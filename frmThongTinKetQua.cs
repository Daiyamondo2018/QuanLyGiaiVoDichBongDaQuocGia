
using QuanLiGiaiVoDichBongDaQuocGia;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinKetQua : MyForm
    {
        public frmThongTinKetQua()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadTreeView();
        }

        #region Support
        public void LoadTreeView()
        {
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
            {
                TreeNode muagiai = new TreeNode();
                muagiai.Text = row["TenMua"].ToString();
                muagiai.Tag = row["MaMua"].ToString();
                muagiai.Name = "muagiai";
                muagiai.Nodes.Add("*");
                tv_trandau.Nodes.Add(muagiai);
            }

        }
        #endregion

        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            List<string> listvongdau = new List<string>();
            List<string> listtrandau = new List<string>();
            if(e.Node.Name=="muagiai")
            {
                e.Node.Nodes.Clear();
                this.vongdauTableAdapter1.FillByMaMua(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU, e.Node.Tag.ToString());

                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU.Rows)
                {
                    TreeNode vongdau = new TreeNode();
                    vongdau.Text = row["TenVong"].ToString();
                    vongdau.Tag = row["MaVong"].ToString();
                    vongdau.Name = "vongdau";
                    vongdau.Nodes.Add("*");
                    e.Node.Nodes.Add(vongdau);
                }
            }
            else if (e.Node.Name == "vongdau")
            {
                this.trandauTableAdapter1.FillByMaVong(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU, e.Node.Tag.ToString().Trim());
                e.Node.Nodes.Clear();
                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    TreeNode trandau = new TreeNode();
                    trandau.Text = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString()) +"-"+ this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi2"].ToString());
                    trandau.Tag = row["MaTranDau"].ToString();
                    trandau.Name = "trandau";
                    e.Node.Nodes.Add(trandau);
                }
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name=="trandau")
            {
                this.trandauTableAdapter1.FillByMaTranDau(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU,e.Node.Tag.ToString());
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    txt_doi1.Text = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString());
                    txt_doi2.Text= this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString());
                    txt_san.Text = this.sanTableAdapter1.LayTenSanTuMaSan(row["MaSan"].ToString());
                    txt_thoigian.Text = row["NgayGioDuKien"].ToString();
                    txt_sobanthangdoi1.Text = row["SoBanThangDoi1"].ToString();
                    txt_sobanthangdoi2.Text = row["SoBanThangDoi2"].ToString();
                    this.cT_GHIBANTableAdapter1.FillByMaTranDau(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CT_GHIBAN, row["MaTranDau"].ToString());
                    lv_cauthughiban.Items.Clear();
                    int i = 1;
                    foreach (DataRow r in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CT_GHIBAN.Rows)
                    {
                        string[] item = new string[4];
                        string mathidau = r["MaThiDau"].ToString();
                        string macauthu = this.doibonG_CAUTHUTableAdapter1.LayMaCauThuTuMaThiDau(mathidau);
                        item[0] = i.ToString();
                        item[1] = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                        item[2] = this.loaibanthangTableAdapter1.LayTenLoaiTuMaLoai(r["MaLoaiBanThang"].ToString());
                        item[3] = r["ThoiDiem"].ToString();
                        ListViewItem it = new ListViewItem(item);
                        lv_cauthughiban.Items.Add(it);
                        i++;
                    }
                }
                
            }
        }

    }
}
