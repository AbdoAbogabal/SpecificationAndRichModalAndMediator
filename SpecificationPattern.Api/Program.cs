var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString).EnableDetailedErrors());
builder.Services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));




builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllHandler<>).Assembly));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using IServiceScope scope = app.Services.CreateScope();
ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
dbContext.Database.Migrate();

app.UseMiddleware<ExceptionHandler>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
