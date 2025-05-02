using Dog.Data;
using Dogs.Models; 
using Microsoft.EntityFrameworkCore;

public static class DogRouteClass
{
    public static void DogRoute(this WebApplication app)
    {
        var route = app.MapGroup(prefix: "Dogs");
          
        route.MapPost(pattern: "",
          async (DogResquest req, DogContext context) =>
        {
            var dog = new DogModel(req.Name);
            await context.AddAsync(dog);
            await context.SaveChangesAsync();
        });

        route.MapGet(pattern: "", async (DogContext context) =>
        {
            var dogs = await context.Dogs.ToListAsync();
            return Results.Ok(dogs);
        });
      
        route.MapPut("{id:guid}",
         async(Guid id, DogResquest req, DogContext context) => 
        {
            var dog = await context.Dogs.FindAsync(id);
            if (dog is null) return Results.NotFound();
         
         dog.ChangeName(req.Name);
            await context.SaveChangesAsync();
            return Results.Ok(dog);
          
         });


    }
}