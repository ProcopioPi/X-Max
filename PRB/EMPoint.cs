using System;
using System.Collections.Generic;
using System.Drawing;

namespace XMax.PRB
{
    public class EMPoint
    {
        List<Bayes> bayes;
        Color color;
        double value;

        public EMPoint(double value, int clusters)
        {
            this.value = value;
            bayes = new List<Bayes>();

            Bayes tmpBayes;
            for (int c = 0; c < clusters; c++)
            {
                tmpBayes = new Bayes();
                tmpBayes.Prior = 1f/clusters;
                bayes.Add(tmpBayes);
            }
        }

        public void ComputeGaussianDensity(int index, double mean, double stdDev)
        {
            bayes[index].Density = Gauss.Function(value, mean, stdDev);        
        }

        public void ComputePosteriors()
        {
            double marginal;

            marginal = 0;
            for (int b = 0; b < bayes.Count; b++)
            {
                marginal += bayes[b].Density * bayes[b].Prior;
            }

            for (int b = 0; b < bayes.Count; b++)
            {
                if (marginal != 0)
                    bayes[b].Posterior = (bayes[b].Density * bayes[b].Prior) / marginal;
                else
                {
                    bayes[b].Posterior = 0;
                }
            }
        }

        public void UpdateColorPos()
        {
            double total = 0;
            List<double> perc = new List<double>();
            double r, g, b;

            r = g = b = 0;

            for (int i = 0; i < bayes.Count; i++)
            {
                total += bayes[i].Posterior;
                perc.Add(i / bayes.Count);
            }
            for (int i = 0; i < bayes.Count; i++)
            {
                if (total != 0)
                    perc[i] = (bayes[i].Posterior * 100) / total;
                else
                    perc[i] = 0;
            }
            for (int i = 0; i < perc.Count; i++)
            {
                r += EM.Stats[i].Color.R * (perc[i] / 100);
                g += EM.Stats[i].Color.G * (perc[i] / 100);
                b += EM.Stats[i].Color.B * (perc[i] / 100);
            }

            try
            {
                this.color = Color.FromArgb((int)r, (int)g, (int)b);
            }
            catch (Exception) { };
        }

        public Bayes this[int i]
        {
            get { return bayes[i]; }
        }

        public double Value
        {
            get { return this.value; }
        }

        public Color Color
        {
            get { return color; }
        }

    }
}
