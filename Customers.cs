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
using ProjectCS;

namespace Project1
{
    public partial class Customers : ChildForm
    {
        SqlConnection con;
        SqlCommand gCmd;

        public Customers(SqlConnection sql, ToolStripMenuItem menu): base(sql, menu)
        {
            con = conn;
            InitializeComponent();
            initADO();
            loadCustomerInfo();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //txtCompanyName.Focus();
        }


        void initADO()
        {
            gCmd = new SqlCommand();
            gCmd.Connection = con;
            gCmd.CommandType = CommandType.StoredProcedure;
        }

        protected override void load()
        {
            loadCustomerInfo();
        }

        void loadCustomerInfo()
        {
            SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "loadCustomersInfo";
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                    dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
                    dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
        }

        void addNewCustomer()
        {
            SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "addNewCustomer";

            SqlParameter param = new SqlParameter("@companyname", SqlDbType.NVarChar, 40);
            param.Value = txtCompanyName.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@contactname", SqlDbType.NVarChar, 30);
            param.Value = txtContactName.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@contacttitle", SqlDbType.NVarChar, 30);
            param.Value = txtContactTitle.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@address", SqlDbType.NVarChar, 60);
            param.Value = txtAddress.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@city", SqlDbType.NVarChar, 15);
            param.Value = txtCity.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@region", SqlDbType.NVarChar, 15);
            param.Value = txtRegion.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@postalcode", SqlDbType.NVarChar, 10);
            param.Value = txtPostalCode.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@country", SqlDbType.NVarChar, 15);
            param.Value = txtCountry.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
            param.Value = mtbxPhone.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fax", SqlDbType.NVarChar, 24);
            param.Value = txtFax.Text;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            loadCustomerInfo();
            clearAllText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //btnUpdate.Enabled = false;
            if (validateInput() == false)
                return;
            else
            {
                addNewCustomer();
            }
        }

        bool validateInput()
        {
            bool error = false;
            if (txtCompanyName.Text.Length == 0 || txtCompanyName.Text.Length > 40)
            {
                error = true;
                errorProvider1.SetError(txtCompanyName, "Please enter your Comapany Name!");
            }

            if (txtContactName.Text.Length == 0 || txtContactName.Text.Length > 30)
            {
                error = true;
                errorProvider1.SetError(txtContactName, "Please enter your Contact Name!");
            }

            if (txtContactTitle.Text.Length == 0 || txtContactTitle.Text.Length > 30)
            {
                error = true;
                errorProvider1.SetError(txtContactTitle, "Please enter your Contact Title!");
            }

            if (txtAddress.Text.Length == 0 || txtAddress.Text.Length > 60)
            {
                error = true;
                errorProvider1.SetError(txtAddress, "Please enter your Address!");
            }

            if (txtCity.Text.Length == 0 || txtCity.Text.Length > 15)
            {
                error = true;
                errorProvider1.SetError(txtCity, "Please enter your City!");
            }

            if (txtRegion.Text.Length > 15)
            {
                error = true;
                errorProvider1.SetError(txtRegion, "Out of range!");
            }

            if (txtPostalCode.Text.Length > 10)
            {
                error = true;
                errorProvider1.SetError(txtPostalCode, "Out of range!");
            }

            if (txtCountry.Text.Length == 0 || txtCountry.Text.Length > 15)
            {
                error = true;
                errorProvider1.SetError(txtCountry, "Please enter your Country!");
            }

            if (mtbxPhone.Text.Length == 0 || mtbxPhone.Text.Length > 24)
            {
                error = true;
                errorProvider1.SetError(mtbxPhone, "Please enter your Phone Number!");
            }

            if (txtFax.Text.Length > 24)
            {
                error = true;
                errorProvider1.SetError(txtFax, "Out of range!");
            }

            if (error == true)
                return false;
            else
            {
                errorProvider1.Clear();
                
            }
            return true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                lbID.Text = r.Cells[0].Value.ToString();
                txtCompanyName.Text = r.Cells[1].Value.ToString();
                txtContactName.Text = r.Cells[2].Value.ToString();
                txtContactTitle.Text = r.Cells[3].Value.ToString();
                txtAddress.Text = r.Cells[4].Value.ToString();
                txtCity.Text = r.Cells[5].Value.ToString();
                txtRegion.Text = r.Cells[6].Value.ToString();
                txtPostalCode.Text = r.Cells[7].Value.ToString();
                txtCountry.Text = r.Cells[8].Value.ToString();
                mtbxPhone.Text = r.Cells[9].Value.ToString();
                txtFax.Text = r.Cells[10].Value.ToString();
                errorProvider1.Clear();
            }
        }

        void updateCustomer()
        {
            SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "updateCustomer";
            SqlParameter param = new SqlParameter("@companyname", SqlDbType.NVarChar, 40);
            param.Value = txtCompanyName.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@contactname", SqlDbType.NVarChar, 30);
            param.Value = txtContactName.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@contacttitle", SqlDbType.NVarChar, 30);
            param.Value = txtContactTitle.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@address", SqlDbType.NVarChar, 60);
            param.Value = txtAddress.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@city", SqlDbType.NVarChar, 15);
            param.Value = txtCity.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@region", SqlDbType.NVarChar, 15);
            param.Value = txtRegion.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@postalcode", SqlDbType.NVarChar, 10);
            param.Value = txtPostalCode.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@country", SqlDbType.NVarChar, 15);
            param.Value = txtCountry.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
            param.Value = mtbxPhone.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fax", SqlDbType.NVarChar, 24);
            param.Value = txtFax.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@custid", SqlDbType.Int);
            param.Value = lbID.Text;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            searchByCustomerName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
                return;
            else
            {
                updateCustomer();
            }
        }

        void clearAllText()
        {
            lbID.ResetText();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtRegion.Clear();
            txtPostalCode.Clear();
            txtCountry.Clear();
            mtbxPhone.Clear();
            txtFax.Clear();
            txtSearch.Clear();
            txtCompanyName.Focus();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllText();
            searchByCustomerName();
        }

        void deleteCustomer()
        {
            SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "deleteCustomer";
            SqlParameter param = new SqlParameter("@custid", SqlDbType.Int);
            param.Value = lbID.Text;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            loadCustomerInfo();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure???", "Confirm", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                deleteCustomer();
                clearAllText();
            }
        }

        void searchByCustomerName()
        {
            SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "searchByCustomerName";
            SqlParameter param = new SqlParameter("@contactname", SqlDbType.NVarChar, 40);
            param.Value = txtSearch.Text;
            cmd.Parameters.Add(param);

            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                    dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
                    dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchByCustomerName();
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.|| e.KeyChar > Keys.D9 && e.KeyChar != Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPostalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }


    }
}
