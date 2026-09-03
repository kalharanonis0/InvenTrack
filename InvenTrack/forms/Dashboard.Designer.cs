namespace InvenTrack.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Categorycountlabel = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            currentStockstatus = new Label();
            label4 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            InventoryValueStatus = new Label();
            label6 = new Label();
            label5 = new Label();
            guna2vProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            guna2vProgressBar2 = new Guna.UI2.WinForms.Guna2VProgressBar();
            guna2vProgressBar3 = new Guna.UI2.WinForms.Guna2VProgressBar();
            panel9 = new Panel();
            lowStockCountstates = new Label();
            equalStockCountstates = new Label();
            highStockCountstates = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            panel10 = new Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 53);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(840, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 38);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 54);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Categorycountlabel);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 51);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // Categorycountlabel
            // 
            Categorycountlabel.AutoSize = true;
            Categorycountlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categorycountlabel.ForeColor = SystemColors.ActiveCaptionText;
            Categorycountlabel.Location = new Point(140, 16);
            Categorycountlabel.Name = "Categorycountlabel";
            Categorycountlabel.Size = new Size(0, 20);
            Categorycountlabel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(49, 16);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Category  :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(306, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 54);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(currentStockstatus);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 51);
            panel6.TabIndex = 0;
            // 
            // currentStockstatus
            // 
            currentStockstatus.AutoSize = true;
            currentStockstatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentStockstatus.ForeColor = SystemColors.ActiveCaptionText;
            currentStockstatus.Location = new Point(161, 16);
            currentStockstatus.Name = "currentStockstatus";
            currentStockstatus.Size = new Size(0, 20);
            currentStockstatus.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(35, 16);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "Current Stock   :";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkViolet;
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(617, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(262, 105);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(InventoryValueStatus);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(0, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(302, 102);
            panel8.TabIndex = 0;
            // 
            // InventoryValueStatus
            // 
            InventoryValueStatus.AutoSize = true;
            InventoryValueStatus.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryValueStatus.ForeColor = SystemColors.ActiveCaptionText;
            InventoryValueStatus.Location = new Point(87, 45);
            InventoryValueStatus.Name = "InventoryValueStatus";
            InventoryValueStatus.Size = new Size(0, 37);
            InventoryValueStatus.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(23, 45);
            label6.Name = "label6";
            label6.Size = new Size(68, 37);
            label6.TabIndex = 2;
            label6.Text = "Rs  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(23, 16);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 0;
            label5.Text = "Inventory Value  :";
            // 
            // guna2vProgressBar1
            // 
            guna2vProgressBar1.CustomizableEdges = customizableEdges1;
            guna2vProgressBar1.Location = new Point(18, 17);
            guna2vProgressBar1.Name = "guna2vProgressBar1";
            guna2vProgressBar1.ProgressColor2 = Color.Green;
            guna2vProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2vProgressBar1.Size = new Size(64, 248);
            guna2vProgressBar1.TabIndex = 7;
            guna2vProgressBar1.Text = "guna2vProgressBar1";
            guna2vProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2vProgressBar2
            // 
            guna2vProgressBar2.CustomizableEdges = customizableEdges3;
            guna2vProgressBar2.Location = new Point(100, 17);
            guna2vProgressBar2.Name = "guna2vProgressBar2";
            guna2vProgressBar2.ProgressColor = Color.FromArgb(255, 128, 0);
            guna2vProgressBar2.ProgressColor2 = Color.FromArgb(192, 64, 0);
            guna2vProgressBar2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2vProgressBar2.Size = new Size(64, 248);
            guna2vProgressBar2.TabIndex = 8;
            guna2vProgressBar2.Text = "guna2vProgressBar2";
            guna2vProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2vProgressBar3
            // 
            guna2vProgressBar3.CustomizableEdges = customizableEdges5;
            guna2vProgressBar3.Location = new Point(181, 17);
            guna2vProgressBar3.Name = "guna2vProgressBar3";
            guna2vProgressBar3.ProgressColor = Color.Red;
            guna2vProgressBar3.ProgressColor2 = Color.Maroon;
            guna2vProgressBar3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2vProgressBar3.Size = new Size(64, 248);
            guna2vProgressBar3.TabIndex = 9;
            guna2vProgressBar3.Text = "guna2vProgressBar3";
            guna2vProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonHighlight;
            panel9.Controls.Add(lowStockCountstates);
            panel9.Controls.Add(equalStockCountstates);
            panel9.Controls.Add(highStockCountstates);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(guna2vProgressBar1);
            panel9.Controls.Add(guna2vProgressBar3);
            panel9.Controls.Add(guna2vProgressBar2);
            panel9.Location = new Point(0, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(262, 366);
            panel9.TabIndex = 10;
            // 
            // lowStockCountstates
            // 
            lowStockCountstates.AutoSize = true;
            lowStockCountstates.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lowStockCountstates.ForeColor = Color.Red;
            lowStockCountstates.Location = new Point(188, 292);
            lowStockCountstates.Name = "lowStockCountstates";
            lowStockCountstates.Size = new Size(36, 28);
            lowStockCountstates.TabIndex = 14;
            lowStockCountstates.Text = "00";
            // 
            // equalStockCountstates
            // 
            equalStockCountstates.AutoSize = true;
            equalStockCountstates.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            equalStockCountstates.ForeColor = Color.FromArgb(255, 128, 0);
            equalStockCountstates.Location = new Point(108, 292);
            equalStockCountstates.Name = "equalStockCountstates";
            equalStockCountstates.Size = new Size(36, 28);
            equalStockCountstates.TabIndex = 13;
            equalStockCountstates.Text = "00";
            // 
            // highStockCountstates
            // 
            highStockCountstates.AutoSize = true;
            highStockCountstates.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            highStockCountstates.ForeColor = Color.Lime;
            highStockCountstates.Location = new Point(27, 292);
            highStockCountstates.Name = "highStockCountstates";
            highStockCountstates.Size = new Size(36, 28);
            highStockCountstates.TabIndex = 12;
            highStockCountstates.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(15, 268);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 12;
            label8.Text = "Good Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(172, 268);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 11;
            label7.Text = "Out Of Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(100, 268);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 10;
            label3.Text = "Low Stock";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Controls.Add(panel9);
            panel10.Location = new Point(617, 220);
            panel10.Name = "panel10";
            panel10.Size = new Size(262, 369);
            panel10.TabIndex = 11;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 25;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(12, 173);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(586, 288);
            guna2DataGridView1.TabIndex = 12;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.None;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(491, 483);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 13;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(891, 604);
            Controls.Add(button1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel10);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label Categorycountlabel;
        private Panel panel5;
        private Panel panel6;
        private Label currentStockstatus;
        private Label label4;
        private Panel panel7;
        private Panel panel8;
        private Label InventoryValueStatus;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2vProgressBar1;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2vProgressBar2;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2vProgressBar3;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label lowStockCountstates;
        private Label equalStockCountstates;
        private Label highStockCountstates;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button button1;
    }
}