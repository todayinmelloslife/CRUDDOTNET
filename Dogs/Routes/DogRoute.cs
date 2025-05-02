using Dog.Data;
using Dogs.Models; 

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
    }
}