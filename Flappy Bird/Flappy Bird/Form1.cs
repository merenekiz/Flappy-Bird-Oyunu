using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        // oyun değişkenleri
        int boruHizi = 3; // boruların hareket hızı
        int yerCekimi = 8; // kuşun yerçekimi etkisi ile düşüş hızı
        int skor = 0; // oyuncunun skorunu tutar
        bool oyunSonu = false; // oyunun bitip bitmediğini kontrol eder


        public Form1()
        {
            InitializeComponent();
        }


        // Space tuşuna basıldığında kuşun yukarı hareket etmesini sağlar
        private void oyunanahtariyukari(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Eğer oyun bitmediyse
            {
                yerCekimi = 3; // Kuş yukarı hareket eder
            }

        }

        // Space tuşuna basılmadığında kuşun aşağı hareket etmesini sağlar
        private void oyunanahtariassagi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)  // Eğer oyun bitmediyse
            {
                yerCekimi = -8; // Kuş aşağı hareket eder
            }
        }

        // Zamanlayıcı oyun döngüsü
        private void Zamanlayıcı_Tick(object sender, EventArgs e)
        {
            Bird.Top += yerCekimi; // Kuşun düşüşünü günceller
            boruAlt1.Left -= boruHizi; // Boruları sola hareket ettir
            boruUst1.Left -= boruHizi;
            boruAlt2.Left -= boruHizi;
            boruUst2.Left -= boruHizi;
            boruAlt3.Left -= boruHizi;
            boruUst3.Left -= boruHizi;
            boruAlt4.Left -= boruHizi;
            boruUst4.Left -= boruHizi;
            skorTablosu.Text = "Skor : " + skor; // Skoru ekrana yazdır

            // Boruların yeniden konumlandırılması ve skor güncellemesini sağlar
            if (boruAlt1.Left<-50)
            {
                boruAlt1.Left = 900;
                skor++;

         
            }
            if(boruUst1.Left<-50)
            {
                boruUst1.Left = 900;
                

            }
            if(Bird.Bounds.IntersectsWith(boruAlt1.Bounds)||Bird.Bounds.IntersectsWith(boruUst1.Bounds)||Bird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                oyunuBitir();
            }
            if (boruAlt2.Left < -50)
            {
                boruAlt2.Left = 900;
                skor++;


            }
            if (boruUst2.Left < -50)
            {
                boruUst2.Left = 900;
                

            }
            if (Bird.Bounds.IntersectsWith(boruAlt2.Bounds) || Bird.Bounds.IntersectsWith(boruUst2.Bounds) || Bird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                oyunuBitir();
            }
            if (boruAlt3.Left < -50)
            {
                boruAlt3.Left = 900;
                skor++;


            }
            if (boruUst3.Left < -50)
            {
                boruUst3.Left = 900;
                

            }
            if (Bird.Bounds.IntersectsWith(boruAlt3.Bounds) || Bird.Bounds.IntersectsWith(boruUst3.Bounds) || Bird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                oyunuBitir();
            }
            if (boruAlt4.Left < -50)
            {
                boruAlt4.Left = 900;
                skor++;


            }
            if (boruUst4.Left < -50)
            {
                boruUst4.Left = 900;
                skor++;


            }
            if (Bird.Bounds.IntersectsWith(boruAlt4.Bounds) || Bird.Bounds.IntersectsWith(boruUst4.Bounds) || Bird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                oyunuBitir();
            }

            // Skor 5'i geçerse boru hızı artırılır
            if (skor > 5)
            {
                boruHizi = 4;
            }

            // Kuş ekranın üst kısmına çarparsa oyunu bitir
            if (Bird.Top<-25)
            {
                oyunuBitir();

            }
                


        }

        // Oyun bittiğinde yapılacak işlemler
        private void oyunuBitir()
        {
            Zamanlayıcı.Stop(); // Zamanlayıcıyı durdur
            skorTablosu.Text = "Skorunuz : " + skor; // Skoru göster
            oyunSonu = true; // Oyun bitti olarak işaretler
            this.KeyDown += new KeyEventHandler(Kapat); // Bir tuşa basıldığında formu kapatır
        }

        // Oyun bittiğinde herhangi bir tuşa basıldığında oyunu kapatma
        private void Kapat(object sender, KeyEventArgs e)
        {
            
            if (oyunSonu) // Oyun bittiyse
            {
                this.Close(); // Oynunu kapatır
            }
        }

    }
}
