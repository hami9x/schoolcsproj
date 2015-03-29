using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using ProjectCS;

namespace Project
{
    public partial class Categories : ChildForm
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader dr;
        //SqlDataAdapter da;
        //SqlCommandBuilder cb;
        //DataSet ds;
        //DataTable dt;

        public Categories(SqlConnection sql, ToolStripMenuItem menu)
            : base(sql, menu)
        {
            con = conn;
            InitializeComponent();
            initialADOObject();
        }

        protected override void load()
        {
            loadCategories();
        }

        void initialADOObject()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        void loadCategories()
        {
            this.cbSearchOpt.SelectedIndex = 0;
            this.cbSearchOpt.DropDownStyle = ComboBoxStyle.DropDownList;
            SqlCommand c = cmd.Clone();
            c.CommandText = "getCategories";
            SqlDataReader dr = c.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (dr.Read())
            {

                dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadCategories();
        }

        void addCategories() {
            SqlCommand c = cmd.Clone();
            c.CommandText = "insertCategories";


            SqlParameter param = new SqlParameter("@categoryname", SqlDbType.NVarChar, 15);
            param.Value = txtCategoriesName.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@description", SqlDbType.NVarChar, 200);
            param.Value = txtDescription.Text;
            c.Parameters.Add(param);

            c.ExecuteNonQuery();

            loadCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCategories();
        }

        void updateCategories() {
            SqlCommand c = cmd.Clone();
            c.CommandText = "updateCategories";


            SqlParameter param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = txtID.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@categoryname", SqlDbType.NVarChar, 15);
            param.Value = txtCategoriesName.Text;
            c.Parameters.Add(param);

            param = new SqlParameter("@description", SqlDbType.NVarChar, 200);
            param.Value = txtDescription.Text;
            c.Parameters.Add(param);

            c.ExecuteNonQuery();

            loadCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateCategories();
        }

        void deleteCategories()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "deleteCategories";


            SqlParameter param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = txtID.Text;
            c.Parameters.Add(param);

            c.ExecuteNonQuery();

            loadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCategories();
        }


        void searchByID() {
            SqlCommand c = cmd.Clone();
            c.CommandText = "searchByCatID";

            SqlParameter param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = txtSearch.Text;
            c.Parameters.Add(param);

            SqlDataReader dr = c.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString()  );
            }
            dr.Close();
            
        }

        void searchByName()
        {
            SqlCommand c = cmd.Clone();
            c.CommandText = "searchByCatName";

            SqlParameter param = new SqlParameter("@categoryname", SqlDbType.NVarChar, 15);
            param.Value = txtSearch.Text;
            c.Parameters.Add(param);

            SqlDataReader dr = c.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView2.SelectedRows[0];
                txtID.Text = r.Cells[0].Value.ToString();
                txtCategoriesName.Text = r.Cells[1].Value.ToString();
                txtDescription.Text = r.Cells[2].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchOpt.Text.Equals("By ID")) searchByID();
            else if (cbSearchOpt.Text.Equals("By Category Name")) searchByName();
            else loadCategories();
            
        }

     
        
    }
}
