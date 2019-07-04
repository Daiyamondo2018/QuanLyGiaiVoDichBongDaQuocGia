using QuanLiGiaiVoDichBongDaQuocGia;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class frmThongTinDoi : MyForm
    {
        public frmThongTinDoi()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadTreeView();
        }
        #region NewData
        public static string masan = "";
        #endregion

        #region Support
        //load danh sách các mùa giải và gán vào treeview
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
                tv_doibong.Nodes.Add(muagiai);
            }

        }
        #endregion


        #region Event
        private void txt_thongtinsan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (masan != "")
            {
                frmThongTinSan frm = new frmThongTinSan(masan);
                frm.ShowDialog();

            }
        }

        private void tv_doibong_AfterExpand(object sender, TreeViewEventArgs e)
        {
            List<string> listmadoi = new List<string>();
            if (e.Node.Name == "muagiai")
            {
                e.Node.Nodes.Clear();
                this.doibonG_MUAGIAITableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI, e.Node.Tag.ToString());
                foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI.Rows)
                {
                    listmadoi.Add(row["MaDoi"].ToString());
                }
                foreach (string madoi in listmadoi)
                {
                    this.doibongTableAdapter1.FillByMaDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG, madoi);
                    foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Rows)
                    {
                        TreeNode doiNode = new TreeNode();
                        doiNode.Text = row["TenDoi"].ToString();
                        doiNode.Tag = madoi;
                        doiNode.Name = "doibong";
                        e.Node.Nodes.Add(doiNode);
                    }
                }

            }
        }

        private void tv_doibong_MouseClick(object sender, MouseEventArgs e)
        {



        }
        

        private void tv_doibong_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "muagiai")
            {
                
            }
            else if (e.Node.Name == "doibong")
            {
                lv_cauthu.Items.Clear();

                label_tendoi.Text = e.Node.Text;

                this.doibonG_MUAGIAITableAdapter1.FillByMaDoi_MaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI, e.Node.Tag.ToString().Trim(), e.Node.Parent.Tag.ToString().Trim());
                foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI.Rows)
                {
                    masan = row["MaSan"].ToString();
                }

                this.sanTableAdapter1.FillByMaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN, masan);
                foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN.Rows)
                {
                    txt_san.Text = row["TenSan"].ToString();
                }
                List<string> listmacauthu = new List<string>();


                string mathamgia = this.doibonG_MUAGIAITableAdapter1.LayMaThamGia(e.Node.Parent.Tag.ToString().Trim(), e.Node.Tag.ToString().Trim());
                this.cauthuTableAdapter1.FillByMaThamGia_ThongTinDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, mathamgia);
                foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
                {
                    listmacauthu.Add(row["MaCauThu"].ToString());
                }

                int i = 1;
                foreach (string macauthu in listmacauthu)
                {
                    
                    this.cauthuTableAdapter1.FillByMaCauThu(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, macauthu);
                    foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
                    {
                        string[] cauthu = new string[6];
                        cauthu[0] = i.ToString();
                        cauthu[1] = row["TenCauThu"].ToString();
                        cauthu[2] = row["NgaySinh"].ToString();
                        cauthu[3] = row["MaLoaiCauThu"].ToString();
                        cauthu[3] = this.loaicauthuTableAdapter1.LayLoaiCauThuTuMaLoaiCauThu(cauthu[3]);
                        cauthu[4] = row["QuocTich"].ToString();
                        cauthu[5] = row["GhiChu"].ToString();
                        ListViewItem item = new ListViewItem(cauthu);
                        lv_cauthu.Items.Add(item);
                        i++;
                    }
                }
                
            }
            else if (e.Node.Name == "cauthu")
            {
                
            }
        }
        #endregion
    }
}
