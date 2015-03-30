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

namespace GroupProject_Employees
{
    public partial class Employees : ChildForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

         public Employees(SqlConnection sql, ToolStripMenuItem menu)
            : base(sql, menu)
        {
            con = conn;
            InitializeComponent();
            InitializeADOObject();
            loadEmployees();
        }
        bool validateInput()
        {
            bool error = true;
            //string empID = txtempID.Text;
            //if (empID.Length == 0)
            //{
            //    errorProvider1.SetError(txtempID, "Please enter empID");
            //    error = false;
            //}

            string lastName = txtLastName.Text;
            if (lastName.Length == 0)
            {
                errorProvider1.SetError(txtLastName, "Please enter Last Name");
                error = false;
            }

            string firstName = txtFirstName.Text;
            if (firstName.Length == 0)
            {
                errorProvider1.SetError(txtFirstName, "Please enter First Name");
                error = false;
            }

            string title = txtTitle.Text;
            if (title.Length == 0)
            {
                errorProvider1.SetError(txtTitle, "Please enter Title");
                error = false;
            }

            string toc = txtTOC.Text;
            if (toc.Length == 0)
            {
                errorProvider1.SetError(txtTOC, "Please enter Title of Courtesy");
                error = false;
            }

            DateTime currDate = DateTime.Now;
            int currYear = currDate.Year;
            DateTime birthDate = dtpBirth.Value;
            int birthYear = birthDate.Year;
            if (currYear - birthYear < 18)
            {
                errorProvider1.SetError(dtpBirth, "Age must be greater than 18!");
                error = false;
            }

            DateTime hireDate = dtpHire.Value;
            int hireYear = hireDate.Year;
            if (hireYear - birthYear < 0)
            {
                errorProvider1.SetError(dtpHire, "Employee must be 18 to work!");
                error = false;
            }

            string address = txtAddress.Text;
            if (address.Length == 0)
            {
                errorProvider1.SetError(txtAddress, "Please enter Address");
                error = false;
            }

            string city = txtCity.Text;
            if (city.Length == 0)
            {
                errorProvider1.SetError(txtCity, "Please enter Address");
                error = false;
            }

            string region = txtRegion.Text;
            if (region.Length == 0)
            {
                errorProvider1.SetError(txtRegion, "Please enter Region");
                error = false;
            }

            string postalCode = txtPostal.Text;
            if (postalCode.Length == 0)
            {
                errorProvider1.SetError(txtPostal, "Please enter Postal Code");
                error = false;
            }

            string country = txtCountry.Text;
            if (country.Length == 0)
            {
                errorProvider1.SetError(txtAddress, "Please enter Country");
                error = false;
            }

            if (mtbPhone.MaskCompleted == false)
            {
                errorProvider1.SetError(mtbPhone, "Please enter require unit");
                error = false;
            }

            if (error == false)
            {
                return false;
            }
            else
                errorProvider1.Clear();
            return true;
        }

        void InitializeADOObject()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.ClearSelection();
                lblID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtTitle.Text = "";
                txtTOC.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtRegion.Text = "";
                txtPostal.Text = "";
                txtCountry.Text = "";
                mtbPhone.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool selEmpty = dataGridView1.SelectedRows.Count == 0;
            this.btnDelete.Enabled = !selEmpty;
            this.btnUpdate.Enabled = !selEmpty;
            this.btnAdd.Enabled = selEmpty;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                lblID.Text = r.Cells[0].Value.ToString();
                txtLastName.Text = r.Cells[1].Value.ToString();
                txtFirstName.Text = r.Cells[2].Value.ToString();
                txtTitle.Text = r.Cells[3].Value.ToString();
                txtTOC.Text = r.Cells[4].Value.ToString();
                DateTime dt;
                DateTime.TryParse(r.Cells[5].Value.ToString(), out dt);
                dtpBirth.Value = dt;
                DateTime.TryParse(r.Cells[6].Value.ToString(), out dt);
                dtpHire.Value = dt;
                txtAddress.Text = r.Cells[7].Value.ToString();
                txtCity.Text = r.Cells[8].Value.ToString();
                txtRegion.Text = r.Cells[9].Value.ToString();
                txtPostal.Text = r.Cells[10].Value.ToString();
                txtCountry.Text = r.Cells[11].Value.ToString();
                mtbPhone.Text = r.Cells[12].Value.ToString();
                cbmgrID.Text = r.Cells[13].Value.ToString();
            }
        }
        //string id = datagirview1.selectedrows[0].cells[0].value.ToString();
        //DataRow[] rows = dt.Select("ID=" +id);
        void addNewEmployee()
        {
            //SqlConnection con = new SqlConnection();
                //con.ConnectionString =
                 //   @"server=.\sqlexpress;database=TSQLFundamentals2008;integrated security=true";
            try
            {
                
                
                cmd.CommandText = ("HR.addEmployee");
                cmd.Parameters.Clear();
                
                cmd.Parameters.Add(new SqlParameter("@lastname", txtLastName.Text));

                SqlParameter param = new SqlParameter("@firstname", SqlDbType.NVarChar, 30);
                param.Value = txtFirstName.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@title", SqlDbType.NVarChar, 30);
                param.Value = txtTitle.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@titleofcourtesy", SqlDbType.NVarChar, 25);
                param.Value = txtTOC.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@birthdate", SqlDbType.DateTime);
                param.Value = dtpBirth.Value.ToShortDateString();
                cmd.Parameters.Add(param);

                param = new SqlParameter("@hiredate", SqlDbType.DateTime);
                param.Value = dtpHire.Value.ToShortDateString();
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
                param.Value = txtPostal.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@country", SqlDbType.NVarChar, 15);
                param.Value = txtCountry.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
                param.Value = mtbPhone.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@mgrid", SqlDbType.Int);
                if (cbmgrID.Text.Length == 0)
                {
                    param.Value = DBNull.Value;
                }
                else
                    param.Value = cbmgrID.Text;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //loadEmployees();
            finally
            {
                
            }
        }

        void loadEmployees()
        {
            try
            {
                
                cmd.CommandText = ("HR.getEmployee");
                cmd.Parameters.Clear();
                dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(),
                        DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(),
                        dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(),
                        dr[12].ToString(), dr[13].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
                return;
            addNewEmployee();

            loadEmployees();
        }

        private void txtPostal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
        void deleteEmployee()
        {
            try
            {
                
                cmd.CommandText = "HR.deleteEmployee";
                cmd.Parameters.Clear();
                int id = int.Parse(lblID.Text.Trim());
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@empid";
                param.SqlDbType = SqlDbType.Int;
                param.Value = id;
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure to delete?",
                "Confirm delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                deleteEmployee();
                loadEmployees();
            }
        }

        void updateEmployee()
        {
            try
            {
                
                cmd.CommandText = ("HR.updateEmployee");
                cmd.Parameters.Clear();

                int id = int.Parse(lblID.Text.Trim());
                SqlParameter param = new SqlParameter("@empid", SqlDbType.Int);
                param.Value = id;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@lastname", SqlDbType.NVarChar, 20);
                param.Value = txtLastName.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@firstname", SqlDbType.NVarChar, 10);
                param.Value = txtFirstName.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@title", SqlDbType.NVarChar, 30);
                param.Value = txtTitle.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@titleofcourtesy", SqlDbType.NVarChar, 25);
                param.Value = txtTOC.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@birthdate", SqlDbType.DateTime);
                param.Value = dtpBirth.Value.ToShortDateString();
                cmd.Parameters.Add(param);

                param = new SqlParameter("@hiredate", SqlDbType.DateTime);
                param.Value = dtpHire.Value.ToShortDateString();
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
                param.Value = txtPostal.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@country", SqlDbType.NVarChar, 15);
                param.Value = txtCountry.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@phone", SqlDbType.NVarChar, 24);
                param.Value = mtbPhone.Text;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@mgrid", SqlDbType.Int);
                if (cbmgrID.Text.Length == 0)
                {
                    param.Value = DBNull.Value;
                }
                else
                    param.Value = cbmgrID.Text;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            updateEmployee();
            loadEmployees();
        }

        

        
    }
}
