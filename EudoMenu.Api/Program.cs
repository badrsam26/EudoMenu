using EudoMenu.Persistence;
using PostLand.Application;
using Swashbuckle.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddPersistenceServices(builder.Configuration); //Injection des services Persistence
builder.Services.AddApplicationServices(); //Injection des services Couche Application: AutoMapper + MediatR
builder.Services.AddControllers();

// Personnalisation Swagger pour la documentation de l'API
builder.Services.AddSwaggerGen(c =>
{
    var filePath = Path.Combine(System.AppContext.BaseDirectory, "EudoMenu.Api.xml");
    c.IncludeXmlComments(filePath);
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "MenuRestaurants API",
        Version = "v1",
        Description = "API pour la gestion des menus pour restaurants ",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Badr BENAHSINA",
            Email = "badr.benahsina@gmail.com",
        }
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
}
app.UseSwaggerUI(options =>{
                                options.DefaultModelsExpandDepth(-1);
                            });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
