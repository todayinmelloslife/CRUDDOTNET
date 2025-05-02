namespace Dogs.Models
{
    // Representa um cachorro com ID e Nome.
    public class DogModel
    {
        public string Name { get; set; }

        // Construtor que inicializa o nome e gera um ID único.
        public DogModel(string name)
        {
            Name = name;
            id = Guid.NewGuid();
        }
        public Guid id { get; init; }

        // Método para alterar o nome do cachorro.
        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}