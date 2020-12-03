namespace Proje_Obs
{
    partial class FrmOgretmenPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenPaneli));
            this.Btndersislem = new System.Windows.Forms.Button();
            this.btnKulüpislem = new System.Windows.Forms.Button();
            this.BtnSinavnotlari = new System.Windows.Forms.Button();
            this.BtnOgrenciislemleri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btndersislem
            // 
            this.Btndersislem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btndersislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btndersislem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btndersislem.Location = new System.Drawing.Point(160, 12);
            this.Btndersislem.Name = "Btndersislem";
            this.Btndersislem.Size = new System.Drawing.Size(324, 83);
            this.Btndersislem.TabIndex = 1;
            this.Btndersislem.Text = "Ders İşlemleri";
            this.Btndersislem.UseVisualStyleBackColor = false;
            this.Btndersislem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKulüpislem
            // 
            this.btnKulüpislem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKulüpislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKulüpislem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulüpislem.Location = new System.Drawing.Point(160, 101);
            this.btnKulüpislem.Name = "btnKulüpislem";
            this.btnKulüpislem.Size = new System.Drawing.Size(324, 83);
            this.btnKulüpislem.TabIndex = 2;
            this.btnKulüpislem.Text = "Kulüp İşlemleri";
            this.btnKulüpislem.UseVisualStyleBackColor = false;
            this.btnKulüpislem.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSinavnotlari
            // 
            this.BtnSinavnotlari.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSinavnotlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSinavnotlari.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavnotlari.Location = new System.Drawing.Point(160, 190);
            this.BtnSinavnotlari.Name = "BtnSinavnotlari";
            this.BtnSinavnotlari.Size = new System.Drawing.Size(324, 83);
            this.BtnSinavnotlari.TabIndex = 3;
            this.BtnSinavnotlari.Text = "Sınav Notları";
            this.BtnSinavnotlari.UseVisualStyleBackColor = false;
            this.BtnSinavnotlari.Click += new System.EventHandler(this.BtnSinavnotlari_Click);
            // 
            // BtnOgrenciislemleri
            // 
            this.BtnOgrenciislemleri.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnOgrenciislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOgrenciislemleri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciislemleri.Location = new System.Drawing.Point(160, 279);
            this.BtnOgrenciislemleri.Name = "BtnOgrenciislemleri";
            this.BtnOgrenciislemleri.Size = new System.Drawing.Size(324, 83);
            this.BtnOgrenciislemleri.TabIndex = 4;
            this.BtnOgrenciislemleri.Text = "Öğrenci İşlemleri";
            this.BtnOgrenciislemleri.UseVisualStyleBackColor = false;
            this.BtnOgrenciislemleri.Click += new System.EventHandler(this.BtnOgrenciislemleri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOgretmenPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnOgrenciislemleri);
            this.Controls.Add(this.BtnSinavnotlari);
            this.Controls.Add(this.btnKulüpislem);
            this.Controls.Add(this.Btndersislem);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgretmenPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgretmenPaneli";
            this.Load += new System.EventHandler(this.FrmOgretmenPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btndersislem;
        private System.Windows.Forms.Button btnKulüpislem;
        private System.Windows.Forms.Button BtnSinavnotlari;
        private System.Windows.Forms.Button BtnOgrenciislemleri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}