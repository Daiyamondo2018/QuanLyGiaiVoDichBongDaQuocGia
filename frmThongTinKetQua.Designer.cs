namespace GUI
{
    partial class frmThongTinKetQua
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_trandau = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sobanthangdoi1 = new System.Windows.Forms.TextBox();
            this.txt_sobanthangdoi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doi1 = new System.Windows.Forms.TextBox();
            this.txt_doi2 = new System.Windows.Forms.TextBox();
            this.txt_san = new System.Windows.Forms.TextBox();
            this.txt_thoigian = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lv_cauthughiban = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.muagiaiTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter();
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet();
            this.vongdauTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter();
            this.trandauTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.TRANDAUTableAdapter();
            this.doibongTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter();
            this.sanTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter();
            this.cT_GHIBANTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CT_GHIBANTableAdapter();
            this.doibonG_CAUTHUTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter();
            this.cauthuTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CAUTHUTableAdapter();
            this.loaibanthangTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAIBANTHANGTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 528);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(947, 528);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_trandau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(287, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mùa Giải - Trận Đấu";
            // 
            // tv_trandau
            // 
            this.tv_trandau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_trandau.Location = new System.Drawing.Point(3, 16);
            this.tv_trandau.Name = "tv_trandau";
            this.tv_trandau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tv_trandau.ShowLines = false;
            this.tv_trandau.Size = new System.Drawing.Size(281, 509);
            this.tv_trandau.TabIndex = 2;
            this.tv_trandau.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            this.tv_trandau.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(656, 528);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lv_cauthughiban, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 509);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 146);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16686F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60834F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.23986F));
            this.tableLayoutPanel2.Controls.Add(this.txt_sobanthangdoi1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_sobanthangdoi2, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_doi1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_doi2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_thoigian, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.25807F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 146);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txt_sobanthangdoi1
            // 
            this.txt_sobanthangdoi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sobanthangdoi1.Location = new System.Drawing.Point(259, 111);
            this.txt_sobanthangdoi1.Name = "txt_sobanthangdoi1";
            this.txt_sobanthangdoi1.ReadOnly = true;
            this.txt_sobanthangdoi1.Size = new System.Drawing.Size(71, 20);
            this.txt_sobanthangdoi1.TabIndex = 5;
            this.txt_sobanthangdoi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sobanthangdoi2
            // 
            this.txt_sobanthangdoi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sobanthangdoi2.Location = new System.Drawing.Point(336, 111);
            this.txt_sobanthangdoi2.Name = "txt_sobanthangdoi2";
            this.txt_sobanthangdoi2.ReadOnly = true;
            this.txt_sobanthangdoi2.Size = new System.Drawing.Size(68, 20);
            this.txt_sobanthangdoi2.TabIndex = 6;
            this.txt_sobanthangdoi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đôi 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đội 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sân:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_doi1
            // 
            this.txt_doi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_doi1.Location = new System.Drawing.Point(99, 14);
            this.txt_doi1.Name = "txt_doi1";
            this.txt_doi1.ReadOnly = true;
            this.txt_doi1.Size = new System.Drawing.Size(154, 20);
            this.txt_doi1.TabIndex = 1;
            // 
            // txt_doi2
            // 
            this.txt_doi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_doi2.Location = new System.Drawing.Point(410, 14);
            this.txt_doi2.Name = "txt_doi2";
            this.txt_doi2.ReadOnly = true;
            this.txt_doi2.Size = new System.Drawing.Size(157, 20);
            this.txt_doi2.TabIndex = 2;
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.Location = new System.Drawing.Point(410, 62);
            this.txt_san.Name = "txt_san";
            this.txt_san.ReadOnly = true;
            this.txt_san.Size = new System.Drawing.Size(157, 20);
            this.txt_san.TabIndex = 4;
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thoigian.CustomFormat = "HH:mm - dd/MM/yyyy ";
            this.txt_thoigian.Enabled = false;
            this.txt_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_thoigian.Location = new System.Drawing.Point(99, 62);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(154, 20);
            this.txt_thoigian.TabIndex = 3;
            this.txt_thoigian.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thời Gian:";
            // 
            // lv_cauthughiban
            // 
            this.lv_cauthughiban.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_cauthughiban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_cauthughiban.Location = new System.Drawing.Point(3, 155);
            this.lv_cauthughiban.Name = "lv_cauthughiban";
            this.lv_cauthughiban.Size = new System.Drawing.Size(644, 351);
            this.lv_cauthughiban.TabIndex = 2;
            this.lv_cauthughiban.UseCompatibleStateImageBehavior = false;
            this.lv_cauthughiban.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Cầu Thủ";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại Bàn Thắng";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời Điểm";
            this.columnHeader4.Width = 176;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1
            // 
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DataSetName = "QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet";
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vongdauTableAdapter1
            // 
            this.vongdauTableAdapter1.ClearBeforeFill = true;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // cT_GHIBANTableAdapter1
            // 
            this.cT_GHIBANTableAdapter1.ClearBeforeFill = true;
            // 
            // doibonG_CAUTHUTableAdapter1
            // 
            this.doibonG_CAUTHUTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter1
            // 
            this.cauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // loaibanthangTableAdapter1
            // 
            this.loaibanthangTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThongTinKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 528);
            this.Controls.Add(this.panel1);
            this.Icon = global::QuanLiGiaiVoDichBongDaQuocGia.Properties.Resources.Icon;
            this.Name = "frmThongTinKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Trận Đấu";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_trandau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_sobanthangdoi1;
        private System.Windows.Forms.TextBox txt_sobanthangdoi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_doi1;
        private System.Windows.Forms.TextBox txt_doi2;
        private System.Windows.Forms.TextBox txt_san;
        private System.Windows.Forms.DateTimePicker txt_thoigian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lv_cauthughiban;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.VONGDAUTableAdapter vongdauTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CT_GHIBANTableAdapter cT_GHIBANTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter doibonG_CAUTHUTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAIBANTHANGTableAdapter loaibanthangTableAdapter1;
    }
}