using Hamburgerci.Helpers;
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
    public partial class frmExtraEkle : Form
    {
        public frmExtraEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmSiparisOlustur.extralar.Add(new Models.Extra { ExtraAdi = txtExtraAdi.Text, Fiyat = nmrFiyat.Value });
            Tools.Clean(this.Controls);
            MessageBox.Show("Ekstra Ekleme işlemi başarılı!..");
        }
    }
}
