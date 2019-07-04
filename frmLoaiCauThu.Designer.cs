namespace GUI
{
    partial class frmLoaiCauThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_loaicauthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_maloaicauthu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loaicauthuTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAICAUTHUTableAdapter();
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 355);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1796F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28161F));
            this.tableLayoutPanel2.Controls.Add(this.btn_them, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_xoa, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_sua, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_xacnhan, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_huy, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_loaicauthu, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(725, 136);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Location = new System.Drawing.Point(35, 84);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 35);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.Location = new System.Drawing.Point(327, 84);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.Location = new System.Drawing.Point(181, 84);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 35);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xacnhan.Location = new System.Drawing.Point(473, 84);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(75, 35);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Lưu";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_huy.Location = new System.Drawing.Point(614, 84);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 35);
            this.btn_huy.TabIndex = 6;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_loaicauthu
            // 
            this.txt_loaicauthu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_loaicauthu.Location = new System.Drawing.Point(441, 24);
            this.txt_loaicauthu.Name = "txt_loaicauthu";
            this.txt_loaicauthu.Size = new System.Drawing.Size(140, 20);
            this.txt_loaicauthu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Loại Cầu Thủ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_maloaicauthu);
            this.panel2.Location = new System.Drawing.Point(149, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 62);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 62);
            this.panel3.TabIndex = 1;
            // 
            // txt_maloaicauthu
            // 
            this.txt_maloaicauthu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_maloaicauthu.Location = new System.Drawing.Point(0, 21);
            this.txt_maloaicauthu.Name = "txt_maloaicauthu";
            this.txt_maloaicauthu.Size = new System.Drawing.Size(140, 20);
            this.txt_maloaicauthu.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 145);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 207);
            this.dataGridView1.TabIndex = 8;
            // 
            // loaicauthuTableAdapter1
            // 
            this.loaicauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1
            // 
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DataSetName = "QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet";
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLoaiCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 355);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoaiCauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Cầu Thủ";
            this.Load += new System.EventHandler(this.frmLoaiCauThu_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAICTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAICTDataGridViewTextBoxColumn;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAICAUTHUTableAdapter loaicauthuTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1;
        private System.Windows.Forms.TextBox txt_loaicauthu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_maloaicauthu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}