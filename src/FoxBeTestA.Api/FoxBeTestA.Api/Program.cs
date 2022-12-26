using FoxBeTestA.DAL.Data;

var application = WebApplication.CreateBuilder(args)
    .RegisterServices().Build();

if (application.Environment.IsDevelopment())
{
    using (var scope = application.Services.CreateScope())
    {
        var foxBeTestAContext = scope.ServiceProvider.GetRequiredService<FoxBeTestAContext>();
        foxBeTestAContext.Database.EnsureCreated();
    }
}

application.SetupMiddlewares().Run();
