using System;
using System.Collections.Generic;

namespace XMax.PRB
{
    public class EM
    {
        private List<EMPoint> points;
        private static List<StatsData> stats;
        private static int clusters;
        
        public EM(int clusters)
        {
            EM.clusters = clusters;
            stats = new List<StatsData>();            
            points = new List<EMPoint>();
            GenerateStats();
        }

        private void GenerateStats()
        {
            StatsData tmpStats;
            for (int i = 0; i < EM.clusters; i++)
            {
                tmpStats = new StatsData();
                tmpStats.Variance = MyUtil.VARIANCE;
                tmpStats.Mean = (float)(MyUtil.Rand.Next((int)MyUtil.MIN_MEAN, (int)MyUtil.MAX_MEAN));
                tmpStats.ChangeColor();
                tmpStats.GaussianPoints = Gauss.FindPoints(tmpStats.Mean, tmpStats.StdDev, MyUtil.DX, MyUtil.X_MAX, MyUtil.X_MIN);
                tmpStats.Index = i;
                tmpStats.Name = "  EM_" + i;

                stats.Add(tmpStats);
            }
        }

        public void AddDataPoints(double[] dataPoints)
        {
            for (int i = 0; i < dataPoints.Length; i++)
            {
                points.Add(new EMPoint(dataPoints[i], clusters));
            }
        }

        public void ComputeProbabilities()
        {
            for (int i = 0; i < points.Count; i++)
            {
                for (int stat = 0; stat < stats.Count; stat++)
                {
                    if (stats[stat].Variance > MyUtil.MIN_VARIANCE && stats[stat].Variance < MyUtil.MAX_VARIANCE)
                        points[i].ComputeGaussianDensity(stat, stats[stat].Mean, stats[stat].StdDev);
                }

                points[i].ComputePosteriors();
                points[i].UpdateColorPos();
            }
            UpdateGaussianParameters();
        }

        public void UpdateGaussianParameters()
        {
            double posteriorSum;
            double tmpVariance;
            double tmpMean;

            posteriorSum = 0;
            for (int stat = 0; stat < stats.Count; stat++)
            {
                //Update means
                tmpMean = 0;
                for (int i = 0; i < points.Count; i++)
                {
                    tmpMean += (points[i][stat].Posterior * points[i].Value);
                    posteriorSum += points[i][stat].Posterior;
                }
                stats[stat].Mean = tmpMean / posteriorSum;

                //Update variance
                tmpVariance = 0;
                for (int i = 0; i < points.Count; i++)
                {
                    tmpVariance += points[i][stat].Posterior * ((points[i].Value - stats[stat].Mean) * (points[i].Value - stats[stat].Mean));
                }

                if (Math.Sqrt(tmpVariance / posteriorSum) < MyUtil.MAX_VARIANCE && Math.Sqrt(tmpVariance / posteriorSum) > MyUtil.MIN_VARIANCE)
                {
                    stats[stat].Variance = tmpVariance / posteriorSum;
                }

                stats[stat].GaussianPoints = Gauss.FindPoints(stats[stat].Mean, stats[stat].StdDev, MyUtil.DX, MyUtil.X_MAX, MyUtil.X_MIN);

                //Update Posteriors
                for (int i = 0; i < points.Count; i++)
                {
                    points[i][stat].Prior = posteriorSum / points.Count;
                }
            }
        }

        public static List<StatsData> Stats
        {
            get { return EM.stats; }
        }
        public List<EMPoint> Points
        {
            get { return points; }
        }

    }
}
