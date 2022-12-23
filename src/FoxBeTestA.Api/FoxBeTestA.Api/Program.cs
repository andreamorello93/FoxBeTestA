WebApplication.CreateBuilder(args)
    .RegisterServices().Build()
    .SetupMiddlewares().Run();
