namespace deneme_entity
{
    partial class frmMusteriIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriIslemler));
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnSiparisdDurum = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparis.BackgroundImage")));
            this.btnSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparis.Location = new System.Drawing.Point(168, 109);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(278, 244);
            this.btnSiparis.TabIndex = 0;
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.BtnSiparis_Click);
            // 
            // btnSiparisdDurum
            // 
            this.btnSiparisdDurum.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisdDurum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisdDurum.BackgroundImage")));
            this.btnSiparisdDurum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisdDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisdDurum.Location = new System.Drawing.Point(448, 389);
            this.btnSiparisdDurum.Name = "btnSiparisdDurum";
            this.btnSiparisdDurum.Size = new System.Drawing.Size(285, 244);
            this.btnSiparisdDurum.TabIndex = 0;
            this.btnSiparisdDurum.Text = "Sipariş Durumu";
            this.btnSiparisdDurum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisdDurum.UseVisualStyleBackColor = false;
            this.btnSiparisdDurum.Click += new System.EventHandler(this.BtnSiparisdDurum_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(736, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 244);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kullanıcı İşlemleri";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1097, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(56, 53);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(8, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(124, 53);
            this.btnGeri.TabIndex = 17;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(267, 30);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(46, 17);
            this.lblMusteri.TabIndex = 20;
            this.lblMusteri.Text = "label1";
            // 
            // frmMusteriIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_entity.Properties.Resources.istockphoto_486846754_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.ControlBox = false;
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSiparisdDurum);
            this.Controls.Add(this.btnSiparis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriIslemler";
            this.Load += new System.EventHandler(this.FrmMusteriIslemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnSiparisdDurum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblMusteri;
    }
}