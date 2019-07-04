using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinLichThiDau : MyForm
    {
        public frmThongTinLichThiDau()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel1;
            FillMuaGiai();
            LoadListView();
        }

        #region NewData
        string mamua, tenmua, mavong, tenvong;
        string tendoi1, tendoi2, thoigian, san, vongdau;
        #endregion

        #region Support

        public void FillMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            cb_muagiai.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
        }

        public void FillVongDau(string mamua)
        {
            this.vongdauTableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU, mamua);
            cb_vong.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU;
            cb_vong.DisplayMember = "TenVong";
            cb_vong.ValueMember = "MaVong";
        }

        
        public void LoadListView()
        {
            lv_lichthidau.Items.Clear();
            this.trandauTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU);
            int i = 1;
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
            {
                string[] trandau = new string[7];
                trandau[0] = i.ToString();
                trandau[1] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString());
                trandau[2] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["maDoi2"].ToString());
                trandau[3] = row["NgayGioDuKien"].ToString();
                trandau[4] = this.sanTableAdapter1.LayTenSanTuMaSan(row["MaSan"].ToString());
                trandau[5] = this.vongdauTableAdapter1.LayTenVongTuMaVong(row["MaVong"].ToString());
                trandau[6] = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(row["MaVong"].ToString());
                ListViewItem item = new ListViewItem(trandau);
                lv_lichthidau.Items.Add(item);
                i++;
            }
        }

        public void ClearLabel()
        {
            label_doi1.Text = "";
            label_doi2.Text = "";
            label_mua.Text = "";
            label_san.Text = "";
            label_thoigian.Text = "";
            label_vong.Text = "";
        }

        #endregion


        #region event

        private void cb_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_muagiai.SelectedValue != null)
            {
                mamua = cb_muagiai.SelectedValue.ToString();
                int i = 1;
                lv_lichthidau.Items.Clear();
                this.trandauTableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU, mamua);
                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    string[] trandau = new string[7];
                    trandau[0] = i.ToString();
                    trandau[1] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString());
                    trandau[2] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["maDoi2"].ToString());
                    trandau[3] = row["NgayGioDuKien"].ToString();
                    trandau[4] = this.sanTableAdapter1.LayTenSanTuMaSan(row["MaSan"].ToString());
                    trandau[5] = this.vongdauTableAdapter1.LayTenVongTuMaVong(row["MaVong"].ToString());
                    trandau[6] = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(row["MaVong"].ToString());
                    ListViewItem item = new ListViewItem(trandau);
                    string mua = this.vongdauTableAdapter1.LayMaMuaTuMaVong(row["MaVong"].ToString());
                    if(mua.Equals(mamua))
                    {
                        lv_lichthidau.Items.Add(item);
                        i++;
                    }
                }
                FillVongDau(mamua);
                label7.Visible = true;
                cb_vong.Visible = true;
            }
        }

        private void cb_vong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_vong.SelectedValue!=null)
            {
                mavong = cb_vong.SelectedValue.ToString();
                int i = 1;
                mavong = cb_vong.SelectedValue.ToString();
                lv_lichthidau.Items.Clear();
                this.trandauTableAdapter1.FillByMaVong(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU, mavong);
                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    string[] trandau = new string[7];
                    trandau[0] = i.ToString();
                    trandau[1] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString());
                    trandau[2] = this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["maDoi2"].ToString());
                    trandau[3] = row["NgayGioDuKien"].ToString();
                    trandau[4] = this.sanTableAdapter1.LayTenSanTuMaSan(row["MaSan"].ToString());
                    trandau[5] = this.vongdauTableAdapter1.LayTenVongTuMaVong(row["MaVong"].ToString());
                    trandau[6] = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(row["MaVong"].ToString());
                    ListViewItem item = new ListViewItem(trandau);
                    
                    if(row["MaVong"].ToString().Equals(mavong))
                    {
                        lv_lichthidau.Items.Add(item);
                        i++;
                    }
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tendoi = txt_dieukien.Text.Trim();
            foreach(ListViewItem i in lv_lichthidau.Items)
            {
                if(i.SubItems[1].Text.Contains(tendoi)|| i.SubItems[2].Text.Contains(tendoi))
                {
                    
                }
                else
                {
                    lv_lichthidau.Items.Remove(i);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadListView();
            ClearLabel();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_dieukien.Text = "";
            LoadListView();
        }


        private void lv_lichthidau_MouseClick(object sender, MouseEventArgs e)
        {
            label_doi1.Text = lv_lichthidau.SelectedItems[0].SubItems[1].Text;
            label_doi2.Text = lv_lichthidau.SelectedItems[0].SubItems[2].Text;
            label_thoigian.Text = lv_lichthidau.SelectedItems[0].SubItems[3].Text;
            label_san.Text = lv_lichthidau.SelectedItems[0].SubItems[4].Text;
            label_vong.Text = lv_lichthidau.SelectedItems[0].SubItems[5].Text;
            label_mua.Text = lv_lichthidau.SelectedItems[0].SubItems[6].Text;
        }
        #endregion
    }

}

