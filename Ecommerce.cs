using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Project1;
using Project;
using GroupProject_Employees;
using WindowsFormsApplication7;

namespace ProjectCS
{
    public partial class Ecommerce : Form
    {
        private Products productsWindow;
        private Customers customersWindow;
        private Shippers shippersWindow;
        private Categories catWindow;
        private Supplier suppliersWindow;
        private Employees empWindow;
        private Orders ordersWindow;
        private SqlConnection conn;

        public Ecommerce()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            conn.Open();

            productsWindow = new Products(conn, wdProducts);
            productsWindow.MdiParent = this;
            customersWindow = new Customers(conn, wdCustomers);
            customersWindow.MdiParent = this;
            shippersWindow = new Shippers(conn, wdShippers);
            shippersWindow.MdiParent = this;
            catWindow = new Categories(conn, wdCategories);
            catWindow.MdiParent = this;
            suppliersWindow = new Supplier(conn, wdSuppliers);
            suppliersWindow.MdiParent = this;
            empWindow = new Employees(conn, wdEmployees);
            empWindow.MdiParent = this;
            ordersWindow = new Orders(conn, wdOrders);
            ordersWindow.MdiParent = this;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                ChildForm f = (ChildForm)childForm;
                f.Close();
            }
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Ecommerce_Load(object sender, EventArgs e)
        {
        }

        private void Ecommerce_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                ChildForm f = (ChildForm)childForm;
                f.Stop();
            }
        }
    }
}
