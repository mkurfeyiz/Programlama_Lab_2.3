using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2._3._3
{
    public partial class formKimyasalTicaret : Form
    {
        MusterilerDal _musterilerDal = new MusterilerDal();
        UreticiFirmalarDal _ureticiFirmalarDal = new UreticiFirmalarDal();
        TedarikciFirmalarDal _tedarikciFirmalarDal = new TedarikciFirmalarDal();
        KimyasalUrunlerDal _kimyasalUrunlerDal = new KimyasalUrunlerDal();
        MesafeBilgileriDal _mesafeBilgileriDal = new MesafeBilgileriDal();

        public formKimyasalTicaret()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Metodları
        /// </summary>
        private void LoadMusteriler()
        {
            dgwTable.DataSource = _musterilerDal.GetMusterilerTable();
        }

        private void LoadUreticiFirmalar()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetUreticiFirmalarTable();
        }

        private void LoadTedarikciFirmalar()
        {
            dgwTable.DataSource = _tedarikciFirmalarDal.GetTedarikciFirmalarTable();
        }

        private void LoadKimyasalUrunler()
        {
            dgwTable.DataSource = _kimyasalUrunlerDal.GetKimyasalUrunlerTable();
        }

        private void LoadMesafeBilgileri()
        {
            dgwTable.DataSource = _mesafeBilgileriDal.GetMesafeBilgileriTable();
        }
         private void LoadEnUcuzN()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzN();
        }

        private void LoadEnUcuzH()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzH();
        }

        private void LoadEnUcuzC()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzC();
        }

        private void LoadEnUcuzS()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzS();
        }

        private void LoadEnUcuzO()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzO();
        }

        private void LoadEnUcuzCl()
        {
            dgwTable.DataSource = _ureticiFirmalarDal.GetEnUcuzCl();
        }

        /// <summary>
        /// 
        /// </summary>
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button Metodları
        /// </summary>
        private void btnUreticiFirmalar_Click(object sender, EventArgs e)
        {
            LoadUreticiFirmalar();
        }

        private void btnTedarikciFirmalar_Click(object sender, EventArgs e)
        {
            LoadTedarikciFirmalar();
        }

        private void btnKimyasalUrunler_Click(object sender, EventArgs e)
        {
            LoadKimyasalUrunler();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            LoadMusteriler();
        }

        private void btnMesafe_Click(object sender, EventArgs e)
        {
            LoadMesafeBilgileri();
        }

        private void btnAddMusteri_Click(object sender, EventArgs e)
        {
            _musterilerDal.AddMusteri(new Musteriler
            {
                MusteriAdi = tbxMusteriAdi.Text,
                Adres = tbxAdres.Text,
                AlinanUrun = tbxAlinanUrun.Text
            });
            LoadMusteriler();
            MessageBox.Show("Musteri Listeye Eklendi");
        }

        private void btnAddTedarikciFirma_Click(object sender, EventArgs e)
        {
            _tedarikciFirmalarDal.AddTedarikciFirma(new TedarikciFirmalar
            {
                FirmaAdi = tbxFirmaAdi.Text,
                Ulke = tbxUlke.Text,
                SehirMerkezi = tbxSehirMerkezi.Text,
                Hammadde = tbxHammadde.Text,
                Miktar = Convert.ToInt32(tbxMiktar.Text),
                UretimTarihi = tbxUretimTarihi.Text,
                RafOmru = Convert.ToInt32(tbxRafOmru.Text),
                SatisFiyati = Convert.ToDecimal(tbxSatisFiyati.Text)
            });
            LoadTedarikciFirmalar();
            MessageBox.Show("Tedarikci Firma Listeye Eklendi");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            LoadEnUcuzN();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            LoadEnUcuzH();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LoadEnUcuzC();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            LoadEnUcuzS();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            LoadEnUcuzO();
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            LoadEnUcuzCl();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("170201015 Erdem Özer \n170201083 Muhammed Kurfeyiz");
        }

        private void tbxFirmaAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
