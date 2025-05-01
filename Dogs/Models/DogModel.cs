namespace Dogs.Models
{
    public class DogModel
    {
        public string Name { get; set; }

        public DogModel(string name)
        {
            Name = name;
        }
    }
}
