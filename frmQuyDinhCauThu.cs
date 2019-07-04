using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuyDinhCauThu : MyForm
    {
        public frmQuyDinhCauThu()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            FillDataGridviewQuyDinhChung();
            FillLoaiCauThu();
            trangthai = TrangThai.none;
        }
        #region NewData
        //các dữ liệu cần thiết
        enum TrangThai { them,xoa,sua,none};
        private static TrangThai trangthai;
        string tuoitoithieu, tuoitoida, socauthutoithieu, socauthutoida, socauthunuocngoaitoida,loaicauthu,maloaicauthu;
        #endregion

        #region Support
        //binding các textbox quy định chung
        public void binding_quydinhchung()
        {
            txt_tuoitoithieu.DataBindings.Clear();
            txt_tuoitoithieu.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "TuoiToiThieu");

            txt_tuoitoida.DataBindings.Clear();
            txt_tuoitoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "TuoiToiDa");

            txt_socauthutoithieu.DataBindings.Clear();
            txt_socauthutoithieu.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuToiThieu");

            txt_socauthutoida.DataBindings.Clear();
            txt_socauthutoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuToiDa");

            txt_socauthunuocngoaitoida.DataBindings.Clear();
            txt_socauthunuocngoaitoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuNuocNgoaiToiDa");
        }
        //binding các textbox cầu thủ
        public void binding_loaicauthu()
        {
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dataGridView_loaicauthu.DataSource, "MaLoaiCauThu");

            txt_loaicauthu.DataBindings.Clear();
            txt_loaicauthu.DataBindings.Add("Text", dataGridView_loaicauthu.DataSource, "LoaiCauThu");
        }
        //đổ dữ liệu vào datagridview loại cầu thủ
        public void FillLoaiCauThu()
        {
            this.loaicauthuTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU);
            this.dataGridView_loaicauthu.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU;
            binding_loaicauthu();
            Lockbuttonxacnhan();
        }
        //khóa button xác nhận và các control kèm theo
        public void Lockbuttonxacnhan()
        {
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            txt_loaicauthu.Enabled = false;
        }
        //mở khóa button xác nhận và control kèm theo
        public void UnLockbuttonxacnhan()
        {
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_loaicauthu.Enabled = true;
        }
        //tạo bảng cho datagridview quy định chung
        public DataTable createdatatableforquydinhchung()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TuoiToiThieu", typeof(string));
            dataTable.Columns.Add("TuoiToiDa", typeof(string));
            dataTable.Columns.Add("SoCauThuToiThieu", typeof(string));
            dataTable.Columns.Add("SoCauThuToiDa", typeof(string));
            dataTable.Columns.Add("SoCauThuNuocNgoaiToiDa", typeof(string));
            return dataTable;
        }
        //đổ dữ liệu vào textbox quy định chung
        public void FillDataGridviewQuyDinhChung()
        {
            DataTable dataTable = createdatatableforquydinhchung();
            this.thamsoTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO.Rows)
            {
                tuoitoithieu = row["TuoiToiThieu"].ToString();
                tuoitoida = row["TuoiToiDa"].ToString();
                socauthutoithieu = row["SoCauThuToiThieu"].ToString();
                socauthutoida = row["SoCauThuToiDa"].ToString();
                socauthunuocngoaitoida = row["SoCauThuNuocNgoaiToiDa"].ToString();
                dataTable.Rows.Add(tuoitoithieu, tuoitoida, socauthutoithieu, socauthutoida, socauthunuocngoaitoida);
            }
            this.dataGridView_quydinh.DataSource = dataTable;
            binding_quydinhchung();
            dataGridView_quydinh.Enabled = false;
        }
        //tạo mã cầu thủ khi thêm mới
        public string TaoMaLoaiCauThu()
        {
            try
            {
                if(this.loaicauthuTableAdapter1.DemSoMaLoaiCauThu()==0)
                {
                    return "LCT001";
                }
                string ID_MaLoaiCauThu = "";
                this.loaicauthuTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU.Rows)
                {
                    ID_MaLoaiCauThu = row["MaLoaiCauThu"].ToString();
                }
                int tem = int.Parse(ID_MaLoaiCauThu.Substring(3))+1;
                ID_MaLoaiCauThu = "000" + tem;
                ID_MaLoaiCauThu = "LCT" + ID_MaLoaiCauThu.Substring(ID_MaLoaiCauThu.Length - 3);
                return ID_MaLoaiCauThu;

            }
            catch (Exception)
            {
            }
            return null;
        }

        #endregion


        #region Event

        private void frmQuyDinhCauThu_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            socauthutoithieu = txt_socauthutoithieu.Text.Trim();
            socauthutoida = txt_socauthutoida.Text.Trim();
            tuoitoithieu = txt_tuoitoithieu.Text.Trim();
            tuoitoida = txt_tuoitoida.Text.Trim();
            socauthunuocngoaitoida = txt_socauthunuocngoaitoida.Text.Trim();

            this.thamsoTableAdapter1.UpdateQuyDinhCauThu(int.Parse(tuoitoithieu), int.Parse(tuoitoida), int.Parse(socauthutoithieu), int.Parse(socauthutoida), int.Parse(socauthunuocngoaitoida));
            MessageBox.Show("Cập nhật thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridviewQuyDinhChung();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_loaicauthu.Text = "";
            txt_loaicauthu.Focus();
            UnLockbuttonxacnhan();
            trangthai = TrangThai.them;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_loaicauthu.Focus();
            UnLockbuttonxacnhan();
            trangthai = TrangThai.sua;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            UnLockbuttonxacnhan();
            trangthai = TrangThai.xoa;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
           switch(trangthai)
            {
                case TrangThai.them:
                    {
                        maloaicauthu = TaoMaLoaiCauThu();
                        loaicauthu = txt_loaicauthu.Text.Trim();
                        this.loaicauthuTableAdapter1.Insert(maloaicauthu, loaicauthu);
                        MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.sua:
                    {
                        maloaicauthu = txt_maloai.Text.Trim();
                        loaicauthu = txt_loaicauthu.Text.Trim();
                        this.loaicauthuTableAdapter1.UpdateByMaLoaiCauThu(loaicauthu, maloaicauthu);
                        MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.xoa:
                    {
                        maloaicauthu = txt_maloai.Text.Trim();
                        if (maloaicauthu!=""&& MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this.loaicauthuTableAdapter1.DeleteMyMaLoaiCauThu(maloaicauthu);
                        }
                        break;
                    }
                default:
                    break;
            }
            FillLoaiCauThu();
            Lockbuttonxacnhan();
        }

       
        private void txt_tuoitoithieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tuoitoida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_socauthutoithieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_socauthutoida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_socauthunuocngoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_loaicauthu.Text = "";
            Lockbuttonxacnhan();
        }
        #endregion
    }

}
