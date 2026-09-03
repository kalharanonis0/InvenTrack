namespace InvenTrack.Forms
{
    partial class Add_Product
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            sucsusspanel = new Panel();
            Updatebutton = new Button();
            CategorycomboBox = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddProductbutton = new Button();
            Cancelbutton = new Button();
            DescriptiontextBox = new TextBox();
            ReorderQtytextBox = new TextBox();
            UnitPricetextBox = new TextBox();
            MinimumStockLeveltextBox = new TextBox();
            CurrentStocktextBox = new TextBox();
            SKUtextBox = new TextBox();
            ProductNametextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            sucsusspanellabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            sucsusspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(840, 5);
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
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(sucsusspanel);
            panel2.Controls.Add(Updatebutton);
            panel2.Controls.Add(CategorycomboBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(AddProductbutton);
            panel2.Controls.Add(Cancelbutton);
            panel2.Controls.Add(DescriptiontextBox);
            panel2.Controls.Add(ReorderQtytextBox);
            panel2.Controls.Add(UnitPricetextBox);
            panel2.Controls.Add(MinimumStockLeveltextBox);
            panel2.Controls.Add(CurrentStocktextBox);
            panel2.Controls.Add(SKUtextBox);
            panel2.Controls.Add(ProductNametextBox);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 512);
            panel2.TabIndex = 3;
            // 
            // sucsusspanel
            // 
            sucsusspanel.BackColor = Color.FromArgb(192, 255, 192);
            sucsusspanel.Controls.Add(sucsusspanellabel);
            sucsusspanel.Location = new Point(691, 437);
            sucsusspanel.Name = "sucsusspanel";
            sucsusspanel.Size = new Size(200, 61);
            sucsusspanel.TabIndex = 21;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.DarkTurquoise;
            Updatebutton.Cursor = Cursors.Hand;
            Updatebutton.FlatStyle = FlatStyle.Flat;
            Updatebutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Updatebutton.ForeColor = Color.White;
            Updatebutton.Location = new Point(708, 13);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(169, 32);
            Updatebutton.TabIndex = 20;
            Updatebutton.Text = "Update Product";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.Font = new Font("Segoe UI", 11F);
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(464, 148);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(172, 28);
            CategorycomboBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(224, 336);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 18;
            label10.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 271);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 17;
            label9.Text = "Reorder Qty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 271);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 16;
            label8.Text = "Unit Price (Rs.) *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 202);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 15;
            label7.Text = "Minimum Stock Level *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 202);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 14;
            label6.Text = "Current Stock *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 130);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Category *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 130);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "SKU *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 62);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 11;
            label3.Text = "Product Name *";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 24);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 10;
            label2.Text = "Add New Product";
            // 
            // AddProductbutton
            // 
            AddProductbutton.BackColor = Color.DodgerBlue;
            AddProductbutton.Cursor = Cursors.Hand;
            AddProductbutton.FlatStyle = FlatStyle.Flat;
            AddProductbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddProductbutton.ForeColor = Color.White;
            AddProductbutton.Location = new Point(321, 449);
            AddProductbutton.Name = "AddProductbutton";
            AddProductbutton.Size = new Size(191, 32);
            AddProductbutton.TabIndex = 9;
            AddProductbutton.Text = "Add Product";
            AddProductbutton.UseVisualStyleBackColor = false;
            AddProductbutton.Click += AddProductbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Cursor = Cursors.Hand;
            Cancelbutton.FlatStyle = FlatStyle.Flat;
            Cancelbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Cancelbutton.Location = new Point(224, 449);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(75, 32);
            Cancelbutton.TabIndex = 8;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // DescriptiontextBox
            // 
            DescriptiontextBox.Font = new Font("Segoe UI", 11F);
            DescriptiontextBox.Location = new Point(224, 354);
            DescriptiontextBox.Multiline = true;
            DescriptiontextBox.Name = "DescriptiontextBox";
            DescriptiontextBox.Size = new Size(412, 76);
            DescriptiontextBox.TabIndex = 7;
            // 
            // ReorderQtytextBox
            // 
            ReorderQtytextBox.Font = new Font("Segoe UI", 11F);
            ReorderQtytextBox.Location = new Point(464, 289);
            ReorderQtytextBox.Name = "ReorderQtytextBox";
            ReorderQtytextBox.Size = new Size(172, 27);
            ReorderQtytextBox.TabIndex = 6;
            // 
            // UnitPricetextBox
            // 
            UnitPricetextBox.Font = new Font("Segoe UI", 11F);
            UnitPricetextBox.Location = new Point(224, 289);
            UnitPricetextBox.Name = "UnitPricetextBox";
            UnitPricetextBox.Size = new Size(172, 27);
            UnitPricetextBox.TabIndex = 5;
            // 
            // MinimumStockLeveltextBox
            // 
            MinimumStockLeveltextBox.Font = new Font("Segoe UI", 11F);
            MinimumStockLeveltextBox.Location = new Point(464, 220);
            MinimumStockLeveltextBox.Name = "MinimumStockLeveltextBox";
            MinimumStockLeveltextBox.Size = new Size(172, 27);
            MinimumStockLeveltextBox.TabIndex = 4;
            // 
            // CurrentStocktextBox
            // 
            CurrentStocktextBox.Font = new Font("Segoe UI", 11F);
            CurrentStocktextBox.Location = new Point(224, 220);
            CurrentStocktextBox.Name = "CurrentStocktextBox";
            CurrentStocktextBox.Size = new Size(172, 27);
            CurrentStocktextBox.TabIndex = 3;
            // 
            // SKUtextBox
            // 
            SKUtextBox.Font = new Font("Segoe UI", 11F);
            SKUtextBox.Location = new Point(224, 148);
            SKUtextBox.Name = "SKUtextBox";
            SKUtextBox.Size = new Size(172, 27);
            SKUtextBox.TabIndex = 1;
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Font = new Font("Segoe UI", 11F);
            ProductNametextBox.Location = new Point(224, 80);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(412, 27);
            ProductNametextBox.TabIndex = 0;
            ProductNametextBox.TextChanged += ProductNametextBox_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // sucsusspanellabel
            // 
            sucsusspanellabel.AutoSize = true;
            sucsusspanellabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sucsusspanellabel.ForeColor = Color.ForestGreen;
            sucsusspanellabel.Location = new Point(17, 20);
            sucsusspanellabel.Name = "sucsusspanellabel";
            sucsusspanellabel.Size = new Size(114, 20);
            sucsusspanellabel.TabIndex = 0;
            sucsusspanellabel.Text = "Added Product";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 604);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Add_Product";
            Text = "Add_Product";
            Load += Add_Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sucsusspanel.ResumeLayout(false);
            sucsusspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox ProductNametextBox;
        private TextBox ReorderQtytextBox;
        private TextBox UnitPricetextBox;
        private TextBox MinimumStockLeveltextBox;
        private TextBox CurrentStocktextBox;
        private TextBox SKUtextBox;
        private Button AddProductbutton;
        private Button Cancelbutton;
        private TextBox DescriptiontextBox;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ErrorProvider errorProvider1;
        private ComboBox CategorycomboBox;
        private Button Updatebutton;
        private PictureBox pictureBox2;
        private Panel sucsusspanel;
        private Label sucsusspanellabel;
    }
}