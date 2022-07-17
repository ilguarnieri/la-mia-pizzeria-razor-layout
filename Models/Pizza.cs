namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Photo { get; private set; }
        public float Price { get; private set; }

        public Pizza(string name, string description, string photo, string price)
        {
            this.Name = name;
            this.Description = description;
            this.Photo = photo;
            this.Price = float.Parse(price);
        }


    }
}
