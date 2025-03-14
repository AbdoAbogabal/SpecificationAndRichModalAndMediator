var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication()
                .AddCookie(IdentityConstants.ApplicationScheme)
                .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddApiEndpoints();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
builder.Services.AddDbContext<ApplicationDbContext>(e => e.UseSqlServer(connectionString, e => e.MigrationsAssembly("SpecificationPattern.Infrastructure").EnableRetryOnFailure())
                                                        .EnableDetailedErrors()
                                                        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


builder.Services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllHandler<>).Assembly));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

ExtenstionMethods.UpdateDataBase(app);

app.UseMiddleware<ExceptionHandler>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapIdentityApi<User>();

app.Run();

