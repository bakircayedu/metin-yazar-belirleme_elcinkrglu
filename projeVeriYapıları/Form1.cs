using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace projeVeriYapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int word = 0;
        Stack stk = new Stack();
        Stack stk1 = new Stack();
        Stack stk2 = new Stack();
        Cumle kel = new Cumle();
       
        public void DosyaEkleme()
        {
            OpenFileDialog dosya = new OpenFileDialog();
          
            dosya.Filter = "Text Dosyası |*.txt";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = dosya.FileName;
                var fileStream = dosya.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    kel.text = reader.ReadToEnd();
                    kel.cumleler = kel.text.Split(new char[] { '.', '?', '!' }).ToArray();
                   

                }

            }
        }
        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            DosyaEkleme();
        }
        public void StackAktar()

        {
            DosyaEkleme();
            for (int i = 0; i < kel.cumleler.Length; i++)
            {
                stk.Push(kel.cumleler[i]);

                txtCumleSayisi.Text = Convert.ToString(kel.cumleler.Length - 1);

            }
            int CumleNumarasi = Convert.ToInt32(txtCumleNumarasi.Text);
            kel.kelimeler = kel.cumleler[CumleNumarasi].Split(' ').ToArray();
            stk1.Push(kel.cumleler[CumleNumarasi]);
            for (int j = 0; j < kel.kelimeler.Length; j++)
            {
                stk2.Push(kel.kelimeler[j]);
                txtKelime.Text = Convert.ToString(kel.kelimeler.Length);

            }
            string[]  kelimee = kel.text.Split(' ');
            tbToplamKelime.Text = (kelimee.Length).ToString() ;
            int Ortalama = (kel.cumleler.Length/ kelimee.Length);
            tbOrtalama.Text = Ortalama.ToString();
            


            





        

    }

        private void btnStack_Click(object sender, EventArgs e)
        {
            DosyaEkleme();
            StackAktar();
            MessageBox.Show(stk.DisplayElements());
            MessageBox.Show(stk1.DisplayElements());
            MessageBox.Show(stk2.DisplayElements());

        }    
        public void KelimeDuzenle()
        {
            StackAktar();
            bool Kontrol = false;
           
            string words = (kel.kelimeler).ToString();

            List<string> list = words.Split(' ').ToList();
            

            MatchCollection yeniKelime = Regex.Matches(kel.text, @"[\w\d_]");
            for (int j = 0; j < yeniKelime.Count; j++)
            {

                for (int i = 0; i < kel.kelimeler.Length; i++)
                {
                    if (yeniKelime[j].ToString() == kel.kelimeler[i])
                        Kontrol = true;
                }
                Kelime k = new Kelime();
                if (Kontrol == false)
                    
                {
                    kel.kelimeler[j] = yeniKelime[j].ToString();
                    word++;
                    kel.Sıra = j;
                    kel.İslenmemisHali = yeniKelime[j].ToString();

                    for (int i = 0; i < yeniKelime.Count; i++)
                    {
                        if (yeniKelime[i].ToString() == yeniKelime[j].ToString())
                        {
                            k.kullanımSıklığı++;

                        }
                    }
                    Kontrol = false;



                }
            }
        }

        public void HeapAktar()
        {
            Heap heap = new Heap(1000);

            string[] kelimeler1 = kel.text.Split(' ');
            KelimeDuzenle();
            if (kel.kelimeler.Length > 0)
            {

                for (int i = 0; i < kelimeler1.Length; i++)
                {

                    heap.Insert(kelimeler1[i]);
                }
                MessageBox.Show("Heap'e Aktarıldı.");


            }

        }


            private void button1_Click(object sender, EventArgs e)
        {

            HeapAktar();

            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Kelime[] words;
            DosyaEkleme();
        
            string[] kelimeler1 = kel.text.Split(' ');
            Heap heap = new Heap(kelimeler1.Length);
            words = heap.Sort();
            foreach (var item in words)
            {
                string lb = item.kullanımSıklığı + " - " + item.kelime;
                MessageBox.Show(lb);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///////hash
        }
    }
}
