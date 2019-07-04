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
    public partial class frmQuyDinhBanThang : MyForm
    {
        public frmQuyDinhBanThang()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            FillLoaiBanThang();
            FillQuyDinh();
            dataGridView_quydinh.Enabled = false;
            trangthai = TrangThai.none;
        }

        #region NewData

        //các dữ liệu cần thiết
        string thoidiemghibantoida, diemthang, diemhoa, diemthua, loaibanthang, maloaibanthang;
        enum TrangThai { them,sua,xoa,none};
        private static TrangThai trangthai;
        #endregion


        #region Support
        //khóa button xác nhận và control kèm theo
        public void LockButtonXacNhan()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
            txt_loaibanthang.Enabled = false;
        }
        //mở khóa button xác nhận và control kèm theo
        public void UnLockButtonXacNhan()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
            txt_loaibanthang.Enabled = true;
        }
        //tạo bảng cho datagridview quy định
        public DataTable createdataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ThoiDiemGhiBanToiDa", typeof(string));
            dataTable.Columns.Add("DiemSoThang", typeof(string));
            dataTable.Columns.Add("DiemSoHoa", typeof(string));
            dataTable.Columns.Add("DiemSoThua", typeof(string));
            return dataTable;
        }
        //đổ dữ liệu vào datagridview quy định
        public void FillQuyDinh()
        {
            DataTable dataTable = createdataTable();
            this.thamsoTableAdapter1.Fill(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO.Rows)
            {
                thoidiemghibantoida = row["ThoiDiemGhiBanToiDa"].ToString();
                diemthang = row["DiemSoThang"].ToString();
                diemhoa = row["DiemSoHoa"].ToString();
                diemthua = row["DiemSoThua"].ToString();
                dataTable.Rows.Add(thoidiemghibantoida, diemthang, diemhoa, diemthua);
            }
            this.dataGridView_quydinh.DataSource = dataTable;
            binding_quydinh();
        }
        //binding textbox liên quan đến quy định
        public void binding_quydinh()
        {
            txt_thoidiemghibantoida.DataBindings.Clear();
            txt_thoidiemghibantoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "ThoiDiemGhiBanToiDa");

            txt_diemthang.DataBindings.Clear();
            txt_diemthang.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "DiemSoThang");

            txt_diemhoa.DataBindings.Clear();
            txt_diemhoa.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "DiemSoHoa");

            txt_diemthua.DataBindings.Clear();
            txt_diemthua.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "DiemSoThua");
        }
        //binding textbox liên quan đến loại bàn thắng
        public void binding_loaibanthang()
        {
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dataGridView_loaibanthang.DataSource, "MaLoaiBanThang");

            txt_loaibanthang.DataBindings.Clear();
            txt_loaibanthang.DataBindings.Add("Text", dataGridView_loaibanthang.DataSource, "LoaiBanThang");
        }
        //đổ dữ liệu vào datagridview loại bàn thắng
        public void FillLoaiBanThang()
        {
            this.loaibanthangTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG);
            this.dataGridView_loaibanthang.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG;
            binding_loaibanthang();
            LockButtonXacNhan();
        }
        //tạo mã bàn thắng khi thêm mới
        public string TaoMaBanThang()
        {
            try
            {
                if(this.loaibanthangTableAdapter1.DemSoLoaiBanThang()==0)
                {
                    return "LBT001";
                }
                string ID_MaBanThang = "";
                this.loaibanthangTableAdapter1.FillByNothing(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAIBANTHANG.Rows)
                {
                    ID_MaBanThang = row["MaLoaiBanThang"].ToString();
                }
                int tem = int.Parse(ID_MaBanThang.Substring(3))+1;
                ID_MaBanThang = "000" + tem;
                ID_MaBanThang = "LBT" + ID_MaBanThang.Substring(ID_MaBanThang.Length - 3);
                return ID_MaBanThang;

            }
            catch (Exception)
            {
            }
            return null;
        }

        #endregion


        #region Event
        private void frmQuyDinhBanThang_Load(object sender, EventArgs e)
        {
            
            
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_loaibanthang.Text = "";
            txt_loaibanthang.Focus();
            UnLockButtonXacNhan();
            trangthai = TrangThai.them;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_loaibanthang.Focus();
            UnLockButtonXacNhan();
            trangthai = TrangThai.sua;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            UnLockButtonXacNhan();
            trangthai = TrangThai.xoa;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
           switch(trangthai)
            {
                case TrangThai.them:
                    {
                        maloaibanthang = TaoMaBanThang();
                        loaibanthang = txt_loaibanthang.Text.Trim();
                        this.loaibanthangTableAdapter1.Insert(maloaibanthang, loaibanthang);
                        MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.sua:
                    {
                        maloaibanthang = txt_maloai.Text.Trim();
                        loaibanthang = txt_loaibanthang.Text.Trim();
                        this.loaibanthangTableAdapter1.UpdateByMaLoaiBanThang(loaibanthang, maloaibanthang);
                        MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.xoa:
                    {
                        maloaibanthang = txt_maloai.Text.Trim();
                        if(maloaibanthang!=""&&MessageBox.Show("Bạn có muốn xóa?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                        {
                            this.loaibanthangTableAdapter1.DeleteByMaLoaiBanThang(maloaibanthang);
                        }
                        break;
                    }
                default:
                    break;
            }
            FillLoaiBanThang();
            LockButtonXacNhan();
            trangthai = TrangThai.none;
        }

        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            thoidiemghibantoida = txt_thoidiemghibantoida.Text.Trim();
            diemthang = txt_diemthang.Text.Trim();
            diemhoa = txt_diemhoa.Text.Trim();
            diemthua = txt_diemthua.Text.Trim();
            this.thamsoTableAdapter1.UpdateQuyDinhBanThang(int.Parse(thoidiemghibantoida),int.Parse(diemthang),int.Parse(diemhoa),int.Parse(diemthua));
            MessageBox.Show("Cập nhật thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillQuyDinh();
        }
        private void txt_thoidiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_hoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_thua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_loaibanthang.Text = "";
            trangthai = TrangThai.none;
        }
        #endregion
    }
}
