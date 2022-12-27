Feature: Accomodation

CRUD Operations for accomodation entity

@Accomodation
Scenario: Insert Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 1 json nodes	

@Accomodation
Scenario: Update Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'	
	And the PUT http request to 'api/accomodation/{id}' with the new entity
	| Name    |
	| Hotel 5 |
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 1 json nodes	
	And first json node should be equal to
	| Name    |
	| Hotel 5 |
