using Hamburgerci.Helpers;
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
    public partial class frmSiparisOlustur : Form
    {
        public frmSiparisOlustur()
        {
            InitializeComponent();
        }

        private void frmSiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenuler.Items.AddRange(menuler.ToArray());

            foreach (var item in extralar)
                flpExtralar.Controls.Add(new CheckBox { Text = item.ExtraAdi, Tag = item });
        }

        public static List<Siparis> siparisler = new List<Siparis>();
        List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Models.Menu> menuler = new List<Models.Menu>()
        {
            new Models.Menu {MenuAdi="Kral Burger",Fiyat = 30.00M},
            new Models.Menu {MenuAdi="Mc Fish",Fiyat = 25.00M},
            new Models.Menu {MenuAdi="King Chicken",Fiyat = 23.00M},
            new Models.Menu {MenuAdi="Steak House",Fiyat = 35.00M},
            new Models.Menu {MenuAdi="Kasap Burger",Fiyat = 28.00M},
            new Models.Menu {MenuAdi="Mexico Burger",Fiyat = 29.00M},
        };

        public static List<Extra> extralar = new List<Extra>()
        {
            new Extra { ExtraAdi ="Ketçap", Fiyat = 1 },
            new Extra { ExtraAdi ="Mayonez", Fiyat = 1 },
            new Extra { ExtraAdi ="Acı Sos", Fiyat = 1 },
            new Extra { ExtraAdi ="Sarımsaklı Mayonez", Fiyat = 1.25M },
            new Extra { ExtraAdi ="Ranch Sos", Fiyat = 1.5M },
            new Extra { ExtraAdi ="Bufalo Sos", Fiyat = 2 },
            new Extra { ExtraAdi ="Barbekü", Fiyat = 2 },
            new Extra { ExtraAdi ="Hardal", Fiyat = 1.5M }
        };
        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis siparis = lstSiparisler.Items[i] as Siparis;
                toplamTutar += siparis.ToplamTutar;
            }

            
            lblToplamTutar.Text = toplamTutar.ToString("C2"); 
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.Menu = (Models.Menu)cmbMenuler.SelectedItem;

            if (rbKucuk.Checked)
                siparis.Boyut = Enums.Boyut.Küçük;
            else if (rbNormal.Checked)
                siparis.Boyut = Enums.Boyut.Normal;
            else
                siparis.Boyut = Enums.Boyut.Büyük;

            foreach (CheckBox item in flpExtralar.Controls)
            {
                if (item.Checked)
                    siparis.Extralar.Add(item.Tag as Extra);

            }
            if (flpExtralar != null)
                siparis.Adet = (int)nmrAdet.Value;

            siparis.Hesapla();

            mevcutSiparisler.Add(siparis);

            lstSiparisler.Items.Add(siparis);

            Tools.Clean(this.Controls);
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Tutarı : {TutarHesapla().ToString("C2")} Satın almayı tamamlamak ister misiniz?", "Sipariş Onay Bildirimi!...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                
                siparisler.AddRange(mevcutSiparisler);


                mevcutSiparisler.Clear();
                lstSiparisler.Items.Clear();
                lblToplamTutar.Text = "0 TL";
                MessageBox.Show("Siparişiniz Tamamlandı!...");
                Tools.Clean(this.Controls);
            }
        }
    }
}
