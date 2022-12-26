using FoxBeTestA.DAL.Data;
using Microsoft.EntityFrameworkCore;

public static class RegisterStartupMiddlewares
{
    public static WebApplication SetupMiddlewares(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();

        return app;
    }
}

