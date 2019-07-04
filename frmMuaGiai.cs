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
    public partial class frmMuaGiai : Form
    {
        public frmMuaGiai()
        {
            InitializeComponent();
            FillDataGridView();
            LockButtonXacNhan();
            trangthai = TrangThai.none;
        }
        #region NewData
        //các dữ liệu cần thiết
        string mamua, tenmua, thoigianbatdau, thoigianketthuc;
        enum TrangThai { them,xoa,sua,none};
        private static TrangThai trangthai;

        #endregion

        #region Support
        //tạo mã mùa khi thêm mùa mới
        public string TaoMaMua()
        {
            try
            {
                if(this.muagiaiTableAdapter1.DemSoMua()==0)
                {
                    return "MG0001";
                }
                string ID_MaMua = "";
                this.muagiaiTableAdapter1.FillByNothing(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
                {
                    ID_MaMua = row["MaMua"].ToString();
                }
                int tem = int.Parse(ID_MaMua.Substring(2))+1;
                ID_MaMua = "0000" + tem;
                ID_MaMua = "MG" + ID_MaMua.Substring(ID_MaMua.Length - 4);
                return ID_MaMua;

            }
            catch (Exception)
            {
            }
            return null;
        }

        //lockbutton xác nhận và các control lock/unlock theo
        public void LockButtonXacNhan()
        {
            txt_tenmua.Enabled = false;
            txt_thoigianbatdau.Enabled = false;
            txt_thoigianketthuc.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_xacnhan.Enabled = false;
            btn_huy.Enabled = false;
        }
        //unlock button xác nhận và các control lock/unlock theo 
        public void UnLockButtonXacNhan()
        {
            txt_tenmua.Enabled = true;
            txt_thoigianbatdau.Enabled = true;
            txt_thoigianketthuc.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xacnhan.Enabled = true;
            btn_huy.Enabled = true;
        }
        //bingding các textbox
        public void BindingData()
        {
            txt_mamua.DataBindings.Clear();
            txt_mamua.DataBindings.Add("Text", dataGridView1.DataSource, "MaMua");

            txt_tenmua.DataBindings.Clear();
            txt_tenmua.DataBindings.Add("Text", dataGridView1.DataSource, "TenMua");

            txt_thoigianbatdau.DataBindings.Clear();
            txt_thoigianbatdau.DataBindings.Add("Text", dataGridView1.DataSource, "NgayBatDau");

            txt_thoigianketthuc.DataBindings.Clear();
            txt_thoigianketthuc.DataBindings.Add("Text", dataGridView1.DataSource, "NgayKetThuc");
        }
        //không binding các textbox
        public void NotBindingData()
        {
            txt_mamua.DataBindings.Clear();
            txt_tenmua.DataBindings.Clear();
            txt_thoigianbatdau.DataBindings.Clear();
            txt_thoigianketthuc.DataBindings.Clear();
        }
        //tạo bảng cho datagridview
        public DataTable creadatatable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaMua", typeof(string));
            dataTable.Columns.Add("TenMua", typeof(string));
            dataTable.Columns.Add("NgayBatDau", typeof(string));
            dataTable.Columns.Add("NgayKetThuc", typeof(string));
            return dataTable;
        }
        //đổ dữ liệu cho datagridview
        public void FillDataGridView()
        {
            DataTable dataTable = creadatatable();
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
            {
                mamua = row["MaMua"].ToString();
                tenmua = row["TenMua"].ToString();
                thoigianbatdau = row["NgayBatDau"].ToString();
                thoigianketthuc = row["NgayKetThuc"].ToString();
                dataTable.Rows.Add(mamua, tenmua, thoigianbatdau, thoigianketthuc);
            }
            this.dataGridView1.DataSource = dataTable;
            BindingData();
        }

        #endregion

        #region Event

        private void frmMuaGiai_Load(object sender, EventArgs e)
        {
            

        }



        private void button_them_Click(object sender, EventArgs e)
        {
            txt_tenmua.Text = "";
            UnLockButtonXacNhan();
            trangthai = TrangThai.them;
        }


        private void button_sua_Click(object sender, EventArgs e)
        {
            UnLockButtonXacNhan();
            trangthai = TrangThai.sua;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            UnLockButtonXacNhan();
            trangthai = TrangThai.xoa;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LockButtonXacNhan();
            BindingData();
            trangthai = TrangThai.none;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                switch (trangthai)
                {
                    case TrangThai.them:
                        {
                            mamua = TaoMaMua();
                            tenmua = txt_tenmua.Text.Trim();
                            thoigianbatdau = txt_thoigianbatdau.Text;
                            thoigianketthuc = txt_thoigianketthuc.Text;
                            this.muagiaiTableAdapter1.Insert(mamua, tenmua, DateTime.Parse(thoigianbatdau), DateTime.Parse(thoigianketthuc));
                            MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case TrangThai.sua:
                        {
                            mamua = txt_mamua.Text.Trim();
                            tenmua = txt_tenmua.Text.Trim();
                            thoigianbatdau = txt_thoigianbatdau.Text;
                            thoigianketthuc = txt_thoigianketthuc.Text;
                            this.muagiaiTableAdapter1.UpdateByMaMua(tenmua, DateTime.Parse(thoigianbatdau), DateTime.Parse(thoigianketthuc), mamua);
                            MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case TrangThai.xoa:
                        {
                            mamua = txt_mamua.Text.Trim();
                            if (mamua != "" && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                this.muagiaiTableAdapter1.DeleteByMaMua(mamua);
                            }
                            break;
                        }
                    default:
                        break;
                }
                trangthai = TrangThai.none;
                LockButtonXacNhan();
                FillDataGridView();
                BindingData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mùa giải đã có vòng đấu, vui lòng xóa các vòng đấu thuộc mùa giải này");
            }
        }

        private void txt_thoigianbatdau_ValueChanged(object sender, EventArgs e)
        {
            if(trangthai==TrangThai.them)
            {
                if(txt_thoigianbatdau.Value<DateTime.Now)
                {
                    MessageBox.Show("Thời gian bắt đầu phải lớn hơn thời gian hiện tại");
                    txt_thoigianbatdau.Value = DateTime.Now.AddDays(1);
                    return;
                }
            }
        }

        private void txt_thoigianketthuc_ValueChanged(object sender, EventArgs e)
        {
            if (trangthai == TrangThai.none)
                return;
            if(txt_thoigianketthuc.Value<txt_thoigianbatdau.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu","Warning",MessageBoxButtons.OK);
                txt_thoigianketthuc.Value = txt_thoigianbatdau.Value.AddDays(1);
                return;
            }
        }
        #endregion
    }
}
