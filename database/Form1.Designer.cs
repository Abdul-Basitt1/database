namespace database
{
    partial class Form1
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
            this.softtechDataSet = new database.softtechDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new database.softtechDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new database.softtechDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.TextBox();
            this.contactname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.phon = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ordqty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.submitorder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.TextBox();
            this.orddate = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.softtechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // softtechDataSet
            // 
            this.softtechDataSet.DataSetName = "softtechDataSet";
            this.softtechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.softtechDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = database.softtechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // companyname
            // 
            this.companyname.Location = new System.Drawing.Point(171, 33);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(100, 22);
            this.companyname.TabIndex = 5;
            // 
            // contactname
            // 
            this.contactname.Location = new System.Drawing.Point(171, 72);
            this.contactname.Name = "contactname";
            this.contactname.Size = new System.Drawing.Size(100, 22);
            this.contactname.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(460, 147);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // phon
            // 
            this.phon.Location = new System.Drawing.Point(171, 110);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(100, 22);
            this.phon.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.phon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.companyname);
            this.panel1.Controls.Add(this.contactname);
            this.panel1.Location = new System.Drawing.Point(49, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 226);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.ordqty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.showorder);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.submitorder);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.customerid);
            this.panel2.Controls.Add(this.orddate);
            this.panel2.Location = new System.Drawing.Point(49, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 254);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(356, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(460, 147);
            this.dataGridView2.TabIndex = 8;
            // 
            // ordqty
            // 
            this.ordqty.Location = new System.Drawing.Point(171, 109);
            this.ordqty.Name = "ordqty";
            this.ordqty.Size = new System.Drawing.Size(100, 22);
            this.ordqty.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id";
            // 
            // showorder
            // 
            this.showorder.Location = new System.Drawing.Point(356, 170);
            this.showorder.Name = "showorder";
            this.showorder.Size = new System.Drawing.Size(117, 35);
            this.showorder.TabIndex = 10;
            this.showorder.Text = "Show Data";
            this.showorder.UseVisualStyleBackColor = true;
            this.showorder.Click += new System.EventHandler(this.showorder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Order Date";
            // 
            // submitorder
            // 
            this.submitorder.Location = new System.Drawing.Point(262, 170);
            this.submitorder.Name = "submitorder";
            this.submitorder.Size = new System.Drawing.Size(88, 35);
            this.submitorder.TabIndex = 9;
            this.submitorder.Text = "Submit";
            this.submitorder.UseVisualStyleBackColor = true;
            this.submitorder.Click += new System.EventHandler(this.submitorder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order Quantity";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(171, 32);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(100, 22);
            this.customerid.TabIndex = 13;
            // 
            // orddate
            // 
            this.orddate.Location = new System.Drawing.Point(171, 71);
            this.orddate.Name = "orddate";
            this.orddate.Size = new System.Drawing.Size(100, 22);
            this.orddate.TabIndex = 6;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(328, 46);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(84, 23);
            this.customer.TabIndex = 15;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(655, 50);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(82, 23);
            this.order.TabIndex = 16;
            this.order.Text = "Orders";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Click Here to insert customer Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Click Here to insert Orders Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.order);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SoftTech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softtechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private softtechDataSet softtechDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private softtechDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private softtechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyname;
        private System.Windows.Forms.TextBox contactname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox phon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox ordqty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.TextBox orddate;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

