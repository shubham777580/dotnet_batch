Feature: pizza_buy

A short summary of the feature

@tag7
Scenario: Buying a pizza
	Given navigate to pizzaa website
	When click on buy button of respective pizza
	Then opens up order checkout page
	When click on confirm order button
	Then opens up order confirmed page
