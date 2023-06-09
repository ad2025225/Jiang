using Autofac.Extensions.DependencyInjection;
using Autofac;
using Jiang.Common.AutoMapper;
using Jiang.Common.Swagger;
using Microsoft.EntityFrameworkCore;
using Jiang.Common.AuthorizationSetup;
using Jiang.Models;
using Jiang.Common.AppSettings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerSetup();//swaggger¿‡
builder.Services.AddSingleton(new Appsettings(builder.Configuration));//appsettings∞Ô÷˙¿‡
builder.Services.AddAuthorizationSetup();

#region EF Core
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration["AppSettings:ConnectionStrings:SqlServer"]);
});
#endregion

#region Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutoFacManager());
});
#endregion


#region ≈‰÷√øÁ”Ú
builder.Services.AddCors(c =>
{
    c.AddPolicy("Cors", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
#endregion
#region
#endregion

var app = builder.Build();

#region Swagger
if (app.Environment.IsDevelopment())
{
     app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/Jiang-V1/swagger.json", "Jiang-V1");
        options.RoutePrefix = string.Empty;
    });
}
#endregion


app.UseCors("Cors");
                  
app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
