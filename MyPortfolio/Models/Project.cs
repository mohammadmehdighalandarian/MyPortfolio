namespace MyPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discreption { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }


        public Project(int id, string name, string discreption, string client, string image)
        {
            Id = id;
            Name = name;
            Discreption = discreption;
            Client = client;
            Image = image;
        }
    }
}
