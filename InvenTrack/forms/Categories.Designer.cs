namespace InvenTrack.Forms
{
    partial class Categories
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            addnewCategorybutton = new Button();
            body_panel_add = new Panel();
            AddCategorybtn = new Button();
            CategoryPagetextBox = new Guna.UI2.WinForms.Guna2TextBox();
            Reloadbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            body_panel_add.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 53);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(103, 214);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(646, 307);
            guna2DataGridView1.TabIndex = 5;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(addnewCategorybutton);
            panel2.Location = new Point(12, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 42);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // addnewCategorybutton
            // 
            addnewCategorybutton.BackColor = SystemColors.Highlight;
            addnewCategorybutton.Cursor = Cursors.Hand;
            addnewCategorybutton.Dock = DockStyle.Fill;
            addnewCategorybutton.FlatAppearance.BorderSize = 0;
            addnewCategorybutton.FlatStyle = FlatStyle.Flat;
            addnewCategorybutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addnewCategorybutton.ForeColor = SystemColors.ButtonFace;
            addnewCategorybutton.Location = new Point(0, 0);
            addnewCategorybutton.Name = "addnewCategorybutton";
            addnewCategorybutton.Size = new Size(263, 42);
            addnewCategorybutton.TabIndex = 0;
            addnewCategorybutton.Text = "Add New Category";
            addnewCategorybutton.UseVisualStyleBackColor = false;
            addnewCategorybutton.Click += addCategorybutton_Click;
            // 
            // body_panel_add
            // 
            body_panel_add.Controls.Add(AddCategorybtn);
            body_panel_add.Controls.Add(CategoryPagetextBox);
            body_panel_add.Location = new Point(103, 139);
            body_panel_add.Name = "body_panel_add";
            body_panel_add.Size = new Size(646, 69);
            body_panel_add.TabIndex = 7;
            // 
            // AddCategorybtn
            // 
            AddCategorybtn.BackColor = SystemColors.Highlight;
            AddCategorybtn.Cursor = Cursors.Hand;
            AddCategorybtn.FlatAppearance.BorderSize = 0;
            AddCategorybtn.FlatStyle = FlatStyle.Flat;
            AddCategorybtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddCategorybtn.ForeColor = SystemColors.HighlightText;
            AddCategorybtn.Location = new Point(400, 18);
            AddCategorybtn.Name = "AddCategorybtn";
            AddCategorybtn.Size = new Size(84, 36);
            AddCategorybtn.TabIndex = 1;
            AddCategorybtn.Text = "Add";
            AddCategorybtn.UseVisualStyleBackColor = false;
            AddCategorybtn.Click += AddCategorybtn_Click;
            // 
            // CategoryPagetextBox
            // 
            CategoryPagetextBox.CustomizableEdges = customizableEdges5;
            CategoryPagetextBox.DefaultText = "";
            CategoryPagetextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CategoryPagetextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CategoryPagetextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CategoryPagetextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CategoryPagetextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryPagetextBox.Font = new Font("Segoe UI", 9F);
            CategoryPagetextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryPagetextBox.Location = new Point(83, 18);
            CategoryPagetextBox.Name = "CategoryPagetextBox";
            CategoryPagetextBox.PlaceholderText = "";
            CategoryPagetextBox.SelectedText = "";
            CategoryPagetextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CategoryPagetextBox.Size = new Size(282, 36);
            CategoryPagetextBox.TabIndex = 0;
            // 
            // Reloadbutton
            // 
            Reloadbutton.BackColor = SystemColors.ControlLightLight;
            Reloadbutton.Cursor = Cursors.Hand;
            Reloadbutton.FlatStyle = FlatStyle.Flat;
            Reloadbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Reloadbutton.ForeColor = SystemColors.ControlDarkDark;
            Reloadbutton.Location = new Point(687, 75);
            Reloadbutton.Name = "Reloadbutton";
            Reloadbutton.Size = new Size(182, 36);
            Reloadbutton.TabIndex = 2;
            Reloadbutton.Text = "Reload";
            Reloadbutton.UseVisualStyleBackColor = false;
            Reloadbutton.Click += Reloadbutton_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 604);
            Controls.Add(Reloadbutton);
            Controls.Add(body_panel_add);
            Controls.Add(panel2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel1);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            body_panel_add.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Panel panel2;
        private Button addnewCategorybutton;
        private PictureBox pictureBox1;
        private Panel body_panel_add;
        private Button AddCategorybtn;
        private Guna.UI2.WinForms.Guna2TextBox CategoryPagetextBox;
        private Button Reloadbutton;
    }
}