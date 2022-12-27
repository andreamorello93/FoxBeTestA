Feature: Price List

CRUD Operations for Price List entity

@PriceList
Scenario: Get All Price List
	Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the Room Type entities for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	| Double      | {AccomodationId} | 50                           |
	| Deluxe      | {AccomodationId} | 70                           |
	| Suite       | {AccomodationId} | 100                          |
	And the POST http request to 'api/roomtype' for all RoomType entities for PriceList
	And And the PriceList entities
	| Date			 | RoomTypeId			 | Price |
	| 2022-12-27     | {RoomTypeId1}         | 0     |
	| 2022-12-27     | {RoomTypeId2}	     | 0     |
	| 2022-12-27     | {RoomTypeId3}         | 0     |
	| 2022-12-27     | {RoomTypeId4}         | 0     |
	And the POST http request to 'api/pricelist' for all PriceList entities for PriceList
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 4 json nodes for PriceList
	And response nodes should be equal to PriceList
	| Date			          | RoomTypeId			  | Price   |
	| 2022-12-27T00:00:00     | {RoomTypeId1}         | 50.0    |
	| 2022-12-27T00:00:00     | {RoomTypeId2}         | 75.0    |
	| 2022-12-27T00:00:00     | {RoomTypeId3}         | 85.0    |
	| 2022-12-27T00:00:00     | {RoomTypeId4}         | 100.0   |

@PriceList
Scenario: Get Price List
	Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId		| Price |
	| 2022-12-27     | {RoomTypeId}     | 0     |
	And the POST http request to 'api/pricelist' for PriceList
	When perfom the GET http request to 'api/pricelist/{id}' with the inserted id for PriceList
	Then response node should be equal to PriceList
	| Date					 | RoomTypeId			| Price    |
	| 2022-12-27T00:00:00    | {RoomTypeId}         | 50.0     |

@PriceList
Scenario: Insert Price List
    Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId			| Price |
	| 2022-12-27     | {RoomTypeId}         | 0     |
	And the POST http request to 'api/pricelist' for PriceList
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 1 json nodes for PriceList
	And response nodes should be equal to PriceList
	| Date			       	  | RoomTypeId			  | Price    |
	| 2022-12-27T00:00:00     | {RoomTypeId1}         | 50.0     |

@PriceList
Scenario: Update Price List
	Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId			| Price |
	| 2022-12-27     | {RoomTypeId}         | 0     |
	And the POST http request to 'api/pricelist' for PriceList
	And the PUT http request to 'api/pricelist/{id}' with the inserted id and the new entity PriceList
	| Date			 | RoomTypeId    | Price                        | 
	| 2022-12-28     | {RoomTypeId}  | 20                           |
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 1 json nodes for PriceList
	And response nodes should be equal to PriceList	
	| Date				  | RoomTypeId     | Price         | 
	| 2022-12-28T00:00:00 | {RoomTypeId1}  | 20.0          |

@PriceList
Scenario: Delete Price List
	Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 50            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 0                            |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId			| Price |
	| 2022-12-27     | {RoomTypeId}         | 0     |
	And the POST http request to 'api/pricelist' for PriceList
	And the DELETE http request to 'api/pricelist/{id}' for PriceList
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 0 json nodes for PriceList

@PriceList
Scenario: Insert Price List With 85% plus on base price 20
    Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 20            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 85                           |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId			| Price |
	| 2022-12-27     | {RoomTypeId}         | 0     |
	And the POST http request to 'api/pricelist' for PriceList
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 1 json nodes for PriceList
	And response nodes should be equal to PriceList
	| Date			       	  | RoomTypeId			  | Price    |
	| 2022-12-27T00:00:00     | {RoomTypeId1}         | 37.0     |

@PriceList
Scenario: Insert Price List With 85% plus on base price 20 but price inserted. no calculations nedded
    Given the Accomodation entity for PriceList
	| Name    | BaseRoomPrice |
	| Hotel 1 | 20            |
	And the POST Accomodation http request to 'api/accomodation' for PriceList
	And the RoomType entity for PriceList
	| Description | AccomodationId   | ExtraPercentageFromBasePrice |
	| Single      | {AccomodationId} | 85                           |
	And the POST http request Room Type to 'api/roomtype' for PriceList
	And And the PriceList entity
	| Date			 | RoomTypeId			| Price  |
	| 2022-12-27     | {RoomTypeId}         | 10     |
	And the POST http request to 'api/pricelist' for PriceList
	When perfom the GET http request to 'api/pricelist' for PriceList
	Then I should recieve 1 json nodes for PriceList
	And response nodes should be equal to PriceList
	| Date			       	  | RoomTypeId			  | Price    |
	| 2022-12-27T00:00:00     | {RoomTypeId1}         | 10.0     |
