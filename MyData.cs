using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using XMax.PRB;

namespace XMax
{
    public class MyData
    {
        private Hashtable hashtable;
        private ArrayList arrayListX;
        private List<PointF> histogramPoints;
        private List<RectangleF> histogramRectangles;
        private StatsData stats;
        private PointF meanPoint;
        private double[] data;
        private float maxY;
        private int index;
        private string name;

        public MyData()
        {
            hashtable = new Hashtable();
            stats = new StatsData();
        }

        public MyData(double[] data)
        {
            this.data = data;
            hashtable = new Hashtable();
            stats = new StatsData();
            Analize();
        }

        #region Methods
        private void Analize()
        {
            ComputeMean();
            ComputeVariance();
            GenerateHistogramPoints();
            GenerateGaussianPoints();
            stats.ChangeColor();
        }

        private void GenerateGaussianPoints()
        {
            stats.GaussianPoints = Gauss.FindPoints(stats.Mean, stats.StdDev, MyUtil.DX, MyUtil.X_MAX, MyUtil.X_MIN);
        }

        private void GenerateHistogramPoints()
        {
            double value;
            float diffX;
            RectangleF tmpRect;
            PointF tmpPoint;

            value = 0;
            maxY = 0;
            histogramPoints = new List<PointF>();
            for (int i = 0; i < data.Length; i++)
            {
                value = Math.Round(data[i], 1);
                if (hashtable.ContainsKey(value))
                {
                    hashtable[value] = (int)hashtable[value] + 1;

                    if ((int)hashtable[value] > maxY)
                        maxY = (int)hashtable[value];
                }
                else
                    hashtable.Add(value, 1);
            }

            arrayListX = new ArrayList(hashtable.Keys);
            arrayListX.Sort();

            tmpPoint = new PointF();

            double key = 0;
            for (int k = 0; k < arrayListX.Count; k++)
            {
                key = (double)arrayListX[k];
                tmpPoint.X = ((float)key);
                tmpPoint.Y = (float)(((int)hashtable[key]) / maxY);
                histogramPoints.Add(tmpPoint);
            }

            tmpRect = new RectangleF();
            histogramRectangles = new List<RectangleF>();
            for (int i = 0; i < histogramPoints.Count - 1; i++)
            {
                diffX = Math.Abs(histogramPoints[i].X - histogramPoints[i + 1].X);

                tmpRect.X = histogramPoints[i].X;
                tmpRect.Width = diffX;
                tmpRect.Height = histogramPoints[i].Y;

                histogramRectangles.Add(tmpRect);
            }
        }

        private void ComputeVariance()
        {
            float tmp;

            stats.Variance = 0;
            tmp = 0;
            for (int d = 0; d < data.Length; d++)
            {
                tmp = (float)(data[d] - stats.Mean);
                stats.Variance += (tmp * tmp);
            }
            stats.Variance /= data.Length;
            stats.StdDev = (float)Math.Sqrt(stats.Variance);
        }

        private void ComputeMean()
        {
            stats.Mean = 0;
            for (int d = 0; d < data.Length; d++)
            {
                stats.Mean += (float)data[d];
            }
            stats.Mean /= data.Length;
        }

        #endregion

        #region GETTERS-SETTERS
        public StatsData Stats
        {
            get { return stats; }
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
        public double[] DataPoints
        {
            get { return data; }
        }

        public PointF MeanP
        {
            get { return meanPoint; }
        }

        public int Count
        {
            get { return stats.GaussianPoints.Count; }
        }

        public List<RectangleF> HistogramRectangles
        {
            get { return histogramRectangles; }
        }

        public List<PointF> GaussPoints
        {
            get { return stats.GaussianPoints; }
            set
            {
                stats.GaussianPoints = value;
                meanPoint = stats.GaussianPoints[stats.GaussianPoints.Count - 1];
                stats.GaussianPoints.RemoveAt(stats.GaussianPoints.Count - 1);
            }
        }

        public Color Color
        {
            get { return stats.Color; }
            set { stats.Color = value; }
        }

        public double this[int i]
        {
            get { return data[i]; }
        }

        public PointF MinValue
        {
            get { return histogramPoints[0]; }
        }
        public PointF MaxValue
        {
            get { return histogramPoints[histogramPoints.Count - 1]; }
        }

        public double Mean
        {
            get { return stats.Mean; }
            set { stats.Mean = value; }
        }

        public double StdDev
        {
            get { return stats.StdDev; }
            set { stats.StdDev = value; }
        }

        public double Variance
        {
            get { return stats.Variance; }
            set
            {
                stats.Variance = value;
                stats.StdDev = (float)Math.Sqrt(stats.Variance);
            }
        }
        #endregion
    }
}
