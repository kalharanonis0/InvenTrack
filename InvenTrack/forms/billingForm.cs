using Guna.UI2.WinForms;
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
    public partial class billingForm : Form
    {

        public billingForm()
        {
            InitializeComponent();
        }

        private void billingForm_Load(object sender, EventArgs e)
        {
            Lastbillid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                string conString = Properties.Settings.Default.conString;
                SqlConnection conn = new SqlConnection(conString);
                try
                {
                    conn.Open();
                    string searchtext = searchTextBox.Text.Trim();
                    string query = "SELECT ProductName,SKU,CurrentStock,UnitPrice FROM Product WHERE ProductName LIKE '" + searchtext + "' OR SKU LIKE '" + searchtext + "' ";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.CommandType = CommandType.Text;
                    SqlDataReader sdr = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    //ProductName1 = Convert.ToString(sdr["ProductName"]);
                    //UnitPrice1 = Convert.ToDecimal(sdr["UnitPrice"]);
                    dt.Load(sdr);
                    searchDataGridView.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Error..! " + ex.Message); }
                finally { conn.Close(); }

            }
        }

        private void AddItemBillButton_Click(object sender, EventArgs e)
        {

            if (searchTextBox.Text != "")
            {
                string conString = Properties.Settings.Default.conString;
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string searchtext = searchTextBox.Text.Trim();
                    string query = "SELECT ProductName,UnitPrice FROM Product WHERE ProductName LIKE '" + searchtext + "' OR SKU LIKE '" + searchtext + "' ";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        string ProductName1;
                        decimal UnitPrice1;

                        while (sdr.Read())
                        {

                            ProductName1 = Convert.ToString(sdr["ProductName"]);
                            UnitPrice1 = Convert.ToDecimal(sdr["UnitPrice"]);

                            LoadData(ProductName1, UnitPrice1);
                            totleAmount();
                        }
                    }


                }

            }
        }

        private void LoadData(string ProductName1, decimal UnitPrice1)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                conn.Open();
                string customerName = CustomerNametextBox.Text;
                int qty = Convert.ToInt32(QtytextBox.Text);
                int billid = Convert.ToInt32(billidtextBox.Text);
                decimal SubTotal = qty * UnitPrice1;
                string query2 = "INSERT INTO BillItems(CustomerName,BillID,ProductName,Qty,UnitPrice,SubTotal) VALUES('" + customerName + "','" + billid + "','" + ProductName1 + "'," + qty + "," + UnitPrice1 + "," + SubTotal + ")";
                SqlCommand command1 = new SqlCommand(query2, conn);
                command1.CommandType = CommandType.Text;
                command1.ExecuteNonQuery();
                QtytextBox.Clear();

                string query = "UPDATE Product SET CurrentStock = CurrentStock - " + qty + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                searchDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. !  " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


            try
            {
                conn.Open();
                int billid = Convert.ToInt32(billidtextBox.Text);
                string query3 = "SELECT * FROM BillItems WHERE BillID LIKE '" + billid + "'";
                SqlCommand command2 = new SqlCommand(query3, conn);
                command2.CommandType = CommandType.Text;
                SqlDataReader sdr = command2.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                billDataGridView.DataSource = dt;

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


        private void Lastbillid()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "SELECT TOP 1 BillID FROM BillItems ORDER BY BillID DESC";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                int Lastbillid = Convert.ToInt32(command.ExecuteScalar());
                int nextbillid = Lastbillid + 1;

                LastBillId.Text = Lastbillid.ToString();
                billidtextBox.Text = nextbillid.ToString();
            }
        }

        private void totleAmount()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                int billid = Convert.ToInt32(billidtextBox.Text);
                string query = "SELECT SUM(SubTotal) FROM BillItems WHERE BillID LIKE '" + billid + "'";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                decimal currentStock = Convert.ToDecimal(command.ExecuteScalar());

                TotalAmountlabel.Text = currentStock.ToString();
            }
        }

        private decimal totleAmountre()
        {
            string conString = Properties.Settings.Default.conString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                int billid = Convert.ToInt32(billidtextBox.Text);
                string query = "SELECT SUM(SubTotal) FROM BillItems WHERE BillID LIKE '" + billid + "'";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();

                decimal tamount = Convert.ToDecimal(command.ExecuteScalar());

                return tamount;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Lastbillid();
            //addbill();

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            decimal Customerpayse = Convert.ToDecimal(CustomerpaystextBox.Text);
            decimal Change = Customerpayse - totleAmountre();
            Changelabel.Text = Change.ToString();
        }

        private void addbill()
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection conn = new SqlConnection(conString);

            try
            {
                conn.Open();
                string customerName = CustomerNametextBox.Text;
                int billid = Convert.ToInt32(billidtextBox.Text);
                decimal Customerpayse = Convert.ToDecimal(CustomerpaystextBox.Text);
                decimal Change = Customerpayse - totleAmountre();
                decimal  totleAmountr = totleAmountre();


                //string query2 = "INSERT INTO BILL(BillID,CustomerName,Total,Paid,Change) VALUES(" + billid + ",'"+ customerName + "',"+ totleAmountr + ","+ Customerpayse + ","+ Change + ")";
                string query2 = "INSERT INTO BILL (BillID, CustomerName, Total, Paid, Change) VALUES (@billid, @customerName, @totleAmountr, @Customerpayse, @Change)";
                SqlCommand command1 = new SqlCommand(query2, conn);
                command1.CommandType = CommandType.Text;
                command1.ExecuteNonQuery();
                

               
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
