namespace PROJECT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRESENHAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDPOINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIRCLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cENTERPOINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tWOPOINTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLLIPSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOLYGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSLATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TX = new System.Windows.Forms.ToolStripTextBox();
            this.TY = new System.Windows.Forms.ToolStripTextBox();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOTATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aROUND00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angle = new System.Windows.Forms.ToolStripTextBox();
            this.sTARTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aROUNDXYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCALINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SX = new System.Windows.Forms.ToolStripTextBox();
            this.SY = new System.Windows.Forms.ToolStripTextBox();
            this.sATRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIPINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmax = new System.Windows.Forms.ToolStripTextBox();
            this.ymax = new System.Windows.Forms.ToolStripTextBox();
            this.xmin = new System.Windows.Forms.ToolStripTextBox();
            this.ymin = new System.Windows.Forms.ToolStripTextBox();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pp = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lINEToolStripMenuItem,
            this.mIDPOINTToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.pOLYGONToolStripMenuItem,
            this.tRANSLATIONToolStripMenuItem,
            this.rOTATIONToolStripMenuItem,
            this.sCALINGToolStripMenuItem,
            this.cLIPINGToolStripMenuItem,
            this.xmax,
            this.ymax,
            this.xmin,
            this.ymin,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lINEToolStripMenuItem
            // 
            this.lINEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bRESENHAMToolStripMenuItem});
            this.lINEToolStripMenuItem.Name = "lINEToolStripMenuItem";
            this.lINEToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.lINEToolStripMenuItem.Text = "LINE";
            this.lINEToolStripMenuItem.Click += new System.EventHandler(this.lINEToolStripMenuItem_Click_1);
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bRESENHAMToolStripMenuItem
            // 
            this.bRESENHAMToolStripMenuItem.Name = "bRESENHAMToolStripMenuItem";
            this.bRESENHAMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bRESENHAMToolStripMenuItem.Text = "BRESENHAM";
            this.bRESENHAMToolStripMenuItem.Click += new System.EventHandler(this.bRESENHAMToolStripMenuItem_Click);
            // 
            // mIDPOINTToolStripMenuItem
            // 
            this.mIDPOINTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIRCLEToolStripMenuItem,
            this.eLLIPSEToolStripMenuItem});
            this.mIDPOINTToolStripMenuItem.Name = "mIDPOINTToolStripMenuItem";
            this.mIDPOINTToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.mIDPOINTToolStripMenuItem.Text = "MIDPOINT";
            this.mIDPOINTToolStripMenuItem.Click += new System.EventHandler(this.mIDPOINTToolStripMenuItem_Click_1);
            // 
            // cIRCLEToolStripMenuItem
            // 
            this.cIRCLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cENTERPOINTToolStripMenuItem,
            this.tWOPOINTSToolStripMenuItem});
            this.cIRCLEToolStripMenuItem.Name = "cIRCLEToolStripMenuItem";
            this.cIRCLEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cIRCLEToolStripMenuItem.Text = "CIRCLE";
            // 
            // cENTERPOINTToolStripMenuItem
            // 
            this.cENTERPOINTToolStripMenuItem.Name = "cENTERPOINTToolStripMenuItem";
            this.cENTERPOINTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cENTERPOINTToolStripMenuItem.Text = "CENTER&POINT";
            this.cENTERPOINTToolStripMenuItem.Click += new System.EventHandler(this.cENTERPOINTToolStripMenuItem_Click_1);
            // 
            // tWOPOINTSToolStripMenuItem
            // 
            this.tWOPOINTSToolStripMenuItem.Name = "tWOPOINTSToolStripMenuItem";
            this.tWOPOINTSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tWOPOINTSToolStripMenuItem.Text = "TWO POINTS";
            this.tWOPOINTSToolStripMenuItem.Click += new System.EventHandler(this.tWOPOINTSToolStripMenuItem_Click);
            // 
            // eLLIPSEToolStripMenuItem
            // 
            this.eLLIPSEToolStripMenuItem.Name = "eLLIPSEToolStripMenuItem";
            this.eLLIPSEToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.eLLIPSEToolStripMenuItem.Text = "ELLIPSE";
            this.eLLIPSEToolStripMenuItem.Click += new System.EventHandler(this.eLLIPSEToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.rectangleToolStripMenuItem.Text = "RECTANGLE";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // pOLYGONToolStripMenuItem
            // 
            this.pOLYGONToolStripMenuItem.Name = "pOLYGONToolStripMenuItem";
            this.pOLYGONToolStripMenuItem.Size = new System.Drawing.Size(142, 23);
            this.pOLYGONToolStripMenuItem.Text = "UNFORMED_POLYGON";
            this.pOLYGONToolStripMenuItem.Click += new System.EventHandler(this.pOLYGONToolStripMenuItem_Click);
            // 
            // tRANSLATIONToolStripMenuItem
            // 
            this.tRANSLATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TX,
            this.TY,
            this.sTARTToolStripMenuItem});
            this.tRANSLATIONToolStripMenuItem.Name = "tRANSLATIONToolStripMenuItem";
            this.tRANSLATIONToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.tRANSLATIONToolStripMenuItem.Text = "TRANSLATION";
            this.tRANSLATIONToolStripMenuItem.Click += new System.EventHandler(this.tRANSLATIONToolStripMenuItem_Click);
            // 
            // TX
            // 
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(100, 23);
            this.TX.Text = "X";
            // 
            // TY
            // 
            this.TY.Name = "TY";
            this.TY.Size = new System.Drawing.Size(100, 23);
            this.TY.Text = "Y";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // rOTATIONToolStripMenuItem
            // 
            this.rOTATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aROUND00ToolStripMenuItem,
            this.aROUNDXYToolStripMenuItem});
            this.rOTATIONToolStripMenuItem.Name = "rOTATIONToolStripMenuItem";
            this.rOTATIONToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.rOTATIONToolStripMenuItem.Text = "ROTATION";
            this.rOTATIONToolStripMenuItem.Click += new System.EventHandler(this.rOTATIONToolStripMenuItem_Click);
            // 
            // aROUND00ToolStripMenuItem
            // 
            this.aROUND00ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angle,
            this.sTARTToolStripMenuItem1});
            this.aROUND00ToolStripMenuItem.Name = "aROUND00ToolStripMenuItem";
            this.aROUND00ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aROUND00ToolStripMenuItem.Text = "AROUND(0,0)";
            // 
            // angle
            // 
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(100, 23);
            this.angle.Text = "ANGLE";
            // 
            // sTARTToolStripMenuItem1
            // 
            this.sTARTToolStripMenuItem1.Name = "sTARTToolStripMenuItem1";
            this.sTARTToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.sTARTToolStripMenuItem1.Text = "START";
            this.sTARTToolStripMenuItem1.Click += new System.EventHandler(this.sTARTToolStripMenuItem1_Click);
            // 
            // aROUNDXYToolStripMenuItem
            // 
            this.aROUNDXYToolStripMenuItem.Name = "aROUNDXYToolStripMenuItem";
            this.aROUNDXYToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aROUNDXYToolStripMenuItem.Text = "AROUND(X,Y)";
            this.aROUNDXYToolStripMenuItem.Click += new System.EventHandler(this.aROUNDXYToolStripMenuItem_Click);
            // 
            // sCALINGToolStripMenuItem
            // 
            this.sCALINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SX,
            this.SY,
            this.sATRTToolStripMenuItem});
            this.sCALINGToolStripMenuItem.Name = "sCALINGToolStripMenuItem";
            this.sCALINGToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.sCALINGToolStripMenuItem.Text = "SCALING";
            this.sCALINGToolStripMenuItem.Click += new System.EventHandler(this.sCALINGToolStripMenuItem_Click);
            // 
            // SX
            // 
            this.SX.Name = "SX";
            this.SX.Size = new System.Drawing.Size(100, 23);
            this.SX.Text = "X";
            // 
            // SY
            // 
            this.SY.Name = "SY";
            this.SY.Size = new System.Drawing.Size(100, 23);
            this.SY.Text = "Y";
            // 
            // sATRTToolStripMenuItem
            // 
            this.sATRTToolStripMenuItem.Name = "sATRTToolStripMenuItem";
            this.sATRTToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sATRTToolStripMenuItem.Text = "SATRT";
            this.sATRTToolStripMenuItem.Click += new System.EventHandler(this.sATRTToolStripMenuItem_Click);
            // 
            // cLIPINGToolStripMenuItem
            // 
            this.cLIPINGToolStripMenuItem.Name = "cLIPINGToolStripMenuItem";
            this.cLIPINGToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.cLIPINGToolStripMenuItem.Text = "CLIPING";
            this.cLIPINGToolStripMenuItem.Click += new System.EventHandler(this.cLIPINGToolStripMenuItem_Click);
            // 
            // xmax
            // 
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(100, 23);
            this.xmax.Text = "Xmax";
            // 
            // ymax
            // 
            this.ymax.Name = "ymax";
            this.ymax.Size = new System.Drawing.Size(100, 23);
            this.ymax.Text = "Ymax";
            // 
            // xmin
            // 
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(100, 23);
            this.xmin.Text = "Xmin";
            // 
            // ymin
            // 
            this.ymin.Name = "ymin";
            this.ymin.Size = new System.Drawing.Size(100, 23);
            this.ymin.Text = "Ymin";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // pp
            // 
            this.pp.BackColor = System.Drawing.Color.White;
            this.pp.Location = new System.Drawing.Point(0, 27);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(771, 675);
            this.pp.TabIndex = 1;
            this.pp.TabStop = false;
            this.pp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p1_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(772, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 431);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lINEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRESENHAMToolStripMenuItem;
        private System.Windows.Forms.PictureBox pp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mIDPOINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIRCLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cENTERPOINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tWOPOINTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLLIPSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOLYGONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSLATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TX;
        private System.Windows.Forms.ToolStripTextBox TY;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOTATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aROUND00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aROUNDXYToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox angle;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sCALINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SX;
        private System.Windows.Forms.ToolStripTextBox SY;
        private System.Windows.Forms.ToolStripMenuItem sATRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIPINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox xmax;
        private System.Windows.Forms.ToolStripTextBox ymax;
        private System.Windows.Forms.ToolStripTextBox xmin;
        private System.Windows.Forms.ToolStripTextBox ymin;
        private System.Windows.Forms.Timer timer1;
    }
}

