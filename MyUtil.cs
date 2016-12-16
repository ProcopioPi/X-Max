using System;
using System.Drawing;

namespace XMax
{
    public class MyUtil
    {
        private static Random random = new Random(DateTime.Now.Millisecond);

        public static Random Rand
        {
            get { return MyUtil.random; }
            set { MyUtil.random = value; }
        }

        public const float DX = 0.01f;
        public const float X_MIN = -11.1f;
        public const float Y_MIN = -0.1f;
        public const float X_MAX = -X_MIN;
        public const float Y_MAX = 2f;
        public const float W_WIDTH = X_MAX - X_MIN;
        public const float W_HEIGHT = Y_MAX - Y_MIN;

        public const int MAX_MEAN = 5;
        public const int MIN_MEAN = -MAX_MEAN;
        public const float VARIANCE = 1;
        public const float MAX_VARIANCE = 2;
        public const float MIN_VARIANCE = 0.05F;

        public const string allGreek1 = "α β γ δ ε ζ η θ ι κ λ μ ν ξ ο π ρ σ τ υ φ χ ψ ω";
        public const string allGreek2 = "Α Β Γ Δ Ε Ζ Η Θ Ι Κ Λ Μ Ν Ξ Ο Π Ρ Σ Τ Υ Φ Χ Ψ Ω";
        public const string ENTER = "\r\n";

        public static Color RandomColor()
        {
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[random.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            return randomColor;
        }

        public static Color RandomColor(int min, int max)
        {
            Color randomColor = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
            return randomColor;
        }
    }
}
