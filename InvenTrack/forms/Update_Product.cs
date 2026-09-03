using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvenTrack.Forms
{
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            LoadCategories();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {

                string conString = Properties.Settings.Default.conString;
                SqlConnection conn = new SqlConnection(conString);
                try
                {
                    conn.Open();

                    string searchName = guna2TextBox1.Text.Trim();


                    string query = "SELECT * FROM Product WHERE CAST(Id AS VARCHAR) LIKE'" + searchName + "' OR ProductName LIKE '" + searchName + "' OR SKU LIKE '" + searchName + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    guna2DataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.. !  " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();

                int productId = Convert.ToInt32(guna2TextBox1.Text);
                int newstock = Convert.ToInt32(textBox2.Text);
                decimal newprice = Convert.ToDecimal(textBox3.Text);

                bool up = radioButton1.Checked;
                bool doun = radioButton2.Checked;

                if (up)
                {
                    string query = "UPDATE Product SET CurrentStock = CurrentStock + " + newstock + " , UnitPrice ="+ newprice + " WHERE Id = " + productId + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    guna2DataGridView1.DataSource = dt;
                    LoadCategories();
                }

                if (doun)
                {
                    string query = "UPDATE Product SET CurrentStock = CurrentStock - " + newstock + " , UnitPrice ="+ newprice + " WHERE Id = " + productId + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    guna2DataGridView1.DataSource = dt;

                }

                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. !  " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {

                string conString = Properties.Settings.Default.conString;
                SqlConnection conn = new SqlConnection(conString);
                try
                {
                    conn.Open();

                    string searchName = guna2TextBox1.Text.Trim();

                    DialogResult result = MessageBox.Show("Are You sure You want to Delete this?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Product WHERE CAST(Id AS VARCHAR) LIKE'" + searchName + "' OR ProductName LIKE '" + searchName + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader rd = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        guna2DataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.. !  " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
