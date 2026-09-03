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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void addCategorybutton_Click(object sender, EventArgs e)
        {
            body_panel_add.Visible = true;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            body_panel_add.Visible = false;
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                string newCategory = CategoryPagetextBox.Text;
                conn.Open();
                string query = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                SqlDataReader sdr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
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

        private void AddCategorybtn_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                string newCategory = CategoryPagetextBox.Text;



                conn.Open();
                string query = "INSERT INTO Category(Categoryname) VALUES('" + newCategory + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

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

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                string newCategory = CategoryPagetextBox.Text;
                conn.Open();
                string query = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                SqlDataReader sdr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
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
}
