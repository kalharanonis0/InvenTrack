using InvenTrack.Forms;
namespace InvenTrack
{
    public partial class Form1 : Form

    {
        
        
        
        
        
        
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void AllProductsbutton_Click(object sender, EventArgs e)
        {
            All_Products all_Products = new All_Products();
            all_Products.TopLevel = false;
            all_Products.FormBorderStyle = FormBorderStyle.None;
            all_Products.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(all_Products);
            all_Products.Show();
        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.TopLevel = false;
            add_Product.FormBorderStyle = FormBorderStyle.None;
            add_Product.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(add_Product);
            add_Product.Show();
        }

        private void Categoriesbutton_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.TopLevel = false;
            categories.FormBorderStyle = FormBorderStyle.None;
            categories.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(categories);
            categories.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(home);
            home.Show();
        }

        private void Billingbutton_Click(object sender, EventArgs e)
        {
            billingForm billingForm = new billingForm();
            billingForm.TopLevel = false;
            billingForm.FormBorderStyle = FormBorderStyle.None;
            billingForm.Dock = DockStyle.Fill;
            bodypanel.Controls.Clear();
            bodypanel.Controls.Add(billingForm);
            billingForm.Show();
        }
    }
}
