using System;

namespace NRI_Distribution_Exercise_Domain.Util
{
    public static class AreaCalculator
{    
        public static int AreaCalc(int areaType, int n1, int? n2)
        {
            // Square
            if (areaType == 1) 
            {
                return n1 * n1;
            }
            //Triangle
            if (areaType == 2)  
            {
                return (int)((n1 * n2) / 2);
            }
            // Rectangle
            if (areaType == 3) 
            {
                return (int)(n1 * n2);
            }
            // Hexagon
            if (areaType == 4) 
            {
                return (int)(((3 * (Math.Sqrt(3))) / 2) * (n1 * n1));
            }
            else return 0;

        }
}

}
