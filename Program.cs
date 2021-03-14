using System;
using IngredientsCalculator.ClassLibrary;

namespace IngredientsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Database();

            UserMethods.ListAllIngredients(data.Ingredients);

            while (true)
            {
                bool InvalidIngredient = true;
                var ingredient = UserMethods.Ingredient();
                foreach (var i in data.Ingredients)
                    if (i.Name == ingredient)
                        InvalidIngredient = false;

                if (InvalidIngredient == true)
                {
                    UserMethods.InvalidIngredient();
                    continue;
                }

                double amount;
                try
                {
                    amount = UserMethods.Amount();
                }
                catch
                {
                    UserMethods.InvalidAmount();
                    continue;
                }

                double volume = data.DensityToMilliliter(ingredient, amount);

                var result = new Result(volume, data.Milliliter);

                if (result.Volume > 1000)
                    result.ChangeUnitToLiter(data.Liter);

                Console.WriteLine($"{result.Volume} {result.Unit.Shortcut}");
                Console.WriteLine("---------------");
            }
        }
    }
}
