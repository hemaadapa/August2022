Feature: TMFeature

A short summary of the feature

@tag1

Scenario: Create time and material record with valid details
	Given I logged into Turn Up portal successfully
	When I navigate to time and material page
	And  I create new time and material record
	Then The new record should be created successfully
