using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotOrtalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesap_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            float toplam;

            sayi1 = Convert.ToInt32(not1.Text);
            sayi2 = Convert.ToInt32(not2.Text);

            
            if (sayi1 <= 100 && sayi2 <= 100)
            {
                lblAd.Text = ad.Text;
                lblNum.Text = num.Text;

                toplam = (sayi1 + sayi2) / 2;
                lblOrt.Text = toplam.ToString();

                if (toplam >= 50)
                {
                    lblDurum.Text = "Geçti";
                    lblDurum.BackColor = Color.LightGreen;
                }
                else
                {
                    lblDurum.Text = "Kaldı";
                    lblDurum.BackColor = Color.Red;
                }
            }

            else
            {
                MessageBox.Show("Geçersiz Not Değeri", "Uyarı");
            }


        }

        private void not1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void not2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad.Clear();
            num.Clear();
            not1.Clear();
            not2.Clear();
        }

        private void not1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
