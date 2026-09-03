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
    public partial class All_Products : Form
    {
        public All_Products()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void All_Products_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadData();
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


                    string query = @"SELECT * FROM Product WHERE CAST(Id AS VARCHAR) LIKE'" + searchName + "' OR ProductName LIKE '" + searchName + "' OR SKU LIKE '" + searchName + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    AddProductDataGridView.DataSource = dt;

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

        private void LoadCategories()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT Id, CategoryName FROM Category";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                guna2ComboBox1.DataSource = dt;
                guna2ComboBox1.DisplayMember = "CategoryName";
                guna2ComboBox1.ValueMember = "Id";
            }
        }

        private void LoadData()
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {

                conn.Open();
                string query = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                SqlDataReader sdr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                AddProductDataGridView.DataSource = dt;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            LoadCategories();
            LoadData();
        }
    }
}
