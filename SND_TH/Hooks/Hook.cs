using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAssistant.Extensions;
using SND_TH.Driver;
using SND_TH.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SND_TH.Hooks
{
    [Binding]
    public sealed class Hook
    {
        [ThreadStatic]
        private static ExtentTest _featureName;
        [ThreadStatic]
        private static ExtentTest _scenario;
        private static ExtentReports _extent;
        private readonly ScenarioContext _scenarioContext;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public Hook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext ?? throw new ArgumentNullException("scenarioContext");
        }

        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterTypeAs<BrowserDriver, IBrowserDriver>();
            // I will implement login functioality for regression tests (hardcode verify need and implement it into testinitializer)
            //TODO: implement logic that has to run before executing each scenarios
            _scenario = _featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title,
                _scenarioContext.ScenarioInfo.Description);
        }

        [BeforeScenario]
        public void DeleteScreenShots(FeatureContext featureContext, TestContext testRunContext)
        {
            var path = Path.Combine(testRunContext.DeploymentDirectory,
                $@"Screenshots\{ featureContext.FeatureInfo.Title}\{_scenarioContext.ScenarioInfo.Title}");
            if (Directory.Exists(path)) Directory.Delete(path, true);
        }

        [AfterScenario]
        public void AfterScenario(IObjectContainer objectContainer)
        {
            objectContainer.Resolve<BrowserDriver>().Current.CloseAndDispose();
            //TODO: implement logic that has to run after executing each scenario
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _featureName = _extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeTestRun]
        public static void ReportInitializer(TestContext testRunContext)
        {
            var htmlReporter = new ExtentHtmlReporter(Path.Combine(testRunContext.DeploymentDirectory, @"TestResults\"));
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }
        [AfterTestRun]
        public static void TearDownReport()
        {
            _extent.Flush();

            SlackReporting.SendReportInSlack();
        }

        [AfterStep]
        public void InsertReportingSteps(BrowserDriver driver, FeatureContext featureContext, TestContext testRunContext)
        {
            //Take Screenshot
            var regex = new Regex(@"[^a-zA-Z0-9 -]");
            
            var path = Path.Combine(testRunContext.DeploymentDirectory,
                @$"Screenshots\{regex.Replace(featureContext.FeatureInfo.Title, string.Empty)}\{regex.Replace(_scenarioContext.ScenarioInfo.Title, string.Empty)}");
            var screenshotName = regex.Replace(_scenarioContext.StepContext.StepInfo.Text, string.Empty);
            var screenshot = driver.Current.TakeScreenshot(screenshotName, path);
            var stepType = _scenarioContext.CurrentScenarioBlock;

            var stepIsPending =
                _scenarioContext.ScenarioExecutionStatus == ScenarioExecutionStatus.StepDefinitionPending;

            var testIsFailed = (_scenarioContext.TestError != null) | _scenarioContext.ContainsKey("CustomTestError");
            var stepErrorMessage = _scenarioContext.TestError?.Message;
            if (_scenarioContext.ContainsKey("CustomTestError"))
                stepErrorMessage +=
                    $"CustomTestError: {Environment.NewLine}{_scenarioContext.Get<string>("CustomTestError")}";

            switch (stepType)
            {
                case ScenarioBlock.Given:
                    if (stepIsPending) //skip
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text)
                            .Skip("Step Definition Pending");
                    else if (testIsFailed)
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text) //fail
                            .Fail(stepErrorMessage)
                            .AddScreenCaptureFromPath(screenshot, screenshotName);
                    else
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text); //success
                    break;

                case ScenarioBlock.When:
                    if (stepIsPending)
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text)
                            .Skip("Step Definition Pending");
                    else if (testIsFailed)
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text)
                            .Fail(stepErrorMessage)
                            .AddScreenCaptureFromPath(screenshot, screenshotName);
                    else
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                    break;


                case ScenarioBlock.Then:
                    if (stepIsPending)
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text)
                            .Skip("Step Definition Pending");
                    else if (testIsFailed)
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text)
                            .Fail(stepErrorMessage)
                            .AddScreenCaptureFromPath(screenshot, screenshotName);
                    else
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                    break;

                default:
                    if (stepIsPending)
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text)
                            .Skip("Step Definition Pending");
                    else if (testIsFailed)
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text)
                            .Fail(stepErrorMessage)
                            .AddScreenCaptureFromPath(screenshot, screenshotName);
                    else
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);

                    break;

            }
        }
    }
}
