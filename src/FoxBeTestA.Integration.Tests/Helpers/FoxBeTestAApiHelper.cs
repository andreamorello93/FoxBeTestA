using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.DAL.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoxBeTestA.Integration.Tests.Helpers
{
    public class FoxBeTestAApiHelper
    {
        public HttpClient Client { get; set; }
        public string ConnectionString { get; set; }

        public FoxBeTestAApiHelper()
        {
            var webApplication = new FoxBeTestAFactory<Program>();

            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            ConnectionString = configuration.GetConnectionString("DefaultConnection");

            Client = webApplication.CreateClient();
        }
    }
}
