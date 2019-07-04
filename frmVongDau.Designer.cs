namespace GUI
{
    partial class frmVongDau
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mavong = new System.Windows.Forms.TextBox();
            this.txt_tenvong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.cb_muagiai = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet();
            this.muagiaiTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter();
            this.vongdauTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 379);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71963F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62443F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75884F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62443F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.27267F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_tenvong, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_them, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_sua, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_xoa, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_xacnhan, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_muagiai, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_huy, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 145);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.txt_mavong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 66);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(142, 66);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Vòng Đấu:";
            // 
            // txt_mavong
            // 
            this.txt_mavong.Location = new System.Drawing.Point(15, 6);
            this.txt_mavong.Name = "txt_mavong";
            this.txt_mavong.Size = new System.Drawing.Size(100, 20);
            this.txt_mavong.TabIndex = 0;
            // 
            // txt_tenvong
            // 
            this.txt_tenvong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenvong.Location = new System.Drawing.Point(151, 26);
            this.txt_tenvong.Name = "txt_tenvong";
            this.txt_tenvong.Size = new System.Drawing.Size(173, 20);
            this.txt_tenvong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn Mùa Giải:";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Location = new System.Drawing.Point(36, 91);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 35);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.Location = new System.Drawing.Point(200, 91);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 35);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.Location = new System.Drawing.Point(356, 91);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xacnhan.Location = new System.Drawing.Point(512, 91);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(75, 35);
            this.btn_xacnhan.TabIndex = 7;
            this.btn_xacnhan.Text = "Lưu";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // cb_muagiai
            // 
            this.cb_muagiai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_muagiai.FormattingEnabled = true;
            this.cb_muagiai.Location = new System.Drawing.Point(463, 25);
            this.cb_muagiai.Name = "cb_muagiai";
            this.cb_muagiai.Size = new System.Drawing.Size(173, 21);
            this.cb_muagiai.TabIndex = 8;
            this.cb_muagiai.SelectedIndexChanged += new System.EventHandler(this.cb_muagiai_SelectedIndexChanged);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_huy.Location = new System.Drawing.Point(679, 92);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 32);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 154);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // quanLyGiaiVoDichBongDaQuocGia_FinalDataSet
            // 
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.DataSetName = "QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet";
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // vongdauTableAdapter1
            // 
            this.vongdauTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVongDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.panel1);
            this.Icon = global::QuanLiGiaiVoDichBongDaQuocGia.Properties.Resources.Icon;
            this.Name = "frmVongDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vòng Đấu";
            this.Load += new System.EventHandler(this.frmVongDau_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_tenvong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.ComboBox cb_muagiai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_mavong;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet quanLyGiaiVoDichBongDaQuocGia_FinalDataSet;
        private System.Windows.Forms.Button btn_huy;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter vongdauTableAdapter1;
    }
}