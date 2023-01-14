namespace Final_Project___Recipe_Website.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Cuisine { get; set; }
        public string Type { get; set; }
        public string Sort { get; set; }

        [AllowHtml]
        public byte[] Photo { get; set; }
        public string Instructions { get; set; }
        public string Ingredients { get; set; }
        public string Author { get; set; }

    }
}
