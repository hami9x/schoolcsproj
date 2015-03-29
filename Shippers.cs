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
    public partial class Shippers : ChildForm
    {
        SqlConnection con;
        SqlCommand cmd;

        public Shippers(SqlConnection sql, ToolStripMenuItem menu): base(sql, menu)
        {
            con = conn;
            InitializeComponent();
            initADO();
            loadShipperInfo();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        protected override void load()
        {
            loadShipperInfo();
        }

        void initADO()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        void loadShipperInfo()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "loadShipperInfo";
            SqlDataReader dr = c.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
        }

        bool validateInput()
        {
            bool error = false;
            if (txtCompanyNameShipper.Text.Length == 0 || txtCompanyNameShipper.Text.Length > 40)
            {
                error = true;
                errorProvider1.SetError(txtCompanyNameShipper, "Please fill this blank!");
            }

            if (mtbxPhoneShipper.Text.Length == 0 || mtbxPhoneShipper.Text.Length > 24)
            {
                error = true;
                errorProvider1.SetError(mtbxPhoneShipper, "Please fill this blank!");
            }

            if (error == true)
                return false;
            else
            {
                errorProvider1.Clear();
            }
            return true;
        }

        void addNewShipper()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "addNewShipper";
            SqlParameter param = new SqlParameter("@companyname", SqlDbType.NVarChar, 40);
            param.Value = txtCompanyNameShipper.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
            param.Value = mtbxPhoneShipper.Text;
            c.Parameters.Add(param);

            c.ExecuteNonQuery();
            searchByShipperName();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
                return;
            else
            {
                addNewShipper();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                lbID.Text = r.Cells[0].Value.ToString();
                txtCompanyNameShipper.Text = r.Cells[1].Value.ToString();
                mtbxPhoneShipper.Text = r.Cells[2].Value.ToString();
            }
        }

        void updateShipper()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "updateShipper";
            SqlParameter param = new SqlParameter("@companyname", SqlDbType.NVarChar, 40);
            param.Value = txtCompanyNameShipper.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
            param.Value = mtbxPhoneShipper.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@shipperid", SqlDbType.Int);
            param.Value = lbID.Text;
            c.Parameters.Add(param);

            c.ExecuteNonQuery();
            searchByShipperName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
                return;
            else
            {
                updateShipper();
            }
        }

        void deleteShipper()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "deleteShipper";
            SqlParameter param = new SqlParameter("@shipperid", SqlDbType.Int);
            param.Value = lbID.Text;
            c.Parameters.Add(param);
            c.ExecuteNonQuery();
            loadShipperInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure???", "Confirm", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            else
            {
                deleteShipper();
                clearAllText();
            }
        }

        void clearAllText()
        {
            lbID.ResetText();
            txtCompanyNameShipper.Clear();
            mtbxPhoneShipper.Clear();
            txtSearchShipper.Clear();
            txtCompanyNameShipper.Focus();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            loadShipperInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllText();
        }

        void searchByShipperName()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "searchByShipperName";
            SqlParameter param = new SqlParameter("@companyname", SqlDbType.NVarChar, 40);
            param.Value = txtSearchShipper.Text;
            c.Parameters.Add(param);

            SqlDataReader dr = c.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchByShipperName();
        }



    }
}
