var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddEndpointsApiExplorer(); // Adiciona suporte para explorar os endpoints da API.
builder.Services.AddSwaggerGen(); // Adiciona suporte para gerar a documentação da API com Swagger.

var app = builder.Build(); // Constrói o aplicativo.

if (app.Environment.IsDevelopment()) // Verifica o ambiente
{
    app.UseSwagger(); 
    app.UseSwaggerUI(); 
}

DogRouteClass.DogRoute(app); // Configura as rotas relacionadas aos cães.

app.UseHttpsRedirection();
app.Run(); // Inicia o aplicativo e começa a escutar as requisições.

