using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace XMax.PRB
{
    public class StatsData
    {
        private double mean;
        private double stdDev;
        private double variance;
        private List<PointF> gaussianPoints;
        private int index;
        private string name;
        private Color color;
               
        public StatsData()
        {
        }

        public void ChangeColor()
        {
            this.color = MyUtil.RandomColor(5, 250);
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
         
        public List<PointF> GaussianPoints
        {
            get { return gaussianPoints; }
            set { gaussianPoints = value; }
        }

        public double Variance
        {
            get { return variance; }
            set
            {
                variance = value;
                stdDev = Math.Sqrt(variance);
            }
        }

        public double StdDev
        {
            get { return stdDev; }
            set { stdDev = value; }
        }

        public double Mean
        {
            get { return mean; }
            set { mean = value; }
        }
    }
}
