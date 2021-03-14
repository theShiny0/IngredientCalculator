using System;
namespace IngredientsCalculator.ClassLibrary
{
    public class Ingredient
    {

        public string Name { get; private set; }
        public double Density { get; private set; }

        public Ingredient(string name, double density)
        {
            Name = name;
            Density = density;
        }

        public void ChangeDensity(double NewDensitiy)
        {
            Console.WriteLine("Update Density: ");
            double NewDensity = Convert.ToDouble(Console.ReadLine());
            Density = NewDensitiy;
        }
    }
}
