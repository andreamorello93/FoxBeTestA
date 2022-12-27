Feature: Accomodation

CRUD Operations for accomodation entity

@Accomodation
Scenario: Get All Accomodation
	Given the Accomodation entities
	| Name    |
	| Hotel 1 |
	| Hotel 2 |
	| Hotel 3 |
	| Hotel 4 |
	| Hotel 5 |
	And the POST http request to 'api/accomodation' for all entities
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 5 json nodes	
	And response nodes should be equal to
	| Name    |
	| Hotel 1 |
	| Hotel 2 |
	| Hotel 3 |
	| Hotel 4 |
	| Hotel 5 |

@Accomodation
Scenario: Get Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |	
	And the POST http request to 'api/accomodation'
	When perfom the GET http request to 'api/accomodation/{id}' with the inserted id	
	Then response node should be equal to
	| Name    |
	| Hotel 1 |	

@Accomodation
Scenario: Insert Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 1 json nodes	
	And response nodes should be equal to
	| Name    |
	| Hotel 1 |

@Accomodation
Scenario: Update Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'	
	And the PUT http request to 'api/accomodation/{id}' with the inserted id and the new entity
	| Name    |
	| Hotel 5 |
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 1 json nodes	
	And response nodes should be equal to
	| Name    |
	| Hotel 5 |

@Accomodation
Scenario: Delete Accomodation
	Given the Accomodation entity
	| Name    |
	| Hotel 1 |
	And the POST http request to 'api/accomodation'	
	And the DELETE http request to 'api/accomodation/{id}'
	When perfom the GET http request to 'api/accomodation'
	Then I should recieve 0 json nodes		
