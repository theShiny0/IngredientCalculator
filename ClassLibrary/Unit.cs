using System;
namespace IngredientsCalculator.ClassLibrary
{
    public class Unit
    {
        public string Name { get; private set; }
        public string Shortcut { get; private set; }

        public Unit(string name, string shortcut)
        {
            Name = name;
            Shortcut = shortcut;
        }
    }
}
