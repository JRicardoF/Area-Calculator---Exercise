using System;
using NRI_Distribution_Exercise_Domain.Util;

namespace NRI_Distribution_Exercise_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int areaType = 0;
            int squareLength = 0;
            int triangleBase = 0;
            int triangleHeight = 0;
            int rectangleWidth = 0;
            int rectangleLength = 0;
            int hexagonSide = 0;

            Console.WriteLine("Welcome to ACME Inc. - Area Calculator Program");

            do
            {
                Console.WriteLine("Please insert a number that matches what type of area you want to calculate, (1=Square, 2=Triangle, 3=Rectangle, 4=Hexagon)");
                areaType = int.Parse(Console.ReadLine());

                //Square
                if (areaType == 1) 
                {
                    Console.WriteLine("Square area calculator:");
                    Console.WriteLine("Please insert a value of the length of one side");
                    squareLength = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0} ", AreaCalculator.AreaCalc(areaType, squareLength, 0));
                }
                //Triangle
                if (areaType == 2)
                {
                    Console.WriteLine("Triangle area calculator:");
                    Console.WriteLine("Please insert a value of the Base of the triangle");
                    triangleBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert a value of height of the triangle");
                    triangleHeight = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0} ", AreaCalculator.AreaCalc(areaType, triangleBase, triangleHeight));
                }
                //Rectangle
                if (areaType == 3)
                {
                    Console.WriteLine("Rectangle area calculator:");
                    Console.WriteLine("Please insert a value of width of the rectangle");
                    rectangleWidth = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert a value of length of the rectangle");
                    rectangleLength = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0} ", AreaCalculator.AreaCalc(areaType, rectangleWidth, rectangleLength));
                }
                //Hexagon
                if (areaType == 4)
                {
                    Console.WriteLine("Hexagon Area Calculator:");
                    Console.WriteLine("Please insert a value of the side of the hexagon");
                    hexagonSide = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0} ", AreaCalculator.AreaCalc(areaType, hexagonSide, 0));
                }

                Console.WriteLine("If you want to exit the program, insert any number greater than 4.");

            } while (areaType <= 4);

            Console.WriteLine("Thank you for using ACME Inc. - Area Calculator Program.");
        }
    }
}
