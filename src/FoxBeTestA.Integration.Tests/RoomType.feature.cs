﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FoxBeTestA.Integration.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Room Type")]
    public partial class RoomTypeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "RoomType.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Room Type", "CRUD Operations for Room Type entity", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Room Type")]
        [NUnit.Framework.CategoryAttribute("RoomType")]
        public void GetAllRoomType()
        {
            string[] tagsOfScenario = new string[] {
                    "RoomType"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Room Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "BaseRoomPrice"});
                table43.AddRow(new string[] {
                            "Hotel 1",
                            "50"});
#line 7
 testRunner.Given("the Accomodation entity for RoomType", ((string)(null)), table43, "Given ");
#line hidden
#line 10
 testRunner.And("the POST Accomodation http request to \'api/accomodation\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table44.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
                table44.AddRow(new string[] {
                            "Double",
                            "{AccomodationId}",
                            "50"});
                table44.AddRow(new string[] {
                            "Deluxe",
                            "{AccomodationId}",
                            "70"});
                table44.AddRow(new string[] {
                            "Suite",
                            "{AccomodationId}",
                            "100"});
#line 11
 testRunner.And("the Room Type entities", ((string)(null)), table44, "And ");
#line hidden
#line 17
 testRunner.And("the POST http request to \'api/roomtype\' for all entities for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("perfom the GET http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("I should recieve 4 json nodes for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table45.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
                table45.AddRow(new string[] {
                            "Double",
                            "{AccomodationId}",
                            "50"});
                table45.AddRow(new string[] {
                            "Deluxe",
                            "{AccomodationId}",
                            "70"});
                table45.AddRow(new string[] {
                            "Suite",
                            "{AccomodationId}",
                            "100"});
#line 20
 testRunner.And("response nodes should be equal to RoomType", ((string)(null)), table45, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Room Type")]
        [NUnit.Framework.CategoryAttribute("RoomType")]
        public void GetRoomType()
        {
            string[] tagsOfScenario = new string[] {
                    "RoomType"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Room Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "BaseRoomPrice"});
                table46.AddRow(new string[] {
                            "Hotel 1",
                            "50"});
#line 29
 testRunner.Given("the Accomodation entity for RoomType", ((string)(null)), table46, "Given ");
#line hidden
#line 32
 testRunner.And("the POST Accomodation http request to \'api/accomodation\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table47.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
#line 33
 testRunner.And("the RoomType entity", ((string)(null)), table47, "And ");
#line hidden
#line 36
 testRunner.And("the POST http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.When("perfom the GET http request to \'api/roomtype/{id}\' with the inserted id for RoomT" +
                        "ype", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table48.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
#line 38
 testRunner.Then("response node should be equal to RoomType", ((string)(null)), table48, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert Room Type")]
        [NUnit.Framework.CategoryAttribute("RoomType")]
        public void InsertRoomType()
        {
            string[] tagsOfScenario = new string[] {
                    "RoomType"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert Room Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "BaseRoomPrice"});
                table49.AddRow(new string[] {
                            "Hotel 1",
                            "50"});
#line 44
    testRunner.Given("the Accomodation entity for RoomType", ((string)(null)), table49, "Given ");
#line hidden
#line 47
 testRunner.And("the POST Accomodation http request to \'api/accomodation\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table50.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
#line 48
 testRunner.And("the RoomType entity", ((string)(null)), table50, "And ");
#line hidden
#line 51
 testRunner.And("the POST http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.When("perfom the GET http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("I should recieve 1 json nodes for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table51.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
#line 54
 testRunner.And("response nodes should be equal to RoomType", ((string)(null)), table51, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Room Type")]
        [NUnit.Framework.CategoryAttribute("RoomType")]
        public void UpdateRoomType()
        {
            string[] tagsOfScenario = new string[] {
                    "RoomType"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Room Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "BaseRoomPrice"});
                table52.AddRow(new string[] {
                            "Hotel 1",
                            "50"});
#line 60
 testRunner.Given("the Accomodation entity for RoomType", ((string)(null)), table52, "Given ");
#line hidden
#line 63
 testRunner.And("the POST Accomodation http request to \'api/accomodation\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table53.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}",
                            "0"});
#line 64
 testRunner.And("the RoomType entity", ((string)(null)), table53, "And ");
#line hidden
#line 67
 testRunner.And("the POST http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table54.AddRow(new string[] {
                            "NewDescription",
                            "{AccomodationId}",
                            "20"});
#line 68
 testRunner.And("the PUT http request to \'api/roomtype/{id}\' with the inserted id and the new enti" +
                        "ty RoomType", ((string)(null)), table54, "And ");
#line hidden
#line 71
 testRunner.When("perfom the GET http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then("I should recieve 1 json nodes for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId",
                            "ExtraPercentageFromBasePrice"});
                table55.AddRow(new string[] {
                            "NewDescription",
                            "{AccomodationId}",
                            "20"});
#line 73
 testRunner.And("response nodes should be equal to RoomType", ((string)(null)), table55, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Room Type")]
        [NUnit.Framework.CategoryAttribute("RoomType")]
        public void DeleteRoomType()
        {
            string[] tagsOfScenario = new string[] {
                    "RoomType"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Room Type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "BaseRoomPrice"});
                table56.AddRow(new string[] {
                            "Hotel 1",
                            "50"});
#line 79
 testRunner.Given("the Accomodation entity for RoomType", ((string)(null)), table56, "Given ");
#line hidden
#line 82
 testRunner.And("the POST Accomodation http request to \'api/accomodation\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                            "Description",
                            "AccomodationId"});
                table57.AddRow(new string[] {
                            "Single",
                            "{AccomodationId}"});
#line 83
 testRunner.And("the RoomType entity", ((string)(null)), table57, "And ");
#line hidden
#line 86
 testRunner.And("the POST http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("the DELETE http request to \'api/roomtype/{id}\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.When("perfom the GET http request to \'api/roomtype\' for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("I should recieve 0 json nodes for RoomType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
