namespace ProductManagement
{
    partial class frmProdManagement
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
            this.inputProductForm = new System.Windows.Forms.GroupBox();
            this.btn_DeleteProd = new System.Windows.Forms.Button();
            this.btn_AddProd = new System.Windows.Forms.Button();
            this.btn_SaveProd = new System.Windows.Forms.Button();
            this.layoutProductForm = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.txt_Origin = new System.Windows.Forms.TextBox();
            this.lb_ExpireDate = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lb_ProdID = new System.Windows.Forms.Label();
            this.lb_Origin = new System.Windows.Forms.Label();
            this.lb_ProdName = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.txt_ProdID = new System.Windows.Forms.TextBox();
            this.dtp_ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.txt_StartPrice = new System.Windows.Forms.TextBox();
            this.txt_EndPrice = new System.Windows.Forms.TextBox();
            this.dt_GridSearch = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orgin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RangePriceProd = new System.Windows.Forms.Button();
            this.btn_ExpProd = new System.Windows.Forms.Button();
            this.btn_JPProd = new System.Windows.Forms.Button();
            this.btn_MaxPriceProd = new System.Windows.Forms.Button();
            this.grpBoxProd = new System.Windows.Forms.GroupBox();
            this.dt_GridProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxOp = new System.Windows.Forms.GroupBox();
            this.txt_DeleteOrg = new System.Windows.Forms.TextBox();
            this.btnCheckExp = new System.Windows.Forms.Button();
            this.btn_DeleteAllExp = new System.Windows.Forms.Button();
            this.btn_DeleteAllProd = new System.Windows.Forms.Button();
            this.btn_DeleteOrg = new System.Windows.Forms.Button();
            this.inputProductForm.SuspendLayout();
            this.layoutProductForm.SuspendLayout();
            this.gb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridSearch)).BeginInit();
            this.grpBoxProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridProd)).BeginInit();
            this.grpBoxOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputProductForm
            // 
            this.inputProductForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputProductForm.Controls.Add(this.btn_DeleteProd);
            this.inputProductForm.Controls.Add(this.btn_AddProd);
            this.inputProductForm.Controls.Add(this.btn_SaveProd);
            this.inputProductForm.Controls.Add(this.layoutProductForm);
            this.inputProductForm.Location = new System.Drawing.Point(14, 14);
            this.inputProductForm.Margin = new System.Windows.Forms.Padding(5);
            this.inputProductForm.Name = "inputProductForm";
            this.inputProductForm.Padding = new System.Windows.Forms.Padding(5);
            this.inputProductForm.Size = new System.Drawing.Size(469, 338);
            this.inputProductForm.TabIndex = 0;
            this.inputProductForm.TabStop = false;
            this.inputProductForm.Text = "Nhập thông tin sản phẩm";
            // 
            // btn_DeleteProd
            // 
            this.btn_DeleteProd.Location = new System.Drawing.Point(352, 292);
            this.btn_DeleteProd.Name = "btn_DeleteProd";
            this.btn_DeleteProd.Size = new System.Drawing.Size(100, 38);
            this.btn_DeleteProd.TabIndex = 3;
            this.btn_DeleteProd.Text = "Xóa SP";
            this.btn_DeleteProd.UseVisualStyleBackColor = true;
            this.btn_DeleteProd.Click += new System.EventHandler(this.btn_DeleteProd_Click);
            // 
            // btn_AddProd
            // 
            this.btn_AddProd.Location = new System.Drawing.Point(122, 292);
            this.btn_AddProd.Name = "btn_AddProd";
            this.btn_AddProd.Size = new System.Drawing.Size(100, 38);
            this.btn_AddProd.TabIndex = 3;
            this.btn_AddProd.Text = "Thêm SP";
            this.btn_AddProd.UseVisualStyleBackColor = true;
            this.btn_AddProd.Click += new System.EventHandler(this.btn_AddProd_Click);
            // 
            // btn_SaveProd
            // 
            this.btn_SaveProd.Location = new System.Drawing.Point(237, 292);
            this.btn_SaveProd.Name = "btn_SaveProd";
            this.btn_SaveProd.Size = new System.Drawing.Size(100, 38);
            this.btn_SaveProd.TabIndex = 3;
            this.btn_SaveProd.Text = "Lưu SP";
            this.btn_SaveProd.UseVisualStyleBackColor = true;
            this.btn_SaveProd.Click += new System.EventHandler(this.btn_SaveProd_Click);
            // 
            // layoutProductForm
            // 
            this.layoutProductForm.AutoSize = true;
            this.layoutProductForm.ColumnCount = 2;
            this.layoutProductForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.layoutProductForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutProductForm.Controls.Add(this.txt_Quantity, 1, 2);
            this.layoutProductForm.Controls.Add(this.txt_ProdName, 1, 1);
            this.layoutProductForm.Controls.Add(this.txt_Origin, 1, 4);
            this.layoutProductForm.Controls.Add(this.lb_ExpireDate, 0, 5);
            this.layoutProductForm.Controls.Add(this.txt_Price, 1, 3);
            this.layoutProductForm.Controls.Add(this.lb_ProdID, 0, 0);
            this.layoutProductForm.Controls.Add(this.lb_Origin, 0, 4);
            this.layoutProductForm.Controls.Add(this.lb_ProdName, 0, 1);
            this.layoutProductForm.Controls.Add(this.lb_Price, 0, 3);
            this.layoutProductForm.Controls.Add(this.lb_Quantity, 0, 2);
            this.layoutProductForm.Controls.Add(this.txt_ProdID, 1, 0);
            this.layoutProductForm.Controls.Add(this.dtp_ExpireDate, 1, 5);
            this.layoutProductForm.Location = new System.Drawing.Point(8, 32);
            this.layoutProductForm.Name = "layoutProductForm";
            this.layoutProductForm.RowCount = 6;
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutProductForm.Size = new System.Drawing.Size(447, 240);
            this.layoutProductForm.TabIndex = 2;
            this.layoutProductForm.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutProductForm_Paint);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(204, 83);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(240, 31);
            this.txt_Quantity.TabIndex = 1;
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Location = new System.Drawing.Point(204, 43);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.Size = new System.Drawing.Size(240, 31);
            this.txt_ProdName.TabIndex = 1;
            this.txt_ProdName.TextChanged += new System.EventHandler(this.txt_ProdName_TextChanged);
            // 
            // txt_Origin
            // 
            this.txt_Origin.Location = new System.Drawing.Point(204, 163);
            this.txt_Origin.Name = "txt_Origin";
            this.txt_Origin.Size = new System.Drawing.Size(240, 31);
            this.txt_Origin.TabIndex = 1;
            this.txt_Origin.TextChanged += new System.EventHandler(this.txt_Origin_TextChanged);
            // 
            // lb_ExpireDate
            // 
            this.lb_ExpireDate.AutoSize = true;
            this.lb_ExpireDate.Location = new System.Drawing.Point(5, 200);
            this.lb_ExpireDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ExpireDate.Name = "lb_ExpireDate";
            this.lb_ExpireDate.Size = new System.Drawing.Size(153, 23);
            this.lb_ExpireDate.TabIndex = 1;
            this.lb_ExpireDate.Text = "Ngày hết hạn:";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(204, 123);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(240, 31);
            this.txt_Price.TabIndex = 1;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // lb_ProdID
            // 
            this.lb_ProdID.AutoSize = true;
            this.lb_ProdID.Location = new System.Drawing.Point(5, 0);
            this.lb_ProdID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ProdID.Name = "lb_ProdID";
            this.lb_ProdID.Size = new System.Drawing.Size(76, 23);
            this.lb_ProdID.TabIndex = 1;
            this.lb_ProdID.Text = "Mã SP:";
            // 
            // lb_Origin
            // 
            this.lb_Origin.AutoSize = true;
            this.lb_Origin.Location = new System.Drawing.Point(5, 160);
            this.lb_Origin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Origin.Name = "lb_Origin";
            this.lb_Origin.Size = new System.Drawing.Size(98, 23);
            this.lb_Origin.TabIndex = 1;
            this.lb_Origin.Text = "Xuất xứ:";
            // 
            // lb_ProdName
            // 
            this.lb_ProdName.AutoSize = true;
            this.lb_ProdName.Location = new System.Drawing.Point(5, 40);
            this.lb_ProdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ProdName.Name = "lb_ProdName";
            this.lb_ProdName.Size = new System.Drawing.Size(87, 23);
            this.lb_ProdName.TabIndex = 1;
            this.lb_ProdName.Text = "Tên SP:";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(5, 120);
            this.lb_Price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(98, 23);
            this.lb_Price.TabIndex = 1;
            this.lb_Price.Text = "Đơn giá:";
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Location = new System.Drawing.Point(5, 80);
            this.lb_Quantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(109, 23);
            this.lb_Quantity.TabIndex = 1;
            this.lb_Quantity.Text = "Số lượng:";
            // 
            // txt_ProdID
            // 
            this.txt_ProdID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ProdID.Location = new System.Drawing.Point(204, 3);
            this.txt_ProdID.Name = "txt_ProdID";
            this.txt_ProdID.Size = new System.Drawing.Size(240, 31);
            this.txt_ProdID.TabIndex = 2;
            this.txt_ProdID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtp_ExpireDate
            // 
            this.dtp_ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExpireDate.Location = new System.Drawing.Point(204, 203);
            this.dtp_ExpireDate.Name = "dtp_ExpireDate";
            this.dtp_ExpireDate.Size = new System.Drawing.Size(240, 31);
            this.dtp_ExpireDate.TabIndex = 3;
            this.dtp_ExpireDate.ValueChanged += new System.EventHandler(this.dtp_ExpireDate_ValueChanged);
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.txt_StartPrice);
            this.gb_Search.Controls.Add(this.txt_EndPrice);
            this.gb_Search.Controls.Add(this.dt_GridSearch);
            this.gb_Search.Controls.Add(this.btn_RangePriceProd);
            this.gb_Search.Controls.Add(this.btn_ExpProd);
            this.gb_Search.Controls.Add(this.btn_JPProd);
            this.gb_Search.Controls.Add(this.btn_MaxPriceProd);
            this.gb_Search.Location = new System.Drawing.Point(504, 14);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(838, 338);
            this.gb_Search.TabIndex = 1;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Chọn chức năng tìm kiếm";
            // 
            // txt_StartPrice
            // 
            this.txt_StartPrice.Location = new System.Drawing.Point(684, 29);
            this.txt_StartPrice.Multiline = true;
            this.txt_StartPrice.Name = "txt_StartPrice";
            this.txt_StartPrice.Size = new System.Drawing.Size(71, 60);
            this.txt_StartPrice.TabIndex = 4;
            this.txt_StartPrice.TextChanged += new System.EventHandler(this.txt_startPrice_TextChanged);
            this.txt_StartPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StartPrice_KeyPress);
            // 
            // txt_EndPrice
            // 
            this.txt_EndPrice.Location = new System.Drawing.Point(761, 30);
            this.txt_EndPrice.Multiline = true;
            this.txt_EndPrice.Name = "txt_EndPrice";
            this.txt_EndPrice.Size = new System.Drawing.Size(71, 60);
            this.txt_EndPrice.TabIndex = 4;
            this.txt_EndPrice.TextChanged += new System.EventHandler(this.txt_EnđPrice_TextChanged);
            this.txt_EndPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EndPrice_KeyPress);
            // 
            // dt_GridSearch
            // 
            this.dt_GridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GridSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProdName,
            this.Quantity,
            this.Price,
            this.Orgin,
            this.ExpireDate});
            this.dt_GridSearch.Location = new System.Drawing.Point(6, 96);
            this.dt_GridSearch.Name = "dt_GridSearch";
            this.dt_GridSearch.RowHeadersWidth = 51;
            this.dt_GridSearch.RowTemplate.Height = 24;
            this.dt_GridSearch.Size = new System.Drawing.Size(826, 230);
            this.dt_GridSearch.TabIndex = 0;
            this.dt_GridSearch.SelectionChanged += new System.EventHandler(this.dt_GridSearch_SelectionChanged);
            // 
            // ProdID
            // 
            this.ProdID.DataPropertyName = "ProdID";
            this.ProdID.HeaderText = "Mã SP";
            this.ProdID.MinimumWidth = 6;
            this.ProdID.Name = "ProdID";
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Tên SP";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Orgin
            // 
            this.Orgin.DataPropertyName = "Origin";
            this.Orgin.HeaderText = "Xuất xử";
            this.Orgin.MinimumWidth = 6;
            this.Orgin.Name = "Orgin";
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "Ngày hết hạn";
            this.ExpireDate.MinimumWidth = 6;
            this.ExpireDate.Name = "ExpireDate";
            // 
            // btn_RangePriceProd
            // 
            this.btn_RangePriceProd.Location = new System.Drawing.Point(469, 30);
            this.btn_RangePriceProd.Name = "btn_RangePriceProd";
            this.btn_RangePriceProd.Size = new System.Drawing.Size(209, 59);
            this.btn_RangePriceProd.TabIndex = 3;
            this.btn_RangePriceProd.Text = "Xuất các SP có đơn giá từ [a,b]";
            this.btn_RangePriceProd.UseVisualStyleBackColor = true;
            this.btn_RangePriceProd.Click += new System.EventHandler(this.btn_RangePriceProd_Click);
            // 
            // btn_ExpProd
            // 
            this.btn_ExpProd.Location = new System.Drawing.Point(294, 30);
            this.btn_ExpProd.Name = "btn_ExpProd";
            this.btn_ExpProd.Size = new System.Drawing.Size(152, 59);
            this.btn_ExpProd.TabIndex = 3;
            this.btn_ExpProd.Text = "Xuất toàn bộ SP quá hạn";
            this.btn_ExpProd.UseVisualStyleBackColor = true;
            this.btn_ExpProd.Click += new System.EventHandler(this.btn_ExpProd_Click);
            // 
            // btn_JPProd
            // 
            this.btn_JPProd.Location = new System.Drawing.Point(150, 29);
            this.btn_JPProd.Name = "btn_JPProd";
            this.btn_JPProd.Size = new System.Drawing.Size(138, 59);
            this.btn_JPProd.TabIndex = 3;
            this.btn_JPProd.Text = "1 SP từ Nhật Bản";
            this.btn_JPProd.UseVisualStyleBackColor = true;
            this.btn_JPProd.Click += new System.EventHandler(this.btn_JPProd_Click);
            // 
            // btn_MaxPriceProd
            // 
            this.btn_MaxPriceProd.Location = new System.Drawing.Point(6, 29);
            this.btn_MaxPriceProd.Name = "btn_MaxPriceProd";
            this.btn_MaxPriceProd.Size = new System.Drawing.Size(138, 59);
            this.btn_MaxPriceProd.TabIndex = 3;
            this.btn_MaxPriceProd.Text = "1 SP có ĐG cao nhất";
            this.btn_MaxPriceProd.UseVisualStyleBackColor = true;
            this.btn_MaxPriceProd.Click += new System.EventHandler(this.btn_MaxPriceProd_Click);
            // 
            // grpBoxProd
            // 
            this.grpBoxProd.Controls.Add(this.dt_GridProd);
            this.grpBoxProd.Location = new System.Drawing.Point(14, 360);
            this.grpBoxProd.Name = "grpBoxProd";
            this.grpBoxProd.Size = new System.Drawing.Size(936, 269);
            this.grpBoxProd.TabIndex = 2;
            this.grpBoxProd.TabStop = false;
            this.grpBoxProd.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // dt_GridProd
            // 
            this.dt_GridProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_GridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dt_GridProd.Location = new System.Drawing.Point(6, 30);
            this.dt_GridProd.Name = "dt_GridProd";
            this.dt_GridProd.RowHeadersWidth = 51;
            this.dt_GridProd.RowTemplate.Height = 24;
            this.dt_GridProd.Size = new System.Drawing.Size(924, 233);
            this.dt_GridProd.TabIndex = 0;
            this.dt_GridProd.SelectionChanged += new System.EventHandler(this.dt_GridProd_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProdID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Xuất xử";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExpireDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // grpBoxOp
            // 
            this.grpBoxOp.Controls.Add(this.txt_DeleteOrg);
            this.grpBoxOp.Controls.Add(this.btnCheckExp);
            this.grpBoxOp.Controls.Add(this.btn_DeleteAllExp);
            this.grpBoxOp.Controls.Add(this.btn_DeleteAllProd);
            this.grpBoxOp.Controls.Add(this.btn_DeleteOrg);
            this.grpBoxOp.Location = new System.Drawing.Point(957, 373);
            this.grpBoxOp.Name = "grpBoxOp";
            this.grpBoxOp.Size = new System.Drawing.Size(379, 256);
            this.grpBoxOp.TabIndex = 3;
            this.grpBoxOp.TabStop = false;
            this.grpBoxOp.Text = "Chọn thao tác";
            // 
            // txt_DeleteOrg
            // 
            this.txt_DeleteOrg.Location = new System.Drawing.Point(221, 29);
            this.txt_DeleteOrg.Multiline = true;
            this.txt_DeleteOrg.Name = "txt_DeleteOrg";
            this.txt_DeleteOrg.Size = new System.Drawing.Size(152, 60);
            this.txt_DeleteOrg.TabIndex = 4;
            this.txt_DeleteOrg.TextChanged += new System.EventHandler(this.txt_DeleteOrg_TextChanged);
            // 
            // btnCheckExp
            // 
            this.btnCheckExp.Location = new System.Drawing.Point(6, 105);
            this.btnCheckExp.Name = "btnCheckExp";
            this.btnCheckExp.Size = new System.Drawing.Size(373, 59);
            this.btnCheckExp.TabIndex = 3;
            this.btnCheckExp.Text = "Kiểm tra trong kho có SP quá hạn không ?";
            this.btnCheckExp.UseVisualStyleBackColor = true;
            this.btnCheckExp.Click += new System.EventHandler(this.btnCheckExp_Click);
            // 
            // btn_DeleteAllExp
            // 
            this.btn_DeleteAllExp.Location = new System.Drawing.Point(197, 180);
            this.btn_DeleteAllExp.Name = "btn_DeleteAllExp";
            this.btn_DeleteAllExp.Size = new System.Drawing.Size(176, 59);
            this.btn_DeleteAllExp.TabIndex = 3;
            this.btn_DeleteAllExp.Text = "Xóa toàn bộ SP quá hạn";
            this.btn_DeleteAllExp.UseVisualStyleBackColor = true;
            this.btn_DeleteAllExp.Click += new System.EventHandler(this.btn_DeleteAllExp_Click);
            // 
            // btn_DeleteAllProd
            // 
            this.btn_DeleteAllProd.Location = new System.Drawing.Point(6, 180);
            this.btn_DeleteAllProd.Name = "btn_DeleteAllProd";
            this.btn_DeleteAllProd.Size = new System.Drawing.Size(176, 59);
            this.btn_DeleteAllProd.TabIndex = 3;
            this.btn_DeleteAllProd.Text = "Xóa toàn bộ SP trong kho";
            this.btn_DeleteAllProd.UseVisualStyleBackColor = true;
            this.btn_DeleteAllProd.Click += new System.EventHandler(this.btn_DeleteAllProd_Click);
            // 
            // btn_DeleteOrg
            // 
            this.btn_DeleteOrg.Location = new System.Drawing.Point(6, 30);
            this.btn_DeleteOrg.Name = "btn_DeleteOrg";
            this.btn_DeleteOrg.Size = new System.Drawing.Size(209, 59);
            this.btn_DeleteOrg.TabIndex = 3;
            this.btn_DeleteOrg.Text = "Xóa các SP có xuất xứ bất kỳ";
            this.btn_DeleteOrg.UseVisualStyleBackColor = true;
            this.btn_DeleteOrg.Click += new System.EventHandler(this.btn_DeleteOrg_Click);
            // 
            // frmProdManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 636);
            this.Controls.Add(this.grpBoxOp);
            this.Controls.Add(this.grpBoxProd);
            this.Controls.Add(this.gb_Search);
            this.Controls.Add(this.inputProductForm);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProdManagement";
            this.Text = "LINQ to Object";
            this.Load += new System.EventHandler(this.frmProdManagement_Load);
            this.inputProductForm.ResumeLayout(false);
            this.inputProductForm.PerformLayout();
            this.layoutProductForm.ResumeLayout(false);
            this.layoutProductForm.PerformLayout();
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridSearch)).EndInit();
            this.grpBoxProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridProd)).EndInit();
            this.grpBoxOp.ResumeLayout(false);
            this.grpBoxOp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputProductForm;
        private System.Windows.Forms.Label lb_ProdID;
        private System.Windows.Forms.Label lb_ProdName;
        private System.Windows.Forms.Label lb_Quantity;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_Origin;
        private System.Windows.Forms.Label lb_ExpireDate;
        private System.Windows.Forms.TableLayoutPanel layoutProductForm;
        private System.Windows.Forms.Button btn_DeleteProd;
        private System.Windows.Forms.Button btn_SaveProd;
        private System.Windows.Forms.TextBox txt_ProdID;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Origin;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.DateTimePicker dtp_ExpireDate;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.DataGridView dt_GridSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orgin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.Button btn_MaxPriceProd;
        private System.Windows.Forms.Button btn_JPProd;
        private System.Windows.Forms.Button btn_ExpProd;
        private System.Windows.Forms.Button btn_RangePriceProd;
        private System.Windows.Forms.TextBox txt_EndPrice;
        private System.Windows.Forms.TextBox txt_StartPrice;
        private System.Windows.Forms.GroupBox grpBoxProd;
        private System.Windows.Forms.DataGridView dt_GridProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grpBoxOp;
        private System.Windows.Forms.TextBox txt_DeleteOrg;
        private System.Windows.Forms.Button btn_DeleteOrg;
        private System.Windows.Forms.Button btnCheckExp;
        private System.Windows.Forms.Button btn_DeleteAllExp;
        private System.Windows.Forms.Button btn_DeleteAllProd;
        private System.Windows.Forms.Button btn_AddProd;
    }
}

