using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : MyForm
    {
        public frmDangKy()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel_dangky;
            LoadData();
            trangthai = TrangThai.none;
            BindingData();
            LockControls();
        }
        #region NewData
        //các dữ liệu cần thiết
        enum TrangThai { them,xoa,sua,none};
        private static TrangThai trangthai;
        private string madoi, tendoi, sannha, masan,mamua, mamua_pre;
        #endregion

        #region support
        //Lấy thông tin mùa giải set cho chcekbo mùa giải
        private void FillMuaGiai()
        {
            try
            {
                this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
                cb_muagiai.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI;
                cb_muagiai.DisplayMember = "TenMua";
                cb_muagiai.ValueMember = "MaMua";
                cb_muagiai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_muagiai.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //xóa dữ liệu trên các text view
        public void Clear()
        {
            txt_tendoi.Text = "";
            txt_sannha.Text = "";
            cb_muagiai.Text = "";
            txt_succhua.Text = "";
            txt_diachi.Text = "";
        }
        //khóa các textbox khi button chức năng chưa được nhấn
        public void LockControls()
        {
            txt_tendoi.Enabled = false;
            cb_muagiai.Enabled = false;
            txt_sannha.Enabled = false;
            txt_diachi.Enabled = false;
            txt_succhua.Enabled = false;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
        //mở khóa textbox sau khi button chức năng được nhấn
        public void UnLockControls()
        {
            txt_tendoi.Enabled = true;
            cb_muagiai.Enabled = true;
            txt_sannha.Enabled = true;
            txt_diachi.Enabled = true;
            txt_succhua.Enabled = true;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //binding dữ liệu khi nhấp vào một dòng trên datagridview
        public void BindingData()
        {
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaDoi");

            txt_tendoi.DataBindings.Clear();
            txt_tendoi.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi");

            cb_muagiai.DataBindings.Clear();
            cb_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "TenMua");

            txt_sannha.DataBindings.Clear();
            txt_sannha.DataBindings.Add("Text", dataGridView1.DataSource, "TenSan");

            txt_succhua.DataBindings.Clear();
            txt_succhua.DataBindings.Add("Text", dataGridView1.DataSource, "SucChua");

            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");

            txt_masan.DataBindings.Clear();
            txt_masan.DataBindings.Add("Text", dataGridView1.DataSource, "MaSan");
        }

        //ngưng binding sau khi nhấn hủy
        private void NotBindingData()
        {
            txt_madoi.DataBindings.Clear();
            txt_tendoi.DataBindings.Clear();
            cb_muagiai.DataBindings.Clear();
            txt_sannha.DataBindings.Clear();
            txt_succhua.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_masan.DataBindings.Clear();
        }


        //tạo các trườg dữ liệu cho datagridview
        private DataTable createTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(string));
            dataTable.Columns.Add("MaDoi", typeof(string));
            dataTable.Columns.Add("TenDoi", typeof(string));
            dataTable.Columns.Add("TenMua", typeof(string));
            dataTable.Columns.Add("MaSan", typeof(string));
            dataTable.Columns.Add("TenSan", typeof(string));
            dataTable.Columns.Add("DiaChi", typeof(string));
            dataTable.Columns.Add("SucChua", typeof(string));
            return dataTable;
        }

        //thêm một dòng vào datagridview
        private void ThemRow(ref DataTable dt,string i, string madoi, string tendoi,
            string tenmua, string masan, string tensan,
            string diachi,string succhua)
        {
            dt.Rows.Add(i,madoi, tendoi, tenmua, masan, tensan, diachi, succhua);
        }
        // Lấy thông tin của đội bóng
        public string [] TaiDoi(string madoi)
        {
            string []doi = new string[2];
            this.doibongTableAdapter1.FillByMaDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG, madoi);
            foreach(DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Rows)
            {
                doi[0] = row["MaDoi"].ToString();
                doi[1] = row["TenDoi"].ToString();
            }
            return doi;
        }

        //tạo mã đội khi một đội đăng kí mới
        public string TaoMaDoi()
        {
            try
            {
                if(this.doibongTableAdapter1.DemSoDoiBong()==0)
                {
                    return "DB0001";
                }
                string ID_Doi = "";
                this.doibongTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG.Rows)
                {
                    ID_Doi = row["MaDoi"].ToString();
                }
                string temp = ID_Doi.Substring(2);
                int tem = int.Parse(temp);
                tem++;
                ID_Doi = "0000" + tem;
                ID_Doi = "DB" + ID_Doi.Substring(ID_Doi.Length - 4);
                return ID_Doi;

            }
            catch (Exception)
            {
            }
            return null;
        }

        //tạo mã sân của đội vừa đăng kí
        private string TaoMaSan()
        {

            try
            {
                if (this.sanTableAdapter1.DemSoLuongSan() == 0)
                {
                    return "MS0001";
                }
                string ID_San = "";
                this.sanTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN);
                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN.Rows)
                {
                    ID_San = row["MaSan"].ToString();
                }
                string temp = ID_San.Substring(2);
                int tem = int.Parse(temp);
                tem++;
                ID_San = "0000" + tem;
                ID_San = "MS" + ID_San.Substring(ID_San.Length - 4);
                return ID_San;

            }
            catch (Exception)
            {
            }
            return null;
        }


        //tạo mã tham gia cho đội vừa đăng kí
        private string TaoMaThamGia()
        {
            
            try
            {
                if(this.doibonG_MUAGIAITableAdapter1.DemSoMaThamGia()==0)
                {
                    return "TG0001";
                }
                string ID_MaThamGia = "";
                this.doibonG_MUAGIAITableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI);
                foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI.Rows)
                {
                    ID_MaThamGia = row["MaThamGia"].ToString();
                }
                string temp = ID_MaThamGia.Substring(2);
                int tem = int.Parse(temp);
                tem++;
                ID_MaThamGia = "0000" + tem;
                ID_MaThamGia = "TG" + ID_MaThamGia.Substring(ID_MaThamGia.Length - 4);
                return ID_MaThamGia;
            }
            catch (Exception)
            {
            }
            return null;
        }

        //Lấy thông tin sân
        public string[] TaiSan(string masan)
        {
            string[] san = new string[4];
            this.sanTableAdapter1.FillByMaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN, masan);
            foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN.Rows)
            {
                san[0] = row["MaSan"].ToString();
                san[1] = row["TenSan"].ToString();
                san[2] = row["DiaChi"].ToString();
                san[3] = row["SucChua"].ToString();
            }
            return san;
        }
        //Lấy thông tin mùa
        public string TaiMua(string mamua)
        {
            this.muagiaiTableAdapter1.FillByMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI, mamua);
            foreach(DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
            {
                return row["TenMua"].ToString();
            }
            return null;
        }
        //Load dữ liệu cho datagridview
        private void LoadData()
        {
            DataTable dataTable = createTable();
            int i = 1;
            this.doibonG_MUAGIAITableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI);
            foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI.Rows)
            {
                string[] doi = TaiDoi(row["MaDoi"].ToString());
                string[] san = TaiSan(row["MaSan"].ToString());
                string mua = TaiMua(row["MaMua"].ToString());
                ThemRow(ref dataTable, i.ToString(),doi[0], doi[1], mua, san[0], san[1], san[2], san[3]);
                i++;
            }
            dataGridView1.DataSource = dataTable;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        #endregion

        #region event
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                switch (trangthai)
                {
                    case TrangThai.them:
                        {
                            madoi = TaoMaDoi();
                            tendoi = txt_tendoi.Text.Trim();
                            sannha = txt_sannha.Text.Trim();
                            masan = TaoMaSan();
                            string mathamgia = TaoMaThamGia();
                            string diachi = txt_diachi.Text.Trim();
                            string succhua = txt_succhua.Text.Trim();


                            if (txt_tendoi.Text == "")
                            {
                                MessageBox.Show("Nhập tên đội");
                                return;
                            }

                            if (txt_sannha.Text == "")
                            {
                                MessageBox.Show("Nhập tên sân");
                                return;
                            }

                            if (txt_succhua.Text == "")
                            {
                                MessageBox.Show("Nhập sức chưa");
                                return;
                            }

                            if (txt_diachi.Text == "")
                            {
                                MessageBox.Show("Nhập địa chỉ sân");
                                return;
                            }

                            this.doibongTableAdapter1.Insert(madoi, tendoi);
                            this.sanTableAdapter1.Insert(masan, sannha, diachi, int.Parse(succhua));
                            this.doibonG_MUAGIAITableAdapter1.Insert(mathamgia, mamua, madoi, masan);
                            this.bangxephangTableAdapter1.Insert(DateTime.Now, mathamgia, 0, 0, 0, 0, 0);
                            MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Clear();
                            LoadData();
                            BindingData();
                            LockControls();
                            break;
                        }
                    case TrangThai.sua:
                        {
                            madoi = txt_madoi.Text.Trim();
                            masan = txt_masan.Text.Trim();
                            cb_muagiai.Enabled = false;
                            if (txt_tendoi.Text == "")
                            {
                                MessageBox.Show("Nhập tên đội");
                                return;
                            }

                            if (txt_sannha.Text == "")
                            {
                                MessageBox.Show("Nhập tên sân");
                                return;
                            }

                            if (txt_succhua.Text == "")
                            {
                                MessageBox.Show("Nhập sức chứa");
                                return;
                            }

                            if (txt_diachi.Text == "")
                            {
                                MessageBox.Show("Nhập địa chỉ sân");
                                return;
                            }
                            mamua = cb_muagiai.SelectedValue.ToString();
                            string mathamgia = doibonG_MUAGIAITableAdapter1.LayMaThamGia(mamua_pre, madoi);
                            this.doibongTableAdapter1.UpdateByMaDoi(txt_tendoi.Text.Trim(), madoi);
                            this.doibonG_MUAGIAITableAdapter1.FillByMaThamGia(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI, mathamgia);
                            //this.doibonG_MUAGIAITableAdapter1.FillByMaDoi_MaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_MUAGIAI, madoi, mamua);
                            this.sanTableAdapter1.UpdateByMaSan(txt_sannha.Text.Trim(), txt_diachi.Text.Trim(), int.Parse(txt_succhua.Text.Trim()), masan);
                            this.doibonG_MUAGIAITableAdapter1.UpdateByMaThamGia(mamua, madoi, masan, mathamgia);
                            MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            BindingData();
                            LockControls();
                            break;
                        }
                    case TrangThai.xoa:
                        {
                            madoi = txt_madoi.Text.Trim();
                            if (cb_muagiai.SelectedValue != null && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                masan = txt_masan.Text.Trim();
                                mamua = cb_muagiai.SelectedValue.ToString();
                                string mathamgia = doibonG_MUAGIAITableAdapter1.LayMaThamGia(mamua, madoi);
                                if (this.doibonG_MUAGIAITableAdapter1.DemSoDoiTheoMua(mamua) != 0)
                                {
                                    MessageBox.Show("Mùa giải đã có đội đăng kí, vui lòng xóa các đội đăng kí trước khi xóa mùa giải");
                                }
                                else
                                {
                                    this.bangxephangTableAdapter1.DeleteByMaThamGia(mathamgia);
                                    this.doibonG_MUAGIAITableAdapter1.DeleteByMaThamGia(mathamgia);
                                    this.doibongTableAdapter1.DeleteByMaDoi(madoi);
                                    this.sanTableAdapter1.DeleteByMaSan(masan);
                                }
                            }
                            //Clear();
                            BindingData();
                            LoadData();
                            LockControls();
                            break;
                        }
                    default:
                        break;
                }
                trangthai = TrangThai.none;
                btn_them.Focus();
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            UnLockControls();
            btn_them.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            FillMuaGiai();
            NotBindingData();
            Clear();
            trangthai = frmDangKy.TrangThai.them;
            txt_tendoi.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            UnLockControls();
            FillMuaGiai();
            btn_xacnhan.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            cb_muagiai.Enabled = false;
            //BindingData();
            trangthai = frmDangKy.TrangThai.sua;
            mamua_pre = cb_muagiai.SelectedValue.ToString();
        }
    
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xacnhan.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            //Clear();
            FillMuaGiai();
            //BindingData();
            trangthai = frmDangKy.TrangThai.xoa;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LockControls();
            btn_xacnhan.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            //Clear();
            //NotBindingData();
            BindingData();
            trangthai = TrangThai.none;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            

        }

        //mã mùa tự động thay đổi theo giá trị được chọn từ combobox
        private void cb_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_muagiai.Text!="")
            {
                mamua = cb_muagiai.SelectedValue.ToString();
            }
        }

        //kiểm tra nếu ô sức chưa nhập vào không phải số thì không nhận giá trị nhập vào
        private void txt_succhua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }

}
