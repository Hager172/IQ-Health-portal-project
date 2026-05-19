


using ACMS_ONLINE_APPLICATION;
using ACMS_ONLINE_INFRASTRUCTURE.Data;
using AutoMapper;
using IQHealthPortal.Application.Features.Authentication.Commands.Login;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Application.Interfaces.services;
using IQHealthPortal.Application.mapping;
using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.Claims;
using IQHealthPortal.Infrastructure.Identity.Services;
using IQHealthPortal.Infrastructure.MeddleWare;
using IQHealthPortal.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options => {


    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 2;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;


})
    .AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();


builder.Services.Configure<JWT>(builder.Configuration.GetSection("JwtSetting"));

builder.Services.Configure<ClientConnectionOptions>(builder.Configuration.GetSection("ConnectionStrings"));




builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSetting:Key"])),
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["JwtSetting:Issuer"],
            ValidateAudience = true,
            ValidAudience = builder.Configuration["JwtSetting:Audience"],
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero // Set to zero for immediate expiration check
        };
    });




builder.Services.AddDbContext<IdentityContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("1"));
});


builder.Services.AddAuthorization();
builder.Services.AddHttpContextAccessor();
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped<IDbContextFactory, DbContextFactory>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IClaimService, ClaimService>();
builder.Services.AddScoped<IPageRepository, PageRepository>();
builder.Services.AddScoped<IClaimRepository, ClaimRepository>();


builder.Services.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();
builder.Services.AddScoped<ImemberRepository, MemberRepository>();
//builder.Services.AddScoped<IUserPermissionRepository, UserPermissionRepository>();
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services.AddMediatR(typeof(ApplicationLayer).Assembly);
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(ApplicationLayer).Assembly);
});

//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
});
//builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
builder.Services.AddHttpContextAccessor();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();


// Source - https://stackoverflow.com/a/79835686
// Posted by Nermin, modified by community. See post 'Timeline' for change history
// Retrieved 2026-02-19, License - CC BY-SA 4.0

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

    // Add JWT Authentication to Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});






builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
        //.WithOrigins("http://localhost:4200", "http://150.200.12.4:4200") // adjust based on real deployment        
        .AllowAnyOrigin()
        .AllowAnyHeader()
              .AllowAnyMethod()
              //.AllowCredentials()
              ;
    });
});


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseCors("AllowFrontend");

app.UseAuthentication();


app.UseMiddleware<ClientConnectionMiddleware>();
app.UseAuthorization();

app.MapControllers();



app.Run();
