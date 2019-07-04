using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmTaoLichThiDau : MyForm
    { 
        public frmTaoLichThiDau()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadDataGridView();
            dtsan = TaoBangSan();
            Locktextbox();
            UnLockButton();
            trangthai = TrangThai.none;
            BindingData();
            btn_them.Focus();
        }

        #region NewData
        //các dữ liệu cần thiết
        string mavongdau, matrandau, madoi1, madoi2, masan, mamua, tenmua;
        DateTime thoigian;
        enum TrangThai { them, sua, xoa,none };
        private static TrangThai trangthai;
        DataTable dtsan = new DataTable();
        #endregion

        #region Support
        //xóa text trên textbox và combobox
        public void Clear()
        {
            cb_muagiai.Text = "";
            cb_vongdau.Text = "";
            cb_doi1.Text = "";
            cb_doi2.Text = "";
            txt_san.Text = "";
            txt_thoigian.Text = "";
        }
        //load và đổ dữ liệu vào datagridview
        private void LoadDataGridView()
        {
            this.trandauTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU);
            DataTable dataTable = newTableDataGridView();
            int i = 1;
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
            {
                matrandau = row["MaTranDau"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                madoi2 = row["MaDoi2"].ToString();
                thoigian = Convert.ToDateTime(row["NgayGioDuKien"].ToString());
                masan = row["MaSan"].ToString();
                mavongdau = row["MaVong"].ToString();

                tenmua = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(mavongdau);
                string tendoi1 = LayTenDoi(madoi1);
                string tendoi2 = LayTenDoi(madoi2);
                string tensan = LayTenSan(masan);
                string tenvongdau = LayTenVong(mavongdau);
                dataTable.Rows.Add(i.ToString(), matrandau, tendoi1, tendoi2, thoigian.ToString(), tensan, tenvongdau, tenmua);
                i++;
            }
            dataGridView1.DataSource = dataTable;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }
        //tạo bảng cho datagridview
        private DataTable newTableDataGridView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(string));
            table.Columns.Add("MaTranDau", typeof(string));
            table.Columns.Add("TenDoi1", typeof(string));
            table.Columns.Add("TenDoi2", typeof(string));
            table.Columns.Add("NgayGioDuKien", typeof(string));
            table.Columns.Add("San", typeof(string));
            table.Columns.Add("VongDau", typeof(string));
            table.Columns.Add("MuaGiai", typeof(string));
            return table;
        }
        //binding dữ liệu cho textbox và combobox
        public void BindingData()
        {
            
            txt_san.DataBindings.Clear();
            txt_san.DataBindings.Add("Text", dataGridView1.DataSource, "San");

            txt_thoigian.DataBindings.Clear();
            txt_thoigian.DataBindings.Add("Text", dataGridView1.DataSource, "NgayGioDuKien");

            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MaTranDau");

            cb_muagiai.DataBindings.Clear();
            cb_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MuaGiai");

            cb_vongdau.DataBindings.Clear();
            cb_vongdau.DataBindings.Add("Text", dataGridView1.DataSource, "VongDau");

            cb_doi1.DataBindings.Clear();
            cb_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi1");

            cb_doi2.DataBindings.Clear();
            cb_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi2");
        }
        //không binding khi nhấn hủy
        public void NotBindingData()
        {
            txt_thoigian.DataBindings.Clear();
            txt_san.DataBindings.Clear();
            txt_matrandau.DataBindings.Clear();
            cb_muagiai.DataBindings.Clear();
            cb_vongdau.DataBindings.Clear();
            cb_doi1.DataBindings.Clear();
            cb_doi2.DataBindings.Clear();

        }
        //khóa textbox
        public void Locktextbox()
        {
            cb_muagiai.Enabled = false;
            cb_vongdau.Enabled = false;
            cb_doi1.Enabled = false;
            cb_doi2.Enabled = false;
            txt_san.Enabled = false;
            txt_thoigian.Enabled = false;
        }
        //mở khóa textbox
        public void UnLocktextbox()
        {
            cb_muagiai.Enabled = true;
            cb_vongdau.Enabled = true;
            cb_doi1.Enabled = true;
            cb_doi2.Enabled = true;
            txt_san.Enabled = false;
            txt_thoigian.Enabled = true;
        }
        //khóa button
        public void LockButton()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //mở khóa button
        public void UnLockButton()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
        }
        //lấy tên đội từ mã đội
        private string LayTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter1.FillByMaDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG, madoi);
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Rows)
            {
                tendoi = row["TenDoi"].ToString();
            }
            return tendoi;
        }
        //lấy tên sân từ mã sân
        private string LayTenSan(string masan)
        {
            string tensan = "";
            this.sanTableAdapter1.FillByMaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN, masan);
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN.Rows)
            {
                tensan = row["TenSan"].ToString();
            }
            return tensan;
        }
        //lấy tên vòng đấu từ mã vòng
        private string LayTenVong(string mavong)
        {
            string tenvong = "";
            this.vongdauTableAdapter1.FillByMaVong(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU, mavong);
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU.Rows)
            {
                tenvong = row["TenVong"].ToString();
            }
            return tenvong;
        }
        //tạo mã trận đấu khi thêm mới
        private string TaoMaTranDau()
        {
            try
            {
                if(this.trandauTableAdapter1.DemSoTranDau()==0)
                {
                    return "TD0001";
                }
                string ID_TranDau = "";
                this.trandauTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    ID_TranDau = row["MaTranDau"].ToString();
                }
                int tem = int.Parse(ID_TranDau.Substring(2))+1;
                ID_TranDau = "0000" + tem;
                ID_TranDau = "TD" + ID_TranDau.Substring(ID_TranDau.Length - 4);
                return ID_TranDau;
            }
            catch (Exception)
            {
            }
            return null;
        }
        //tạo bảng cho combobox sân để gán datasource
        private DataTable TaoBangSan()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TenSan", typeof(string));
            dataTable.Columns.Add("MaSan", typeof(string));
            return dataTable;
        }
        //lấy thông tin sân của một đội bóng
        private string[] LayThongTinSan(string mamua, string madoi)
        {
            string[] temp = new string[2];
            string masan = this.doibonG_MUAGIAITableAdapter1.LayMaSanByMaMua_MaDoi(mamua, madoi);
            this.sanTableAdapter1.FillByMaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN, masan);
            foreach (DataRow dataRow in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN.Rows)
            {
                temp[0] = dataRow["TenSan"].ToString();
                temp[1] = dataRow["MaSan"].ToString();
            }
            return temp;
        }


        #endregion

        #region event


        private void btn_them_Click_1(object sender, EventArgs e)
        {
            LockButton();
            btn_xacnhan.Focus();
            UnLocktextbox();
            NotBindingData();
            Clear();
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            cb_muagiai.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
            cb_muagiai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_muagiai.AutoCompleteSource = AutoCompleteSource.ListItems;
            txt_thoigian.Value = DateTime.Now.AddDays(1);
            trangthai = TrangThai.them;
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            LockButton();
            btn_xacnhan.Focus();
            //UnLocktextbox();
            txt_thoigian.Enabled = true;
            txt_thoigian.Focus();
            NotBindingData();
            trangthai = TrangThai.sua;
        }

        private void txt_thoigian_ValueChanged(object sender, EventArgs e)
        {
            if (trangthai == TrangThai.none||trangthai==TrangThai.xoa)
                return;
            else if (trangthai == TrangThai.them || trangthai == TrangThai.sua)
            {
                if (txt_thoigian.Value < DateTime.Now)
                {
                    txt_thoigian.Value = DateTime.Now.AddDays(1);
                    MessageBox.Show("Thời gian không hợp lệ, trận đấu phải diễn ra sau ngày hiện tại!");
                    return;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==dataGridView1.RowCount)
            {
                NotBindingData();
            }
            else
            {
                BindingData();
            }
        }

        private void cb_doi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_doi2.SelectedValue != null && cb_doi2.SelectedValue.ToString() != "")
            {
                madoi2 = cb_doi1.SelectedValue.ToString();
            }
        }

        private void cb_vongdau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_vongdau.SelectedValue!=null&&cb_vongdau.SelectedValue.ToString()!="")
            {
                mavongdau = cb_vongdau.SelectedValue.ToString();
            }
        }

        private void txt_san_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_doi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_doi1.SelectedValue != null)
            {
                madoi1 = cb_doi1.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Mùa giải chưa có đội đăng kí tham gia!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtsan.Rows.Clear();
            dtsan.Rows.Add(LayThongTinSan(mamua, madoi1));
            txt_san.DataSource = dtsan;
            txt_san.DisplayMember = "TenSan";
            txt_san.ValueMember = "MaSan";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            LockButton();
            btn_xacnhan.Focus();
            UnLocktextbox();
            cb_muagiai.Enabled = false;
            trangthai = TrangThai.xoa;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            trangthai = TrangThai.none;
            UnLockButton();
            btn_them.Focus();
            Locktextbox();
            //Clear();
            BindingData();
        }

        private void cb_muagiai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_muagiai.SelectedValue != null)
            {
                mamua = cb_muagiai.SelectedValue.ToString();
                try
                {
                    this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
                    cb_muagiai.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI;
                    cb_muagiai.DisplayMember = "TenMua";
                    cb_muagiai.ValueMember = "MaMua";
                   
                    this.vongdauTableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU, mamua);
                    cb_vongdau.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.VONGDAU;
                    cb_vongdau.DisplayMember = "TenVong";
                    cb_vongdau.ValueMember = "MaVong";
                   

                    if (this.vongdauTableAdapter1.DemSoVongTheoMua(mamua) == 0&&trangthai!=TrangThai.none)
                    {
                        MessageBox.Show("Mùa giải chưa có vòng đấu, vui lòng thêm vòng đấu trước khi tạo trận đấu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    this.doibongTableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG, mamua);
                    DataTable dataTable1 = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Copy();
                    DataTable dataTable2 = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Copy();


                    cb_doi1.DataSource = dataTable1;
                    cb_doi1.DisplayMember = "TenDoi";
                    cb_doi1.ValueMember = "MaDoi";

                    cb_doi2.DataSource = dataTable2;
                    cb_doi2.DisplayMember = "TenDoi";
                    cb_doi2.ValueMember = "MaDoi";

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            switch (trangthai)
            {
                case TrangThai.them:
                    {
                        if (this.vongdauTableAdapter1.DemSoVongTheoMua(mamua) == 0)
                        {
                            MessageBox.Show("Mùa giải chưa có vòng đấu, vui lòng thêm vòng đấu trước khi tạo trận đấu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        matrandau = TaoMaTranDau();
                        madoi1 = cb_doi1.SelectedValue.ToString();
                        madoi2 = cb_doi2.SelectedValue.ToString();
                        thoigian = DateTime.Parse(txt_thoigian.Value.ToString());
                        masan = txt_san.SelectedValue.ToString();
                        mavongdau = cb_vongdau.SelectedValue.ToString();
                        this.trandauTableAdapter1.Insert(matrandau, mavongdau, madoi1, madoi2, thoigian, thoigian, masan, 0, 0, 0);
                        MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.sua:
                    {
                        matrandau = txt_matrandau.Text.Trim();
                        thoigian = DateTime.Parse(txt_thoigian.Value.ToString());
                        mamua = this.muagiaiTableAdapter1.LayMaMuaTuMaVong(mavongdau);
                        string masan = this.doibonG_MUAGIAITableAdapter1.LayMaSanByMaMua_MaDoi(mamua, madoi1);
                        this.trandauTableAdapter1.UpdateByMaTranDau(mavongdau, madoi1, madoi2, thoigian, thoigian, masan, 0, 0, 0, matrandau);
                        MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.xoa:
                    {
                        if (
                        MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                        {
                            matrandau = txt_matrandau.Text.Trim();
                            this.trandauTableAdapter1.DeleteByMaTranDau(matrandau);
                        }
                        break;
                    }
            }
            trangthai = TrangThai.none;
            UnLockButton();
            btn_them.Focus();
            Locktextbox();
            LoadDataGridView();
            //Clear();
            BindingData();
        }


        private void frmTaoLichThiDau_Load(object sender, EventArgs e)
        {
           

        }

        #endregion

    }

}