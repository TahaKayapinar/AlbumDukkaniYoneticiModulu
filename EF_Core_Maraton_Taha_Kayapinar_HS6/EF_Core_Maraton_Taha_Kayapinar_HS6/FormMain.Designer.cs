namespace EF_Core_Maraton_Taha_Kayapinar_HS6
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuKullaniciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.manuSatisiDurmusAlbumler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSatisiDevamEdenAlbumler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemeEnSonEklenen10Album = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIndirimdekiAlbumler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlbumNewDeleteUpdate = new System.Windows.Forms.Button();
            this.btnUserDeleteInsertUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKullaniciIslemleri,
            this.menuAlbum});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuKullaniciIslemleri
            // 
            this.menuKullaniciIslemleri.Name = "menuKullaniciIslemleri";
            this.menuKullaniciIslemleri.Size = new System.Drawing.Size(111, 20);
            this.menuKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.menuKullaniciIslemleri.Click += new System.EventHandler(this.menuKullaniciIslemleri_Click);
            // 
            // menuAlbum
            // 
            this.menuAlbum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuSatisiDurmusAlbumler,
            this.menuSatisiDevamEdenAlbumler,
            this.menuSistemeEnSonEklenen10Album,
            this.menuIndirimdekiAlbumler});
            this.menuAlbum.Name = "menuAlbum";
            this.menuAlbum.Size = new System.Drawing.Size(98, 20);
            this.menuAlbum.Text = "Albüm Listeleri";
            this.menuAlbum.Click += new System.EventHandler(this.menuAlbum_Click);
            // 
            // manuSatisiDurmusAlbumler
            // 
            this.manuSatisiDurmusAlbumler.Name = "manuSatisiDurmusAlbumler";
            this.manuSatisiDurmusAlbumler.Size = new System.Drawing.Size(249, 22);
            this.manuSatisiDurmusAlbumler.Text = "Satışı Durmuş Albümler";
            this.manuSatisiDurmusAlbumler.Click += new System.EventHandler(this.manuSatisiDurmusAlbumler_Click);
            // 
            // menuSatisiDevamEdenAlbumler
            // 
            this.menuSatisiDevamEdenAlbumler.Name = "menuSatisiDevamEdenAlbumler";
            this.menuSatisiDevamEdenAlbumler.Size = new System.Drawing.Size(249, 22);
            this.menuSatisiDevamEdenAlbumler.Text = "Satışı Devam Eden Albümler";
            // 
            // menuSistemeEnSonEklenen10Album
            // 
            this.menuSistemeEnSonEklenen10Album.Name = "menuSistemeEnSonEklenen10Album";
            this.menuSistemeEnSonEklenen10Album.Size = new System.Drawing.Size(249, 22);
            this.menuSistemeEnSonEklenen10Album.Text = "Sisteme en son eklenen 10 albüm";
            // 
            // menuIndirimdekiAlbumler
            // 
            this.menuIndirimdekiAlbumler.Name = "menuIndirimdekiAlbumler";
            this.menuIndirimdekiAlbumler.Size = new System.Drawing.Size(249, 22);
            this.menuIndirimdekiAlbumler.Text = "İndirimdeki Albümler";
            this.menuIndirimdekiAlbumler.Click += new System.EventHandler(this.menuIndirimdekiAlbumler_Click);
            // 
            // btnAlbumNewDeleteUpdate
            // 
            this.btnAlbumNewDeleteUpdate.Location = new System.Drawing.Point(12, 39);
            this.btnAlbumNewDeleteUpdate.Name = "btnAlbumNewDeleteUpdate";
            this.btnAlbumNewDeleteUpdate.Size = new System.Drawing.Size(194, 46);
            this.btnAlbumNewDeleteUpdate.TabIndex = 1;
            this.btnAlbumNewDeleteUpdate.Text = "Albüm Ekle/Sil/Gücelle";
            this.btnAlbumNewDeleteUpdate.UseVisualStyleBackColor = true;
            this.btnAlbumNewDeleteUpdate.Click += new System.EventHandler(this.btnAlbumNewDeleteUpdate_Click);
            // 
            // btnUserDeleteInsertUpdate
            // 
            this.btnUserDeleteInsertUpdate.Location = new System.Drawing.Point(12, 91);
            this.btnUserDeleteInsertUpdate.Name = "btnUserDeleteInsertUpdate";
            this.btnUserDeleteInsertUpdate.Size = new System.Drawing.Size(194, 46);
            this.btnUserDeleteInsertUpdate.TabIndex = 1;
            this.btnUserDeleteInsertUpdate.Text = "Kullanıcı Ekle/Sil/Gücelle";
            this.btnUserDeleteInsertUpdate.UseVisualStyleBackColor = true;
            this.btnUserDeleteInsertUpdate.Click += new System.EventHandler(this.btnUserDeleteInsertUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 201);
            this.Controls.Add(this.btnUserDeleteInsertUpdate);
            this.Controls.Add(this.btnAlbumNewDeleteUpdate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuKullaniciIslemleri;
        private ToolStripMenuItem menuAlbum;
        private ToolStripMenuItem manuSatisiDurmusAlbumler;
        private ToolStripMenuItem menuSatisiDevamEdenAlbumler;
        private ToolStripMenuItem menuSistemeEnSonEklenen10Album;
        private ToolStripMenuItem menuIndirimdekiAlbumler;
        private Button btnAlbumNewDeleteUpdate;
        private Button btnUserDeleteInsertUpdate;
    }
}