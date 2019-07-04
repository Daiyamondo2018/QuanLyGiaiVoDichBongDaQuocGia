using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLiGiaiVoDichBongDaQuocGia;

namespace GUI
{
    public partial class frmThemCauThuGhiBan : MyForm
    {
        public frmThemCauThuGhiBan()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel_themcauthughiban;
            trangThai = TrangThai.none;
            LockTextBox();
            LockControlThem();
            FillLoaiBanThang();
            getThamSo();
            btn_chontrandau.Focus();
        }

        #region NewData

        enum TrangThai { them,sua,xoa,none};
        private static TrangThai trangThai;
        string macauthu,tencauthu,maloaibanthang, loaibanthang, matrandau, mamua, mavong, madoi1, madoi2, tendoi1, tendoi2, madoi, thoigian;
        string mathamgia1, mathamgia2;
        int thoidiemghibantoida, thoidiem, sobanthangdoi1, sobanthangdoi2, thoiluong;
        int sotranthang1, sotranthua1, sotranhoa1, hieuso1, sotranthang2, sotranthua2, sotranhoa2, hieuso2;
        #endregion

        #region  Support

        public void BindingData()
        {
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaDoi");

            cb_cauthu.DataBindings.Clear();
            cb_cauthu.DataBindings.Add("Text", dataGridView1.DataSource, "TenCauThu");

            cb_loaibanthang.DataBindings.Clear();
            cb_loaibanthang.DataBindings.Add("Text", dataGridView1.DataSource, "LoaiBanThang");

            txt_thoidiem.DataBindings.Clear();
            txt_thoidiem.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiDiemGhiBan");

            txt_macauthu.DataBindings.Clear();
            txt_macauthu.DataBindings.Add("Text", dataGridView1.DataSource, "MaCauThu");
        }

        public void getThamSo()
        {
            this.thamsoTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO.Rows)
            {
                thoidiemghibantoida=int.Parse(row["ThoiDiemGhiBanToiDa"].ToString());
            }
        }

        public void LockTextBox()
        {
            txt_doi1.Enabled = false;
            txt_doi2.Enabled = false;
            txt_banthangdoi1.Enabled = false;
            txt_banthangdoi2.Enabled = false;
        }

       
        public void LockControlThem()
        {
            cb_doibong.Enabled = false;
            cb_cauthu.Enabled = false;
            cb_loaibanthang.Enabled = false;
            txt_thoidiem.Enabled = false;
            txt_muagiai.Enabled = false;
            txt_vongdau.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
           
        }

        public void UnLockControl()
        {
            cb_doibong.Enabled = true;
            txt_thoidiem.Enabled = true;
            cb_cauthu.Enabled = true;
            cb_loaibanthang.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }

        public void FillLoaiBanThang()
        {
            this.loaibanthangTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG);
            cb_loaibanthang.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG;
            cb_loaibanthang.DisplayMember = "LoaiBanThang";
            cb_loaibanthang.ValueMember = "MaLoaiBanThang";
        }

        public DataTable createcauthutable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaCauThu", typeof(string));
            dataTable.Columns.Add("TenCauThu", typeof(string));
            return dataTable;
        }
        public DataTable createdatagridviewtable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(string));
            dataTable.Columns.Add("MaCauThu", typeof(string));
            dataTable.Columns.Add("TenCauThu", typeof(string));
            dataTable.Columns.Add("MaDoi", typeof(string));
            dataTable.Columns.Add("TenDoi", typeof(string));
            dataTable.Columns.Add("LoaiBanThang", typeof(string));
            dataTable.Columns.Add("ThoiDiemGhiBan", typeof(string));
            return dataTable;
        }
        public void FillDataGridView(string matrandau)
        {
            DataTable dataTable = createdatagridviewtable();
            this.cT_GHIBANTableAdapter1.FillByMaTranDau(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CT_GHIBAN,matrandau);
            int i=1;
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CT_GHIBAN.Rows)
            {
                string  mathidau, thoidiem, maloaibanthang, macauthu, tencauthu, madoi, tendoi;
                matrandau = row["MaTranDau"].ToString();
                mathidau = row["MaThiDau"].ToString();
                thoidiem = row["ThoiDiem"].ToString();
                maloaibanthang = row["MaLoaiBanThang"].ToString();
                string loaibanthang = this.loaibanthangTableAdapter1.LayTenLoaiTuMaLoai(maloaibanthang);
                macauthu = this.cauthuTableAdapter1.LayMaCauThuTuMaThiDau(mathidau);
                tencauthu = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                madoi = this.doibonG_MUAGIAITableAdapter1.LayMaDoiTuMaThiDau(mathidau);
                tendoi = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi);
                dataTable.Rows.Add(i.ToString(), macauthu, tencauthu,madoi, tendoi, loaibanthang, thoidiem);
                i++;
            }
            dataGridView1.DataSource = dataTable;
        }
        
        public void FillDoiBongByMaTranDau(string matrandau)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaDoi",typeof(string));
            dataTable.Columns.Add("TenDoi",typeof(string));
            this.trandauTableAdapter1.FillByMaTranDau(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU,matrandau);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
            {
                dataTable.Rows.Add(row["MaDoi1"].ToString(),this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi1"].ToString()));
                dataTable.Rows.Add(row["MaDoi2"].ToString(), this.doibongTableAdapter1.LayTenDoiTuMaDoi(row["MaDoi2"].ToString()));
            }
            cb_doibong.DataSource = dataTable;
            cb_doibong.DisplayMember = "TenDoi";
            cb_doibong.ValueMember = "MaDoi";
        }

        #endregion

        #region event

        private void frmThemCauThuGhiBan_Load(object sender, System.EventArgs e)
        {         
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                thoiluong = int.Parse(txt_thoiluong.Text.Trim());
                this.trandauTableAdapter1.UpdateThoiLuongByMaTranDau(thoiluong, matrandau);
                mathamgia1 = this.doibonG_MUAGIAITableAdapter1.LayMaThamGiaTuMaMua_MaDoi(mamua, madoi1);
                this.bangxephangTableAdapter1.FillByMaThamGia(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG, mathamgia1);
                DataTable dataTable = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG.Copy();
                foreach (DataRow row in dataTable.Rows)
                {
                    sotranthang1 = (int)row["SoTranThang"];
                    sotranhoa1 = (int)row["SoTranHoa"];
                    sotranthua1 = (int)row["SoTranThua"];
                    hieuso1 = (int)row["HieuSo"];
                }
                bangxephangTableAdapter1.ClearBeforeFill = true;
                mathamgia2 = this.doibonG_MUAGIAITableAdapter1.LayMaThamGiaTuMaMua_MaDoi(mamua, madoi2);
                this.bangxephangTableAdapter1.FillByMaThamGia(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG,mathamgia2);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG.Rows)
                {
                    sotranthang2 = (int)row["SoTranThang"];
                    sotranhoa2 = (int)row["SoTranHoa"];
                    sotranthua2 = (int)row["SoTranThua"];
                    hieuso2 = (int)row["HieuSo"];
                }
                if(sobanthangdoi1>sobanthangdoi2)
                {

                    DateTime t = DateTime.Now;
                    this.bangxephangTableAdapter1.Insert(t, mathamgia1, sotranthang1+1, sotranhoa1, sotranthua1, hieuso1+sobanthangdoi1-sobanthangdoi2, 0);
                    this.bangxephangTableAdapter1.Insert(t, mathamgia2, sotranthang2, sotranhoa2, sotranthua2 + 1, hieuso2 + sobanthangdoi2 - sobanthangdoi1, 0);

                }
                else if(sobanthangdoi1==sobanthangdoi2)
                {
                    DateTime t = DateTime.Now;
                    this.bangxephangTableAdapter1.Insert(t, mathamgia1, sotranthang1 , sotranhoa1+1, sotranthua1, hieuso1 , 0);
                    this.bangxephangTableAdapter1.Insert(t, mathamgia2, sotranthang2, sotranhoa2+1, sotranthua2, hieuso2 , 0);
                }
                else
                {
                    DateTime t = DateTime.Now;
                    this.bangxephangTableAdapter1.Insert(t, mathamgia1, sotranthang1 , sotranhoa1, sotranthua1+1, hieuso1 + sobanthangdoi1 - sobanthangdoi2, 0);
                    this.bangxephangTableAdapter1.Insert(t, mathamgia2, sotranthang2+1, sotranhoa2, sotranthua2 , hieuso2 + sobanthangdoi2 - sobanthangdoi1, 0);
                }
                MessageBox.Show("Lưu thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {

            }
        }

        private void cb_doibong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_doibong.SelectedValue!=null)
            {
                madoi = cb_doibong.SelectedValue.ToString();
                DataTable dataTable = createcauthutable();
                this.cauthuTableAdapter1.FillBy1MaDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, cb_doibong.SelectedValue.ToString());
                foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
                {
                    macauthu = row["MaCauThu"].ToString();
                    tencauthu = row["TenCauThu"].ToString();
                    dataTable.Rows.Add(macauthu, tencauthu);
                }
                cb_cauthu.DataSource = dataTable;
                cb_cauthu.DisplayMember = "TenCauThu";
                cb_cauthu.ValueMember = "MaCauThu";
                cb_cauthu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_cauthu.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void cb_loaibanthang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_loaibanthang.SelectedValue != null)
            {
                loaibanthang = cb_loaibanthang.SelectedValue.ToString();
            }
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LockControlThem();
            cb_doibong.Text = "";
            cb_cauthu.Text = "";
            txt_thoidiem.Text = "";
            cb_loaibanthang.Text = "";
            BindingData();
            trangThai = TrangThai.none;
        }

        private void txt_thoidiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thoidiem = int.Parse(txt_thoidiem.Text);
                if (thoidiem > thoidiemghibantoida)
                {
                    MessageBox.Show("Thời điểm ghi bàn tối đa là: " + thoidiemghibantoida + ", vui lòng nhập lại");
                    txt_thoidiem.Text = "";
                }
            }
            catch(Exception ex)
            {

            }
        }


        private void btn_xacnhan_Click_1(object sender, EventArgs e)
        {
           switch(trangThai)
            {
                case TrangThai.them:
                    {
                        try
                        {
                            if (cb_doibong.SelectedValue == null)
                            {
                                MessageBox.Show("Vui lòng chọn đội bóng");
                                return;
                            }
                            madoi = cb_doibong.SelectedValue.ToString();
                            if (cb_cauthu.SelectedValue == null)
                            {
                                MessageBox.Show("Vui lòng chọn cầu thủ");
                                return;
                            }
                            macauthu = cb_cauthu.SelectedValue.ToString();
                            tencauthu = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                            string mathamgia = this.doibonG_MUAGIAITableAdapter1.LayMaThamGiaTuMaMua_MaDoi(mamua, madoi);
                            string mathidau = this.doibonG_CAUTHUTableAdapter1.LayMaThiDauByMaThamGia_MaCauThu(mathamgia, macauthu);
                            if (txt_thoidiem.Text == "")
                            {
                                MessageBox.Show("Vui lòng nhập thời điểm ghi bàn");
                                return;
                            }
                            if (cb_loaibanthang.SelectedValue == null)
                            {
                                MessageBox.Show("Vui lòng chọn loại bàn thắng");
                                return;
                            }
                            maloaibanthang = cb_loaibanthang.SelectedValue.ToString();
                            this.cT_GHIBANTableAdapter1.Insert(matrandau, mathidau, thoidiem, maloaibanthang);
                            if (madoi.Equals(madoi1))
                            {
                                sobanthangdoi1++;
                            }
                            else
                            {
                                sobanthangdoi2++;
                            }
                            int sobanthang=(int)this.doibonG_CAUTHUTableAdapter1.LaySoBanThangTheoKhoaChinh(mathidau, mathamgia, macauthu);
                            sobanthang++;
                            this.doibonG_CAUTHUTableAdapter1.UpdateByPrimaryKey(sobanthang, mathidau, mathamgia, macauthu);
                            this.trandauTableAdapter1.UpdateSoBanThangTheoMaTranDau(sobanthangdoi1, sobanthangdoi2, matrandau);
                            FillDataGridView(matrandau);
                            MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LockControlThem();
                            trangThai = TrangThai.none;
                            txt_banthangdoi1.Text = sobanthangdoi1.ToString();
                            txt_banthangdoi2.Text = sobanthangdoi2.ToString();
                            
                        }
                        catch(Exception ex)
                        {

                        }
                        break;
                    }
                case TrangThai.sua:
                    {
                        try
                        {
                            macauthu = cb_cauthu.SelectedValue.ToString();
                            madoi = cb_doibong.SelectedValue.ToString();

                            tencauthu = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                            string mathamgia = this.doibonG_MUAGIAITableAdapter1.LayMaThamGiaTuMaMua_MaDoi(mamua, madoi);

                            string mathidau = this.doibonG_CAUTHUTableAdapter1.LayMaThiDauByMaThamGia_MaCauThu(mathamgia, macauthu);
                            maloaibanthang = cb_loaibanthang.SelectedValue.ToString();
                            this.cT_GHIBANTableAdapter1.UpdateByPrimaryKey(maloaibanthang, matrandau, mathidau, thoidiem);
                            FillDataGridView(matrandau);
                            MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LockControlThem();
                            trangThai = TrangThai.none;
                        }
                        catch(Exception ex)
                        {

                        }

                        break;
                    }
                case TrangThai.xoa:
                    {
                        try
                        {
                            if (cb_cauthu.SelectedValue != null && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                macauthu = cb_cauthu.SelectedValue.ToString();
                                madoi = cb_doibong.SelectedValue.ToString();

                                tencauthu = this.cauthuTableAdapter1.LayTenCauThuTuMaCauThu(macauthu);
                                string mathamgia = this.doibonG_MUAGIAITableAdapter1.LayMaThamGiaTuMaMua_MaDoi(mamua, madoi);

                                string mathidau = this.doibonG_CAUTHUTableAdapter1.LayMaThiDauByMaThamGia_MaCauThu(mathamgia, macauthu);
                                if (madoi.Equals(madoi1))
                                {
                                    sobanthangdoi1--;
                                }
                                else
                                {
                                    sobanthangdoi2--;
                                }
                                int sobanthang = (int)this.doibonG_CAUTHUTableAdapter1.LaySoBanThangTheoKhoaChinh(mathidau, mathamgia, macauthu);
                                sobanthang--;
                                this.doibonG_CAUTHUTableAdapter1.UpdateByPrimaryKey(sobanthang, mathidau, mathamgia, macauthu);
                                this.trandauTableAdapter1.UpdateSoBanThangTheoMaTranDau(sobanthangdoi1, sobanthangdoi2, matrandau);
                                this.cT_GHIBANTableAdapter1.DeleteByPrimaryKey(matrandau, mathidau, thoidiem);
                                FillDataGridView(matrandau);
                                LockControlThem();
                                trangThai = TrangThai.none;
                                txt_banthangdoi1.Text = sobanthangdoi1.ToString();
                                txt_banthangdoi2.Text = sobanthangdoi2.ToString();

                            }
                        }
                        catch(Exception ex)
                        {

                        }
                        break;
                    }
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if(matrandau==""||matrandau==null)
            {
                return;
            }
            trangThai = TrangThai.xoa;
            UnLockControl();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (matrandau == "" || matrandau == null)
            {
                return;
            }
            trangThai = TrangThai.sua;
            UnLockControl();
            cb_doibong.Enabled = false;
            txt_thoidiem.Enabled = false;
            cb_cauthu.Enabled = false;
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (matrandau == "" || matrandau == null)
            {
                MessageBox.Show("Vui lòng chọn trận đấu trước!");
                return;
            }
            txt_thoidiem.Text = "";
            cb_loaibanthang.Text = "";
            cb_cauthu.Text = "";
            cb_doibong.Text = "";
            trangThai = TrangThai.them;
            UnLockControl();
            cb_doibong.Focus();
        }

        private void txt_thoidiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_cauthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cauthu.SelectedValue != null)
            {
                tencauthu = cb_cauthu.SelectedValue.ToString();
            }
        }

        private void btn_chontrandau_Click_1(object sender, EventArgs e)
        {
            frmChonTranDau frmchontrandau = new frmChonTranDau();
            frmchontrandau.ShowDialog();
            try
            {
                DataTable dataTable = createcauthutable();
                matrandau = frmchontrandau.matrandau;
                madoi1 = frmchontrandau.madoi1;
                madoi2 = frmchontrandau.madoi2;
                tendoi1 = frmchontrandau.tendoi1;
                tendoi2 = frmchontrandau.tendoi2;
                mavong = frmchontrandau.mavong;
                mamua = this.vongdauTableAdapter1.LayMaMuaTuMaVong(mavong);
                sobanthangdoi1 = frmchontrandau.sobanthangdoi1;
                sobanthangdoi2 = frmchontrandau.sobanthangdoi2;
                thoiluong = frmchontrandau.thoiluong;
                thoigian = frmchontrandau.thoigian;
                if (matrandau != "" && matrandau!=null)
                {
                    FillDoiBongByMaTranDau(matrandau);
                    FillDataGridView(matrandau);
                    BindingData();
                    

                    this.cauthuTableAdapter1.FillByMaDoi(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU, madoi1, madoi2);
                    foreach (DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.CAUTHU.Rows)
                    {
                        macauthu = row["MaCauThu"].ToString();
                        tencauthu = row["TenCauThu"].ToString();
                        dataTable.Rows.Add(macauthu, tencauthu);
                    }
                    cb_cauthu.DataSource = dataTable;
                    cb_cauthu.DisplayMember = "TenCauThu";
                    cb_cauthu.ValueMember = "MaCauThu";
                    cb_cauthu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_cauthu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_cauthu.AutoCompleteSource = AutoCompleteSource.ListItems;


                    string mavong=this.trandauTableAdapter1.LayMaVongTuMaTranDau(matrandau);
                    string tenvong=this.vongdauTableAdapter1.LayTenVongTuMaVong(mavong);
                    string tenmua = this.muagiaiTableAdapter1.LayTenMuaTuMaVong(mavong);
                    txt_muagiai.Text = tenmua;
                    txt_vongdau.Text = tenvong;

                    txt_doi1.Text = tendoi1;
                    txt_doi2.Text = tendoi2;

                    txt_banthangdoi1.Text = sobanthangdoi1.ToString();
                    txt_banthangdoi2.Text = sobanthangdoi2.ToString();
                    txt_thoiluong.Text = thoiluong.ToString();
                }
                btn_them.Focus();
            }
            catch (Exception ex)
            {
                btn_chontrandau.Focus();
            }

        }

        #endregion

    }

}
