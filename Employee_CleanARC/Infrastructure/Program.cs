using Application.Handlers.CommandHandlers;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDb"));
});
builder.Services.AddMediatR(typeof(CreateEmployeeHandler).GetTypeInfo().Assembly);
WebApplication? app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee.API v1"));
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});



app.UseHttpsRedirection();

#pragma warning disable ASP0001 // Authorization middleware is incorrectly configured
app.UseAuthorization();
#pragma warning restore ASP0001 // Authorization middleware is incorrectly configured

app.MapControllers();

app.Run();
