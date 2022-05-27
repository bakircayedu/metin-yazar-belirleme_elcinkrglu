
namespace projeVeriYapıları
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.btnStack = new System.Windows.Forms.Button();
            this.txtCumleSayisi = new System.Windows.Forms.TextBox();
            this.txtCumleNumarasi = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.tbOrtalama = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDosya = new System.Windows.Forms.TabPage();
            this.tpStack = new System.Windows.Forms.TabPage();
            this.tpHeap = new System.Windows.Forms.TabPage();
            this.tpHash = new System.Windows.Forms.TabPage();
            this.lbDosyaYolu = new System.Windows.Forms.Label();
            this.lblCumleNumarasi = new System.Windows.Forms.Label();
            this.lblToplamCumle = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.tbToplamKelime = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpDosya.SuspendLayout();
            this.tpStack.SuspendLayout();
            this.tpHeap.SuspendLayout();
            this.tpHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.BackColor = System.Drawing.Color.White;
            this.btnDosyaEkle.Location = new System.Drawing.Point(212, 96);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(294, 62);
            this.btnDosyaEkle.TabIndex = 0;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.UseVisualStyleBackColor = false;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(276, 248);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(174, 22);
            this.txtDosya.TabIndex = 1;
            // 
            // btnStack
            // 
            this.btnStack.BackColor = System.Drawing.Color.White;
            this.btnStack.Location = new System.Drawing.Point(232, 91);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(328, 54);
            this.btnStack.TabIndex = 2;
            this.btnStack.Text = "Stack\'e Oku";
            this.btnStack.UseVisualStyleBackColor = false;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // txtCumleSayisi
            // 
            this.txtCumleSayisi.Location = new System.Drawing.Point(383, 178);
            this.txtCumleSayisi.Name = "txtCumleSayisi";
            this.txtCumleSayisi.Size = new System.Drawing.Size(332, 22);
            this.txtCumleSayisi.TabIndex = 5;
            // 
            // txtCumleNumarasi
            // 
            this.txtCumleNumarasi.Location = new System.Drawing.Point(301, 55);
            this.txtCumleNumarasi.Name = "txtCumleNumarasi";
            this.txtCumleNumarasi.Size = new System.Drawing.Size(174, 22);
            this.txtCumleNumarasi.TabIndex = 6;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(383, 232);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(332, 22);
            this.txtKelime.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(245, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Heap\'e Aktar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(245, 188);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(354, 84);
            this.btnMax.TabIndex = 9;
            this.btnMax.Text = "En Çok Kullanılan Kelimeleri Getir\r\n\r\n";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // tbOrtalama
            // 
            this.tbOrtalama.Location = new System.Drawing.Point(383, 325);
            this.tbOrtalama.Name = "tbOrtalama";
            this.tbOrtalama.Size = new System.Drawing.Size(332, 22);
            this.tbOrtalama.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDosya);
            this.tabControl1.Controls.Add(this.tpStack);
            this.tabControl1.Controls.Add(this.tpHeap);
            this.tabControl1.Controls.Add(this.tpHash);
            this.tabControl1.Location = new System.Drawing.Point(29, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 404);
            this.tabControl1.TabIndex = 12;
            // 
            // tpDosya
            // 
            this.tpDosya.BackColor = System.Drawing.Color.Pink;
            this.tpDosya.Controls.Add(this.lbDosyaYolu);
            this.tpDosya.Controls.Add(this.btnDosyaEkle);
            this.tpDosya.Controls.Add(this.txtDosya);
            this.tpDosya.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tpDosya.Location = new System.Drawing.Point(4, 25);
            this.tpDosya.Name = "tpDosya";
            this.tpDosya.Padding = new System.Windows.Forms.Padding(3);
            this.tpDosya.Size = new System.Drawing.Size(840, 375);
            this.tpDosya.TabIndex = 0;
            this.tpDosya.Text = "Dosya Ekle";
            // 
            // tpStack
            // 
            this.tpStack.BackColor = System.Drawing.Color.Pink;
            this.tpStack.Controls.Add(this.lblOrtalama);
            this.tpStack.Controls.Add(this.lblToplam);
            this.tpStack.Controls.Add(this.tbOrtalama);
            this.tpStack.Controls.Add(this.tbToplamKelime);
            this.tpStack.Controls.Add(this.lblKelime);
            this.tpStack.Controls.Add(this.lblToplamCumle);
            this.tpStack.Controls.Add(this.lblCumleNumarasi);
            this.tpStack.Controls.Add(this.btnStack);
            this.tpStack.Controls.Add(this.txtCumleNumarasi);
            this.tpStack.Controls.Add(this.txtKelime);
            this.tpStack.Controls.Add(this.txtCumleSayisi);
            this.tpStack.Location = new System.Drawing.Point(4, 25);
            this.tpStack.Name = "tpStack";
            this.tpStack.Padding = new System.Windows.Forms.Padding(3);
            this.tpStack.Size = new System.Drawing.Size(840, 375);
            this.tpStack.TabIndex = 1;
            this.tpStack.Text = "Stack İşlemleri";
            // 
            // tpHeap
            // 
            this.tpHeap.BackColor = System.Drawing.Color.Pink;
            this.tpHeap.Controls.Add(this.button1);
            this.tpHeap.Controls.Add(this.btnMax);
            this.tpHeap.Location = new System.Drawing.Point(4, 25);
            this.tpHeap.Name = "tpHeap";
            this.tpHeap.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeap.Size = new System.Drawing.Size(840, 375);
            this.tpHeap.TabIndex = 2;
            this.tpHeap.Text = "Heap İşlemleri";
            // 
            // tpHash
            // 
            this.tpHash.BackColor = System.Drawing.Color.Pink;
            this.tpHash.Controls.Add(this.button2);
            this.tpHash.Location = new System.Drawing.Point(4, 25);
            this.tpHash.Name = "tpHash";
            this.tpHash.Padding = new System.Windows.Forms.Padding(3);
            this.tpHash.Size = new System.Drawing.Size(840, 375);
            this.tpHash.TabIndex = 3;
            this.tpHash.Text = "Hash İşlemleri";
            // 
            // lbDosyaYolu
            // 
            this.lbDosyaYolu.AutoSize = true;
            this.lbDosyaYolu.Location = new System.Drawing.Point(284, 211);
            this.lbDosyaYolu.Name = "lbDosyaYolu";
            this.lbDosyaYolu.Size = new System.Drawing.Size(154, 17);
            this.lbDosyaYolu.TabIndex = 2;
            this.lbDosyaYolu.Text = "Eklenen Dosyanın Yolu";
            // 
            // lblCumleNumarasi
            // 
            this.lblCumleNumarasi.AutoSize = true;
            this.lblCumleNumarasi.Location = new System.Drawing.Point(229, 23);
            this.lblCumleNumarasi.Name = "lblCumleNumarasi";
            this.lblCumleNumarasi.Size = new System.Drawing.Size(343, 17);
            this.lblCumleNumarasi.TabIndex = 7;
            this.lblCumleNumarasi.Text = "Lütfen Cümle Numarası Seçiniz.(yoksa çalışmayacak)";
            // 
            // lblToplamCumle
            // 
            this.lblToplamCumle.AutoSize = true;
            this.lblToplamCumle.Location = new System.Drawing.Point(117, 183);
            this.lblToplamCumle.Name = "lblToplamCumle";
            this.lblToplamCumle.Size = new System.Drawing.Size(139, 17);
            this.lblToplamCumle.TabIndex = 8;
            this.lblToplamCumle.Text = "Toplam Cümle Sayısı";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(117, 237);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(195, 17);
            this.lblKelime.TabIndex = 9;
            this.lblKelime.Text = "Seçili Cümledeki Kelime sayısı";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(117, 282);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(142, 17);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "Toplam Kelime Sayısı";
            // 
            // tbToplamKelime
            // 
            this.tbToplamKelime.Location = new System.Drawing.Point(383, 277);
            this.tbToplamKelime.Name = "tbToplamKelime";
            this.tbToplamKelime.Size = new System.Drawing.Size(332, 22);
            this.tbToplamKelime.TabIndex = 10;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(117, 330);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(153, 17);
            this.lblOrtalama.TabIndex = 12;
            this.lblOrtalama.Text = "Ortalama Kelime Sayısı\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 118);
            this.button2.TabIndex = 0;
            this.button2.Text = "Hash Tablo Oluştur";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpDosya.ResumeLayout(false);
            this.tpDosya.PerformLayout();
            this.tpStack.ResumeLayout(false);
            this.tpStack.PerformLayout();
            this.tpHeap.ResumeLayout(false);
            this.tpHash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.TextBox txtCumleSayisi;
        private System.Windows.Forms.TextBox txtCumleNumarasi;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.TextBox tbOrtalama;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDosya;
        private System.Windows.Forms.Label lbDosyaYolu;
        private System.Windows.Forms.TabPage tpStack;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblToplamCumle;
        private System.Windows.Forms.Label lblCumleNumarasi;
        private System.Windows.Forms.TabPage tpHeap;
        private System.Windows.Forms.TabPage tpHash;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox tbToplamKelime;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button button2;
    }
}

