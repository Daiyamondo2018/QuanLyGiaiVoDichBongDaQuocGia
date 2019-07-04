namespace GUI
{
    partial class frmTaoLichThiDau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_matrandau = new System.Windows.Forms.TextBox();
            this.cb_muagiai = new System.Windows.Forms.ComboBox();
            this.cb_vongdau = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thoigian = new System.Windows.Forms.DateTimePicker();
            this.cb_doi1 = new System.Windows.Forms.ComboBox();
            this.cb_doi2 = new System.Windows.Forms.ComboBox();
            this.txt_san = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet();
            this.sanTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter();
            this.doibongTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter();
            this.vongdauTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter();
            this.trandauTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.TRANDAUTableAdapter();
            this.doibonG_MUAGIAITableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 465);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Trận Đấu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.847534F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.48879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.744394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.36771F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 446);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.50208F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.95989F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08714F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54495F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76763F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cb_muagiai, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cb_vongdau, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(893, 28);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mùa Giải:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel10);
            this.panel7.Controls.Add(this.txt_matrandau);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(382, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 22);
            this.panel7.TabIndex = 12;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(164, 22);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vòng Đấu:";
            // 
            // txt_matrandau
            // 
            this.txt_matrandau.Location = new System.Drawing.Point(26, 18);
            this.txt_matrandau.Name = "txt_matrandau";
            this.txt_matrandau.Size = new System.Drawing.Size(100, 20);
            this.txt_matrandau.TabIndex = 0;
            // 
            // cb_muagiai
            // 
            this.cb_muagiai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_muagiai.FormattingEnabled = true;
            this.cb_muagiai.Location = new System.Drawing.Point(177, 3);
            this.cb_muagiai.Name = "cb_muagiai";
            this.cb_muagiai.Size = new System.Drawing.Size(199, 21);
            this.cb_muagiai.TabIndex = 10;
            this.cb_muagiai.SelectedIndexChanged += new System.EventHandler(this.cb_muagiai_SelectedIndexChanged_1);
            // 
            // cb_vongdau
            // 
            this.cb_vongdau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_vongdau.FormattingEnabled = true;
            this.cb_vongdau.Location = new System.Drawing.Point(552, 3);
            this.cb_vongdau.Name = "cb_vongdau";
            this.cb_vongdau.Size = new System.Drawing.Size(195, 21);
            this.cb_vongdau.TabIndex = 9;
            this.cb_vongdau.SelectedIndexChanged += new System.EventHandler(this.cb_vongdau_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sua, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_xacnhan, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_huy, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 114);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(893, 32);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Location = new System.Drawing.Point(51, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 26);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.Location = new System.Drawing.Point(229, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 26);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.Location = new System.Drawing.Point(407, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 26);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xacnhan.Location = new System.Drawing.Point(585, 3);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(75, 26);
            this.btn_xacnhan.TabIndex = 3;
            this.btn_xacnhan.Text = "Lưu";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_huy.Location = new System.Drawing.Point(765, 3);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 26);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97818F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.12708F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.66111F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_thoigian, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_doi1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cb_doi2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(893, 71);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đội 1:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đội 2:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời Gian:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sân:";
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thoigian.CustomFormat = "HH:mm - dd/MM/yyyy ";
            this.txt_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_thoigian.Location = new System.Drawing.Point(177, 43);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(199, 20);
            this.txt_thoigian.TabIndex = 4;
            this.txt_thoigian.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            this.txt_thoigian.ValueChanged += new System.EventHandler(this.txt_thoigian_ValueChanged);
            // 
            // cb_doi1
            // 
            this.cb_doi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_doi1.FormattingEnabled = true;
            this.cb_doi1.Location = new System.Drawing.Point(177, 7);
            this.cb_doi1.Name = "cb_doi1";
            this.cb_doi1.Size = new System.Drawing.Size(199, 21);
            this.cb_doi1.TabIndex = 5;
            this.cb_doi1.SelectedIndexChanged += new System.EventHandler(this.cb_doi1_SelectedIndexChanged);
            // 
            // cb_doi2
            // 
            this.cb_doi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_doi2.FormattingEnabled = true;
            this.cb_doi2.Location = new System.Drawing.Point(552, 7);
            this.cb_doi2.Name = "cb_doi2";
            this.cb_doi2.Size = new System.Drawing.Size(196, 21);
            this.cb_doi2.TabIndex = 6;
            this.cb_doi2.SelectedIndexChanged += new System.EventHandler(this.cb_doi2_SelectedIndexChanged);
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.FormattingEnabled = true;
            this.txt_san.Location = new System.Drawing.Point(552, 42);
            this.txt_san.Name = "txt_san";
            this.txt_san.Size = new System.Drawing.Size(196, 21);
            this.txt_san.TabIndex = 7;
            this.txt_san.SelectedIndexChanged += new System.EventHandler(this.txt_san_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.52921F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.47079F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(893, 291);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 266);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Danh Sách Các Trận Đấu";
            // 
            // quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1
            // 
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DataSetName = "QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet";
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // vongdauTableAdapter1
            // 
            this.vongdauTableAdapter1.ClearBeforeFill = true;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // doibonG_MUAGIAITableAdapter1
            // 
            this.doibonG_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // frmTaoLichThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 465);
            this.Controls.Add(this.panel1);
            this.Icon = global::QuanLiGiaiVoDichBongDaQuocGia.Properties.Resources.Icon;
            this.Name = "frmTaoLichThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Lịch Thi Đấu";
            this.Load += new System.EventHandler(this.frmTaoLichThiDau_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter vongdauTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_matrandau;
        private System.Windows.Forms.ComboBox cb_muagiai;
        private System.Windows.Forms.ComboBox cb_vongdau;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_thoigian;
        private System.Windows.Forms.ComboBox cb_doi1;
        private System.Windows.Forms.ComboBox cb_doi2;
        private System.Windows.Forms.ComboBox txt_san;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}