using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCS
{
    public partial class Products : ChildForm
    {
        private BindingSource bsrc = new BindingSource();
        DataTable table = null;

        public Products(SqlConnection sql, ToolStripMenuItem menu): base(sql, menu) {
            InitializeComponent();
            this.cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Products_Load(object sender, EventArgs e)
        {
        }

        protected override void load()
        {
            //
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT productid, productname, companyname, categoryname, unitprice, discontinued, S.supplierid, C.categoryid"
            + " FROM Production.Products P INNER JOIN Production.Suppliers S ON P.supplierid = S.supplierid"
            + " INNER JOIN Production.Categories C ON P.categoryid = C.categoryid", conn);

            // A table mapping names the DataTable.
            table = new DataTable();
            adapter.Fill(table);
            bsrc.DataSource = table;
            dataView.DataSource = bsrc;

            dataView.Columns[0].HeaderText = "ID";
            dataView.Columns[1].HeaderText = "Name";
            dataView.Columns[2].HeaderText = "Supplier";
            dataView.Columns[3].HeaderText = "Category";
            dataView.Columns[4].HeaderText = "Unit Price";
            dataView.Columns[5].HeaderText = "Discontinued";
            dataView.Columns[6].Visible = false;
            dataView.Columns[7].Visible = false;

            // Init Cat combobox
            SqlDataAdapter catAdt = new SqlDataAdapter("SELECT categoryid, categoryname"
           + " FROM Production.Categories", conn);
            DataTable catTab = new DataTable();
            catAdt.Fill(catTab);
            cbCat.DataSource = catTab;
            cbCat.DisplayMember = "categoryname";
            cbCat.ValueMember = "categoryid";

            // Init Suppliers combobox
            SqlDataAdapter supAdt = new SqlDataAdapter("SELECT supplierid, companyname"
           + " FROM Production.Suppliers", conn);
            DataTable supTab = new DataTable();
            supAdt.Fill(supTab);
            cbSupplier.DataSource = supTab;
            cbSupplier.DisplayMember = "companyname";
            cbSupplier.ValueMember = "supplierid";
        }

        private bool validate(out decimal unitPrice)
        {
            bool error = false;
            if (!decimal.TryParse(this.txUnitPrice.Text, out unitPrice))
            {
                this.errors.SetError(this.txUnitPrice, "Please enter a valid decimal number.");
                error = true;
            }

            if (this.txName.Text == "")
            {
                this.errors.SetError(this.txName, "Please enter name.");
                error = true;
            }

            if (!error)
            {
                this.errors.Clear();
            }

            return !error;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updateControlStates()
        {
            bool selEmpty = this.dataView.SelectedRows.Count == 0;
            this.btnDelete.Enabled = !selEmpty;
            this.btnUpdate.Enabled = !selEmpty;

            if (!selEmpty)
            {
                DataGridViewRow srow = this.dataView.SelectedRows[0];
                this.lblIdValue.Text = srow.Cells[0].Value.ToString();
                this.txName.Text = srow.Cells[1].Value.ToString();
                this.txUnitPrice.Text = srow.Cells[4].Value.ToString();
                this.ckDiscontinued.Checked = (bool)srow.Cells[5].Value;
                this.cbSupplier.SelectedValue = srow.Cells[6].Value;
                this.cbCat.SelectedValue = srow.Cells[7].Value;
            }
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            updateControlStates();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dataView.ClearSelection();
            this.txName.Text = "";
            this.txUnitPrice.Text = "";
            this.cbCat.SelectedIndex = -1;
            this.cbSupplier.SelectedIndex = -1;
            this.ckDiscontinued.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal unitPrice;
            if (validate(out unitPrice)) {
                SqlCommand cmd = new SqlCommand("addNewProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", this.txName.Text));
                cmd.Parameters.Add(new SqlParameter("@supplierid", this.cbSupplier.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@catid", this.cbCat.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@unitprice", unitPrice));
                cmd.Parameters.Add(new SqlParameter("@discontinued", this.ckDiscontinued.Checked));
                cmd.ExecuteNonQuery();

                load();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal unitPrice;
            if (validate(out unitPrice))
            {
                SqlCommand cmd = new SqlCommand("updateProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", this.txName.Text));
                cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.lblIdValue.Text)));
                cmd.Parameters.Add(new SqlParameter("@supplierid", this.cbSupplier.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@catid", this.cbCat.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@unitprice", unitPrice));
                cmd.Parameters.Add(new SqlParameter("@discontinued", this.ckDiscontinued.Checked));
                cmd.ExecuteNonQuery();

                load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete?",
                "Confirm delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in this.dataView.SelectedRows)
                {
                    SqlCommand cmd = new SqlCommand("deleteProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", r.Cells[0].Value));
                    cmd.ExecuteNonQuery();

                    this.dataView.Rows.RemoveAt(r.Index);
                    this.dataView.Update();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("searchProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", txtSearch.Text));
            table.Clear();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                table.Rows.Add((int)r[0], r[1].ToString(), r[2].ToString(), r[3].ToString(), (decimal)r[4], (bool)r[5], (int)r[6], (int)r[7]);
            }
            r.Close();
        }
    }
}
