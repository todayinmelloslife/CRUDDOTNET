using Dogs.Models; 

public static class DogRouteClass
{
    public static void DogRoute(this WebApplication app)
    {
        app.MapGet(pattern: "Dogs", () => new DogModel(name: "duda"));
    }
}