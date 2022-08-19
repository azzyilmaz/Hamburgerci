using Hamburgerci.Models;
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
    public partial class frmSiparisBilgileri : Form
    {
        public frmSiparisBilgileri()
        {
            InitializeComponent();
        }

        private void frmSiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal extraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis item in frmSiparisOlustur.siparisler)
            {
                ciro += item.ToplamTutar;
                foreach (Extra ex in item.Extralar)
                {
                    extraMalzemeGeliri += ex.Fiyat;
                }
                satisAdedi += item.Adet;
                lstSiparisler.Items.Add(item);
            }

            
            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparisAdedi.Text = lstSiparisler.Items.Count.ToString();
            lblExtraMalzemeGeliri.Text = extraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
        }
    }
}
