using System;
using System.Collections.Generic;
namespace IngredientsCalculator.ClassLibrary
{
    public static class UserMethods
    {
        public static void ListAllIngredients(List<Ingredient> Ingredients)
        {
            Console.WriteLine("List of all ingredients in database: ");
            foreach (var i in Ingredients)
            {
                Console.WriteLine($"{i.Name}");
            }
            Console.WriteLine("---------------");
        }

        public static string Ingredient()
        {
            Console.Write("Ingredient: ");
            return Console.ReadLine();
        }

        public static double Amount()
        {
            Console.Write("Amount (Grams): ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void InvalidAmount()
        {
            Console.WriteLine("Invalid Weight!");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            ClearLine();
            for (int i = 0; i < 3; i++)
                ClearLastLine();
        }

        public static void InvalidIngredient()
        {
            Console.WriteLine("Invalid Ingredient! Spelled Wrong Or Not In List.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            ClearLine();
            for (int i = 0; i < 2; i++)
                ClearLastLine();
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}
