namespace Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bird = new System.Windows.Forms.PictureBox();
            this.boruUst1 = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.boruAlt2 = new System.Windows.Forms.PictureBox();
            this.boruAlt3 = new System.Windows.Forms.PictureBox();
            this.boruAlt1 = new System.Windows.Forms.PictureBox();
            this.boruUst2 = new System.Windows.Forms.PictureBox();
            this.boruUst3 = new System.Windows.Forms.PictureBox();
            this.boruAlt4 = new System.Windows.Forms.PictureBox();
            this.boruUst4 = new System.Windows.Forms.PictureBox();
            this.skorTablosu = new System.Windows.Forms.Label();
            this.Zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst4)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(-5, 201);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(84, 89);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // boruUst1
            // 
            this.boruUst1.Image = ((System.Drawing.Image)(resources.GetObject("boruUst1.Image")));
            this.boruUst1.Location = new System.Drawing.Point(306, 1);
            this.boruUst1.Name = "boruUst1";
            this.boruUst1.Size = new System.Drawing.Size(100, 140);
            this.boruUst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst1.TabIndex = 1;
            this.boruUst1.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-5, 499);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(1483, 360);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 2;
            this.Zemin.TabStop = false;
           // this.Zemin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // boruAlt2
            // 
            this.boruAlt2.BackColor = System.Drawing.Color.Aqua;
            this.boruAlt2.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt2.Image")));
            this.boruAlt2.Location = new System.Drawing.Point(550, 381);
            this.boruAlt2.Name = "boruAlt2";
            this.boruAlt2.Size = new System.Drawing.Size(100, 121);
            this.boruAlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt2.TabIndex = 3;
            this.boruAlt2.TabStop = false;
            // 
            // boruAlt3
            // 
            this.boruAlt3.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt3.Image")));
            this.boruAlt3.Location = new System.Drawing.Point(825, 411);
            this.boruAlt3.Name = "boruAlt3";
            this.boruAlt3.Size = new System.Drawing.Size(100, 91);
            this.boruAlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt3.TabIndex = 4;
            this.boruAlt3.TabStop = false;
            // 
            // boruAlt1
            // 
            this.boruAlt1.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt1.Image")));
            this.boruAlt1.Location = new System.Drawing.Point(306, 345);
            this.boruAlt1.Name = "boruAlt1";
            this.boruAlt1.Size = new System.Drawing.Size(100, 157);
            this.boruAlt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt1.TabIndex = 5;
            this.boruAlt1.TabStop = false;
          //  this.boruAlt1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // boruUst2
            // 
            this.boruUst2.Image = ((System.Drawing.Image)(resources.GetObject("boruUst2.Image")));
            this.boruUst2.Location = new System.Drawing.Point(550, 1);
            this.boruUst2.Name = "boruUst2";
            this.boruUst2.Size = new System.Drawing.Size(100, 140);
            this.boruUst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst2.TabIndex = 6;
            this.boruUst2.TabStop = false;
            // 
            // boruUst3
            // 
            this.boruUst3.Image = ((System.Drawing.Image)(resources.GetObject("boruUst3.Image")));
            this.boruUst3.Location = new System.Drawing.Point(825, 1);
            this.boruUst3.Name = "boruUst3";
            this.boruUst3.Size = new System.Drawing.Size(100, 244);
            this.boruUst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst3.TabIndex = 8;
            this.boruUst3.TabStop = false;
          //  this.boruUst3.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // boruAlt4
            // 
            this.boruAlt4.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt4.Image")));
            this.boruAlt4.Location = new System.Drawing.Point(1352, 309);
            this.boruAlt4.Name = "boruAlt4";
            this.boruAlt4.Size = new System.Drawing.Size(100, 193);
            this.boruAlt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt4.TabIndex = 10;
            this.boruAlt4.TabStop = false;
           // this.boruAlt4.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // boruUst4
            // 
            this.boruUst4.Image = ((System.Drawing.Image)(resources.GetObject("boruUst4.Image")));
            this.boruUst4.Location = new System.Drawing.Point(1095, 1);
            this.boruUst4.Name = "boruUst4";
            this.boruUst4.Size = new System.Drawing.Size(100, 244);
            this.boruUst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst4.TabIndex = 11;
            this.boruUst4.TabStop = false;
            // 
            // skorTablosu
            // 
            this.skorTablosu.AutoSize = true;
            this.skorTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorTablosu.Location = new System.Drawing.Point(12, 516);
            this.skorTablosu.Name = "skorTablosu";
            this.skorTablosu.Size = new System.Drawing.Size(126, 36);
            this.skorTablosu.TabIndex = 12;
            this.skorTablosu.Text = "Skor : 0";
            // 
            // Zamanlayıcı
            // 
            this.Zamanlayıcı.Enabled = true;
            this.Zamanlayıcı.Interval = 20;
            this.Zamanlayıcı.Tick += new System.EventHandler(this.Zamanlayıcı_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1478, 561);
            this.Controls.Add(this.skorTablosu);
            this.Controls.Add(this.boruUst4);
            this.Controls.Add(this.boruAlt4);
            this.Controls.Add(this.boruUst3);
            this.Controls.Add(this.boruUst2);
            this.Controls.Add(this.boruAlt1);
            this.Controls.Add(this.boruAlt3);
            this.Controls.Add(this.boruAlt2);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.boruUst1);
            this.Controls.Add(this.Bird);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oyunanahtariassagi);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.oyunanahtariyukari);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox boruUst1;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.PictureBox boruAlt2;
        private System.Windows.Forms.PictureBox boruAlt3;
        private System.Windows.Forms.PictureBox boruAlt1;
        private System.Windows.Forms.PictureBox boruUst2;
        private System.Windows.Forms.PictureBox boruUst3;
        private System.Windows.Forms.PictureBox boruAlt4;
        private System.Windows.Forms.PictureBox boruUst4;
        private System.Windows.Forms.Label skorTablosu;
        private System.Windows.Forms.Timer Zamanlayıcı;
    }
}

