Feature: Google

Scenario Outline: Can find search results
  Given I am on the google page for <profile> and <environment>
  When I search for "TestingBot"
  Then I should see title "TestingBot - Google Search"
  
  Examples:
    | profile | environment |
    | single    | chrome      |e result should be 120