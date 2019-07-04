using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiaiVoDichBongDaQuocGia
{
    class MyTab:TabPage
    {
        private Form frm;
        public MyTab(MyForm frm_contenido)
        {
            this.frm = frm_contenido;
            this.Controls.Add(frm_contenido._Mypanel);
            this.Text = frm_contenido.Text;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
    public class MyForm : Form
    {
        public Panel _Mypanel;
    }
    public class MyTag : MyForm
    {
        private Form frm;
        public MyTag(MyForm frm_contensido)
        {
            this.frm = frm_contensido;
            this.Controls.Add(frm_contensido._Mypanel);
            this.Text = frm_contensido.Text;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
