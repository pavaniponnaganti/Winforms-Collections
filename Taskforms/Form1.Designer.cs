namespace Taskforms
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
            this.Retrieve = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblfix = new System.Windows.Forms.Label();
            this.txtfixedsal = new System.Windows.Forms.TextBox();
            this.lblmonthsal = new System.Windows.Forms.Label();
            this.txtmonthsal = new System.Windows.Forms.TextBox();
            this.lblannual = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblemptype = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtannualsal = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.cmbemptype = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFetchId = new System.Windows.Forms.ComboBox();
            this.cmbselectedemp = new System.Windows.Forms.ComboBox();
            this.form1ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.Retrieve.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Retrieve
            // 
            this.Retrieve.Controls.Add(this.tabPage1);
            this.Retrieve.Controls.Add(this.tabPage2);
            this.Retrieve.Location = new System.Drawing.Point(0, 0);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.SelectedIndex = 0;
            this.Retrieve.Size = new System.Drawing.Size(920, 540);
            this.Retrieve.TabIndex = 0;
            this.Retrieve.Selected += new System.Windows.Forms.TabControlEventHandler(this.Retrieve_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblfix);
            this.tabPage1.Controls.Add(this.txtfixedsal);
            this.tabPage1.Controls.Add(this.lblmonthsal);
            this.tabPage1.Controls.Add(this.txtmonthsal);
            this.tabPage1.Controls.Add(this.lblannual);
            this.tabPage1.Controls.Add(this.lbllastname);
            this.tabPage1.Controls.Add(this.lblfirstname);
            this.tabPage1.Controls.Add(this.lblempid);
            this.tabPage1.Controls.Add(this.lblemptype);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.txtannualsal);
            this.tabPage1.Controls.Add(this.txtlastname);
            this.tabPage1.Controls.Add(this.txtfirstname);
            this.tabPage1.Controls.Add(this.txtempid);
            this.tabPage1.Controls.Add(this.cmbemptype);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Save";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblfix
            // 
            this.lblfix.AutoSize = true;
            this.lblfix.Location = new System.Drawing.Point(370, 250);
            this.lblfix.Name = "lblfix";
            this.lblfix.Size = new System.Drawing.Size(64, 13);
            this.lblfix.TabIndex = 21;
            this.lblfix.Text = "FixedSalary:";
            // 
            // txtfixedsal
            // 
            this.txtfixedsal.Location = new System.Drawing.Point(459, 250);
            this.txtfixedsal.Name = "txtfixedsal";
            this.txtfixedsal.Size = new System.Drawing.Size(121, 20);
            this.txtfixedsal.TabIndex = 6;
            // 
            // lblmonthsal
            // 
            this.lblmonthsal.AutoSize = true;
            this.lblmonthsal.Location = new System.Drawing.Point(372, 213);
            this.lblmonthsal.Name = "lblmonthsal";
            this.lblmonthsal.Size = new System.Drawing.Size(76, 13);
            this.lblmonthsal.TabIndex = 13;
            this.lblmonthsal.Text = "MonthlySalary:";
            this.lblmonthsal.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtmonthsal
            // 
            this.txtmonthsal.Location = new System.Drawing.Point(459, 213);
            this.txtmonthsal.Name = "txtmonthsal";
            this.txtmonthsal.Size = new System.Drawing.Size(121, 20);
            this.txtmonthsal.TabIndex = 5;
            // 
            // lblannual
            // 
            this.lblannual.AutoSize = true;
            this.lblannual.Location = new System.Drawing.Point(370, 171);
            this.lblannual.Name = "lblannual";
            this.lblannual.Size = new System.Drawing.Size(72, 13);
            this.lblannual.TabIndex = 11;
            this.lblannual.Text = "AnnualSalary:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(372, 121);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(58, 13);
            this.lbllastname.TabIndex = 10;
            this.lbllastname.Text = "LastName:";
            this.lbllastname.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(372, 84);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(57, 13);
            this.lblfirstname.TabIndex = 9;
            this.lblfirstname.Text = "FirstName:";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(383, 55);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(24, 13);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "ID :";
            // 
            // lblemptype
            // 
            this.lblemptype.AutoSize = true;
            this.lblemptype.Location = new System.Drawing.Point(359, 12);
            this.lblemptype.Name = "lblemptype";
            this.lblemptype.Size = new System.Drawing.Size(83, 13);
            this.lblemptype.TabIndex = 7;
            this.lblemptype.Text = "Employee Type:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(459, 471);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseCompatibleTextRendering = true;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtannualsal
            // 
            this.txtannualsal.Location = new System.Drawing.Point(459, 171);
            this.txtannualsal.Name = "txtannualsal";
            this.txtannualsal.Size = new System.Drawing.Size(121, 20);
            this.txtannualsal.TabIndex = 4;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(459, 121);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(121, 20);
            this.txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(459, 84);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(121, 20);
            this.txtfirstname.TabIndex = 2;
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(459, 48);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(121, 20);
            this.txtempid.TabIndex = 1;
            // 
            // cmbemptype
            // 
            this.cmbemptype.FormattingEnabled = true;
            this.cmbemptype.Location = new System.Drawing.Point(459, 12);
            this.cmbemptype.Name = "cmbemptype";
            this.cmbemptype.Size = new System.Drawing.Size(121, 21);
            this.cmbemptype.TabIndex = 0;
            this.cmbemptype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnsearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Controls.Add(this.dataGridView5);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbFetchId);
            this.tabPage2.Controls.Add(this.cmbselectedemp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Retrieve";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(580, 313);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(316, 164);
            this.dataGridView6.TabIndex = 9;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(288, 313);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(286, 164);
            this.dataGridView5.TabIndex = 8;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 313);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(279, 164);
            this.dataGridView4.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(580, 147);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(316, 160);
            this.dataGridView3.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(288, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(286, 160);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 160);
            this.dataGridView1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Type:";
            // 
            // cmbFetchId
            // 
            this.cmbFetchId.FormattingEnabled = true;
            this.cmbFetchId.Location = new System.Drawing.Point(176, 110);
            this.cmbFetchId.Name = "cmbFetchId";
            this.cmbFetchId.Size = new System.Drawing.Size(141, 21);
            this.cmbFetchId.TabIndex = 1;
            this.cmbFetchId.SelectedIndexChanged += new System.EventHandler(this.cmbFetchId_SelectedIndexChanged);
            // 
            // cmbselectedemp
            // 
            this.cmbselectedemp.FormattingEnabled = true;
            this.cmbselectedemp.Location = new System.Drawing.Point(176, 49);
            this.cmbselectedemp.Name = "cmbselectedemp";
            this.cmbselectedemp.Size = new System.Drawing.Size(141, 21);
            this.cmbselectedemp.TabIndex = 0;
            this.cmbselectedemp.SelectedIndexChanged += new System.EventHandler(this.cmbselectedemp_SelectedIndexChanged);
            // 
            // form1ErrorProvider
            // 
            this.form1ErrorProvider.ContainerControl = this;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(728, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(678, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(44, 13);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "Search:";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(728, 68);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Click";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 552);
            this.Controls.Add(this.Retrieve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Retrieve.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Retrieve;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbemptype;
        private System.Windows.Forms.TextBox txtannualsal;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbFetchId;
        private System.Windows.Forms.ComboBox cmbselectedemp;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblemptype;
        private System.Windows.Forms.Label lblannual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblfix;
        private System.Windows.Forms.Label lblmonthsal;
        private System.Windows.Forms.TextBox txtmonthsal;
        private System.Windows.Forms.TextBox txtfixedsal;
        private System.Windows.Forms.ErrorProvider form1ErrorProvider;
        private System.Windows.Forms.Label txtSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnsearch;
    }
}

