namespace Hamburgerci
{
    partial class frmMainMdi
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
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHamburgerEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExtraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2133, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSiparisOlustur,
            this.toolStripSiparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(251, 48);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // toolStripSiparisOlustur
            // 
            this.toolStripSiparisOlustur.Name = "toolStripSiparisOlustur";
            this.toolStripSiparisOlustur.Size = new System.Drawing.Size(448, 54);
            this.toolStripSiparisOlustur.Text = "Sipariş Oluştur";
            this.toolStripSiparisOlustur.Click += new System.EventHandler(this.toolStripSiparisOlustur_Click);
            // 
            // toolStripSiparisBilgileri
            // 
            this.toolStripSiparisBilgileri.Name = "toolStripSiparisBilgileri";
            this.toolStripSiparisBilgileri.Size = new System.Drawing.Size(448, 54);
            this.toolStripSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.toolStripSiparisBilgileri.Click += new System.EventHandler(this.toolStripSiparisBilgileri_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHamburgerEkle,
            this.toolStripExtraMalzemeEkle});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(230, 48);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // toolStripHamburgerEkle
            // 
            this.toolStripHamburgerEkle.Name = "toolStripHamburgerEkle";
            this.toolStripHamburgerEkle.Size = new System.Drawing.Size(448, 54);
            this.toolStripHamburgerEkle.Text = "Hamburger Ekle";
            this.toolStripHamburgerEkle.Click += new System.EventHandler(this.toolStripHamburgerEkle_Click);
            // 
            // toolStripExtraMalzemeEkle
            // 
            this.toolStripExtraMalzemeEkle.Name = "toolStripExtraMalzemeEkle";
            this.toolStripExtraMalzemeEkle.Size = new System.Drawing.Size(448, 54);
            this.toolStripExtraMalzemeEkle.Text = "Extra Malzeme Ekle";
            this.toolStripExtraMalzemeEkle.Click += new System.EventHandler(this.toolStripExtraMalzemeEkle_Click);
            // 
            // frmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMdi";
            this.Text = "frmMainMdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem toolStripSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripHamburgerEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripExtraMalzemeEkle;
    }
}