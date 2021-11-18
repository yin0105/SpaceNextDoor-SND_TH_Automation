using CloudinaryDotNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace SND_TH.Helpers
{
    public class SlackReporting
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();
        private string urlWithAccessToken;
        protected const string QASlackChannel = "#automated-reporting";

        public SlackReporting(string urlWithAccessToken)
        {
            _uri = new Uri(urlWithAccessToken);
        }


        //html report uploader
        public static string UploadHTMLReport()
        {
            var htmlPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestResults\index.html";
            try
            {
                //cloudinary acc
                Account account = new Account(
                    "spacenextdoor",
                    "699362336961262",
                    "XsNMIZjtkkReu3048qGQnCmkV2g"
                    );
                Cloudinary cloudinary = new Cloudinary(account);

                var uploadResult = cloudinary.Upload("auto", null, new FileDescription(htmlPath));
                Uri uploadURL = uploadResult.Uri;
                if(uploadURL == null)
                {
                    return "Couldn't upload HTML Report";
                }
                return uploadResult.Uri.ToString();
            }
            catch (Exception ex)
            {
                
                return $"Couldn't Upload Html Report+{ex.Message}"; //need to be tested how this works in action.
            }
        }

        public static void SendReportInSlack()
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            SlackReporting reporting = new SlackReporting(urlWithAccessToken);
            reporting.PostMessage(username: "SND Regression Resuls",
                                  text: $"Thai :flag-th: market report generated  {UploadHTMLReport()} :here:",
                                  channel: "automated-reporting"
                                  );
        }

        // Post message using simple strings.
        public void PostMessage(string text, string username = null, string channel = null, string url = null)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            Payload payload = new Payload()
            {
                Channel = channel,
                Username = username,
                Text = text,
            };
            PostMessage(payload);
        }

        public void PostMessage(Payload payload)
        {
            string payLoadJson = JsonConvert.SerializeObject(payload);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            using(WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payLoadJson;
                var response = client.UploadValues(_uri, "POST", data);

                //The response text is usually "OK"
                string responseText = _encoding.GetString(response);
            }
        }

        public void PostMessageBrowser(string text, string username = null, string channel = null)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            Payloadbrowser payloadbrowser = new Payloadbrowser()
            {
                Channel = channel,
                Username = username,
                Text = text
            };
            PostMessageBrowser(payloadbrowser);
        }

        public void PostMessageBrowser(Payloadbrowser payloadbrowser)
        {
            string payloadbrowserJson = JsonConvert.SerializeObject(payloadbrowser);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            using (WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payloadbrowserJson;

                var response = client.UploadValues(_uri, "POST", data);

                string responseText = _encoding.GetString(response);
            }
        }
    }

    public class Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }


    public class Payloadbrowser
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
