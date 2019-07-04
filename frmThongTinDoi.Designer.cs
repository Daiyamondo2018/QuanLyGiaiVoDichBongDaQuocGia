namespace GUI
{
    partial class frmThongTinDoi
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
            this.tv_doibong = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_cauthu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_tendoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_san = new System.Windows.Forms.TextBox();
            this.txt_thongtinsan = new System.Windows.Forms.LinkLabel();
            this.muagiaiTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter();
            this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet();
            this.doibonG_MUAGIAITableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.doibongTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter();
            this.sanTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter();
            this.cauthuTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CAUTHUTableAdapter();
            this.loaicauthuTableAdapter1 = new QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAICAUTHUTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1068, 429);
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
            this.splitContainer1.Panel1.Controls.Add(this.tv_doibong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1068, 429);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_doibong
            // 
            this.tv_doibong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_doibong.Location = new System.Drawing.Point(0, 0);
            this.tv_doibong.Name = "tv_doibong";
            this.tv_doibong.ShowLines = false;
            this.tv_doibong.Size = new System.Drawing.Size(275, 429);
            this.tv_doibong.TabIndex = 0;
            this.tv_doibong.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tv_doibong_AfterExpand);
            this.tv_doibong.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_doibong_NodeMouseClick);
            this.tv_doibong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tv_doibong_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lv_cauthu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lv_cauthu
            // 
            this.lv_cauthu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_cauthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_cauthu.FullRowSelect = true;
            this.lv_cauthu.Location = new System.Drawing.Point(3, 67);
            this.lv_cauthu.MultiSelect = false;
            this.lv_cauthu.Name = "lv_cauthu";
            this.lv_cauthu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_cauthu.Size = new System.Drawing.Size(783, 359);
            this.lv_cauthu.TabIndex = 0;
            this.lv_cauthu.UseCompatibleStateImageBehavior = false;
            this.lv_cauthu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cầu Thủ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 191;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 176;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại Cầu Thủ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quốc Tịch";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi Chú";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 101;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label_tendoi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_thongtinsan, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 58);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label_tendoi
            // 
            this.label_tendoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tendoi.AutoSize = true;
            this.label_tendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tendoi.Location = new System.Drawing.Point(3, 22);
            this.label_tendoi.Name = "label_tendoi";
            this.label_tendoi.Size = new System.Drawing.Size(254, 13);
            this.label_tendoi.TabIndex = 0;
            this.label_tendoi.Text = "Tên Đội";
            this.label_tendoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân Nhà:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.Location = new System.Drawing.Point(393, 19);
            this.txt_san.Name = "txt_san";
            this.txt_san.ReadOnly = true;
            this.txt_san.Size = new System.Drawing.Size(254, 20);
            this.txt_san.TabIndex = 0;
            // 
            // txt_thongtinsan
            // 
            this.txt_thongtinsan.ActiveLinkColor = System.Drawing.Color.Red;
            this.txt_thongtinsan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_thongtinsan.AutoSize = true;
            this.txt_thongtinsan.DisabledLinkColor = System.Drawing.Color.White;
            this.txt_thongtinsan.LinkColor = System.Drawing.Color.Black;
            this.txt_thongtinsan.Location = new System.Drawing.Point(653, 22);
            this.txt_thongtinsan.Name = "txt_thongtinsan";
            this.txt_thongtinsan.Size = new System.Drawing.Size(72, 13);
            this.txt_thongtinsan.TabIndex = 1;
            this.txt_thongtinsan.TabStop = true;
            this.txt_thongtinsan.Text = "Thông tin sân";
            this.txt_thongtinsan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txt_thongtinsan_LinkClicked);
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
            // doibonG_MUAGIAITableAdapter1
            // 
            this.doibonG_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter1
            // 
            this.cauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // loaicauthuTableAdapter1
            // 
            this.loaicauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThongTinDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 429);
            this.Controls.Add(this.panel1);
            this.Icon = global::QuanLiGiaiVoDichBongDaQuocGia.Properties.Resources.Icon;
            this.Name = "frmThongTinDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đội";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv_doibong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tendoi;
        private System.Windows.Forms.TextBox txt_san;
        private System.Windows.Forms.LinkLabel txt_thongtinsan;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSet quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter1;
        private System.Windows.Forms.ListView lv_cauthu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private QuanLiGiaiVoDichBongDaQuocGia.QuanLyGiaiVoDichBongDaQuocGia_FinalDataSetTableAdapters.LOAICAUTHUTableAdapter loaicauthuTableAdapter1;
    }
}