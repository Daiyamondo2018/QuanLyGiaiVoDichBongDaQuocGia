using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiGiaiVoDichBongDaQuocGia;

namespace GUI
{
    public partial class frmChonDoi : MyForm
    {
        public frmChonDoi()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel1;
            FillDataGridView();
            FilltextMuaGiai();
            BindingData();
            LockControls();
        }
        #region New Data
        //các biến cần thiết
        public string madoi, tendoi, mamua, tenmua;
        #endregion

        #region Support
        //khóa textbox và combobox
        public void LockControls()
        {
            txt_tendoi.Enabled = false;
            txt_sannha.Enabled = false;
            cb_muagiai.Enabled = false;
        }
        //load dữ liệu đổ vào dataGridView
        public void FillDataGridView()
        {
            this.doibongTableAdapter1.FillByMaMua_MaDoi_MaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG);
            dataGridView1.DataSource = this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.DOIBONG;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }
        //load dữ liệu đổ vào combobox mùa giải
        public void FilltextMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            cb_muagiai.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
        }
        //binding dữ liệu khi chọn row in datagridview
        public void BindingData()
        {
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaDoi");

            txt_tendoi.DataBindings.Clear();
            txt_tendoi.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi");

            txt_sannha.DataBindings.Clear();
            txt_sannha.DataBindings.Add("Text", dataGridView1.DataSource, "TenSan");

            cb_muagiai.DataBindings.Clear();
            cb_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "TenMua");

        }

        #endregion

        #region Event
        private void btn_dangky_Click(object sender, System.EventArgs e)
        {
            madoi = txt_madoi.Text.Trim();
            tendoi = txt_tendoi.Text.Trim();
            mamua = cb_muagiai.SelectedValue.ToString();
            tenmua = cb_muagiai.Text.Trim();
            this.Close();
        }

        private void btn_huy_Click(object sender, System.EventArgs e)
        {
            tendoi = "";
            mamua = "";
            madoi = "";
            this.Close();
        }

        private void frmChonDoi_Load(object sender, System.EventArgs e)
        {
            
        }

        private void cb_muagiai_SelectedIndexChanged(object sender, System.EventArgs e)
        {
      
        }
        #endregion
    }

}

