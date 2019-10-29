using OS2Projekt.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2Projekt
{
    public partial class Form1 : Form
    {
        private AES_ aes;
        private RSA_ rsa;
        private byte[] bajtovi = null;
        private SHA512_ sha;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pomocna.GenerirajDatoteke();
            aes = new AES_();
            rsa = new RSA_();
            sha = new SHA512_();
        }

        private void uiAESKriptiranje_Click(object sender, EventArgs e)
        {

            if (uiAESKriptiranje.Text.Length == 0) MessageBox.Show("Morate unijeti tekst za kriptiranje", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string tekstZaKriptiranje = uiTekstZaKriptiranje.Text;
                Pomocna.zapisiUDatoteku("ulazna_datoteka.txt", tekstZaKriptiranje);
                byte[] kriptiraniUBytovima = aes.KriptirajTekst(tekstZaKriptiranje, aes.serviceProvider);
                Pomocna.zapisiUDatoteku("kriptirani_tekst_simetricni.txt", Pomocna.PretvoriByteUString(kriptiraniUBytovima));
                zapisiKriptiraniNaTextBox(Pomocna.PretvoriByteUString(kriptiraniUBytovima));
                uiTekstZaKriptiranje.Clear();
            }
        }

        private void zapisiKriptiraniNaTextBox(string tekst)
        {
            uiKriptiraniTekst.Text = tekst;
        }

        private void uiAESDekriptiranje_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstDatoteke = Pomocna.UcitajSadrzajDatoteke("kriptirani_tekst_simetricni.txt");
                postavidekriptiraniTekst(aes.DekriptirajTekst(tekstDatoteke, aes.serviceProvider));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška", "Greška");
            }

        }

        private void postavidekriptiraniTekst(string tekst)
        {
            uiTekstZaKriptiranje.Text = tekst;

        }

        private void uiRSAKriptiranje_Click(object sender, EventArgs e)
        {
            if (uiTekstZaKriptiranje.Text.Length == 0) MessageBox.Show("Morate unijeti tekst za kriptiranje", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string tekstZaKriptiranje = uiTekstZaKriptiranje.Text;
                Pomocna.zapisiUDatoteku("ulazna_datoteka.txt", tekstZaKriptiranje);
                string RsaKriptirano = rsa.Kriptiraj(uiTekstZaKriptiranje.Text);
                uiKriptiraniTekst.Text = RsaKriptirano;
                Pomocna.zapisiUDatoteku("kriptirani_tekst_asimetricno.txt", RsaKriptirano);
                uiTekstZaKriptiranje.Clear();
            }
        }

        private void uiRSADekriptiraj_Click(object sender, EventArgs e)
        {
            try
            {

                string tekstIzDatoteke = Pomocna.UcitajSadrzajDatoteke("kriptirani_tekst_asimetricno.txt");
                uiTekstZaKriptiranje.Text = rsa.Dekriptiraj(tekstIzDatoteke);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uiSazetak_Click(object sender, EventArgs e)
        {
            string tekstUlazneDatoteke = Pomocna.UcitajSadrzajDatoteke("ulazna_datoteka.txt");
            if (tekstUlazneDatoteke.Length == 0) MessageBox.Show("Ulazna datoteka ne postoji ili je prazna !!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sazetak = sha.IzracunajSazetak(tekstUlazneDatoteke);
                Pomocna.zapisiUDatoteku("sazetak.txt", sazetak);
                MessageBox.Show("Sažetak je zapisan u datoteku.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uiDigitalniPotpis_Click(object sender, EventArgs e)
        {
            try
            {
                string hash = Pomocna.UcitajSadrzajDatoteke("sazetak.txt");
                string digitalniPotpis = rsa.IzradiDigitalniPotpis(hash);
                Pomocna.zapisiUDatoteku("digitalni_potpis.txt", digitalniPotpis);
                MessageBox.Show("Digitalni potpis je generiran", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void uiProvijeriDigitalni_Click(object sender, EventArgs e)
        {
            try
            {
                string ulaz = Pomocna.UcitajSadrzajDatoteke("ulazna_datoteka.txt");
                string sazetiUlaz = sha.IzracunajSazetak(ulaz);
                string potpis = Pomocna.UcitajSadrzajDatoteke("digitalni_potpis.txt");
                if (rsa.ProvijeriDigitalniPotpis(sazetiUlaz, potpis) == true)
                {
                    MessageBox.Show("Potpis je valjan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Potpis nije valjan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
    }
}
