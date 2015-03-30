namespace ProjectCS
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.txUnitPrice = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.ckDiscontinued = new System.Windows.Forms.CheckBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbInf = new System.Windows.Forms.GroupBox();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblIdLbl = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(22, 185);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 22;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(108, 142);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(140, 21);
            this.cbCat.TabIndex = 21;
            // 
            // txUnitPrice
            // 
            this.txUnitPrice.Location = new System.Drawing.Point(165, 182);
            this.txUnitPrice.Name = "txUnitPrice";
            this.txUnitPrice.Size = new System.Drawing.Size(83, 20);
            this.txUnitPrice.TabIndex = 23;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(22, 145);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(49, 13);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "Category";
            // 
            // ckDiscontinued
            // 
            this.ckDiscontinued.AutoSize = true;
            this.ckDiscontinued.Location = new System.Drawing.Point(160, 219);
            this.ckDiscontinued.Name = "ckDiscontinued";
            this.ckDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.ckDiscontinued.TabIndex = 24;
            this.ckDiscontinued.Text = "Discontinued";
            this.ckDiscontinued.UseVisualStyleBackColor = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(108, 104);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(140, 21);
            this.cbSupplier.TabIndex = 19;
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(146, 185);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(13, 13);
            this.lblDollar.TabIndex = 25;
            this.lblDollar.Text = "$";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(22, 107);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 18;
            this.lblSupplier.Text = "Supplier";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(108, 64);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(140, 20);
            this.txName.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbInf
            // 
            this.gbInf.Controls.Add(this.lblIdValue);
            this.gbInf.Controls.Add(this.lblIdLbl);
            this.gbInf.Controls.Add(this.lblName);
            this.gbInf.Controls.Add(this.txName);
            this.gbInf.Controls.Add(this.lblSupplier);
            this.gbInf.Controls.Add(this.lblDollar);
            this.gbInf.Controls.Add(this.cbSupplier);
            this.gbInf.Controls.Add(this.ckDiscontinued);
            this.gbInf.Controls.Add(this.lblCat);
            this.gbInf.Controls.Add(this.txUnitPrice);
            this.gbInf.Controls.Add(this.cbCat);
            this.gbInf.Controls.Add(this.lblUnitPrice);
            this.gbInf.Location = new System.Drawing.Point(39, 16);
            this.gbInf.Name = "gbInf";
            this.gbInf.Size = new System.Drawing.Size(278, 273);
            this.gbInf.TabIndex = 15;
            this.gbInf.TabStop = false;
            this.gbInf.Text = "Infomation";
            this.gbInf.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(105, 35);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(0, 13);
            this.lblIdValue.TabIndex = 27;
            // 
            // lblIdLbl
            // 
            this.lblIdLbl.AutoSize = true;
            this.lblIdLbl.Location = new System.Drawing.Point(22, 35);
            this.lblIdLbl.Name = "lblIdLbl";
            this.lblIdLbl.Size = new System.Drawing.Size(18, 13);
            this.lblIdLbl.TabIndex = 26;
            this.lblIdLbl.Text = "ID";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataView.Location = new System.Drawing.Point(361, 95);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(567, 298);
            this.dataView.TabIndex = 0;
            this.dataView.SelectionChanged += new System.EventHandler(this.dataView_SelectionChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(361, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 71);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Product Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(32, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.gbInf);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.gbInf.ResumeLayout(false);
            this.gbInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.TextBox txUnitPrice;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.CheckBox ckDiscontinued;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbInf;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblIdLbl;
        private System.Windows.Forms.ErrorProvider errors;

    }
}

