using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using InvenTrack.Forms;

namespace InvenTrack.Forms
{


    public partial class Add_Product : Form
    {

        //Update_Product updateProduct = new Update_Product();
        public Add_Product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {
            validation();
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                string Product_Name = ProductNametextBox.Text;
                string SKU = SKUtextBox.Text;
                string Category = CategorycomboBox.Text;
                int Current_Stock = Convert.ToInt32(CurrentStocktextBox.Text);
                int Minimum_Stock_Level = Convert.ToInt32(MinimumStockLeveltextBox.Text);
                decimal Unit_Price = Convert.ToDecimal(UnitPricetextBox.Text);
                int Reorder_Qty = Convert.ToInt32(ReorderQtytextBox.Text);
                string Description = DescriptiontextBox.Text;



                conn.Open();
                string query = "INSERT INTO Product(ProductName,SKU,Category,CurrentStock,MinimumStockLevel,UnitPrice,ReorderQty,Description) VALUES('" + Product_Name + "','" + SKU + "','" + Category + "'," + Current_Stock + "," + Minimum_Stock_Level + "," + Unit_Price + "," + Reorder_Qty + ",'" + Description + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();


                ProductNametextBox.Clear();
                SKUtextBox.Clear();
                CurrentStocktextBox.Clear();
                MinimumStockLeveltextBox.Clear();
                UnitPricetextBox.Clear();
                ReorderQtytextBox.Clear();
                DescriptiontextBox.Clear();

                sucsusspanel.Visible = true;
                sucsusspanel.BackColor = Color.PaleGreen;
                sucsusspanellabel.Text = "Added Product !";
                sucsusspanellabel.ForeColor = Color.ForestGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. !  " + ex.Message);
                sucsusspanel.Visible = true;
                sucsusspanel.BackColor = Color.LightSalmon;
                sucsusspanellabel.Text = "Not Added !";
                sucsusspanellabel.ForeColor=Color.Red;
                
            }
            finally
            {
                conn.Close();
            }

        }
        public void validation()
        {
            string Product_Name = ProductNametextBox.Text;
            if (Product_Name == "") { errorProvider1.SetError(ProductNametextBox, "Enter value !"); }
            else { errorProvider1.SetError(ProductNametextBox, ""); }

            string SKU = SKUtextBox.Text;
            if (SKU == "") { errorProvider1.SetError(SKUtextBox, "Enter value !"); }
            else { errorProvider1.SetError(SKUtextBox, ""); }

            string Category = CategorycomboBox.Text;
            if (Category == "") { errorProvider1.SetError(CategorycomboBox, "Enter value !"); }
            else { errorProvider1.SetError(CategorycomboBox, ""); }

            string Current_Stock = CurrentStocktextBox.Text;
            if (Current_Stock == "") { errorProvider1.SetError(CurrentStocktextBox, "Enter value !"); }
            else { errorProvider1.SetError(CurrentStocktextBox, ""); }

            string Minimum_Stock_Level = MinimumStockLeveltextBox.Text;
            if (Minimum_Stock_Level == "") { errorProvider1.SetError(MinimumStockLeveltextBox, "Enter value !"); }
            else { errorProvider1.SetError(MinimumStockLeveltextBox, ""); }

            string Unit_Price = UnitPricetextBox.Text;
            if (Unit_Price == "") { errorProvider1.SetError(UnitPricetextBox, "Enter value !"); }
            else { errorProvider1.SetError(UnitPricetextBox, ""); }

            string Reorder_Qty = ReorderQtytextBox.Text;


            string Description = DescriptiontextBox.Text;



        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            ProductNametextBox.Clear();
            errorProvider1.SetError(ProductNametextBox, "");
            SKUtextBox.Clear();
            errorProvider1.SetError(SKUtextBox, "");
            //CategorycomboBox.
            errorProvider1.SetError(CategorycomboBox, "");
            CurrentStocktextBox.Clear();
            errorProvider1.SetError(CurrentStocktextBox, "");
            MinimumStockLeveltextBox.Clear();
            UnitPricetextBox.Clear();
            ReorderQtytextBox.Clear();
            DescriptiontextBox.Clear();
            errorProvider1.SetError(UnitPricetextBox, "");
            errorProvider1.SetError(MinimumStockLeveltextBox, "");

            sucsusspanel.Visible = false;
        }

        private void LoadCategories()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT Id, CategoryName FROM Category";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                CategorycomboBox.DataSource = dt;
                CategorycomboBox.DisplayMember = "CategoryName";
                CategorycomboBox.ValueMember = "Id";
            }
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            LoadCategories();
            sucsusspanel.Visible = false;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Update_Product updateProduct = new Update_Product();
            updateProduct.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            LoadCategories();
            //updateProduct.Refresh();
        }

        private void ProductNametextBox_TextChanged(object sender, EventArgs e)
        {
            sucsusspanel.Visible=false;
        }
    }
}
