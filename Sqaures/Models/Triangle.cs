using Sqaures.Exceptions;
using Sqaures.Interfaces;
using System;
using System.Linq;

namespace Sqaures.Models
{
    public class Triangle : IFigure, IValidatedFigure
    {
        public double[] Sides { get; } = new double[3];        

        public bool IsRight
        {
            get
            {
                return (Sides[0] * Sides[0] + Sides[1] * Sides[1] == Sides[2] * Sides[2]) || 
                       (Sides[0] * Sides[0] + Sides[2] * Sides[2] == Sides[1] * Sides[1]) ||
                       (Sides[2] * Sides[2] + Sides[1] * Sides[1] == Sides[0] * Sides[0]);
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            Sides[0] = firstSide;
            Sides[1] = secondSide;
            Sides[2] = thirdSide;

            if (!Validate())
            {
                throw new FigureNotValidException(nameof(Triangle));
            }
        }

        public double CalculateArea()
        {
            double semiPerimeter = Sides.Sum() / 2d;

            return Math.Sqrt(Sides.Select(x => semiPerimeter - x).Aggregate((x, y) => x * y) * semiPerimeter);
        }

        public bool Validate()
        {
            return Sides[0] + Sides[1] > Sides[2] && Sides[0] + Sides[2] > Sides[1] && Sides[1] + Sides[2] > Sides[0];
        }
    }
}
