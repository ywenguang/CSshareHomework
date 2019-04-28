namespace OrderForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.cbField = new System.Windows.Forms.ComboBox();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnExport = new System.Windows.Forms.Button();
      this.btnImport = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // detailsBindingSource
      // 
      this.detailsBindingSource.DataMember = "Details";
      this.detailsBindingSource.DataSource = this.orderBindingSource;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.cbField);
      this.flowLayoutPanel1.Controls.Add(this.txtValue);
      this.flowLayoutPanel1.Controls.Add(this.button1);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
      this.flowLayoutPanel1.Size = new System.Drawing.Size(846, 50);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // cbField
      // 
      this.cbField.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbField.FormattingEnabled = true;
      this.cbField.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
      this.cbField.Location = new System.Drawing.Point(13, 14);
      this.cbField.Name = "cbField";
      this.cbField.Size = new System.Drawing.Size(121, 20);
      this.cbField.TabIndex = 0;
      // 
      // txtValue
      // 
      this.txtValue.Location = new System.Drawing.Point(140, 13);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(245, 21);
      this.txtValue.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(391, 13);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "查询";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.btnAdd);
      this.flowLayoutPanel2.Controls.Add(this.btnModify);
      this.flowLayoutPanel2.Controls.Add(this.btnDelete);
      this.flowLayoutPanel2.Controls.Add(this.btnExport);
      this.flowLayoutPanel2.Controls.Add(this.btnImport);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.flowLayoutPanel2.Size = new System.Drawing.Size(846, 34);
      this.flowLayoutPanel2.TabIndex = 1;
      this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(13, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "添加订单";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(94, 3);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(75, 23);
      this.btnModify.TabIndex = 4;
      this.btnModify.Text = "修改订单";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(175, 3);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 1;
      this.btnDelete.Text = "删除订单";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(256, 3);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(75, 23);
      this.btnExport.TabIndex = 2;
      this.btnExport.Text = "导出订单";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(337, 3);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(75, 23);
      this.btnImport.TabIndex = 3;
      this.btnImport.Text = "导入订单";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 425);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(846, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.splitContainer1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 84);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(10);
      this.panel1.Size = new System.Drawing.Size(846, 341);
      this.panel1.TabIndex = 3;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(10, 10);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
      this.splitContainer1.Size = new System.Drawing.Size(826, 321);
      this.splitContainer1.SplitterDistance = 420;
      this.splitContainer1.TabIndex = 5;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.TotalAmount});
      this.dataGridView1.DataSource = this.orderBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(420, 321);
      this.dataGridView1.TabIndex = 6;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Amount});
      this.dataGridView2.DataSource = this.detailsBindingSource;
      this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView2.Location = new System.Drawing.Point(0, 0);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowTemplate.Height = 23;
      this.dataGridView2.Size = new System.Drawing.Size(402, 321);
      this.dataGridView2.TabIndex = 0;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(ordertest.Order);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "订单号";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.Width = 80;
      // 
      // customerDataGridViewTextBoxColumn
      // 
      this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
      this.customerDataGridViewTextBoxColumn.HeaderText = "客户";
      this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
      this.customerDataGridViewTextBoxColumn.Width = 200;
      // 
      // TotalAmount
      // 
      this.TotalAmount.DataPropertyName = "TotalAmount";
      this.TotalAmount.HeaderText = "总价";
      this.TotalAmount.Name = "TotalAmount";
      this.TotalAmount.ReadOnly = true;
      // 
      // goodsDataGridViewTextBoxColumn
      // 
      this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
      this.goodsDataGridViewTextBoxColumn.HeaderText = "货物";
      this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      // 
      // Amount
      // 
      this.Amount.DataPropertyName = "Amount";
      this.Amount.HeaderText = "总价";
      this.Amount.Name = "Amount";
      this.Amount.ReadOnly = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(846, 447);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.flowLayoutPanel2);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "FormMain";
      this.Text = "订单管理";
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
  }
}

