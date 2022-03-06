using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    internal class PointClassDouble
    {
        public double X;
        public double Y;

        public double SQRTClass(PointClassDouble pointOne, PointClassDouble pointTwo)
        {

            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));

        }

    }
}