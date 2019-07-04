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
    public partial class frmThongTinSan : Form
    {
        public frmThongTinSan(string _masan)
        {
            InitializeComponent();
            masan = _masan;
            this.sanTableAdapter1.FillByMaSan(this.quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN, masan);
            this.dataGridView1.DataSource = quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.SAN;
        }

        string masan;

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
