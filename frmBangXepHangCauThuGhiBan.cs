using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiGiaiVoDichBongDaQuocGia;

namespace GUI
{
    public partial class frmBangXepHangCauThuGhiBan : MyForm
    {
        public frmBangXepHangCauThuGhiBan()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel1;
            FillDataGridView("");
            FillcbMuaGiai();
        }

        #region NewData
        string stt, macauthu, tencauthu, madoi, tendoi, maloaicauthu, loaicauthu, sobanthang, mathidau;

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string mamua, tenmua, mavong, tenvong;
        
        #endregion

        #region support

        public DataTable createtablecbmuagiai()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaMua",typeof(string));
            dataTable.Columns.Add("TenMua", typeof(string));
            return dataTable;
        }

        public DataTable createtable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT",typeof(string));
            dataTable.Columns.Add("CauThu", typeof(string));
            dataTable.Columns.Add("Doi", typeof(string));
            dataTable.Columns.Add("LoaiCauThu", typeof(string));
            dataTable.Columns.Add("SoBanThang", typeof(string));
            return dataTable;
        }
        
        public void FillDataGridView(string mamua)
        {

            DataTable dataTable = createtable();
            if (mamua == "")
            {
                this.doibonG_CAUTHUTableAdapter1.Fill(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_CAUTHU);
            }
            else
            {
                this.doibonG_CAUTHUTableAdapter1.FillByMaMua(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_CAUTHU, mamua); 
            }
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_CAUTHU.Rows)
            {
                mathidau = row["MaThiDau"].ToString();
                macauthu = row["MaCauThu"].ToString();
                sobanthang = row["SoLuongBanThang"].ToString();
                tencauthu = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                maloaicauthu = this.cauthuTableAdapter1.LayMaLoaiCauThuTuMaCauThu(macauthu);
                loaicauthu = this.loaicauthuTableAdapter1.LayLoaiCauThuTuMaLoaiCauThu(maloaicauthu);
                madoi = this.doibonG_MUAGIAITableAdapter1.LayMaDoiTuMaThiDau(mathidau);
                tendoi = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi);
                dataTable.Rows.Add("", tencauthu, tendoi, loaicauthu, sobanthang);
            }
            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            dataGridView1.ReadOnly = false;
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Index==dataGridView1.RowCount-1)
                {
                    return;
                }
                row.Cells[0].Value = i.ToString();
                i++;
            }
            dataGridView1.ReadOnly = true;
        }


        public void FillcbMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            DataTable dataTable = createtablecbmuagiai();
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
            {
                mamua = row["MaMua"].ToString();
                tenmua = row["TenMua"].ToString();
                dataTable.Rows.Add(mamua, tenmua);
            }
            cb_muagiai.DataSource = dataTable;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
        }
        #endregion

        #region Event


        private void cb_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_muagiai.SelectedValue!=null)
            {
                mamua = cb_muagiai.SelectedValue.ToString();
                FillDataGridView(mamua);
            }
        }

        #endregion
    }
}
