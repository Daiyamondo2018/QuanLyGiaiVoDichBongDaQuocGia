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
    public partial class frmVongDau : Form
    {
        public frmVongDau()
        {
            InitializeComponent();
            FillMuaGiai();
            Lock();
            trangthai = TrangThai.none;
        }

        #region NewData
        //các dữ liệu cần thiết
        string mamua, tenmua, mavongdau, tenvongdau;
        enum TrangThai { them,sua,xoa,none};
        private TrangThai trangthai;
        #endregion

        #region Support
        //khóa textbox và các button xác nhận...
        public void Lock()
        {
            txt_tenvong.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
        }
        //mở khóa textbox và button xác nhận...
        public void UnLock()
        {
            txt_tenvong.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //tạo mã vòng khi thêm mới
        public string TaoMaVong()
        {
            try
            {
                if(this.vongdauTableAdapter1.DemSoVong()==0)
                {
                    return "MV0001";
                }
                string ID_MaVongDau = "";
                this.vongdauTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.VONGDAU);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.VONGDAU.Rows)
                {
                    ID_MaVongDau = row["MaVong"].ToString();
                }
                int tem = int.Parse(ID_MaVongDau.Substring(2))+1;
                ID_MaVongDau = "0000" + tem;
                ID_MaVongDau = "MV" + ID_MaVongDau.Substring(ID_MaVongDau.Length - 4);
                return ID_MaVongDau;
            }
            catch(Exception ex)
            {

            }
            return null;
        }
        //bining textbox
        public void BindingData()
        {
            txt_mavong.DataBindings.Clear();
            txt_mavong.DataBindings.Add("Text", dataGridView1.DataSource, "MaVong");

            txt_tenvong.DataBindings.Clear();
            txt_tenvong.DataBindings.Add("Text", dataGridView1.DataSource, "TenVong");
        }
        //hủy binding textbox
        public void NotBindingData()
        {
            txt_mavong.DataBindings.Clear();
            txt_tenvong.DataBindings.Clear();
        }
        //tạo bảng cho combobox mùa giải
        public DataTable newTableForcomboboxmuagiai()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaMua", typeof(string));
            dataTable.Columns.Add("TenMua", typeof(string));
            return dataTable;
        }
        //tạo bảng cho datagridview
        public DataTable newdatatable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaVong", typeof(string));
            dataTable.Columns.Add("TenVong", typeof(string));
            return dataTable;
        }
        // đổ dữ liệu vào combobox mùa giải
        public void FillMuaGiai()
        {
            DataTable dataTable = newTableForcomboboxmuagiai();
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.MUAGIAI);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.MUAGIAI.Rows)
            {
                mamua = row["MaMua"].ToString();
                tenmua = row["TenMua"].ToString();
                dataTable.Rows.Add(mamua, tenmua);
            }
            cb_muagiai.DataSource = dataTable;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
        }
        //đổ dữ liệu vào datagridview
        public void FillDataGridView(string mamua)
        {
            DataTable dataTable = newdatatable();
            this.vongdauTableAdapter1.LayMaVongTenVongTuMaMua(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.VONGDAU,mamua);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet.VONGDAU.Rows)
            {
                mavongdau = row["MaVong"].ToString();
                tenvongdau = row["TenVong"].ToString();
                dataTable.Rows.Add(mavongdau, tenvongdau);
            }
            this.dataGridView1.DataSource = dataTable;
        }
        #endregion

        #region Event
        private void frmVongDau_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            UnLock();
            txt_tenvong.Text = "";
            txt_tenvong.Enabled = true;
            txt_tenvong.Focus();
            trangthai = TrangThai.them;
        }

        private void cb_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_muagiai.SelectedValue!=null)
            {
                mamua = cb_muagiai.SelectedValue.ToString();
                FillDataGridView(mamua);
                if(trangthai!=TrangThai.none)
                {
                    txt_tenvong.Text = "";
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Lock();
            trangthai = TrangThai.none;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BindingData();
            UnLock();
            trangthai = TrangThai.sua;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BindingData();
            UnLock();
            trangthai = TrangThai.xoa;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            switch(trangthai)
            {
                case TrangThai.them:
                    {
                        mavongdau = TaoMaVong();
                        tenvongdau = txt_tenvong.Text.Trim();
                        this.vongdauTableAdapter1.Insert(mavongdau, mamua, tenvongdau);
                        MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.sua:
                    {
                        mavongdau = txt_mavong.Text.Trim();
                        tenvongdau = txt_tenvong.Text.Trim();
                        this.vongdauTableAdapter1.UpdateByMaVong(mamua, tenvongdau, mavongdau);
                        MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case TrangThai.xoa:
                    {
                        mavongdau = txt_mavong.Text.Trim();
                        if(mavongdau!=""&& MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this.vongdauTableAdapter1.DeleteByMaVong(mavongdau);
                        }
                        break;
                    }
                default:
                    break;
            }

            Lock();
            FillDataGridView(mamua);
            BindingData();
            trangthai = TrangThai.none;
        }

        #endregion

    }
}
