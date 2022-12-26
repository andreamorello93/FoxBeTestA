﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using FoxBeTestA.DAL.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace FoxBeTestA.Integration.Tests.Helpers
{
    public class StepDefinitionHelper
    {
        public JToken ApiResponse;

        public StepDefinitionHelper()
        {
            
        }

        public async Task SendPostRequest(HttpClient client, string url, HttpContent content)
        {
            ApiResponse = JToken.Parse(await Post(client, url, content));
        }

        public async Task SendGetRequest(HttpClient client, string url)
        {
            ApiResponse = JToken.Parse(await Get(client, url));
        }

        public void CountApiResponseDtos(int count)
        {
            ApiResponse.Count().Should().Be(count);
        }

        public async Task ExecuteNonQuery(string query, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                await cmd.ExecuteNonQueryAsync();
                conn.Close();
            }
        }

        private async Task<string> Post(HttpClient client, string url, HttpContent content)
        {
            var message = await client.PostAsync(url, content);

            var response = await message.Content.ReadAsStringAsync();

            try { message.StatusCode.Should().Be(HttpStatusCode.OK); } catch (Exception exc) { throw new Exception(response, exc); }

            return response;
        }

        private async Task<string> Get(HttpClient client, string url)
        {
            var message = await client.GetAsync(url);

            var response = await message.Content.ReadAsStringAsync();

            try { message.StatusCode.Should().Be(HttpStatusCode.OK); } catch (Exception exc) { throw new Exception(response, exc); }

            return response;
        }

        private async Task<T> Get<T>(HttpClient client, string url)
        {
            var response = await Get(client, url);

            return DeserializeApiResult<T>(response);
        }

        private async Task<T> Post<T>(HttpClient client, string url, HttpContent content)
        {
            var response = await Post(client, url, content);

            return DeserializeApiResult<T>(response);
        }

        public T DeserializeApiResult<T>(string response)
        {
            return JsonSerializer.Deserialize<T>(response, GetJsonSerializerOptions())!;
        }

        public string SerializeApiResult(object data)
        {
            return JsonSerializer.Serialize(data, GetJsonSerializerOptions())!;
        }

        private JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        }

        public JToken ToJToken<T>(Table table, bool isSingleRow)
        {
            var items = new List<string>();

            foreach (var tableRow in table.Rows)
            {
                var rows = (IDictionary<string, string>)tableRow;

                var properties = new List<string>();
                foreach (var row in rows)
                {
                    var property = typeof(T).GetProperty(row.Key);
                    properties.Add($"\"{ToLowerFirstChar(row.Key)}\": {AddDoubleQuotesIfTypeNeedThem(property.PropertyType, row.Value)}");
                }

                items.Add($"{{{string.Join(",", properties)}}}");
            }

            var list = string.Join(",", items);
            return isSingleRow ? JToken.Parse($"{list}") : JToken.Parse($"[{list}]");
        }

        private static string ToLowerFirstChar(string input)
        {
            return char.ToLower(input[0]) + input[1..];
        }

        private static string? AddDoubleQuotesIfTypeNeedThem(Type type, object value)
        {
            return
                type == typeof(string) || type == typeof(DateTime) || type == typeof(DateTimeOffset)
                    ? $"\"{value}\""
                    : value.ToString();
        }
    }
}
