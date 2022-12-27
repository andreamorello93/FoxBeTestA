using System;
using System.Net.Mime;
using System.Text;
using FluentAssertions;
using FoxBeTestA.DAL.Models;
using FoxBeTestA.Integration.Tests.Helpers;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace FoxBeTestA.Integration.Tests
{
    [Binding]
    public class PriceListStepDefinitions
    {
        private StepDefinitionHelper _stepDefinitionHelper;
        private FoxBeTestAApiHelper _foxBeTestAApiHelper;
        private JToken _accomodationEntity;
        private JToken _roomTypeEntity;
        private JToken _priceListEntity;
        private int _insertedaccomodationId;
        private List<int> _insertedPriceListIds;
        private List<int> _insertedRoomTypeIds;

        [BeforeScenario("PriceList")]
        public async Task BeforeScenario()
        {
            _stepDefinitionHelper = new StepDefinitionHelper();
            _foxBeTestAApiHelper = new FoxBeTestAApiHelper();

            _insertedRoomTypeIds = new List<int>();
            _insertedPriceListIds = new List<int>();
        }

        [AfterScenario("PriceList")]
        public async Task AfterScenario()
        {
            await _stepDefinitionHelper.ExecuteNonQuery("DELETE Accomodations DELETE RoomTypes DELETE PriceList", _foxBeTestAApiHelper.ConnectionString);
        }

        [Given(@"the Accomodation entity for PriceList")]
        public void GivenTheAccomodationEntityForPriceList(Table table)
        {
            _accomodationEntity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
        }

        [Given(@"the POST Accomodation http request to '([^']*)' for PriceList")]
        public async Task GivenThePOSTAccomodationHttpRequestToForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_accomodationEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedaccomodationId = (int)_stepDefinitionHelper.ApiResponse;
        }

        [Given(@"the Room Type entities for PriceList")]
        public void GivenTheRoomTypeEntitiesForPriceList(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, false, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
        }

        [Given(@"the POST http request to '([^']*)' for all RoomType entities for PriceList")]
        public async Task GivenThePOSTHttpRequestToForAllRoomTypeEntitiesForPriceList(string p0)
        {
            foreach (var entity in _roomTypeEntity)
            {
                await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0,
                    new StringContent(entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
                _insertedRoomTypeIds.Add((int)_stepDefinitionHelper.ApiResponse);
            }
        }

        [Given(@"And the PriceList entities")]
        public void GivenAndThePriceListEntities(Table table)
        {
            ReplaceRoomTypesIdInTable(table);

            _priceListEntity = _stepDefinitionHelper.ToJToken<PriceList>(table, false );
        }

        [Given(@"the POST http request to '([^']*)' for all PriceList entities for PriceList")]
        public async Task GivenThePOSTHttpRequestToForAllPriceListEntitiesForPriceList(string p0)
        {
            foreach (var entity in _priceListEntity)
                await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [When(@"perfom the GET http request to '([^']*)' for PriceList")]
        public async Task WhenPerfomTheGETHttpRequestToForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0);
        }

        [Then(@"I should recieve (.*) json nodes for PriceList")]
        public void ThenIShouldRecieveJsonNodesForPriceList(int p0)
        {
            _stepDefinitionHelper.CountApiResponseDtos(p0);
        }

        [Then(@"response nodes should be equal to PriceList")]
        public void ThenResponseNodesShouldBeEqualToPriceList(Table table)
        {
            ReplaceRoomTypesIdInTable(table);

            _priceListEntity = _stepDefinitionHelper.ToJToken<PriceList>(table, false);
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "[*].id");
            _stepDefinitionHelper.ApiResponse.ToString().Should().Be(_priceListEntity.ToString());
        }

        [Given(@"the RoomType entity for PriceList")]
        public void GivenTheRoomTypeEntityForPriceList(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, true, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
        }

        [Given(@"the POST http request Room Type to '([^']*)' for PriceList")]
        public async Task GivenThePOSTHttpRequestRoomTypeToForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_roomTypeEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedRoomTypeIds.Add((int)_stepDefinitionHelper.ApiResponse);
        }

        [Given(@"And the PriceList entity")]
        public void GivenAndThePriceListEntity(Table table)
        {
            _priceListEntity = _stepDefinitionHelper.ToJToken<PriceList>(table, true, new Dictionary<string, object>() { { "{RoomTypeId}", _insertedRoomTypeIds.First() } });
        }

        [Given(@"the POST http request to '([^']*)' for PriceList")]
        public async Task GivenThePOSTHttpRequestToForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_priceListEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedPriceListIds.Add((int)_stepDefinitionHelper.ApiResponse);
        }


        [When(@"perfom the GET http request to '([^']*)' with the inserted id for PriceList")]
        public async Task WhenPerfomTheGETHttpRequestToWithTheInsertedIdForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedPriceListIds.First().ToString()));
        }

        [Then(@"response node should be equal to PriceList")]
        public void ThenResponseNodeShouldBeEqualToPriceList(Table table)
        {
            _priceListEntity = _stepDefinitionHelper.ToJToken<PriceList>(table, true, new Dictionary<string, object>() { { "{RoomTypeId}", _insertedRoomTypeIds.First() } });
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "id");
            _stepDefinitionHelper.ApiResponse.ToString().Should().Be(_priceListEntity.ToString());
        }

        [Given(@"the PUT http request to '([^']*)' with the inserted id and the new entity PriceList")]
        public async Task GivenThePUTHttpRequestToWithTheInsertedIdAndTheNewEntityPriceList(string p0, Table table)
        {
            _priceListEntity = _stepDefinitionHelper.ToJToken<PriceList>(table, true, new Dictionary<string, object>() { { "{RoomTypeId}", _insertedRoomTypeIds.First() } });
            _stepDefinitionHelper.AddJTokenValue(_priceListEntity, "id", _insertedPriceListIds.First());

            await _stepDefinitionHelper.SendPutRequest(_foxBeTestAApiHelper.Client,
                p0.Replace("{id}", _insertedPriceListIds.First().ToString()), new StringContent(_priceListEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [Given(@"the DELETE http request to '([^']*)' for PriceList")]
        public async Task GivenTheDELETEHttpRequestToForPriceList(string p0)
        {
            await _stepDefinitionHelper.SendDeleteRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedPriceListIds.First().ToString()));
        }

        private void ReplaceRoomTypesIdInTable(Table table)
        {
            int index = 0;
            foreach (var row in table.Rows)
            foreach (var key in row.Keys)
                if (row[key] == $"{{RoomTypeId{index + 1}}}")
                {
                    row[key] = _insertedRoomTypeIds[index].ToString();
                    index++;
                }
        }

    }
}
