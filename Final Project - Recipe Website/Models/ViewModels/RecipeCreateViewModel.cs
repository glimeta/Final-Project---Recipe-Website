using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Final_Project___Recipe_Website.Models.ViewModels
{
    public class RecipeCreateViewModel
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Cuisine { get; set; }
        public string Type { get; set; }
        public string Sort { get; set; }

        [AllowHtml]
        public IFormFile Photo { get; set; }
        public string Instructions { get; set; }
        public string Ingredients { get; set; }
        public string Author { get; set; }
    }
}
