namespace OrderForm
{
    partial class FormEdit
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.lblAmout = new System.Windows.Forms.Label();
      this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnAddDetail = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(665, 96);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "基本信息";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 514F));
      this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 76);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // comboBox1
      // 
      this.comboBox1.DataSource = this.customerBindingSource;
      this.comboBox1.DisplayMember = "Name";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(103, 41);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(341, 20);
      this.comboBox1.TabIndex = 10;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // customerBindingSource
      // 
      this.customerBindingSource.DataSource = typeof(ordertest.Customer);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Right;
      this.label2.Location = new System.Drawing.Point(56, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 38);
      this.label2.TabIndex = 7;
      this.label2.Text = "订单号";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Right;
      this.label1.Location = new System.Drawing.Point(68, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 38);
      this.label1.TabIndex = 6;
      this.label1.Text = "客户";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
      this.textBox1.Location = new System.Drawing.Point(103, 3);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(341, 21);
      this.textBox1.TabIndex = 9;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(ordertest.Order);
      // 
      // goodsBindingSource
      // 
      this.goodsBindingSource.DataSource = typeof(ordertest.Goods);
      // 
      // detailsBindingSource
      // 
      this.detailsBindingSource.DataMember = "Details";
      this.detailsBindingSource.DataSource = this.orderBindingSource;
      this.detailsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.detailsBindingSource_AddingNew);
      this.detailsBindingSource.CurrentChanged += new System.EventHandler(this.detailsBindingSource_CurrentChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnAddDetail);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(5, 391);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(665, 38);
      this.panel1.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.button1.Location = new System.Drawing.Point(340, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "保存订单";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Controls.Add(this.dataGridView1);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(5, 101);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(665, 290);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "订单明细";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.tableLayoutPanel2);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox3.Location = new System.Drawing.Point(3, 247);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(659, 40);
      this.groupBox3.TabIndex = 8;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "当前明细";
      // 
      // comboBox2
      // 
      this.comboBox2.DataSource = this.goodsBindingSource;
      this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(103, 3);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(111, 20);
      this.comboBox2.TabIndex = 7;
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goods,
            this.quantityDataGridViewTextBoxColumn,
            this.Amount});
      this.dataGridView1.DataSource = this.detailsBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 17);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(659, 270);
      this.dataGridView1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 6;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.Controls.Add(this.lblAmout, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.comboBox2, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.textBox2, 3, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 20);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Right;
      this.label3.Location = new System.Drawing.Point(68, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "货物";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Right;
      this.label4.Location = new System.Drawing.Point(285, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "数量";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox2
      // 
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailsBindingSource, "Quantity", true));
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Location = new System.Drawing.Point(320, 3);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(111, 21);
      this.textBox2.TabIndex = 9;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Right;
      this.label5.Location = new System.Drawing.Point(502, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 20);
      this.label5.TabIndex = 10;
      this.label5.Text = "价格";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblAmout
      // 
      this.lblAmout.AutoSize = true;
      this.lblAmout.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailsBindingSource, "Amount", true));
      this.lblAmout.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblAmout.Location = new System.Drawing.Point(537, 0);
      this.lblAmout.Name = "lblAmout";
      this.lblAmout.Size = new System.Drawing.Size(17, 20);
      this.lblAmout.TabIndex = 11;
      this.lblAmout.Text = "()";
      this.lblAmout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Goods
      // 
      this.Goods.DataPropertyName = "Goods";
      this.Goods.HeaderText = "货物";
      this.Goods.Name = "Goods";
      this.Goods.ReadOnly = true;
      this.Goods.Width = 200;
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // Amount
      // 
      this.Amount.DataPropertyName = "Amount";
      this.Amount.HeaderText = "价格";
      this.Amount.Name = "Amount";
      this.Amount.ReadOnly = true;
      // 
      // btnAddDetail
      // 
      this.btnAddDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnAddDetail.Location = new System.Drawing.Point(232, 4);
      this.btnAddDetail.Name = "btnAddDetail";
      this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
      this.btnAddDetail.TabIndex = 5;
      this.btnAddDetail.Text = "添加明细";
      this.btnAddDetail.UseVisualStyleBackColor = true;
      this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
      // 
      // FormEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(675, 434);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Name = "FormEdit";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "修改订单";
      this.Load += new System.EventHandler(this.FormEdit_Load);
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label lblAmout;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    private System.Windows.Forms.Button btnAddDetail;
  }
}