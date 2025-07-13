namespace AspMvcHelpersApp.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<string> Languages { get; set; } = new();
    }
}
