using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiGiaiVoDichBongDaQuocGia;
namespace GUI
{
    public partial class frmBangXepHangDoiBong : MyForm
    {
        public frmBangXepHangDoiBong()
        {
            InitializeComponent();
            this._Mypanel = tableLayoutPanel1;
            FillcbMuaGiai();
            LayThamSo();
        }
        #region NewData
        string mamua, tenmua, madoi, tendoi;
        int thang, hoa, thua, hieuso, diem;
        int diemthang, diemhoa, diemthua;
        #endregion


        #region Support

        public void Sort(List<XepHang> l)
        {
            for (int i = 0; i < l.Count - 2; i++)
            {
                for (int j = i + 1; j < l.Count-1; j++)
                {
                    if (l[j].diem > l[i].diem)
                    {
                        l[i].swap(l[j]);
                    }
                    else if (l[j].diem == l[i].diem)
                    {
                        if (l[j].hieuso>l[i].hieuso)
                        {
                            l[j].swap(l[i]);
                        }
                        else if(l[j].hieuso == l[i].hieuso)
                        {
                            int sobanthangsankhachdoi1 = (int)this.trandauTableAdapter1.DemSoBanThangSanKhach(l[j].madoi);
                            int sobanthangsankhachdoi2 = (int)this.trandauTableAdapter1.DemSoBanThangSanKhach(l[i].madoi);
                            if(sobanthangsankhachdoi1>sobanthangsankhachdoi2)
                            {
                                l[j].swap(l[i]);
                            }
                            else if(sobanthangsankhachdoi1 == sobanthangsankhachdoi2)
                            {
                                if (DoiDauTrucTiep(l[j].madoi,l[i].madoi))
                                {
                                    l[j].swap(l[i]);
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool DoiDauTrucTiep(string madoi1, string madoi2)
        {
            int dem = 0;
            this.trandauTableAdapter1.FillByDoiDauTrucTiep(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU,madoi1, madoi2);
            {
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.TRANDAU.Rows)
                {
                    int a = (int)row["SoBanThangDoi1"];
                    int b = (int)row["SoBanThangDoi2"];
                    string md1 = row["MaDoi1"].ToString();
                    if(a>b)
                    {
                        if (md1.Equals(madoi1))
                            dem++;
                        else if (md1.Equals(madoi2))
                            dem--;
                    }
                    else if(a<b)
                    {
                        if (md1.Equals(madoi1))
                            dem--;
                        else if (md1.Equals(madoi2))
                            dem++;
                    }
                }
            }
            if (dem > 0)
                return true;
            return false;
        }


        public void LayThamSo()
        {
            this.thamsoTableAdapter1.Fill(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO);
            foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.THAMSO.Rows)
            {
                diemthang = (int)row["DiemSoThang"];
                diemhoa = (int)row["DiemSoHoa"];
                diemthua = (int)row["DiemSoThua"];
            }
        }

        public DataTable createtabledatagridview()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(string));
            dataTable.Columns.Add("Doi", typeof(string));
            dataTable.Columns.Add("Thang", typeof(string));
            dataTable.Columns.Add("Hoa", typeof(string));
            dataTable.Columns.Add("Thua", typeof(string));
            dataTable.Columns.Add("HieuSo", typeof(string));
            dataTable.Columns.Add("Diem", typeof(string));
            dataTable.Columns.Add("Hang", typeof(string));
            return dataTable;
        }

        public DataTable createtablecbmuagiai()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaMua", typeof(string));
            dataTable.Columns.Add("TenMua", typeof(string));
            return dataTable;
        }

        public void FillcbMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI);
            DataTable dataTable = createtablecbmuagiai();
            foreach (DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.MUAGIAI.Rows)
            {
                mamua = row["MaMua"].ToString();
                tenmua = row["TenMua"].ToString();
                dataTable.Rows.Add(mamua, tenmua);
            }
            cb_muagiai.DataSource = dataTable;
            cb_muagiai.DisplayMember = "TenMua";
            cb_muagiai.ValueMember = "MaMua";
        }

        #endregion



        #region Event
        //sắp xếp mừa giải sau khi thay đổi mùa
        private void cb_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<XepHang> listxephang = new List<XepHang>();
            if(cb_muagiai.SelectedValue!=null)
            {
                mamua = cb_muagiai.SelectedValue.ToString();
                DataTable dataTable = createtabledatagridview();
                this.bangxephangTableAdapter1.FillByMaMua(quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG,mamua);
                foreach(DataRow row in quanLyGiaiVoDichBongDaQuocGia_FinalDataSet1.BANGXEPHANG.Rows)
                {
                    madoi = row["MaThamGia"].ToString();
                    madoi = this.doibonG_MUAGIAITableAdapter1.LayMaDoiTuMaThamGia(madoi);
                    tendoi = this.doibongTableAdapter1.LayTenDoiTuMaDoi(madoi);
                    thang = (int)row["SoTranThang"];
                    hoa = (int)row["SoTranHoa"];
                    thua = (int)row["SoTranThua"];
                    hieuso = (int)row["HieuSo"];
                    diem = thang * diemthang + hoa * diemhoa + thua * diemthua;
                    listxephang.Add(new XepHang(madoi,tendoi, thang, hoa, thua, hieuso,diem));
                }
                //sắp xếp sau đó add vào datatable
                Sort(listxephang);
                int i = 1;
                foreach(XepHang xh in listxephang)
                {
                    dataTable.Rows.Add(i.ToString(),xh.tendoi,xh.thang,xh.hoa,xh.thua,xh.hieuso,xh.diem,i.ToString());
                    i++;
                }
                dataGridView1.DataSource = dataTable;
            }
        }

        #endregion
    }
    public class XepHang
    {
        public string madoi,tendoi;
        public int thang, hoa, thua, hieuso, diem;
        public XepHang() { }
        public XepHang(string md,string td, int t, int h, int th, int hs, int d)
        {
            tendoi = td;
            thang = t;
            hoa = h;
            thua = th;
            hieuso = hs;
            diem = d;
            madoi = md;
        }
        public void swap(XepHang a)
        {
            XepHang t = new XepHang();
            t.madoi = a.madoi;
            t.tendoi = a.tendoi;
            t.thang = a.thang;
            t.hoa = a.hoa;
            t.thua = a.thua;
            t.hieuso = a.hieuso;
            t.diem = a.diem;
            a.madoi = this.madoi;
            a.thang = this.thang;
            a.tendoi = this.tendoi;
            a.hoa = this.hoa;
            a.thua = this.thua;
            a.hieuso = this.hieuso;
            a.diem = this.diem;
            this.madoi = t.madoi;
            this.tendoi = t.tendoi;
            this.thang = t.thang;
            this.hoa = t.hoa;
            this.thua = t.thua;
            this.hieuso = t.hieuso;
            this.diem = t.diem;
        }
    }
}
