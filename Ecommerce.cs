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

namespace ProjectCS
{
    public partial class Ecommerce : Form
    {
        private Products productsWindow;
        private Customers customersWindow;
        private Shippers shippersWindow;
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

    public class ChildForm : Form
    {
        private ToolStripMenuItem menu;
        protected SqlConnection conn;
        private bool running = true;
        public ChildForm()
        {
        }

        public ChildForm(SqlConnection conn, ToolStripMenuItem menu)
        {
            this.menu = menu;
            this.menu.CheckedChanged += new EventHandler(menu_CheckedChanged);
            this.conn = conn;
        }

        protected virtual void load() {}

        public void menu_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Visible && this.menu.Checked)
            {
                this.load();
                this.Visible = true;
            }

            if (this.Visible && !this.menu.Checked)
            {
                this.Hide();
            }
        }

        public void Stop()
        {
            running = false;
            this.Close();
        }



        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (!running)
            {
                return;
            }

            this.menu.Checked = false;
            e.Cancel = true;
        }
    }
}
