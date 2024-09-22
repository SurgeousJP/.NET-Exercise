namespace FarmPJ
{
    partial class animalForm
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
            this.lb_AnimalType = new System.Windows.Forms.Label();
            this.lb_Count = new System.Windows.Forms.Label();
            this.lb_Milk = new System.Windows.Forms.Label();
            this.lb_ChildCount = new System.Windows.Forms.Label();
            this.animalGridView = new System.Windows.Forms.DataGridView();
            this.dgAnimalTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChildCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Milk = new System.Windows.Forms.TextBox();
            this.txt_ChildCount = new System.Windows.Forms.TextBox();
            this.cb_AnimalType = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Eval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_AnimalType
            // 
            this.lb_AnimalType.AutoSize = true;
            this.lb_AnimalType.Location = new System.Drawing.Point(46, 43);
            this.lb_AnimalType.Name = "lb_AnimalType";
            this.lb_AnimalType.Size = new System.Drawing.Size(79, 16);
            this.lb_AnimalType.TabIndex = 0;
            this.lb_AnimalType.Text = "Loại gia súc";
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(46, 89);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(60, 16);
            this.lb_Count.TabIndex = 1;
            this.lb_Count.Text = "Số lượng";
            // 
            // lb_Milk
            // 
            this.lb_Milk.AutoSize = true;
            this.lb_Milk.Location = new System.Drawing.Point(372, 43);
            this.lb_Milk.Name = "lb_Milk";
            this.lb_Milk.Size = new System.Drawing.Size(69, 16);
            this.lb_Milk.TabIndex = 2;
            this.lb_Milk.Text = "Lượng sữa";
            // 
            // lb_ChildCount
            // 
            this.lb_ChildCount.AutoSize = true;
            this.lb_ChildCount.Location = new System.Drawing.Point(373, 86);
            this.lb_ChildCount.Name = "lb_ChildCount";
            this.lb_ChildCount.Size = new System.Drawing.Size(68, 16);
            this.lb_ChildCount.TabIndex = 2;
            this.lb_ChildCount.Text = "Số con đẻ";
            // 
            // animalGridView
            // 
            this.animalGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.animalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAnimalTypeName,
            this.dgAnimalID,
            this.dgCount,
            this.dgMilk,
            this.dgChildCount});
            this.animalGridView.Location = new System.Drawing.Point(49, 212);
            this.animalGridView.Name = "animalGridView";
            this.animalGridView.RowHeadersWidth = 51;
            this.animalGridView.RowTemplate.Height = 24;
            this.animalGridView.Size = new System.Drawing.Size(546, 207);
            this.animalGridView.TabIndex = 3;
            this.animalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalGridView_CellClick);
            // 
            // dgAnimalTypeName
            // 
            this.dgAnimalTypeName.DataPropertyName = "AnimalTypeName";
            this.dgAnimalTypeName.HeaderText = "Loại gia súc";
            this.dgAnimalTypeName.MinimumWidth = 6;
            this.dgAnimalTypeName.Name = "dgAnimalTypeName";
            // 
            // dgAnimalID
            // 
            this.dgAnimalID.DataPropertyName = "AnimalID";
            this.dgAnimalID.HeaderText = "Mã gia súc";
            this.dgAnimalID.MinimumWidth = 6;
            this.dgAnimalID.Name = "dgAnimalID";
            this.dgAnimalID.Visible = false;
            // 
            // dgCount
            // 
            this.dgCount.DataPropertyName = "Count";
            this.dgCount.HeaderText = "Số lượng";
            this.dgCount.MinimumWidth = 6;
            this.dgCount.Name = "dgCount";
            // 
            // dgMilk
            // 
            this.dgMilk.DataPropertyName = "Milk";
            this.dgMilk.HeaderText = "Lượng sữa";
            this.dgMilk.MinimumWidth = 6;
            this.dgMilk.Name = "dgMilk";
            // 
            // dgChildCount
            // 
            this.dgChildCount.DataPropertyName = "ChildCount";
            this.dgChildCount.HeaderText = "Số con đẻ";
            this.dgChildCount.MinimumWidth = 6;
            this.dgChildCount.Name = "dgChildCount";
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(172, 86);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(121, 22);
            this.txt_Count.TabIndex = 4;
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            this.txt_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Count_KeyPress);
            // 
            // txt_Milk
            // 
            this.txt_Milk.Location = new System.Drawing.Point(474, 37);
            this.txt_Milk.Name = "txt_Milk";
            this.txt_Milk.Size = new System.Drawing.Size(121, 22);
            this.txt_Milk.TabIndex = 4;
            this.txt_Milk.TextChanged += new System.EventHandler(this.txt_Milk_TextChanged);
            this.txt_Milk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Milk_KeyPress);
            // 
            // txt_ChildCount
            // 
            this.txt_ChildCount.Location = new System.Drawing.Point(474, 83);
            this.txt_ChildCount.Name = "txt_ChildCount";
            this.txt_ChildCount.Size = new System.Drawing.Size(121, 22);
            this.txt_ChildCount.TabIndex = 4;
            this.txt_ChildCount.TextChanged += new System.EventHandler(this.txt_ChildCount_TextChanged);
            this.txt_ChildCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ChildCount_KeyPress);
            // 
            // cb_AnimalType
            // 
            this.cb_AnimalType.FormattingEnabled = true;
            this.cb_AnimalType.Location = new System.Drawing.Point(172, 37);
            this.cb_AnimalType.Name = "cb_AnimalType";
            this.cb_AnimalType.Size = new System.Drawing.Size(121, 24);
            this.cb_AnimalType.TabIndex = 5;
            this.cb_AnimalType.SelectedIndexChanged += new System.EventHandler(this.cb_AnimalType_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(50, 140);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(190, 140);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 44);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(338, 140);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 44);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Eval
            // 
            this.btn_Eval.Location = new System.Drawing.Point(492, 140);
            this.btn_Eval.Name = "btn_Eval";
            this.btn_Eval.Size = new System.Drawing.Size(103, 44);
            this.btn_Eval.TabIndex = 6;
            this.btn_Eval.Text = "Thống kê";
            this.btn_Eval.UseVisualStyleBackColor = true;
            this.btn_Eval.Click += new System.EventHandler(this.btn_Eval_Click);
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btn_Eval);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_AnimalType);
            this.Controls.Add(this.txt_ChildCount);
            this.Controls.Add(this.txt_Milk);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.animalGridView);
            this.Controls.Add(this.lb_ChildCount);
            this.Controls.Add(this.lb_Milk);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.lb_AnimalType);
            this.Name = "animalForm";
            this.Text = "Quản lý gia súc";
            this.Load += new System.EventHandler(this.animalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AnimalType;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label lb_Milk;
        private System.Windows.Forms.Label lb_ChildCount;
        private System.Windows.Forms.DataGridView animalGridView;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_Milk;
        private System.Windows.Forms.TextBox txt_ChildCount;
        private System.Windows.Forms.ComboBox cb_AnimalType;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Eval;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnimalTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgChildCount;
    }
}

