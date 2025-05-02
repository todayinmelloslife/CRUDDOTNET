using Dog.Data;
using Dogs.Models; 
using Microsoft.EntityFrameworkCore;

public static class DogRouteClass
{
    // Este método define as rotas para o aplicativo.
    public static void DogRoute(this WebApplication app)
    {
        // Define rotas para operações CRUD de cachorros.
        var route = app.MapGroup(prefix: "Dogs");
          
        // Rota POST: Adiciona um cachorro.
        route.MapPost(pattern: "",
          async (DogResquest req, DogContext context) =>
        {
            var dog = new DogModel(req.Name);
            await context.AddAsync(dog);
            await context.SaveChangesAsync();
        });

        // Rota GET: Lista todos os cachorros.
        route.MapGet(pattern: "", async (DogContext context) =>
        {
            var dogs = await context.Dogs.ToListAsync();
            return Results.Ok(dogs);
        });
      
        // Rota PUT: Atualiza o nome de um cachorro.
        route.MapPut("{id:guid}",
         async(Guid id, DogResquest req, DogContext context) => 
        {
            var dog = await context.Dogs.FindAsync(id);
            if (dog is null) return Results.NotFound();
         
            dog.ChangeName(req.Name);
            await context.SaveChangesAsync();
            return Results.Ok(dog);
         });
         
        // Rota DELETE: Remove um cachorro.
        route.MapDelete("{id:guid}",
         async(Guid id, DogContext context) => 
        {
            var dog = await context.Dogs.FindAsync(id);
            if (dog is null) return Results.NotFound();
            context.Remove(dog);
            await context.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}