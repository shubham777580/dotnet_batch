Feature: pizza_privacy_policy

With this feature, we are going to read the privacy policy

@tag1
Scenario: Read Privacy Policy
	Given I have navigate to pizza website
	When I click on privacy button
	Then Privacy details page shows up
