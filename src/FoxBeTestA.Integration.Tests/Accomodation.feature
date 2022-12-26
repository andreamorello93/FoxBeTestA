Feature: Accomodation

A short summary of the feature

@Accomodation
Scenario: Insert Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 1 json nodes	
