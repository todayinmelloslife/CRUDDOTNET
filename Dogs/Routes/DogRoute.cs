namespace Dogs.Routes; 

public static class DogRouteClass // otas relacionadas a "Dogs"
{
    // Este é um método de extensão
    public static void DogRoute(this WebApplication app) // "this" indica que é um método de extensão 
    {
        app.MapGet(pattern: "Dogs", () => "Hello dogs."); 
    }
}