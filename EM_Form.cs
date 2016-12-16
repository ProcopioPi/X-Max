using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XMax.PRB;

namespace XMax
{
    public partial class EM_Form : Form
    {
        private static MyData dataFile;
        private static List<MyData> dataFiles;
        private static int clusters;
        private static EM emMax;

        public EM_Form()
        {
            InitializeComponent();
            clusters = 0;
            dataFiles = new List<MyData>();
        }

        #region Events
        private void EM_Form_Shown(object sender, EventArgs e)
        {
            InitializeGraphics();
        }
        private void EM_Form_SizeChanged(object sender, EventArgs e)
        {
            InitializeGraphics();
            if (dataFile != null)
                DrawInfo(dataFile);
        }
        #endregion

        #region Actions
        /// <summary>
        /// Loads each file as data point distribution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_LOAD_FILE_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    OpenFile();
                    DrawInfo(dataFile);
                    UpdateTreeFileNodes(dataFile);
                }
            }
            catch (Exception) { }
        }
        private void BTN_CLUSTERS_Click(object sender, EventArgs e)
        {
            InitializeEM();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            UpdateProbabilities();
        }

        private void TREE_EM_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateInfo((StatsData)TREE_EM.SelectedNode.Tag);
        }

        private void TREE_FILE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DrawInfo((MyData)TREE_FILE.SelectedNode.Tag);
        }
        #endregion

        #region Methods
        private void InitializeEM()
        {
            TreeNode node;

            clusters = int.Parse(TXT_CLUSTERS.Text);
            emMax = new EM(clusters);

            TREE_EM.Nodes.Clear();
            CanvasBackground.CleanCanvasImage();
            for (int i = 0; i < clusters; i++)
            {
                node = new TreeNode(EM.Stats[i].Name);
                node.BackColor = EM.Stats[i].Color;
                node.Tag = EM.Stats[i];

                node.Checked = true;
                DrawCurves(EM.Stats[i].GaussianPoints, EM.Stats[i].Color);
                TREE_EM.Nodes.Add(node);
            }

            InitPoints();
            LBL_TOTAL.Text = emMax.Points.Count.ToString();
        }

        private void UpdateProbabilities()
        {
            emMax.ComputeProbabilities();

            ReDraw();            
            DrawDataPoints(emMax.Points);
            for (int i = 0; i < EM.Stats.Count; i++)
            {
                DrawCurves(EM.Stats[i].GaussianPoints, EM.Stats[i].Color);
            }
        }

        private void InitPoints()
        {
            for (int i = 0; i < dataFiles.Count; i++)
            {
                emMax.AddDataPoints(dataFiles[i].DataPoints);
            }

            DrawDataPoints(emMax.Points, Color.Gray);
        }

        private void InitializeGraphics()
        {
            CanvasBackground.TransformScale(PCT_CANVAS.ClientSize.Width, PCT_CANVAS.ClientSize.Height);
            ReDraw();
        }

        private void ReDraw()
        {
            CanvasBackground.CleanCanvasImage();
            PCT_CANVAS.BackgroundImage = CanvasBackground.BMP;
            PCT_CANVAS.Image = CanvasBackground.Curves;
        }
                
        private void OpenFile()
        {
            string str = OFD.SafeFileName;
            string file = File.ReadAllText(OFD.FileName);
            string[] dataS = file.Split(new string[] { MyUtil.ENTER }, StringSplitOptions.RemoveEmptyEntries);
            double[] data = new double[dataS.Length];
            double max;

            max = 0;
            for (int i = 0; i < dataS.Length; i++)
            {
                data[i] = double.Parse(dataS[i]);
                if(data[i]> max)
                    max = data[i];
            }

            dataFile = new MyData(data);
            dataFiles.Add(dataFile);

            DrawInfo(dataFile);
        }

        private void UpdateTreeFileNodes(MyData dataFile)
        {
            TreeNode node = new TreeNode("  " + OFD.SafeFileName);
            node.Tag = dataFile;
            node.Checked = false;
            TREE_FILE.Nodes.Add(node);
            TREE_FILE.SelectedNode = node;
            
        }

        private void DrawInfo(MyData dataFile)
        {
            CanvasBackground.DrawHistogram(dataFile);
            DrawCurves(dataFile.GaussPoints,Color.GhostWhite);
            UpdateInfo(dataFile.Stats);
        }

        private void UpdateInfo(StatsData data)
        {
            LBL_MEAN.Text = "μ " + Math.Round(data.Mean, 3);
            LBL_STD.Text = "σ " + Math.Round(data.StdDev, 3);
            LBL_VARIANCE.Text = "σ2 " + Math.Round(data.Variance, 3);
        }

        private void DrawDataPoints(List<EMPoint> dataPoints,Color color)
        {
            for (int i = 0; i < dataPoints.Count; i++)
            {
                CanvasBackground.DrawDataPoint((float)dataPoints[i].Value, color);
            }
            PCT_CANVAS.Image = CanvasBackground.Curves;
        }

        private void DrawDataPoints(List<EMPoint> dataPoints)
        {
            for (int i = 0; i < dataPoints.Count; i++)
            {
                CanvasBackground.DrawDataPoint((float)dataPoints[i].Value, dataPoints[i].Color);
            }
            PCT_CANVAS.Image = CanvasBackground.Curves;
        }

        private void DrawCurves(List<PointF> dataFile,Color color)
        {
            CanvasBackground.DrawCurve(dataFile,color);
            PCT_CANVAS.Image = CanvasBackground.Curves;
        }
        #endregion

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Bitmap back = new Bitmap(PCT_CANVAS.BackgroundImage);
            Graphics gSave = Graphics.FromImage(back);

            gSave.DrawImage(PCT_CANVAS.Image, 0, 0, PCT_CANVAS.Image.Width, PCT_CANVAS.Image.Height);

            back.Save(@"EM_" + DateTime.Now.ToString() + "_.PNG");
        }

    }
}
