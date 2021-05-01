using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //öncelıkle  random ve toplam atıyoruz
        Random rastgele = new Random();

        int oyuncu1toplam = 0;
        int oyuncu2toplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1oyuncu1.Enabled = false;
            button2oyuncu2.Enabled = true;

            //a degıskenı atıyoruz rastgele sayı karıstıryoruz
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);

            //nereye neyı ve nasıl yazdırıyoruz
            label3.Text = a.ToString();
            label4.Text = b.ToString();

            //toplambölüm yazdırıyoruz
            oyuncu1toplam = oyuncu1toplam + a + b;
            label17puan1.Text = oyuncu1toplam.ToString();

            //a için 
            if (a == 1)
            {
                pictureBox1.ImageLocation = "zarlar\\zar1.png";
            }
            else if (a == 2)
            {
                pictureBox1.ImageLocation = "zarlar\\zar2.png";
            }
            else if (a == 3)
            {
                pictureBox1.ImageLocation = "zarlar\\zar3.png";
            }
            else if (a == 4)
            {
                pictureBox1.ImageLocation = "zarlar\\zar4.png";
            }
            else if (a == 5)
            {
                pictureBox1.ImageLocation = "zarlar\\zar5.png";
            }
            else if (a == 6)
            {
                pictureBox1.ImageLocation = "zarlar\\zar6.png";
            }
            //b için buda

            if (b == 1)
            {
                pictureBox2.ImageLocation = "zarlar\\zar1.png";
            }
            else if (b == 2)
            {
                pictureBox2.ImageLocation = "zarlar\\zar2.png";
            }
            else if (b == 3)
            {
                pictureBox2.ImageLocation = "zarlar\\zar3.png";
            }
            else if (b == 4)
            {
                pictureBox2.ImageLocation = "zarlar\\zar4.png";
            }

            else if (b == 5)
            {
                pictureBox2.ImageLocation = "zarlar\\zar5.png";
            }
            else if (b == 6)
            {
                pictureBox2.ImageLocation = "zarlar\\zar6.png";
            }

            if (oyuncu1toplam >= 100)
            {
                label17.Text = "1. Oyuncu Kazandi ";
                button1oyuncu1.Enabled = false;
                button2oyuncu2.Enabled = false;

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1oyuncu1.Enabled = true;
            button2oyuncu2.Enabled = false;

            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            label5.Text = c.ToString();
            label6.Text = d.ToString();

            //toplam yazıdıyoruız
            oyuncu2toplam = oyuncu2toplam + c + d;
            label14puan2.Text = oyuncu2toplam.ToString();


            //c için 
            if (c == 1)
            {
                pictureBox3.ImageLocation = "zarlar\\zar1.png";
            }
            else if (c == 2)
            {
                pictureBox3.ImageLocation = "zarlar\\zar2.png";
            }
            else if (c == 3)
            {
                pictureBox3.ImageLocation = "zarlar\\zar3.png";
            }
            else if (c == 4)
            {
                pictureBox3.ImageLocation = "zarlar\\zar4.png";
            }
            else if (c == 5)
            {
                pictureBox3.ImageLocation = "zarlar\\zar5.png";
            }
            else if (c == 6)
            {
                pictureBox3.ImageLocation = "zarlar\\zar6.png";
            }
            //d için buda

            if (d == 1)
            {
                pictureBox4.ImageLocation = "zarlar\\zar1.png";
            }
            else if (d == 2)
            {
                pictureBox4.ImageLocation = "zarlar\\zar2.png";
            }
            else if (d == 3)
            {
                pictureBox4.ImageLocation = "zarlar\\zar3.png";
            }
            else if (d == 4)
            {
                pictureBox4.ImageLocation = "zarlar\\zar4.png";
            }

            else if (d == 5)
            {
                pictureBox4.ImageLocation = "zarlar\\zar5.png";
            }
            else if (d == 6)
            {
                pictureBox4.ImageLocation = "zarlar\\zar6.png";
            }

            if (oyuncu2toplam >= 100)
            {
                label17.Text = "2.Oyuncu kazandı";
                button1oyuncu1.Enabled = false;
                button2oyuncu2.Enabled = false;
            }
            

        }
        private void button5_Click(object sender, EventArgs e)
        {
            oyuncu1toplam = 0;
            oyuncu2toplam = 0;

            label17puan1.Text = oyuncu1toplam.ToString();
            label14puan2.Text = oyuncu2toplam.ToString();

            label17.Text = "......";
            button1oyuncu1.Enabled = true;
            pictureBox1.ImageLocation = "zarlar\\bos.png";
            pictureBox2.ImageLocation = "zarlar\\bos.png";
            pictureBox3.ImageLocation = "zarlar\\bos.png";
            pictureBox4.ImageLocation = "zarlar\\bos.png";



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
              
    }
}





