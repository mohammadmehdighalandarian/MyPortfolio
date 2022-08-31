namespace MyPortfolio.Models
{
    public class maghale
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Discreption { get; set; }
        public string Image { get; set; }

        public maghale(int id, string name, string discreption, string image)
        {
            this.id = id;
            Name = name;
            Discreption = discreption;
            Image = image;
        }
    }
}
