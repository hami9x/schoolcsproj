namespace WindowsFormsApplication7
{
    partial class Orders
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
            this.orderGrp = new System.Windows.Forms.GroupBox();
            this.lbOrderIdValue = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbShipper = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtShipcountry = new System.Windows.Forms.TextBox();
            this.txtShippostalcode = new System.Windows.Forms.TextBox();
            this.txtShipregion = new System.Windows.Forms.TextBox();
            this.txtShipcity = new System.Windows.Forms.TextBox();
            this.txtShipaddress = new System.Windows.Forms.TextBox();
            this.txtShipname = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.shipcountry = new System.Windows.Forms.Label();
            this.shippostalcode = new System.Windows.Forms.Label();
            this.shipregion = new System.Windows.Forms.Label();
            this.shipcity = new System.Windows.Forms.Label();
            this.shipaddress = new System.Windows.Forms.Label();
            this.shipname = new System.Windows.Forms.Label();
            this.freight = new System.Windows.Forms.Label();
            this.lbshipperid = new System.Windows.Forms.Label();
            this.lbShippeddate = new System.Windows.Forms.Label();
            this.lbRequireddate = new System.Windows.Forms.Label();
            this.lbOrderdate = new System.Windows.Forms.Label();
            this.lbempid = new System.Windows.Forms.Label();
            this.lbcustid = new System.Windows.Forms.Label();
            this.lborderid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcustid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clempid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clorderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrequireddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshippeddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshiperid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clfreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshipname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshipaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshipcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshipregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshippostalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshipcountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderDetGrp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txDiscount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txQty = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.orderDetGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGrp
            // 
            this.orderGrp.Controls.Add(this.lbOrderIdValue);
            this.orderGrp.Controls.Add(this.btnClear);
            this.orderGrp.Controls.Add(this.cbShipper);
            this.orderGrp.Controls.Add(this.cbEmployee);
            this.orderGrp.Controls.Add(this.cbCustomer);
            this.orderGrp.Controls.Add(this.dtShippedDate);
            this.orderGrp.Controls.Add(this.dtRequiredDate);
            this.orderGrp.Controls.Add(this.dtOrderDate);
            this.orderGrp.Controls.Add(this.btnDelete);
            this.orderGrp.Controls.Add(this.btnUpdate);
            this.orderGrp.Controls.Add(this.btnAdd);
            this.orderGrp.Controls.Add(this.txtShipcountry);
            this.orderGrp.Controls.Add(this.txtShippostalcode);
            this.orderGrp.Controls.Add(this.txtShipregion);
            this.orderGrp.Controls.Add(this.txtShipcity);
            this.orderGrp.Controls.Add(this.txtShipaddress);
            this.orderGrp.Controls.Add(this.txtShipname);
            this.orderGrp.Controls.Add(this.txtFreight);
            this.orderGrp.Controls.Add(this.shipcountry);
            this.orderGrp.Controls.Add(this.shippostalcode);
            this.orderGrp.Controls.Add(this.shipregion);
            this.orderGrp.Controls.Add(this.shipcity);
            this.orderGrp.Controls.Add(this.shipaddress);
            this.orderGrp.Controls.Add(this.shipname);
            this.orderGrp.Controls.Add(this.freight);
            this.orderGrp.Controls.Add(this.lbshipperid);
            this.orderGrp.Controls.Add(this.lbShippeddate);
            this.orderGrp.Controls.Add(this.lbRequireddate);
            this.orderGrp.Controls.Add(this.lbOrderdate);
            this.orderGrp.Controls.Add(this.lbempid);
            this.orderGrp.Controls.Add(this.lbcustid);
            this.orderGrp.Controls.Add(this.lborderid);
            this.orderGrp.Location = new System.Drawing.Point(12, 12);
            this.orderGrp.Name = "orderGrp";
            this.orderGrp.Size = new System.Drawing.Size(291, 533);
            this.orderGrp.TabIndex = 0;
            this.orderGrp.TabStop = false;
            this.orderGrp.Text = "Order Info";
            // 
            // lbOrderIdValue
            // 
            this.lbOrderIdValue.AutoSize = true;
            this.lbOrderIdValue.Location = new System.Drawing.Point(137, 16);
            this.lbOrderIdValue.Name = "lbOrderIdValue";
            this.lbOrderIdValue.Size = new System.Drawing.Size(0, 13);
            this.lbOrderIdValue.TabIndex = 40;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbShipper
            // 
            this.cbShipper.FormattingEnabled = true;
            this.cbShipper.Location = new System.Drawing.Point(134, 198);
            this.cbShipper.Name = "cbShipper";
            this.cbShipper.Size = new System.Drawing.Size(102, 21);
            this.cbShipper.TabIndex = 38;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(134, 69);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(102, 21);
            this.cbEmployee.TabIndex = 37;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(134, 35);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(102, 21);
            this.cbCustomer.TabIndex = 36;
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.CustomFormat = "MM/dd/yyyy";
            this.dtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShippedDate.Location = new System.Drawing.Point(134, 166);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(100, 20);
            this.dtShippedDate.TabIndex = 35;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.CustomFormat = "MM/dd/yyyy";
            this.dtRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRequiredDate.Location = new System.Drawing.Point(134, 140);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(100, 20);
            this.dtRequiredDate.TabIndex = 34;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.CustomFormat = "MM/dd/yyyy";
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOrderDate.Location = new System.Drawing.Point(136, 108);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.dtOrderDate.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(68, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(68, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtShipcountry
            // 
            this.txtShipcountry.Location = new System.Drawing.Point(136, 424);
            this.txtShipcountry.Name = "txtShipcountry";
            this.txtShipcountry.Size = new System.Drawing.Size(100, 20);
            this.txtShipcountry.TabIndex = 27;
            // 
            // txtShippostalcode
            // 
            this.txtShippostalcode.Location = new System.Drawing.Point(136, 392);
            this.txtShippostalcode.Name = "txtShippostalcode";
            this.txtShippostalcode.Size = new System.Drawing.Size(100, 20);
            this.txtShippostalcode.TabIndex = 26;
            // 
            // txtShipregion
            // 
            this.txtShipregion.Location = new System.Drawing.Point(136, 362);
            this.txtShipregion.Name = "txtShipregion";
            this.txtShipregion.Size = new System.Drawing.Size(100, 20);
            this.txtShipregion.TabIndex = 25;
            // 
            // txtShipcity
            // 
            this.txtShipcity.Location = new System.Drawing.Point(136, 330);
            this.txtShipcity.Name = "txtShipcity";
            this.txtShipcity.Size = new System.Drawing.Size(100, 20);
            this.txtShipcity.TabIndex = 24;
            // 
            // txtShipaddress
            // 
            this.txtShipaddress.Location = new System.Drawing.Point(136, 300);
            this.txtShipaddress.Name = "txtShipaddress";
            this.txtShipaddress.Size = new System.Drawing.Size(100, 20);
            this.txtShipaddress.TabIndex = 23;
            // 
            // txtShipname
            // 
            this.txtShipname.Location = new System.Drawing.Point(136, 267);
            this.txtShipname.Name = "txtShipname";
            this.txtShipname.Size = new System.Drawing.Size(100, 20);
            this.txtShipname.TabIndex = 22;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(136, 232);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(100, 20);
            this.txtFreight.TabIndex = 21;
            // 
            // shipcountry
            // 
            this.shipcountry.AutoSize = true;
            this.shipcountry.Location = new System.Drawing.Point(21, 424);
            this.shipcountry.Name = "shipcountry";
            this.shipcountry.Size = new System.Drawing.Size(67, 13);
            this.shipcountry.TabIndex = 14;
            this.shipcountry.Text = "Ship Country";
            // 
            // shippostalcode
            // 
            this.shippostalcode.AutoSize = true;
            this.shippostalcode.Location = new System.Drawing.Point(19, 392);
            this.shippostalcode.Name = "shippostalcode";
            this.shippostalcode.Size = new System.Drawing.Size(84, 13);
            this.shippostalcode.TabIndex = 13;
            this.shippostalcode.Text = "Ship Postalcode";
            // 
            // shipregion
            // 
            this.shipregion.AutoSize = true;
            this.shipregion.Location = new System.Drawing.Point(19, 362);
            this.shipregion.Name = "shipregion";
            this.shipregion.Size = new System.Drawing.Size(65, 13);
            this.shipregion.TabIndex = 12;
            this.shipregion.Text = "Ship Region";
            // 
            // shipcity
            // 
            this.shipcity.AutoSize = true;
            this.shipcity.Location = new System.Drawing.Point(21, 333);
            this.shipcity.Name = "shipcity";
            this.shipcity.Size = new System.Drawing.Size(48, 13);
            this.shipcity.TabIndex = 11;
            this.shipcity.Text = "Ship City";
            // 
            // shipaddress
            // 
            this.shipaddress.AutoSize = true;
            this.shipaddress.Location = new System.Drawing.Point(20, 300);
            this.shipaddress.Name = "shipaddress";
            this.shipaddress.Size = new System.Drawing.Size(69, 13);
            this.shipaddress.TabIndex = 10;
            this.shipaddress.Text = "Ship Address";
            // 
            // shipname
            // 
            this.shipname.AutoSize = true;
            this.shipname.Location = new System.Drawing.Point(19, 267);
            this.shipname.Name = "shipname";
            this.shipname.Size = new System.Drawing.Size(59, 13);
            this.shipname.TabIndex = 9;
            this.shipname.Text = "Ship Name";
            // 
            // freight
            // 
            this.freight.AutoSize = true;
            this.freight.Location = new System.Drawing.Point(21, 232);
            this.freight.Name = "freight";
            this.freight.Size = new System.Drawing.Size(39, 13);
            this.freight.TabIndex = 8;
            this.freight.Text = "Freight";
            // 
            // lbshipperid
            // 
            this.lbshipperid.AutoSize = true;
            this.lbshipperid.Location = new System.Drawing.Point(21, 201);
            this.lbshipperid.Name = "lbshipperid";
            this.lbshipperid.Size = new System.Drawing.Size(43, 13);
            this.lbshipperid.TabIndex = 7;
            this.lbshipperid.Text = "Shipper";
            // 
            // lbShippeddate
            // 
            this.lbShippeddate.AutoSize = true;
            this.lbShippeddate.Location = new System.Drawing.Point(18, 166);
            this.lbShippeddate.Name = "lbShippeddate";
            this.lbShippeddate.Size = new System.Drawing.Size(70, 13);
            this.lbShippeddate.TabIndex = 6;
            this.lbShippeddate.Text = "Shipped date";
            // 
            // lbRequireddate
            // 
            this.lbRequireddate.AutoSize = true;
            this.lbRequireddate.Location = new System.Drawing.Point(19, 140);
            this.lbRequireddate.Name = "lbRequireddate";
            this.lbRequireddate.Size = new System.Drawing.Size(76, 13);
            this.lbRequireddate.TabIndex = 5;
            this.lbRequireddate.Text = "Required Date";
            // 
            // lbOrderdate
            // 
            this.lbOrderdate.AutoSize = true;
            this.lbOrderdate.Location = new System.Drawing.Point(19, 115);
            this.lbOrderdate.Name = "lbOrderdate";
            this.lbOrderdate.Size = new System.Drawing.Size(59, 13);
            this.lbOrderdate.TabIndex = 4;
            this.lbOrderdate.Text = "Order Date";
            // 
            // lbempid
            // 
            this.lbempid.AutoSize = true;
            this.lbempid.Location = new System.Drawing.Point(21, 72);
            this.lbempid.Name = "lbempid";
            this.lbempid.Size = new System.Drawing.Size(53, 13);
            this.lbempid.TabIndex = 3;
            this.lbempid.Text = "Employee";
            // 
            // lbcustid
            // 
            this.lbcustid.AutoSize = true;
            this.lbcustid.Location = new System.Drawing.Point(21, 43);
            this.lbcustid.Name = "lbcustid";
            this.lbcustid.Size = new System.Drawing.Size(51, 13);
            this.lbcustid.TabIndex = 2;
            this.lbcustid.Text = "Customer";
            // 
            // lborderid
            // 
            this.lborderid.AutoSize = true;
            this.lborderid.Location = new System.Drawing.Point(21, 16);
            this.lborderid.Name = "lborderid";
            this.lborderid.Size = new System.Drawing.Size(18, 13);
            this.lborderid.TabIndex = 0;
            this.lborderid.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clorderid,
            this.clcustid,
            this.clempid,
            this.clorderdate,
            this.clrequireddate,
            this.clshippeddate,
            this.clshiperid,
            this.clfreight,
            this.clshipname,
            this.clshipaddress,
            this.clshipcity,
            this.clshipregion,
            this.clshippostalcode,
            this.clshipcountry});
            this.dataGridView1.Location = new System.Drawing.Point(328, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 260);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clorderid
            // 
            this.clorderid.HeaderText = "Order ID";
            this.clorderid.Name = "clorderid";
            // 
            // clcustid
            // 
            this.clcustid.HeaderText = "Customer ID";
            this.clcustid.Name = "clcustid";
            // 
            // clempid
            // 
            this.clempid.HeaderText = "Employees ID";
            this.clempid.Name = "clempid";
            // 
            // clorderdate
            // 
            this.clorderdate.HeaderText = "Order Date";
            this.clorderdate.Name = "clorderdate";
            // 
            // clrequireddate
            // 
            this.clrequireddate.HeaderText = "Required Date";
            this.clrequireddate.Name = "clrequireddate";
            // 
            // clshippeddate
            // 
            this.clshippeddate.HeaderText = "Shipped Date";
            this.clshippeddate.Name = "clshippeddate";
            // 
            // clshiperid
            // 
            this.clshiperid.HeaderText = "Shiper ID";
            this.clshiperid.Name = "clshiperid";
            // 
            // clfreight
            // 
            this.clfreight.HeaderText = "Freight";
            this.clfreight.Name = "clfreight";
            // 
            // clshipname
            // 
            this.clshipname.HeaderText = "Ship Name";
            this.clshipname.Name = "clshipname";
            // 
            // clshipaddress
            // 
            this.clshipaddress.HeaderText = "Ship Address";
            this.clshipaddress.Name = "clshipaddress";
            // 
            // clshipcity
            // 
            this.clshipcity.HeaderText = "Ship City";
            this.clshipcity.Name = "clshipcity";
            // 
            // clshipregion
            // 
            this.clshipregion.HeaderText = "Ship Region";
            this.clshipregion.Name = "clshipregion";
            // 
            // clshippostalcode
            // 
            this.clshippostalcode.HeaderText = "Ship PostalCode";
            this.clshippostalcode.Name = "clshippostalcode";
            // 
            // clshipcountry
            // 
            this.clshipcountry.HeaderText = "Ship Country";
            this.clshipcountry.Name = "clshipcountry";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(583, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(443, 209);
            this.dataGridView2.TabIndex = 36;
            // 
            // orderDetGrp
            // 
            this.orderDetGrp.Controls.Add(this.button1);
            this.orderDetGrp.Controls.Add(this.txDiscount);
            this.orderDetGrp.Controls.Add(this.button2);
            this.orderDetGrp.Controls.Add(this.button3);
            this.orderDetGrp.Controls.Add(this.txQty);
            this.orderDetGrp.Controls.Add(this.button4);
            this.orderDetGrp.Controls.Add(this.txUnitPrice);
            this.orderDetGrp.Controls.Add(this.label4);
            this.orderDetGrp.Controls.Add(this.label3);
            this.orderDetGrp.Controls.Add(this.label2);
            this.orderDetGrp.Controls.Add(this.lblProductID);
            this.orderDetGrp.Controls.Add(this.label1);
            this.orderDetGrp.Location = new System.Drawing.Point(328, 289);
            this.orderDetGrp.Name = "orderDetGrp";
            this.orderDetGrp.Size = new System.Drawing.Size(241, 256);
            this.orderDetGrp.TabIndex = 37;
            this.orderDetGrp.TabStop = false;
            this.orderDetGrp.Text = "Order Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txDiscount
            // 
            this.txDiscount.Location = new System.Drawing.Point(105, 150);
            this.txDiscount.Name = "txDiscount";
            this.txDiscount.Size = new System.Drawing.Size(100, 20);
            this.txDiscount.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txQty
            // 
            this.txQty.Location = new System.Drawing.Point(105, 112);
            this.txQty.Name = "txQty";
            this.txQty.Size = new System.Drawing.Size(100, 20);
            this.txQty.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txUnitPrice
            // 
            this.txUnitPrice.Location = new System.Drawing.Point(105, 70);
            this.txUnitPrice.Name = "txUnitPrice";
            this.txUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txUnitPrice.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Unit Price";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(113, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(0, 13);
            this.lblProductID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Product ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 557);
            this.Controls.Add(this.orderDetGrp);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.orderGrp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.orderGrp.ResumeLayout(false);
            this.orderGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.orderDetGrp.ResumeLayout(false);
            this.orderDetGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderGrp;
        private System.Windows.Forms.Label lbOrderdate;
        private System.Windows.Forms.Label lbempid;
        private System.Windows.Forms.Label lbcustid;
        private System.Windows.Forms.Label lborderid;
        private System.Windows.Forms.Label shipcountry;
        private System.Windows.Forms.Label shippostalcode;
        private System.Windows.Forms.Label shipregion;
        private System.Windows.Forms.Label shipcity;
        private System.Windows.Forms.Label shipaddress;
        private System.Windows.Forms.Label shipname;
        private System.Windows.Forms.Label freight;
        private System.Windows.Forms.Label lbshipperid;
        private System.Windows.Forms.Label lbShippeddate;
        private System.Windows.Forms.Label lbRequireddate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtShipcountry;
        private System.Windows.Forms.TextBox txtShippostalcode;
        private System.Windows.Forms.TextBox txtShipregion;
        private System.Windows.Forms.TextBox txtShipcity;
        private System.Windows.Forms.TextBox txtShipaddress;
        private System.Windows.Forms.TextBox txtShipname;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clorderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcustid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clempid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clorderdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clrequireddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshippeddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshiperid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshipname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshipaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshipcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshipregion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshippostalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshipcountry;
        private System.Windows.Forms.DateTimePicker dtShippedDate;
        private System.Windows.Forms.DateTimePicker dtRequiredDate;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox orderDetGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txDiscount;
        private System.Windows.Forms.TextBox txQty;
        private System.Windows.Forms.TextBox txUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbShipper;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbOrderIdValue;
    }
}

