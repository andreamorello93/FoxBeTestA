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
    public class RoomTypeStepDefinitions
    {
        private StepDefinitionHelper _stepDefinitionHelper;
        private FoxBeTestAApiHelper _foxBeTestAApiHelper;
        private JToken _accomodationEntity;
        private JToken _roomTypeEntity;
        private int _insertedaccomodationId;
        private int _insertedRoomTypeId;

        [BeforeScenario("RoomType")]
        public async Task BeforeScenario()
        {
            _stepDefinitionHelper = new StepDefinitionHelper();
            _foxBeTestAApiHelper = new FoxBeTestAApiHelper();
        }

        [AfterScenario("RoomType")]
        public async Task AfterScenario()
        {
            await _stepDefinitionHelper.ExecuteNonQuery("DELETE RoomTypes DELETE Accomodations", _foxBeTestAApiHelper.ConnectionString);
        }

        [Given(@"the Accomodation entity for RoomType")]
        public void GivenTheAccomodationEntityForRoomType(Table table)
        {
            _accomodationEntity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
        }

        [Given(@"the POST Accomodation http request to '([^']*)' for RoomType")]
        public async Task GivenThePOSTAccomodationHttpRequestToForRoomType(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_accomodationEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedaccomodationId = (int)_stepDefinitionHelper.ApiResponse;
        }

        [Given(@"the POST http request to '([^']*)' for RoomType")]
        public async Task GivenThePOSTHttpRequestToForRoomType(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_roomTypeEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedRoomTypeId = (int)_stepDefinitionHelper.ApiResponse;
        }

        [Given(@"the Room Type entities")]
        public void GivenTheRoomTypeEntities(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, false, new Dictionary<string, object>(){{ "{AccomodationId}", _insertedaccomodationId } });
        }

        [Given(@"the POST http request to '([^']*)' for all entities for RoomType")]
        public async Task GivenThePOSTHttpRequestToForAllEntitiesForRoomType(string p0)
        {
            foreach (var entity in _roomTypeEntity)
                await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [When(@"perfom the GET http request to '([^']*)' for RoomType")]
        public async Task WhenPerfomTheGETHttpRequestToForRoomType(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0);
        }

        [Then(@"I should recieve (.*) json nodes for RoomType")]
        public void ThenIShouldRecieveJsonNodesForRoomType(int p0)
        {
            _stepDefinitionHelper.CountApiResponseDtos(p0);
        }

        [Then(@"response nodes should be equal to RoomType")]
        public void ThenResponseNodesShouldBeEqualToRoomType(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, false, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "[*].id");
            _stepDefinitionHelper.ApiResponse.Should().BeEquivalentTo(_roomTypeEntity);
        }

        [Given(@"the RoomType entity")]
        public void GivenTheRoomTypeEntity(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, true, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
        }

        [When(@"perfom the GET http request to '([^']*)' with the inserted id for RoomType")]
        public async Task WhenPerfomTheGETHttpRequestToWithTheInsertedIdForRoomType(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedRoomTypeId.ToString()));
        }

        [Then(@"response node should be equal to RoomType")]
        public void ThenResponseNodeShouldBeEqualToRoomType(Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, true, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "id");
            _stepDefinitionHelper.ApiResponse.Should().BeEquivalentTo(_roomTypeEntity);
        }

        [Given(@"the PUT http request to '([^']*)' with the inserted id and the new entity")]
        public void GivenThePUTHttpRequestToWithTheInsertedIdAndTheNewEntity(string p0, Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"the DELETE http request to '([^']*)' for RoomType")]
        public async Task GivenTheDELETEHttpRequestToForRoomType(string p0)
        {
            await _stepDefinitionHelper.SendDeleteRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedRoomTypeId.ToString()));
        }

        [Given(@"the PUT http request to '([^']*)' with the inserted id and the new entity RoomType")]
        public async Task GivenThePUTHttpRequestToWithTheInsertedIdAndTheNewEntityRoomType(string p0, Table table)
        {
            _roomTypeEntity = _stepDefinitionHelper.ToJToken<RoomType>(table, true, new Dictionary<string, object>() { { "{AccomodationId}", _insertedaccomodationId } });
            _stepDefinitionHelper.AddJTokenValue(_roomTypeEntity, "id", _insertedRoomTypeId);

            await _stepDefinitionHelper.SendPutRequest(_foxBeTestAApiHelper.Client,
                p0.Replace("{id}", _insertedRoomTypeId.ToString()), new StringContent(_roomTypeEntity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

    }
}
