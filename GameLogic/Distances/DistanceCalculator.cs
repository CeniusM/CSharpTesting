using System;

namespace GameLogic.Distances
{
    class Distancecalculator
    {
        public static float GetDistance(float x1, float y1, float x2, float y2)
        {
            float lenght = 0;

            double a = Math.Pow(x2 - x1, 2);
            double b = Math.Pow(y2 - y1, 2);

            lenght = (float)Math.Sqrt((a*b));

            return lenght;
        }
    }
}