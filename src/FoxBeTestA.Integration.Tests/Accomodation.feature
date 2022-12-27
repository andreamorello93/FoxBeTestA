Feature: Accomodation

CRUD Operations for accomodation entity

@Accomodation
Scenario: Get All Accomodation
	Given the Accomodation entities
	| Name    | BaseRoomPrice  |
	| Hotel 1 | 50.00		   |
	| Hotel 2 | 80.00          |
	| Hotel 3 | 75.00          |
	| Hotel 4 | 20.00          |
	| Hotel 5 | 500.00         |
	And the POST http request to 'api/accomodation' for all entities
	When perfom the GET http request to 'api/accomodation' for Accomodation
	Then I should recieve 5 json nodes for Accomodation
	And response nodes should be equal to Accomodation
	| Name    | BaseRoomPrice  |
	| Hotel 1 | 50.00		   |
	| Hotel 2 | 80.00          |
	| Hotel 3 | 75.00          |
	| Hotel 4 | 20.00          |
	| Hotel 5 | 500.00         |

@Accomodation
Scenario: Get Accomodation
	Given the Accomodation entity
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |
	And the POST http request to 'api/accomodation' for Accomodation
	When perfom the GET http request to 'api/accomodation/{id}' with the inserted id	
	Then response node should be equal to
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |	

@Accomodation
Scenario: Insert Accomodation
	Given the Accomodation entity
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |
	And the POST http request to 'api/accomodation' for Accomodation
	When perfom the GET http request to 'api/accomodation' for Accomodation
	Then I should recieve 1 json nodes for Accomodation
	And response nodes should be equal to Accomodation
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |

@Accomodation
Scenario: Update Accomodation
	Given the Accomodation entity
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |
	And the POST http request to 'api/accomodation' for Accomodation
	And the PUT http request to 'api/accomodation/{id}' with the inserted id and the new entity Accomodation
	| Name    | BaseRoomPrice |
	| Hotel 5 | 87.00         |
	When perfom the GET http request to 'api/accomodation' for Accomodation
	Then I should recieve 1 json nodes for Accomodation
	And response nodes should be equal to Accomodation
	| Name    | BaseRoomPrice |
	| Hotel 5 | 87.00         |

@Accomodation
Scenario: Delete Accomodation
	Given the Accomodation entity
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50.00         |
	And the POST http request to 'api/accomodation' for Accomodation
	And the DELETE http request to 'api/accomodation/{id}' for Accomodation
	When perfom the GET http request to 'api/accomodation' for Accomodation
	Then I should recieve 0 json nodes for Accomodation
