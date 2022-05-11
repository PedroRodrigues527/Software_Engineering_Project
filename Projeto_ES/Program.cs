using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Projeto_ES.Data;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Blazored.SessionStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton(new YouTubeService(new BaseClientService.Initializer()
{
    ApiKey = "AIzaSyC1iWH5NiEltxAAftVDqCFgqhfaWYUOgcI",
    ApplicationName = "APPLICATION_NAME"
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
