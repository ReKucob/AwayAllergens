namespace Search_Recipes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipe
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Categories { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }

        public string Fat { get; set; }

        public string Calories { get; set; }

        public string Protein { get; set; }

        public string Rating { get; set; }
    }
}
