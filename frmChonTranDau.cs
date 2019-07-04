using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChonTranDau : Form
    {
        public frmChonTranDau()
        {
            InitializeComponent();
            LoadDataGridView();
            BindingData();
            LockControl();
        }


        #region NewData
        //các dữ liệu cần thiết
        public string matrandau,tenmua,mavong,tenvong,masan,tensan,madoi1,tendoi1,madoi2,tendoi2,thoigian, mamua;
        public int sobanthangdoi1, sobanthangdoi2, thoiluong;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Suppport

        //khóa các textbox
        public void LockControl()
        {
            txt_san.Enabled = false;
            txt_muagiai.Enabled = false;
            txt_vongdau.Enabled = false;
            txt_doi1.Enabled = false;
            txt_doi2.Enabled = false;
            txt_thoigian.Enabled = false;
        }
        //tạo bảng cho datagridview
        public DataTable NewDataGridView()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaTranDau", typeof(string));
            dataTable.Columns.Add("MuaGiai", typeof(string));
            dataTable.Columns.Add("VongDau", typeof(string));
            dataTable.Columns.Add("Doi1", typeof(string));
            dataTable.Columns.Add("Doi2", typeof(string));
            dataTable.Columns.Add("ThoiGian", typeof(string));
            dataTable.Columns.Add("San", typeof(string));
            return dataTable;
        }

        //binding dữ liệu lên các textbox
        public void BindingData()
        {
            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MaTranDau");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MuaGiai");

            txt_vongdau.DataBindings.Clear();
            txt_vongdau.DataBindings.Add("Text", dataGridView1.DataSource, "VongDau");

            txt_doi1.DataBindings.Clear();
            txt_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "Doi1");

            txt_doi2.DataBindings.Clear();
            txt_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "Doi2");

            txt_thoigian.DataBindings.Clear();
            txt_thoigian.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiGian");

            txt_san.DataBindings.Clear();
            txt_san.DataBindings.Add("Text", dataGridView1.DataSource, "San");
        }
        //load danh sách các trận đấu đổ vào datagridview
        public void LoadDataGridView()
        {
            DataTable dataTable = NewDataGridView();
            this.trandauTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
            {
                matrandau = row["MaTranDau"].ToString();
                mavong = row["MaVong"].ToString();
                tenmua = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(mavong);
                tenvong = this.vongdauTableAdapter1.LayTenVongTuMaVong(mavong);
                thoigian = row["NgayGioDuKien"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                tendoi1 = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi1);
                madoi2 = row["MaDoi2"].ToString();
                tendoi2 = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi2);
                masan = row["MaSan"].ToString();
                tensan = this.sanTableAdapter1.LayTenSanTuMaSan(masan);
                dataTable.Rows.Add(matrandau ,tenmua, tenvong, tendoi1, tendoi2, thoigian, tensan);
            }
            this.dataGridView1.DataSource = dataTable;
        }
        #endregion

        #region Event
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            matrandau = txt_matrandau.Text.Trim();
            this.trandauTableAdapter1.FillByMaTranDau(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU,matrandau);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
            {
                mavong=row["MaVong"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                madoi2 = row["MaDoi2"].ToString();
                sobanthangdoi1 = int.Parse(row["SoBanThangDoi1"].ToString());
                sobanthangdoi2=int.Parse(row["SoBanThangDoi2"].ToString());
                tendoi1 = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi1);
                tendoi2 = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi2);
                thoiluong = int.Parse(row["ThoiLuongThiDau"].ToString());
                masan = row["MaSan"].ToString();
                thoigian = row["NgayGioDuKien"].ToString();
            }
            this.Close();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            matrandau = "";
            this.Close();
        }
        #endregion

    }
}
