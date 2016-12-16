using System;
using System.Collections.Generic;
using System.Drawing;

namespace XMax.PRB
{
    public class Gauss
    {
        private static double variance;
        private static double one_over;
        private static double difference;
        

        public static List<PointF> FindPoints(double mean, double stddev, double dx, double xMax, double xMin)
        {
            List<PointF> points = new List<PointF>();
            PointF point = new PointF();
            PointF meanP = new PointF();
            double y;
            for (double x = xMin; x < xMax; x += dx)
            {
                y = Function(x, mean, stddev);
                if (y > 0.005)
                {
                    point.X = (float)x;
                    point.Y = (float)y;
                    points.Add(point);

                    if (x < mean)
                    {
                        meanP.X = point.X;
                        meanP.Y = point.Y;
                    }
                }
            }
            points.Add(meanP);

            return points;
        }

        // The normal distribution function.
        public static double Function(double x, double mean, double stddev)
        {
            variance = stddev * stddev;
            one_over =  (1.0 / (stddev * Math.Sqrt(2 * Math.PI)));
            difference = x - mean;

            return (one_over * Math.Exp(-((difference * difference) / (2 * variance))));
        }
    }
}
