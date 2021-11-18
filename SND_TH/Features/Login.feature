Feature: Login
	Login functionality 


@regression
Scenario: Sign in and sign out 
Checking login and if sign out confirmation popup is displayed after sign out

	Given I navigate on "https://stag-th.spacenextdoor.com/" main page
	And I log in with hardcoded "87777777" and "222222"
	And I sign out
	And The popup is displayed with "Are you sure you want to Sign Out?"
	And I click "Yes" on popup
	Then I am signed out