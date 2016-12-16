using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;

namespace XMax
{
    public class CanvasBackground
    {
        private static Bitmap bmp, curves;
        private static Graphics graphicsBackground, graphicsCanvas;
        private static Matrix transform;
        private static Pen pen = new Pen(Color.Red, .005f);
        private static SolidBrush brush = new SolidBrush(Color.Gray);
        private static Font font = new Font("Arial", 8);
        private static StringFormat stringFormat;

        public static void TransformScale(int width, int height)
        {
            bmp = new Bitmap(width, height);
            curves = new Bitmap(width, height);
            graphicsBackground = Graphics.FromImage(bmp);
            ComputeMatrixTransform(width, height);
        }

        public static void CleanCanvasImage()
        {
            try
            {
                Graphics.FromImage(CanvasBackground.Curves).Clear(Color.Transparent);
                graphicsCanvas = Graphics.FromImage(CanvasBackground.Curves);
                graphicsCanvas.Transform = CanvasBackground.transform;
            }
            catch (Exception) { };
        }
        public static void DrawHistogram(MyData data)
        {
            pen.Color = Color.Black;
            pen.Width = .001f;
            Brush brush = new SolidBrush(data.Color);
            RectangleF rectangle;

            if (data.HistogramRectangles != null)
                for (int i = 0; i < data.HistogramRectangles.Count; i++)
                {
                    try
                    {
                        rectangle = data.HistogramRectangles[i];
                        graphicsCanvas.FillRectangle(brush, rectangle);
                        graphicsCanvas.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
                    }
                    catch (Exception) { }
                }
        }
        public static void DrawCurve(List<PointF> data,Color color)
        {
            try
            {
                pen.Color = color;
                pen.DashStyle = DashStyle.Solid;
                graphicsCanvas.DrawLines(pen, data.OrderBy(c => c.X).ToArray());

            }
            catch (Exception) { };
        }

        public static void DrawCurve(List<PointF> data)
        {
            try
            {
                pen.Color = Color.Black;
                pen.DashStyle = DashStyle.Solid;
                graphicsCanvas.DrawLines(pen, data.OrderBy(c => c.X).ToArray());
            }
            catch (Exception) { };
        }

        public static void DrawDataPoint(float data, Color color)
        {
            try
            {
                brush.Color = color;
                graphicsCanvas.FillEllipse(brush, data, 0, .15f, .01f);
            }
            catch (Exception) { };
        }

        private static void ComputeMatrixTransform(int width, int height)
        {
            RectangleF world = new RectangleF(MyUtil.X_MIN, MyUtil.Y_MIN, MyUtil.W_WIDTH, MyUtil.W_HEIGHT);
            PointF[] device_points =
                {
                    new PointF(0, height),
                    new PointF(width, height),
                    new PointF(0, 0),
                };

            transform = new Matrix(world, device_points);

            DrawXAxis();
            DrawYAxis();
        }

        private static void DrawXAxis()
        {
            graphicsBackground.Transform = transform;

            pen.Color = Color.Black;
            pen.Width = 0;

            graphicsBackground.DrawLine(pen, MyUtil.X_MIN, 0, MyUtil.X_MAX, 0);

            DrawLabelXAxis();
        }
        
        private static void DrawLabelXAxis()
        {
            int index;
            PointF[] ints_array;
            List<PointF> ints;

            graphicsBackground.Transform = new Matrix();
            graphicsBackground.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            ints = new List<PointF>();
            for (int x = (int)MyUtil.X_MIN; x <= MyUtil.X_MAX; x++)
                ints.Add(new PointF(x, -0.07f));

            ints_array = ints.ToArray();
            transform.TransformPoints(ints_array);

            stringFormat = new StringFormat();

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Near;
            index = 0;
            for (int x = (int)MyUtil.X_MIN; x < MyUtil.X_MAX; x++)
            {
                graphicsBackground.DrawString(x.ToString(), font, Brushes.Black,
                    ints_array[index++], stringFormat);
            }
        }

        private static void DrawYAxis()
        {
            graphicsBackground.Transform = transform;
            pen.Color = Color.Black;
            graphicsBackground.DrawLine(pen, 0, MyUtil.Y_MIN, 0, MyUtil.Y_MAX);

            for (int y = (int)MyUtil.Y_MIN; y <= MyUtil.Y_MAX; y++)
            {
                graphicsBackground.DrawLine(pen, -0.2f, y, 0.2f, y);
                graphicsBackground.DrawLine(pen, -0.1f, y + 0.25f, 0.1f, y + 0.25f);
                graphicsBackground.DrawLine(pen, -0.1f, y + 0.50f, 0.1f, y + 0.50f);
                graphicsBackground.DrawLine(pen, -0.1f, y + 0.75f, 0.1f, y + 0.75f);
            }

            DrawLabelYAxis();
        }

        private static void DrawLabelYAxis( )
        {
            int index;
            List<PointF> ints;
            PointF[] ints_array;
            
            ints = new List<PointF>();
            for (float y = 0.25f; y < MyUtil.Y_MAX; y += 0.25f)
            {
                ints.Add(new PointF(0.25f, y));
            }

            ints_array = ints.ToArray();
            transform.TransformPoints(ints_array);

            stringFormat =                  new StringFormat();
            stringFormat.Alignment =        StringAlignment.Near;
            stringFormat.LineAlignment =    StringAlignment.Center;

            index = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                graphicsBackground.DrawString(ints[i].Y.ToString("0.00"), font, Brushes.Black,
                    ints_array[index++], stringFormat);
            }
        }

        public static Bitmap BMP
        {
            get { return CanvasBackground.bmp; }
        }

        public static Bitmap Curves
        {
            get { return CanvasBackground.curves; }
        }
    }
}
