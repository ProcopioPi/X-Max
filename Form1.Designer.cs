namespace XMax
{
    partial class EM_Form
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.PNL_EM = new System.Windows.Forms.Panel();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.TREE_EM = new System.Windows.Forms.TreeView();
            this.TXT_CLUSTERS = new System.Windows.Forms.TextBox();
            this.LBL_EM = new System.Windows.Forms.Label();
            this.BTN_CLUSTERS = new System.Windows.Forms.Button();
            this.PNL_INFO = new System.Windows.Forms.Panel();
            this.PNL_COLOR = new System.Windows.Forms.Panel();
            this.LBL_MEAN = new System.Windows.Forms.Label();
            this.LBL_STD = new System.Windows.Forms.Label();
            this.LBL_VARIANCE = new System.Windows.Forms.Label();
            this.PNL_LEFT = new System.Windows.Forms.Panel();
            this.TREE_FILE = new System.Windows.Forms.TreeView();
            this.BTN_LOAD_FILE = new System.Windows.Forms.Button();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_MAIN.SuspendLayout();
            this.PNL_EM.SuspendLayout();
            this.PNL_INFO.SuspendLayout();
            this.PNL_LEFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MAIN.Controls.Add(this.BTN_SAVE);
            this.PNL_MAIN.Controls.Add(this.PNL_EM);
            this.PNL_MAIN.Controls.Add(this.PNL_INFO);
            this.PNL_MAIN.Controls.Add(this.PNL_LEFT);
            this.PNL_MAIN.Controls.Add(this.PCT_CANVAS);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(1248, 696);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_SAVE.Location = new System.Drawing.Point(140, 654);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(143, 29);
            this.BTN_SAVE.TabIndex = 14;
            this.BTN_SAVE.Text = "SAVE IMAGE";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // PNL_EM
            // 
            this.PNL_EM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PNL_EM.BackColor = System.Drawing.Color.Transparent;
            this.PNL_EM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_EM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_EM.Controls.Add(this.LBL_TOTAL);
            this.PNL_EM.Controls.Add(this.BTN_UPDATE);
            this.PNL_EM.Controls.Add(this.TREE_EM);
            this.PNL_EM.Controls.Add(this.TXT_CLUSTERS);
            this.PNL_EM.Controls.Add(this.LBL_EM);
            this.PNL_EM.Controls.Add(this.BTN_CLUSTERS);
            this.PNL_EM.Location = new System.Drawing.Point(3, 343);
            this.PNL_EM.Name = "PNL_EM";
            this.PNL_EM.Size = new System.Drawing.Size(121, 348);
            this.PNL_EM.TabIndex = 13;
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_TOTAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBL_TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_TOTAL.Location = new System.Drawing.Point(3, 310);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(113, 32);
            this.LBL_TOTAL.TabIndex = 12;
            this.LBL_TOTAL.Text = "TOTAL";
            this.LBL_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.BTN_UPDATE.FlatAppearance.BorderSize = 0;
            this.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_UPDATE.Location = new System.Drawing.Point(3, 232);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(117, 29);
            this.BTN_UPDATE.TabIndex = 13;
            this.BTN_UPDATE.Text = "UPDATE";
            this.BTN_UPDATE.UseVisualStyleBackColor = false;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // TREE_EM
            // 
            this.TREE_EM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.TREE_EM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE_EM.Location = new System.Drawing.Point(3, 97);
            this.TREE_EM.Name = "TREE_EM";
            this.TREE_EM.ShowPlusMinus = false;
            this.TREE_EM.ShowRootLines = false;
            this.TREE_EM.Size = new System.Drawing.Size(117, 129);
            this.TREE_EM.TabIndex = 10;
            this.TREE_EM.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_EM_AfterSelect);
            // 
            // TXT_CLUSTERS
            // 
            this.TXT_CLUSTERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CLUSTERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CLUSTERS.Location = new System.Drawing.Point(7, 68);
            this.TXT_CLUSTERS.Name = "TXT_CLUSTERS";
            this.TXT_CLUSTERS.Size = new System.Drawing.Size(109, 26);
            this.TXT_CLUSTERS.TabIndex = 9;
            this.TXT_CLUSTERS.Text = "3";
            this.TXT_CLUSTERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_EM
            // 
            this.LBL_EM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBL_EM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_EM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_EM.Location = new System.Drawing.Point(3, 3);
            this.LBL_EM.Name = "LBL_EM";
            this.LBL_EM.Size = new System.Drawing.Size(113, 28);
            this.LBL_EM.TabIndex = 7;
            this.LBL_EM.Text = "X-MAX";
            this.LBL_EM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_CLUSTERS
            // 
            this.BTN_CLUSTERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.BTN_CLUSTERS.FlatAppearance.BorderSize = 0;
            this.BTN_CLUSTERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLUSTERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLUSTERS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_CLUSTERS.Location = new System.Drawing.Point(3, 33);
            this.BTN_CLUSTERS.Name = "BTN_CLUSTERS";
            this.BTN_CLUSTERS.Size = new System.Drawing.Size(117, 57);
            this.BTN_CLUSTERS.TabIndex = 11;
            this.BTN_CLUSTERS.Text = "CLUSTERS";
            this.BTN_CLUSTERS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_CLUSTERS.UseVisualStyleBackColor = false;
            this.BTN_CLUSTERS.Click += new System.EventHandler(this.BTN_CLUSTERS_Click);
            // 
            // PNL_INFO
            // 
            this.PNL_INFO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PNL_INFO.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PNL_INFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_INFO.Controls.Add(this.PNL_COLOR);
            this.PNL_INFO.Controls.Add(this.LBL_MEAN);
            this.PNL_INFO.Controls.Add(this.LBL_STD);
            this.PNL_INFO.Controls.Add(this.LBL_VARIANCE);
            this.PNL_INFO.Location = new System.Drawing.Point(3, 235);
            this.PNL_INFO.Name = "PNL_INFO";
            this.PNL_INFO.Size = new System.Drawing.Size(121, 105);
            this.PNL_INFO.TabIndex = 12;
            // 
            // PNL_COLOR
            // 
            this.PNL_COLOR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PNL_COLOR.BackColor = System.Drawing.Color.White;
            this.PNL_COLOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_COLOR.Location = new System.Drawing.Point(1, 1);
            this.PNL_COLOR.Name = "PNL_COLOR";
            this.PNL_COLOR.Size = new System.Drawing.Size(12, 100);
            this.PNL_COLOR.TabIndex = 11;
            // 
            // LBL_MEAN
            // 
            this.LBL_MEAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_MEAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBL_MEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_MEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MEAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_MEAN.Location = new System.Drawing.Point(13, 1);
            this.LBL_MEAN.Name = "LBL_MEAN";
            this.LBL_MEAN.Size = new System.Drawing.Size(103, 32);
            this.LBL_MEAN.TabIndex = 7;
            this.LBL_MEAN.Text = "μ";
            this.LBL_MEAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_STD
            // 
            this.LBL_STD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_STD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBL_STD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_STD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_STD.Location = new System.Drawing.Point(13, 69);
            this.LBL_STD.Name = "LBL_STD";
            this.LBL_STD.Size = new System.Drawing.Size(103, 32);
            this.LBL_STD.TabIndex = 10;
            this.LBL_STD.Text = "σ";
            this.LBL_STD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_VARIANCE
            // 
            this.LBL_VARIANCE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_VARIANCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LBL_VARIANCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_VARIANCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VARIANCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_VARIANCE.Location = new System.Drawing.Point(13, 35);
            this.LBL_VARIANCE.Name = "LBL_VARIANCE";
            this.LBL_VARIANCE.Size = new System.Drawing.Size(103, 32);
            this.LBL_VARIANCE.TabIndex = 8;
            this.LBL_VARIANCE.Text = "σ2";
            this.LBL_VARIANCE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PNL_LEFT
            // 
            this.PNL_LEFT.BackColor = System.Drawing.Color.Green;
            this.PNL_LEFT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_LEFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_LEFT.Controls.Add(this.TREE_FILE);
            this.PNL_LEFT.Controls.Add(this.BTN_LOAD_FILE);
            this.PNL_LEFT.Location = new System.Drawing.Point(3, 3);
            this.PNL_LEFT.Name = "PNL_LEFT";
            this.PNL_LEFT.Size = new System.Drawing.Size(121, 230);
            this.PNL_LEFT.TabIndex = 3;
            // 
            // TREE_FILE
            // 
            this.TREE_FILE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.TREE_FILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE_FILE.Location = new System.Drawing.Point(3, 42);
            this.TREE_FILE.Name = "TREE_FILE";
            this.TREE_FILE.ShowPlusMinus = false;
            this.TREE_FILE.ShowRootLines = false;
            this.TREE_FILE.Size = new System.Drawing.Size(113, 183);
            this.TREE_FILE.TabIndex = 6;
            this.TREE_FILE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_FILE_AfterSelect);
            // 
            // BTN_LOAD_FILE
            // 
            this.BTN_LOAD_FILE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.BTN_LOAD_FILE.FlatAppearance.BorderSize = 0;
            this.BTN_LOAD_FILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOAD_FILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOAD_FILE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_LOAD_FILE.Location = new System.Drawing.Point(3, 3);
            this.BTN_LOAD_FILE.Name = "BTN_LOAD_FILE";
            this.BTN_LOAD_FILE.Size = new System.Drawing.Size(113, 33);
            this.BTN_LOAD_FILE.TabIndex = 5;
            this.BTN_LOAD_FILE.Text = "LOAD FILE";
            this.BTN_LOAD_FILE.UseVisualStyleBackColor = false;
            this.BTN_LOAD_FILE.Click += new System.EventHandler(this.BTN_LOAD_FILE_Click);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(130, 3);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1113, 688);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            // 
            // EM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 696);
            this.Controls.Add(this.PNL_MAIN);
            this.Name = "EM_Form";
            this.Text = "X-pectation Maximization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.EM_Form_Shown);
            this.SizeChanged += new System.EventHandler(this.EM_Form_SizeChanged);
            this.PNL_MAIN.ResumeLayout(false);
            this.PNL_EM.ResumeLayout(false);
            this.PNL_EM.PerformLayout();
            this.PNL_INFO.ResumeLayout(false);
            this.PNL_LEFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.TreeView TREE_FILE;
        private System.Windows.Forms.Button BTN_LOAD_FILE;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Panel PNL_INFO;
        private System.Windows.Forms.Panel PNL_COLOR;
        private System.Windows.Forms.Label LBL_MEAN;
        private System.Windows.Forms.Label LBL_STD;
        private System.Windows.Forms.Label LBL_VARIANCE;
        private System.Windows.Forms.Panel PNL_EM;
        private System.Windows.Forms.Label LBL_TOTAL;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.TreeView TREE_EM;
        private System.Windows.Forms.TextBox TXT_CLUSTERS;
        private System.Windows.Forms.Label LBL_EM;
        private System.Windows.Forms.Button BTN_CLUSTERS;
        private System.Windows.Forms.Button BTN_SAVE;
    }
}

