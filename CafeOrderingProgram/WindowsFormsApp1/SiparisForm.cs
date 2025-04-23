using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SiparisForm : Form

    {
        int caySayisi = 0;
        int kahveSayisi = 0;
        int msuyuSayisi = 0;
        int kolaSayisi = 0;
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cayartiButton_Click(object sender, EventArgs e)
        {
           
            caySayisi++;
            caysayiLabel.Text = Convert.ToString(caySayisi);

        }

        private void cayeksiButton_Click(object sender, EventArgs e)
        {
            if (caySayisi > 0)
            {
                caySayisi--;
                caysayiLabel.Text = Convert.ToString(caySayisi);
            }
        }

        private void kahveartiButton_Click(object sender, EventArgs e)
        {
            
            kahveSayisi++;
            kahvesayiLabel.Text = Convert.ToString(kahveSayisi);
        }

        private void kahveeksiButton_Click(object sender, EventArgs e)
        {
           
            if (kahveSayisi > 0)
                { 
            kahveSayisi--;
            kahvesayiLabel.Text = Convert.ToString(kahveSayisi); }
        }

        private void msuyueksiButton_Click(object sender, EventArgs e)
        {
    
            if (msuyuSayisi > 0)  {
                msuyuSayisi--;
                msuyusayiLabel.Text = Convert.ToString(msuyuSayisi); }
        }

        private void msuyuartiButton_Click(object sender, EventArgs e)
        {
           
            msuyuSayisi++;
            msuyusayiLabel.Text = Convert.ToString(msuyuSayisi);
        }

        private void kolaartiButton_Click(object sender, EventArgs e)
        {
            
            kolaSayisi++;
            kolasayiLabel.Text = Convert.ToString(kolaSayisi);
        }

        private void kolaeksiButton_Click(object sender, EventArgs e)
        {
           
            if (kolaSayisi > 0)
            {
                kolaSayisi--;
                kolasayiLabel.Text = Convert.ToString(kolaSayisi);
            }
        }

        private void sıfırlaButton_Click(object sender, EventArgs e)
        {

             caySayisi = 0;
             kahveSayisi = 0;
             msuyuSayisi = 0;
             kolaSayisi = 0;

            caysayiLabel.Text = "0";
            kahvesayiLabel.Text = "0";
            msuyusayiLabel.Text = "0";
            kolasayiLabel.Text = "0";
        }

        private void tamamlaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HESAP :" + caysayiLabel.Text + "ÇAY," + kahvesayiLabel.Text + "KAHVE," + msuyusayiLabel.Text + "Meyve Suyu," + kolasayiLabel.Text + "Kola,");
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SiparisGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
