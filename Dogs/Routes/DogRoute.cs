namespace Dogs.Routes;

public static class DogRouteClass
{
    public static void DogRoute(this WebApplication app) //this é o meu método de extensao
    {
        app.MapGet(pattern: "Dogs", () => "Hello dogs."); 
    }
}