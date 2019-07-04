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
    public partial class frmLoaiCauThu : Form
    {
        public frmLoaiCauThu()
        {
            InitializeComponent();
            FillDataGridView();
            Locktextbox();
            UnLockButton();
        }

        #region NewData
        //các dữ liệu cần thiết
        string maloaicauthu, tenloaicauthu;
        enum TrangThai { them,xoa,sua,none};
        private static TrangThai trangthai;
        #endregion

        #region Support

        //Tạo mã Loại Cầu thủ
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
        //xóa Text textbox
        public void Clear()
        {
            txt_loaicauthu.Text = "";
            txt_maloaicauthu.Text = "";
        }
        //khóa các textbox
        public void Locktextbox()
        {
            txt_loaicauthu.Enabled = false;
            txt_maloaicauthu.Enabled = false;
        }
        //mở khóa các textbox
        public void UnLocktextbox()
        {
            txt_loaicauthu.Enabled = true;
            txt_maloaicauthu.Enabled = true;
        }
        //khóa các button theemm, sửa, xóa
        public void LockButtonChucNang()
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //mở khóa các button thêm, sửa, xóa
        public void UnLockButton()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
        }
        //tạo bảng cho datagridview
        public DataTable newdatatable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaLoaiCauThu", typeof(string));
            dataTable.Columns.Add("TenLoaiCauThu", typeof(string));
            return dataTable;
        }

        //load dữ liệu cho datagridview
        public void FillDataGridView()
        {
            DataTable dataTable = newdatatable();
            this.loaicauthuTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU);
            foreach(DataRow row in this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.LOAICAUTHU.Rows)
            {
                maloaicauthu = row["MaLoaiCauThu"].ToString();
                tenloaicauthu = row["LoaiCauThu"].ToString();
                dataTable.Rows.Add(maloaicauthu, tenloaicauthu);
            }
            dataGridView1.DataSource = dataTable;
        }

        //binding dữ liệu các textbox
        public void BindingData()
        {
            txt_maloaicauthu.DataBindings.Clear();
            txt_maloaicauthu.DataBindings.Add("Text", dataGridView1.DataSource, "MaLoaiCauThu");

            txt_loaicauthu.DataBindings.Clear();
            txt_loaicauthu.DataBindings.Add("Text", dataGridView1.DataSource, "TenLoaiCauThu");
        }

        #endregion

        #region Event
        private void frmLoaiCauThu_Load(object sender, EventArgs e)
        {
           
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Clear();
            UnLocktextbox();
            LockButtonChucNang();
            trangthai = TrangThai.them;
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            BindingData();
            UnLocktextbox();
            LockButtonChucNang();
            txt_maloaicauthu.Enabled = false;
            trangthai = TrangThai.sua;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            BindingData();
            UnLocktextbox();
            LockButtonChucNang();
            trangthai = TrangThai.xoa;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Locktextbox();
            UnLockButton();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                switch (trangthai)
                {
                    case TrangThai.them:
                        {
                            maloaicauthu = TaoMaLoaiCauThu();
                            tenloaicauthu = txt_loaicauthu.Text.Trim();
                            this.loaicauthuTableAdapter1.Insert(maloaicauthu, tenloaicauthu);
                            MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            FillDataGridView();
                            UnLockButton();
                            Locktextbox();
                            break;
                        }
                    case TrangThai.sua:
                        {
                            maloaicauthu = txt_maloaicauthu.Text.Trim();
                            tenloaicauthu = txt_loaicauthu.Text.Trim();
                            this.loaicauthuTableAdapter1.UpdateByMaLoaiCauThu(tenloaicauthu, maloaicauthu);
                            MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            FillDataGridView();
                            UnLockButton();
                            Locktextbox();
                            break;
                        }
                    case TrangThai.xoa:
                        {
                            maloaicauthu = txt_maloaicauthu.Text.Trim();
                            if (maloaicauthu != "" && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                this.loaicauthuTableAdapter1.DeleteMyMaLoaiCauThu(maloaicauthu);
                            }
                            Clear();
                            FillDataGridView();
                            UnLockButton();
                            Locktextbox();
                            break;
                        }
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loại cầu thủ đã được sử dụng, để xóa loại cầu thủ bạn cần xóa tất cả các cầu thủ thuộc loại cầu thủ này trước");
            }
        }
        #endregion

    }

}
