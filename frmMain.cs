using DevComponents.DotNetBar;
using QuanLiGiaiVoDichBongDaQuocGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //kiểm tra nếu tab đã mở thì trả về true
        public bool kiemTraTabsDaMo(string tabName)
        {
            for(int i=0;i<superTabControl.Tabs.Count;i++)
            {
                if(superTabControl.Tabs[i].Text==tabName)
                {
                    superTabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        //thêm tab vào supertab control
        private bool themSuperTab(ref SuperTabControl tabControl, string title, MyForm form)
        {
            try
            {
                if (kiemTraTabsDaMo(title))
                {
                    superTabControl.TabIndex = superTabControl.Tabs.Count - 1;
                }
                else
                {
                    SuperTabItem tabPage = tabControl.CreateTab(title);
                    tabPage.AttachedControl.Controls.Add(form._Mypanel);
                    superTabControl.SelectedTabIndex = superTabControl.Tabs.Count - 1;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void barButtonItem_dangkidoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Đăng Ký Đội", new frmDangKy());
        }

        private void barButtonItem_themcauthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Thêm Cầu Thủ Mới", new frmThemCauThuMoi());
        }

        private void barButtonItem_themcauthughiban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Thêm Cầu Thủ Ghi Bàn", new frmThemCauThuGhiBan());
        }

        private void barButtonItem_thongtindoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Thông Tin Đội Bóng", new frmThongTinDoi());
        }

        private void barButtonItem_taolichthidau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Tạo Lịch Thi Đấu", new frmTaoLichThiDau());
        }

        private void barButtonItem_xemlichthidau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Xem Lịch Thi Đấu", new frmThongTinLichThiDau());
        }

        private void barButtonItem_bangxephangdoibong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Bảng Xếp Hạng Đội Bóng", new frmBangXepHangDoiBong());
        }

        private void barButtonItem_bangxephangvuaphaluoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Bảng Xếp Hạng Vua Phá Lưới", new frmBangXepHangCauThuGhiBan());
        }

        private void barButtonItem_quydinhvecauthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Quy Định Về Cầu Thủ", new frmQuyDinhCauThu());
        }

        private void barButtonItem_quydinhvebanthang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Quy Định Về Bàn Thắng", new frmQuyDinhBanThang());
        }

        private void barButtonItem_quydinhveloaicauthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiCauThu frmloaicauthu = new frmLoaiCauThu();
            frmloaicauthu.ShowDialog();
        }

        private void barButtonItem_quydinhvevongdau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVongDau frmvongdau = new frmVongDau();
            frmvongdau.ShowDialog();
        }

        private void barButtonItem_quydinhvemuagiai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuaGiai frmmuagiai = new frmMuaGiai();
            frmmuagiai.ShowDialog();
        }

        private void barButtonItem_xemketquacactrandau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themSuperTab(ref superTabControl, "Kết Quả Các Trận Đấu", new frmThongTinKetQua());
        }
    }
}
//  CÒN BẢNG XẾP HẠNG CÁC ĐỘI BÓNG THEO MÙA GIẢI, CẦN CODE GẤP