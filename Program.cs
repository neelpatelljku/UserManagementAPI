using System.Text;
using UserManagementAPI.Data;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var builder = WebApplication.CreateBuilder(args);

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var key = Encoding.ASCII.GetBytes("your_secret_key_here");  // Replace with a strong secret key

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


var appSettings = builder.Configuration.GetSection("AppSettings");
string appName = appSettings["ApplicationName"];
Console.WriteLine($"Starting {appName}...");

using UserManagementAPI.Data;
using Microsoft.EntityFrameworkCore;

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();


var app = builder.Build();
app.UseCors("_myAllowSpecificOrigins");
app.UseAuthentication();
app.UseAuthorization();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
