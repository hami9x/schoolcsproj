using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCS
{
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

        protected virtual void load() { }

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
