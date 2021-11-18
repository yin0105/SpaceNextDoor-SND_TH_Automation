Feature: Booking
	Search and book a storage


Scenario: Book a space 
	Given I navigate on "https://stag-th.spacenextdoor.com/" main page
	And I search "Bangkok" and select it in main search field
	And I Choose "XS" size estimator 
	And I click "First" View All button
	And I click "First" storage unit
	And I click book now button
	And I input following parameters into your details
	| Fullname  | Email          | Phonenumber |
	| lukatest1 | lukatest@g.com | 651234562    |
	And I click reserve unit button
	And I select "Second" insurance plan
	And I click continue button
	And I click continue button
	And I input card number parameters into payment method
	| CardNumber          | MMYY | CVV |
	| 4242 4242 4242 4242 | 7 22 | 123 |
	When I click pay button
	Then The booking confirmation page should be displayed