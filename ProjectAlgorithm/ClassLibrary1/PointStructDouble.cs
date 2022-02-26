using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    internal struct PointStructDouble
    {
        public double X;
        public double Y;

        public double SQRTStruct(PointStructDouble pointOne, PointStructDouble pointTwo)
        {

            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));

        }
    }
}