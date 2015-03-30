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

namespace WindowsFormsApplication7
{
    public partial class Orders : ChildForm
    {
        SqlConnection con;
        SqlCommand gCmd;
    
        public Orders(SqlConnection sql, ToolStripMenuItem menu)
            : base(sql, menu)
        {
            con = conn;
            InitializeComponent();
            initADO();
        }

        private void loadComboboxes()
        {
            SqlDataAdapter adt = new SqlDataAdapter("SELECT custid, (contactname + '(' + CAST(custid AS VARCHAR(10)) + ') ') AS name"
           + " FROM Sales.Customers", conn);
            DataTable tab = new DataTable();
            adt.Fill(tab);
            this.cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCustomer.DataSource = tab;
            this.cbCustomer.DisplayMember = "name";
            this.cbCustomer.ValueMember = "custid";

            adt = new SqlDataAdapter("SELECT empid, (lastname + ' ' + firstname + '(' + CAST(empid AS VARCHAR(10)) + ') ') AS name"
            + " FROM HR.Employees", conn);
            tab = new DataTable();
            adt.Fill(tab);
            this.cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbEmployee.DataSource = tab;
            this.cbEmployee.DisplayMember = "name";
            this.cbEmployee.ValueMember = "empid";

            adt = new SqlDataAdapter("SELECT shipperid, companyname"
            + " FROM Sales.Shippers", conn);
            tab = new DataTable();
            adt.Fill(tab);
            this.cbShipper.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbShipper.DataSource = tab;
            this.cbShipper.DisplayMember = "companyname";
            this.cbShipper.ValueMember = "shipperid";
        }

        protected override void load()
        {
            loadOrdersInfo();
            loadComboboxes();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            addOrders();
        }

        void addOrders()
        {
           SqlCommand cmd = gCmd.Clone();
            cmd.CommandText = "addOrders";

            SqlParameter param = new SqlParameter("@custid", SqlDbType.Int);
            param.Value = 3;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@empid", SqlDbType.Int);
            param.Value = 5;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@orderdate", SqlDbType.DateTime);
            param.Value = "5";
            cmd.Parameters.Add(param);


            param = new SqlParameter("@requireddate", SqlDbType.DateTime);
            param.Value = "6";
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shippeddate", SqlDbType.DateTime);
            param.Value = lbShippeddate;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shipperid", SqlDbType.Int);
            param.Value = 1;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@freight", SqlDbType.Money);
            param.Value = txtFreight.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shipname", SqlDbType.NVarChar, 40);
            param.Value = txtShipname.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shipaddress", SqlDbType.NVarChar, 60);
            param.Value = txtShipaddress.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shicity", SqlDbType.NVarChar, 15);
            param.Value = txtShipcity.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shipregion", SqlDbType.NVarChar, 15);
            param.Value = txtShipregion.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shippostalcode", SqlDbType.NVarChar, 10);
            param.Value = txtShippostalcode.Text;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@shipcountry", SqlDbType.NVarChar, 15);
            param.Value = txtShipcountry.Text;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
        }



            void initADO()
        {
            gCmd = new SqlCommand();
            gCmd.Connection = con;
            gCmd.CommandType = CommandType.StoredProcedure;
        }


            void loadOrdersInfo()
            {
                try
                {
                    SqlCommand cmd = gCmd.Clone();
                    cmd.CommandText = "loadOrdersInfo";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dr.GetDateTime(3).ToShortDateString();
                        dr.GetDateTime(4).ToShortDateString();
                        dr.GetDateTime(5).ToShortDateString();
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                            dr[3], dr[4], dr[5], dr[6].ToString(), dr[7].ToString(),
                            dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

            void updateOrders()
            {
                try
                {
                    SqlCommand cmd = gCmd.Clone();
                    cmd.CommandText = "updateOrders";
                    SqlParameter param = new SqlParameter("@orderid", SqlDbType.Int);
                    param.Value = dataGridView1.SelectedRows[0].Cells[0].Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@custid", SqlDbType.Int);
                    param.Value = cbCustomer.SelectedValue;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@empid", SqlDbType.Int);
                    param.Value = cbEmployee.SelectedValue;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@orderdate", SqlDbType.DateTime);
                    param.Value = dtOrderDate.Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@requireddate", SqlDbType.DateTime);
                    param.Value = dtRequiredDate.Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shippeddate", SqlDbType.DateTime);
                    param.Value = dtShippedDate.Value;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipperid", SqlDbType.Int);
                    param.Value = cbShipper.SelectedValue;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@freight", SqlDbType.Money);
                    param.Value = txtFreight.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipname", SqlDbType.NVarChar, 40);
                    param.Value = txtShipname.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipaddress", SqlDbType.NVarChar, 60);
                    param.Value = txtShipaddress.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipcity", SqlDbType.NVarChar, 15);
                    param.Value = txtShipcity.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipregion", SqlDbType.NVarChar, 15);
                    param.Value = txtShipname.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shippostalcode", SqlDbType.NVarChar, 10);
                    param.Value = txtShippostalcode.Text;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter("@shipcountry", SqlDbType.NVarChar, 15);
                    param.Value = txtShipcountry.Text;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }


            }

         bool validateInput()
        {
            bool error = false;
            if (txtShipname.Text.Length == 0 || txtShipname.Text.Length > 40)
            {
                error = true;
                errorProvider1.SetError(txtShipname, "Please enter your Ship Name!");
            }

            if (txtShipaddress.Text.Length == 0 || txtShipaddress.Text.Length > 60)
            {
                error = true;
                errorProvider1.SetError(txtShipaddress, "Please enter your Ship Address!");
            }

             
            if (txtShipcity.Text.Length == 0 || txtShipcity.Text.Length > 15)
            {
                error = true;
                errorProvider1.SetError(txtShipcity, "Please enter your Ship City!");
            }
             
            if (txtShipregion.Text.Length == 0 || txtShipregion.Text.Length > 10)
            {
                error = true;
                errorProvider1.SetError(txtShipregion, "Out Of Range!");
            }
             
            if (txtShippostalcode.Text.Length == 0 || txtShippostalcode.Text.Length > 10)
            {
                error = true;
                errorProvider1.SetError(txtShippostalcode, "Out Of Range!");
            }

             if (txtShipcountry.Text.Length == 0 || txtShipcountry.Text.Length > 15)
            {
                error = true;
                errorProvider1.SetError(txtShipcountry, "Please enter your Ship Country!");
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
             bool selEmpty = this.dataGridView1.SelectedRows.Count == 0;
             this.btnDelete.Enabled = !selEmpty;
             this.btnUpdate.Enabled = !selEmpty;
             this.btnAdd.Enabled = selEmpty;

             if (dataGridView1.SelectedRows.Count > 0)
             {
                 DataGridViewRow r = dataGridView1.SelectedRows[0];
                 this.lbOrderIdValue.Text = r.Cells[0].Value.ToString();
                 cbCustomer.SelectedValue = r.Cells[1].Value;
                 cbEmployee.SelectedValue = r.Cells[2].Value;
                 dtOrderDate.Value = (DateTime)r.Cells[3].Value;
                 dtRequiredDate.Value = (DateTime)r.Cells[4].Value;
                 dtShippedDate.Value = (DateTime)r.Cells[5].Value;
                 cbShipper.SelectedValue = r.Cells[6].Value;
                 txtFreight.Text = r.Cells[7].Value.ToString();
                 txtShipname.Text = r.Cells[8].Value.ToString();
                 txtShipaddress.Text = r.Cells[9].Value.ToString();
                 txtShipcity.Text = r.Cells[10].Value.ToString();
                 txtShipregion.Text = r.Cells[11].Value.ToString();
                 txtShippostalcode.Text = r.Cells[12].Value.ToString();
                 txtShipcountry.Text = r.Cells[13].Value.ToString();
                 errorProvider1.Clear();

             }

         }

         private void btnUpdate_Click(object sender, EventArgs e)
         {
             if (validateInput() == false)
                 return;
             else
             {
                 updateOrders();
             }

         }

         void deleteOrders()
         {
             try
             {
                 SqlCommand cmd = gCmd.Clone();
                 cmd.CommandText = "deleteOrders";
                 SqlParameter param = new SqlParameter("@orderid", SqlDbType.Int);
                 param.Value = lborderid.Text;
                 cmd.Parameters.Add(param);

                 cmd.ExecuteNonQuery();
                 loadOrdersInfo();
                 btnAdd.Enabled = true;
                 btnUpdate.Enabled = true;
                 btnDelete.Enabled = true;
             }
             catch (Exception ee)
             {
                 MessageBox.Show(ee.Message);
             }
         }

         private void btnDelete_Click(object sender, EventArgs e)
         {
             DialogResult dr = MessageBox.Show("Are you sure???", "Confirm", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
             if (dr == DialogResult.Yes)
             {
                 deleteOrders();
                 
             }

         }

         private void btnClear_Click(object sender, EventArgs e)
         {
             this.dataGridView1.ClearSelection();
             txtFreight.Text = "";
             txtShipname.Text = "";
             txtShipaddress.Text = "";
             txtShipcity.Text = "";
             txtShipregion.Text = "";
             txtShippostalcode.Text = "";
             txtShipcountry.Text = "";
             errorProvider1.Clear();
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

        
    }
}
