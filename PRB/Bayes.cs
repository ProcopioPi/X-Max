
namespace XMax.PRB
{
    public class Bayes
    {
        private double prior;
        private double posterior;
        private double density;
        
        public Bayes()
        {
        }

        public double Density
        {
            get { return density; }
            set { density = value; }
        }
        public double Prior
        {
            get { return prior; }
            set { prior = value; }
        }
        public double Posterior
        {
            get { return posterior; }
            set { posterior = value; }
        }
    }
}
