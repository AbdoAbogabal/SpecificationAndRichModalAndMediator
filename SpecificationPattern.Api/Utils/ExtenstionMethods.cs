namespace SpecificationPattern.Api.Utils;

public static class ExtenstionMethods
{
    public static void UpdateDataBase(WebApplication app)
    {
        IServiceScope scope = app.Services.CreateScope();

        ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        dbContext.Database.Migrate();
    }
}
