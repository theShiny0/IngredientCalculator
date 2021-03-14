using System;
namespace IngredientsCalculator.ClassLibrary
{
    public class Result
    {
        public double Volume { get; private set; }
        public Unit Unit { get; private set; }

        public Result(double volume, Unit unit)
        {
            Volume = volume;
            Unit = unit;
        }

        public void ChangeUnitToLiter(Unit liter)
        {
            Volume /= 1000;
            Unit = liter;
        }
    }
}
