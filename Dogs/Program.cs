using Dogs.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

DogRouteClass.DogRoute(app); 
app.DogRoute(); //chamando o método de extensão




app.UseHttpsRedirection();
app.Run();
