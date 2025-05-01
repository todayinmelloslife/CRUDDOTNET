namespace Dogs.Routes;

public static class DogRouteClass
{
    public static void DogRoute(WebApplication app)
    {
        app.MapGet(pattern: "Dogs", () => "Hello dogs."); //mapGet é um método de extensão que adiciona um manipulador de solicitação HTTP GET para o aplicativo
    }
}