using System;
using System.Net.Mime;
using System.Text;
using FluentAssertions.Json;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Features.AccomodationFeatures.Commands;
using FoxBeTestA.DAL.Models;
using FoxBeTestA.Integration.Tests.Helpers;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace FoxBeTestA.Integration.Tests
{
    [Binding]
    public class AccomodationStepDefinitions
    {
        private StepDefinitionHelper _stepDefinitionHelper;
        private FoxBeTestAApiHelper _foxBeTestAApiHelper;
        private JToken _entity;
        private int _insertedId;

        [BeforeScenario("Accomodation")]
        public async Task BeforeScenario()
        {
            _stepDefinitionHelper = new StepDefinitionHelper();
            _foxBeTestAApiHelper = new FoxBeTestAApiHelper();
        }

        [AfterScenario("Accomodation")]
        public async Task AfterScenario()
        {
            await _stepDefinitionHelper.ExecuteNonQuery("DELETE Accomodations", _foxBeTestAApiHelper.ConnectionString);
        }

        [Given(@"the Accomodation entity")]
        public void GivenTheAccomodationEntity(Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
        }

        [Given(@"the POST http request to '([^']*)' for Accomodation")]
        public async Task GivenThePOSTHttpRequestTo(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedId = (int)_stepDefinitionHelper.ApiResponse;
        }

        [When(@"perfom the GET http request to '([^']*)' for Accomodation")]
        public async Task WhenPerfomTheGETHttpRequestTo(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0);
        }

        [Then(@"I should recieve (.*) json nodes for Accomodation")]
        public void ThenIShoulRecieveJsonNodes(int p0)
        {
            _stepDefinitionHelper.CountApiResponseDtos(p0);
        }

        [Given(@"the PUT http request to '([^']*)' with the inserted id and the new entity Accomodation")]
        public async Task GivenThePUTHttpRequestToWithTheNewEntity(string p0, Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
            _stepDefinitionHelper.AddJTokenValue(_entity, "id", _insertedId);
            await _stepDefinitionHelper.SendPutRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedId.ToString()), new StringContent(_entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [Then(@"response nodes should be equal to Accomodation")]
        public void ThenFirstJsonNodeShouldBeEqualTo(Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, false);
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "[*].id");
            _stepDefinitionHelper.ApiResponse.Should().BeEquivalentTo(_entity);
        }

        [Given(@"the DELETE http request to '([^']*)' for Accomodation")]
        public async Task GivenTheDELETEHttpRequestTo(string p0)
        {
            await _stepDefinitionHelper.SendDeleteRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedId.ToString()));
        }

        [Given(@"the Accomodation entities")]
        public void GivenTheAccomodationEntities(Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, false);
        }

        [Given(@"the POST http request to '([^']*)' for all entities")]
        public async Task GivenThePOSTHttpRequestToForAllEntities(string p0)
        {
            foreach (var entity in _entity)
                await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [When(@"perfom the GET http request to '([^']*)' with the inserted id")]
        public async Task WhenPerfomTheGETHttpRequestToWithTheInsertedId(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedId.ToString()));
        }

        [Then(@"response node should be equal to")]
        public void ThenResponseNodeShouldBeEqualTo(Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
            _stepDefinitionHelper.RemoveJTokenValues(_stepDefinitionHelper.ApiResponse, "id");
            _stepDefinitionHelper.ApiResponse.Should().BeEquivalentTo(_entity);
        }

    }
}
