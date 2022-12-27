Feature: Room Type

CRUD Operations for Room Type entity

@RoomType
Scenario: Get All Room Type
	Given the Accomodation entity for RoomType
	| Name			 |
	| Hotel 1		 |	
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the Room Type entities
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |
	| Double      | {AccomodationId} |
	| Deluxe      | {AccomodationId} |
	| Suite       | {AccomodationId} |
	And the POST http request to 'api/roomtype' for all entities for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 4 json nodes for RoomType
	And response nodes should be equal to RoomType
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |
	| Double      | {AccomodationId} |
	| Deluxe      | {AccomodationId} |
	| Suite       | {AccomodationId} |

@RoomType
Scenario: Get Room Type
	Given the Accomodation entity for RoomType
	| Name			 |
	| Hotel 1		 |	
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |	
	And the POST http request to 'api/roomtype' for RoomType
	When perfom the GET http request to 'api/roomtype/{id}' with the inserted id for RoomType
	Then response node should be equal to RoomType
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |	

@RoomType
Scenario: Insert Room Type
    Given the Accomodation entity for RoomType
	| Name           |
	| Hotel 1		 |	
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |
	And the POST http request to 'api/roomtype' for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 1 json nodes for RoomType
	And response nodes should be equal to RoomType
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |

@RoomType
Scenario: Update Room Type
	Given the Accomodation entity for RoomType
	| Name    |
	| Hotel 1 |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |
	And the POST http request to 'api/roomtype' for RoomType
	And the PUT http request to 'api/roomtype/{id}' with the inserted id and the new entity RoomType
	| Description	 | AccomodationId   |
	| NewDescription | {AccomodationId} |
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 1 json nodes for RoomType
	And response nodes should be equal to RoomType
	| Description	 | AccomodationId   |
	| NewDescription | {AccomodationId} |

@RoomType
Scenario: Delete Room Type
	Given the Accomodation entity for RoomType
	| Name			 |
	| Hotel 1		 |	
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |	
	And the POST http request to 'api/roomtype' for RoomType
	And the DELETE http request to 'api/roomtype/{id}' for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 0 json nodes for RoomType
