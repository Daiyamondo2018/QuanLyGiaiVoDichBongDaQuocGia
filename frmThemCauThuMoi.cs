using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemCauThuMoi : MyForm
    {
        public frmThemCauThuMoi()
        {
            InitializeComponent();
            this._Mypanel = panel_themcauthumoi;
            LoadQuyDinh();
            UnLockButton();
            Locktextbox();
        }


        #region New Data
        //các dữ liệu cần thiết
        enum TrangThai { them,xoa,sua,none};
        private static TrangThai trangthai;
        private string quoctich, tencauthu, loaicauthu, ghichu, maloaicauthu, macauthu, madoi, mamua;
        private DateTime ngaysinh;
        private int tuoitoithieu,tuoitoida,sct_toithieu,sct_toida,sct_nuocngoaitoida;
        #endregion

        #region Support

        //lấy thông tin các tham số từ bảng tham số
        public void LoadQuyDinh()
        {
            this.thamsoTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO);
            foreach(DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO.Rows)
            {
                tuoitoithieu = int.Parse(row["TuoiToiThieu"].ToString());
                tuoitoida = int.Parse(row["TuoiToiDa"].ToString());
                sct_toithieu = int.Parse(row["SoCauThuToiThieu"].ToString());
                sct_toida = int.Parse(row["SoCauThuToiDa"].ToString());
                sct_nuocngoaitoida = int.Parse(row["SoCauThuNuocNgoaiToiDa"].ToString());
            }
        }
        //load dữ liệu cho datagridview_BUGGING
        private void LoadDataGridView()
        {
            if(madoi!=""&&mamua!=""&&madoi!=null&&mamua!=null)
            {
                DataTable dataTable = createTable();
                string mathamgia = doibonG_MUAGIAITableAdapter1.LayMaThamGia(mamua, madoi);
                this.cauthuTableAdapter1.FillByMaThamGia(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, mathamgia);
                DataTable temp = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Copy();
                int i = 1;
                foreach (DataRow row in temp.Rows)
                {
                    dataTable.Rows.Add(GetInfoCauThu(row["MaCauThu"].ToString(),i));
                    i++;
                }
                dataGridView1.DataSource = dataTable;
                foreach (DataGridViewBand band in dataGridView1.Columns)
                {
                    band.ReadOnly = true;
                }
            }
        }
        //lấy thông tin cầu thủ dựa theo mã cầu thủ để set dữ liệu cho datagridview
        private string[] GetInfoCauThu(string macauthu, int i)
        {
            string[] info = new string[7];
            this.cauthuTableAdapter1.FillByMaCauThu(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, macauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
            {
                info[0] = i.ToString();
                info[1] = row["MaCauThu"].ToString();
                info[2] = row["TenCauThu"].ToString();
                info[3] = row["NgaySinh"].ToString();
                info[4] = GetLoaiCauThu(row["MaLoaiCauThu"].ToString());
                info[5] = row["QuocTich"].ToString();
                info[6] = row["GhiChu"].ToString();
                i++;
            }
            return info;
        }

        //Lấy thông tin loại cầu thủ
        private string GetLoaiCauThu(string maloaicauthu)
        {
            string loaicauthu = "";
            this.loaicauthuTableAdapter1.FillByMaLoaiCauThu(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU, maloaicauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU.Rows)
            {
                loaicauthu = row["LoaiCauThu"].ToString();
            }
            return loaicauthu;
        }

        //tạo mã cầu thủ khi thêm cầu thủ mới vào đội
        private string TaoMaCauThu()
        {
            try
            {
                if(this.cauthuTableAdapter1.DemSoCauThu()==0)
                {
                    return "CT0001";
                }
                string ID_CauThu = "";
                this.cauthuTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
                {
                    ID_CauThu = row["MaCauThu"].ToString();
                }
                int tem = int.Parse(ID_CauThu.Substring(2))+1;
                ID_CauThu = "0000" + tem;
                ID_CauThu = "CT" + ID_CauThu.Substring(ID_CauThu.Length - 4);
                return ID_CauThu;

            }
            catch (Exception)
            {
            }
            return null;
        }

        //Lấy dữ liệu từ lọi cầu thủ đã load set cho combobox loại cầu thủ
        private void FillTextLoaiCauThu()
        {
            this.loaicauthuTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU);
            
            cb_loaicauthu.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU;
           
            cb_loaicauthu.DisplayMember = "LoaiCauThu";
           
            cb_loaicauthu.ValueMember = "MaLoaiCauThu";

            cb_loaicauthu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cb_loaicauthu.AutoCompleteSource = AutoCompleteSource.ListItems;
           
        }

        //tạo các trường dữ liệu cho datagridview
        private DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("STT", typeof(string));
            tb.Columns.Add("MaCauThu", typeof(string));
            tb.Columns.Add("TenCauThu", typeof(string));
            tb.Columns.Add("NgaySinh", typeof(string));
            tb.Columns.Add("LoaiCauThu", typeof(string));
            tb.Columns.Add("QuocTich", typeof(string));
            tb.Columns.Add("GhiChu", typeof(string));
            return tb;
        }
        
        //ngưng binding dữ liệu khi nút hủy được nhấn
        private void NotBindingData()
        {
            txt_macauthu.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Clear();
            txt_quoctich.DataBindings.Clear();
            txt_ghichu.DataBindings.Clear();
            cb_loaicauthu.DataBindings.Clear();
        }
        //binding dữ liệu từ một dòng của datagridview cho các textbox và combobox
        private void BindingData()
        {
            txt_macauthu.DataBindings.Clear();
            txt_macauthu.DataBindings.Add("Text", dataGridView1.DataSource, "MaCauThu");

            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", dataGridView1.DataSource, "TenCauThu");

            txt_ngaysinh.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Add("Text", dataGridView1.DataSource, "NgaySinh");

            txt_quoctich.DataBindings.Clear();
            txt_quoctich.DataBindings.Add("Text", dataGridView1.DataSource, "QuocTich");

            txt_ghichu.DataBindings.Clear();
            txt_ghichu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");

            cb_loaicauthu.DataBindings.Clear();
            cb_loaicauthu.DataBindings.Add("Text", dataGridView1.DataSource, "LoaiCauThu");

        }

        //xóa dữ liệu của các textbox
        public void Clear()
        {
            txt_hoten.Text = "";
            cb_loaicauthu.Text = "";
            txt_quoctich.Text = "";
            txt_ghichu.Text = "";
        }
        //tính tuổi của cầu thủ vừa nhập_tính theo năm
        private int TinhTuoi(DateTime namsinh)
        {
            if (namsinh < DateTime.Now)
                return DateTime.Now.Year - namsinh.Year;
            return 0;
        }
        //lock các textbox khi các button chức năng chưa được nhấn
        public void Locktextbox()
        {
            txt_hoten.Enabled = false;
            txt_ngaysinh.Enabled = false;
            cb_loaicauthu.Enabled = false;
            txt_quoctich.Enabled = false;
            txt_ghichu.Enabled = false;
        }

        //unlock các textbox khi nhấn các button chức năng 
        public void UnLocktextbox()
        {
            txt_hoten.Enabled = true;
            txt_ngaysinh.Enabled = true;
            cb_loaicauthu.Enabled = true;
            txt_quoctich.Enabled = true;
            txt_ghichu.Enabled = true;
        }

        //lock các button chức năng khi trạng khác none
        public void LockButton()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //unlock các buttton chức năng khi ở trạng thái none
        public void UnLockButton()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
        }

        //tạo mã thi đấu cho cầu thủ_đội bóng
        private string TaoMaThiDau()
        {
            try
            {
                if(this.doibonG_CAUTHUTableAdapter1.DemSoMaThiDau()==0)
                {
                    return "TD0001";
                }
                string ID_MaThiDau = "";
                this.doibonG_CAUTHUTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_CAUTHU);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG_CAUTHU.Rows)
                {
                    ID_MaThiDau = row["MaThiDau"].ToString();
                }
                int tem = int.Parse(ID_MaThiDau.Substring(2))+1;
                ID_MaThiDau = "0000" + tem;
                ID_MaThiDau = "TD" + ID_MaThiDau.Substring(ID_MaThiDau.Length - 4);
                return ID_MaThiDau;

            }
            catch (Exception)
            {
            }
            return null;
        }

        #endregion

        #region event

        private void btn_chondoi_Click(object sender, System.EventArgs e)
        {
            FillTextLoaiCauThu();
            frmChonDoi frmchondoi = new frmChonDoi();
            frmchondoi.ShowDialog();
            txt_tendoi.Text = frmchondoi.tendoi;
            madoi = frmchondoi.madoi;
            mamua = frmchondoi.mamua;
            LoadDataGridView();
            if(mamua!="")
            {
                BindingData();
                btn_them.Focus();
            }
        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {
            if(txt_tendoi.Text=="")
            {
                return;
            }
            LockButton();
            UnLocktextbox();
            trangthai = TrangThai.them;
            Clear();
            NotBindingData();
            FillTextLoaiCauThu();
            txt_hoten.Focus();
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            if (txt_tendoi.Text == "")
            {
                return;
            }
            LockButton();
            UnLocktextbox();
            trangthai = TrangThai.sua;
            NotBindingData();
            FillTextLoaiCauThu();
            BindingData();
            txt_hoten.Focus();
        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            if (txt_tendoi.Text == "")
            {
                return;
            }
            LockButton();
            UnLocktextbox();
            trangthai = TrangThai.xoa;
            NotBindingData();
            btn_xacnhan.Focus();
        }

        private void btn_xacnhan_Click(object sender, System.EventArgs e)
        {
            try
            {
                switch (trangthai)
                {
                    case TrangThai.them:
                        {
                            if (int.Parse(cauthuTableAdapter1.DemSoCauThuTheoMaDoi_MaMua(mamua, madoi).ToString()) >= sct_toida)
                            {
                                MessageBox.Show("Không thể thêm cầu thủ, Số Cầu thủ của đội đã đủ");
                                return;
                            }

                            ngaysinh = DateTime.Parse(txt_ngaysinh.Value.ToString());


                            if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                            {
                                MessageBox.Show("Tuổi không đúng quy định, tuổi phải từ " + tuoitoithieu + " tuổi đến " + tuoitoida);
                                return;
                            }

                            tencauthu = txt_hoten.Text.Trim();

                            if (tencauthu == "")
                            {
                                MessageBox.Show("Nhập tên cầu thủ");
                                return;
                            }
                            quoctich = txt_quoctich.Text.Trim();

                            if (quoctich == "")
                            {
                                MessageBox.Show("Nhập quốc tịch cầu thủ");
                                return;
                            }
                            macauthu = TaoMaCauThu();
                            string mathidau = TaoMaThiDau();
                            ghichu = txt_ghichu.Text.Trim();
                            string mathamgia = doibonG_MUAGIAITableAdapter1.LayMaThamGia(mamua, madoi);
                            cauthuTableAdapter1.Insert(macauthu, tencauthu, ngaysinh, maloaicauthu, quoctich, ghichu);
                            doibonG_CAUTHUTableAdapter1.Insert(mathidau, mathamgia, macauthu, 0);

                            MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case TrangThai.sua:
                        {
                            macauthu = txt_macauthu.Text.Trim();
                            tencauthu = txt_hoten.Text.Trim();

                            if (tencauthu == "")
                            {
                                MessageBox.Show("Nhập tên cầu thủ");
                                return;
                            }
                            quoctich = txt_quoctich.Text.Trim();
                            

                            if (quoctich == "")
                            {
                                MessageBox.Show("Nhập tên cầu thủ");
                                return;
                            }
                            if(txt_ngaysinh.Value==null)
                            {
                                MessageBox.Show("Nhập ngày sinh của cầu thủ");
                                return;
                            }
                            ngaysinh = DateTime.Parse(txt_ngaysinh.Value.ToString());
                            
                            if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                            {
                                MessageBox.Show("Tuổi không đúng quy định, tuổi phải từ " + tuoitoithieu + " tuổi đến " + tuoitoida);
                                return;
                            }
                            quoctich = txt_quoctich.Text.Trim();
                            ghichu = txt_ghichu.Text.Trim();
                            this.cauthuTableAdapter1.UpdateByMaCauThu(tencauthu, ngaysinh, maloaicauthu, quoctich, ghichu, macauthu);
                            MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case TrangThai.xoa:
                        {
                            if (MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                macauthu = txt_macauthu.Text.Trim();
                                if (macauthu == "")
                                    break;
                                string mathamgia = this.doibonG_MUAGIAITableAdapter1.LayMaThamGia(mamua, madoi);
                                string mathidau = this.doibonG_CAUTHUTableAdapter1.LayMaThiDauByMaThamGia_MaCauThu(mathamgia, macauthu);
                                this.doibonG_CAUTHUTableAdapter1.DeleteByMaThiDau(mathidau);
                                this.cauthuTableAdapter1.DeleteByMaCauThu(macauthu);
                            }
                            break;
                        }
                    default:
                        break;
                }
                trangthai = TrangThai.none;
                UnLockButton();
                Locktextbox();
                //Clear();
                LoadDataGridView();
                BindingData();
                FillTextLoaiCauThu();
                btn_them.Focus();
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_huy_Click(object sender, System.EventArgs e)
        {
            UnLockButton();
            Locktextbox();
            trangthai = TrangThai.none;
            btn_them.Focus();
        }

        // cạp nhật mã loại cầu thủ khi giá trị combobox thay đổi
        private void cb_loaicauthu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(cb_loaicauthu.Text!="")
            {
                maloaicauthu = cb_loaicauthu.SelectedValue.ToString();
            }
        }

        private void frmCauThuMoi_Load(object sender, System.EventArgs e)
        {
        }
        //nhấp dư 
        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
           
        }       
        //kiểm tra ngày sinh có hợp lệ không
        private void txt_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
           
            if(txt_ngaysinh.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày Sinh Không Hợp Lệ");
                txt_ngaysinh.Value = DateTime.Now;
            }
        }
        #endregion
    }

}
