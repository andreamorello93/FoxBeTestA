using FoxBeTestA.DAL.Data;

var application = WebApplication.CreateBuilder(args)
    .RegisterServices().Build();

if (application.Environment.IsDevelopment())
{
    using (var scope = application.Services.CreateScope())
    {
        var salesContext = scope.ServiceProvider.GetRequiredService<FoxBeTestAContext>();
        salesContext.Database.EnsureCreated();
    }
}

application.SetupMiddlewares().Run();
