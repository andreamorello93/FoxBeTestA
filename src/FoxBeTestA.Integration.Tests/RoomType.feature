Feature: Room Type

CRUD Operations for Room Type entity

@RoomType
Scenario: Get All Room Type
	Given the Accomodation entity for RoomType
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the Room Type entities
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	| Double      | {AccomodationId} | 50                           |
	| Deluxe      | {AccomodationId} | 70                           |
	| Suite       | {AccomodationId} | 100                          |
	And the POST http request to 'api/roomtype' for all entities for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 4 json nodes for RoomType
	And response nodes should be equal to RoomType
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	| Double      | {AccomodationId} | 50                           |
	| Deluxe      | {AccomodationId} | 70                           |
	| Suite       | {AccomodationId} | 100                          |

@RoomType
Scenario: Get Room Type
	Given the Accomodation entity for RoomType
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request to 'api/roomtype' for RoomType
	When perfom the GET http request to 'api/roomtype/{id}' with the inserted id for RoomType
	Then response node should be equal to RoomType
	| Description | AccomodationId   | ExtraPercentageFromBasePrice | 
	| Single      | {AccomodationId} | 0                            |

@RoomType
Scenario: Insert Room Type
    Given the Accomodation entity for RoomType
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request to 'api/roomtype' for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 1 json nodes for RoomType
	And response nodes should be equal to RoomType
	| Description | AccomodationId   | ExtraPercentageFromBasePrice | 
	| Single      | {AccomodationId} | 0                            |

@RoomType
Scenario: Update Room Type
	Given the Accomodation entity for RoomType
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request to 'api/roomtype' for RoomType
	And the PUT http request to 'api/roomtype/{id}' with the inserted id and the new entity RoomType
	| Description	 | AccomodationId   | ExtraPercentageFromBasePrice | 
	| NewDescription | {AccomodationId} | 20                           |
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 1 json nodes for RoomType
	And response nodes should be equal to RoomType	
	| Description		| AccomodationId   | ExtraPercentageFromBasePrice | 
	| NewDescription    | {AccomodationId} | 20                           |

@RoomType
Scenario: Delete Room Type
	Given the Accomodation entity for RoomType
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for RoomType
	And the RoomType entity
	| Description | AccomodationId   |
	| Single      | {AccomodationId} |	
	And the POST http request to 'api/roomtype' for RoomType
	And the DELETE http request to 'api/roomtype/{id}' for RoomType
	When perfom the GET http request to 'api/roomtype' for RoomType
	Then I should recieve 0 json nodes for RoomType
