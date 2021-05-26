@Regression
@Search
Feature: Search
	Verify the posibility to search information in the internet from login page

@Smoke
Scenario: 1. Verify Search from the passed search query text
	Given I have Автоматизація as search query text
	When I searching
	Then I see 'Найдено результатов' search results