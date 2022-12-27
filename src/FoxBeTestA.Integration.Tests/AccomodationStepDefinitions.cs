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

        [Given(@"the POST http request to '([^']*)'")]
        public async Task GivenThePOSTHttpRequestTo(string p0)
        {
            await _stepDefinitionHelper.SendPostRequest(_foxBeTestAApiHelper.Client, p0, new StringContent(_entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
            _insertedId = (int)_stepDefinitionHelper.ApiResponse;
        }

        [When(@"perfom the GET http request to '([^']*)'")]
        public async Task WhenPerfomTheGETHttpRequestTo(string p0)
        {
            await _stepDefinitionHelper.SendGetRequest(_foxBeTestAApiHelper.Client, p0);
        }

        [Then(@"I should recieve (.*) json nodes")]
        public void ThenIShoulRecieveJsonNodes(int p0)
        {
            _stepDefinitionHelper.CountApiResponseDtos(p0);
        }

        [Given(@"the PUT http request to '([^']*)' with the new entity")]
        public async Task GivenThePUTHttpRequestToWithTheNewEntity(string p0, Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, true);
            _stepDefinitionHelper.AddJTokenValue(_entity, "id", _insertedId);
            await _stepDefinitionHelper.SendPutRequest(_foxBeTestAApiHelper.Client, p0.Replace("{id}", _insertedId.ToString()), new StringContent(_entity.ToString(), Encoding.UTF8, MediaTypeNames.Application.Json));
        }

        [Then(@"first json node should be equal to")]
        public void ThenFirstJsonNodeShouldBeEqualTo(Table table)
        {
            _entity = _stepDefinitionHelper.ToJToken<Accomodation>(table, false);
            _stepDefinitionHelper.RemoveJTokenValue(_stepDefinitionHelper.ApiResponse, "[*].id");
            _stepDefinitionHelper.ApiResponse.Should().BeEquivalentTo(_entity);
        }

    }
}
