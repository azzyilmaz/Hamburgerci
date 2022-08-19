using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class frmMainMdi : Form
    {
        public frmMainMdi()
        {
            InitializeComponent();
        }
        

        private void toolStripSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new frmSiparisOlustur());
        }

        private void toolStripSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new frmSiparisBilgileri());
        }

        private void toolStripHamburgerEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new frmHamburgerEkle());
        }

        private void toolStripExtraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new frmExtraEkle());
        }

        public void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 25;
            this.Height = _childForm.Height + 75;

            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
    }
}
