Feature: Slider
	Simple calculator for adding two numbers

@mytag @regression
Scenario: Checking if user is able to slide pictures on spaces
	Given I navigate on "https://stag-th.spacenextdoor.com/" main page 
	And I scroll down to features listings
	When I Click all right sliders  "3" times
	Then I click all left sliders "3" times






@mytag @regression
Scenario: Using slider on details page
	Cover photo sliding
	Given I navigate on "https://stag-th.spacenextdoor.com/details/312?address=%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%AF&city_id=2&country_id=3&total_results=5&space_id=null"
	And I disable popup on details page
	And I Click "storage cover" photo
	And I Click "last" thumbnail to slide
	And I Slide right "10" times
	And I Slide left "10" times
	And I Close sliding view popup
	And I Click "storage seconday cover" photo
	And I Close sliding view popup
	And I Click "storage small cover" photo
	And I Slide left "4" times
	And I Slide right "2" times
	And I Click "5th" thumbnail to slide
	And I Close sliding view popup
	Then I Validate if "https://stag-th.spacenextdoor.com/details/312?address=%E0%B8%81%E0%B8%A3%E0%B8%B8%E0%B8%87%E0%B9%80%E0%B8%97%E0%B8%9E%E0%B8%AF&city_id=2&country_id=3&total_results=5&space_id=null" is unchangable after these actions