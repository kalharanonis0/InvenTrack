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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Categorycount();
            currentStock();

            double InventoryValue = Convert.ToDouble(currentStockRe() * UnitPrice());
            InventoryValueStatus.Text = InventoryValue.ToString();

            inventryprogess();
            dataviwe();
            CheckLowStock();
        }

        private void Categorycount()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT COUNT(*) FROM Category";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                int categoryCount = Convert.ToInt32(command.ExecuteScalar());

                Categorycountlabel.Text = categoryCount.ToString();
            }
        }



        private void currentStock()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT SUM(CurrentStock) FROM Product";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                int currentStock = Convert.ToInt32(command.ExecuteScalar());

                currentStockstatus.Text = currentStock.ToString();
            }
        }

        private int currentStockRe()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT SUM(CurrentStock) FROM Product";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                int currentStock = Convert.ToInt32(command.ExecuteScalar());

                return currentStock;
            }
        }

        private decimal UnitPrice()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT SUM(UnitPrice) FROM Product";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                decimal UnitPricek = Convert.ToDecimal(command.ExecuteScalar());

                int price = Convert.ToInt32(UnitPricek);
                return price;
            }
        }


        private void inventryprogess()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT CurrentStock,MinimumStockLevel FROM Product";

                using (SqlCommand command = new SqlCommand(query, conn))
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    int lowStockCount = 0;
                    int equalStockCount = 0;
                    int highStockCount = 0;
                    while (rd.Read())
                    {
                        int currentStock = Convert.ToInt32(rd["CurrentStock"]);
                        int minimumStock = Convert.ToInt32(rd["MinimumStockLevel"]);

                        if (currentStock == 0)
                        {
                            equalStockCount++;
                        }
                        else if (0 < currentStock && currentStock <= minimumStock)
                        {
                            lowStockCount++;
                        }
                        else { highStockCount++; }
                    }

                    highStockCountstates.Text = highStockCount.ToString();
                    equalStockCountstates.Text = equalStockCount.ToString();
                    lowStockCountstates.Text = lowStockCount.ToString();

                    guna2vProgressBar1.Maximum = productcount();
                    guna2vProgressBar1.Value = highStockCount;
                    guna2vProgressBar2.Maximum = productcount();
                    guna2vProgressBar2.Value = equalStockCount;
                    guna2vProgressBar3.Maximum = productcount();
                    guna2vProgressBar3.Value = lowStockCount;


                }


            }
        }

        private void dataviwe()
        {
            string conString = Properties.Settings.Default.conString;

            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                string query = "SELECT ID,ProductName,CurrentStock,MinimumStockLevel FROM Product";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                SqlDataReader rd = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                guna2DataGridView1.DataSource = dt;
                CheckLowStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


        }


        private void CheckLowStock()
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int currentStock = Convert.ToInt32(row.Cells["CurrentStock"].Value);
                int minimumStock = Convert.ToInt32(row.Cells["MinimumStockLevel"].Value);

                if (currentStock == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if(0 < currentStock && currentStock <= minimumStock)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }


        private int productcount()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT COUNT(*) FROM Product";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                int Count = Convert.ToInt32(command.ExecuteScalar());

                return Count;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Categorycount();
            currentStock();

            double InventoryValue = Convert.ToDouble(currentStockRe() * UnitPrice());
            InventoryValueStatus.Text = InventoryValue.ToString();

            inventryprogess();
            dataviwe();
            CheckLowStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckLowStock();
        }
    }
}

