using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace FoxBeTestA.Integration.Tests.Helpers
{
    public class FoxBeTestAFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        public FoxBeTestAFactory()
        {

        }

    }
}
