using System;
using System.Collections.Generic;
using System.Linq;
namespace IngredientsCalculator.ClassLibrary
{
    public class Database
    {
        public List<Ingredient> Ingredients { get; private set; }
        public Unit Milliliter { get; private set; }
        public Unit Liter { get; private set; }
        public Unit StandardDensity { get; private set; }

        public Database()
        {
            Ingredients = new List<Ingredient>();

            Milliliter = new Unit("Milliliter", "ml");
            Liter = new Unit("Liter", "L");
            StandardDensity = new Unit("Density", "kg/L");

            Ingredients.Add(new Ingredient("Puderzucker", 0.62));
            Ingredients.Add(new Ingredient("Weizenmehl", 0.55));
            Ingredients.Add(new Ingredient("Zucker", 1.6));

        }

        public double DensityToMilliliter(string name, double weight)
        {
            double result;
            Ingredient ingredient = null;

            var ingredients = Ingredients.Where(i => i.Name == name);

            foreach (var i in ingredients)
                ingredient = i;

            result = Math.Round(weight / ingredient.Density);

            return result;
        }
    }
}
