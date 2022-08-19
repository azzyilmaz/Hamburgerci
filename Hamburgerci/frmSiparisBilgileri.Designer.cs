namespace Hamburgerci
{
    partial class frmSiparisBilgileri
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisAdedi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExtraMalzemeGeliri = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Siparişler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 20;
            this.lstSiparisler.Location = new System.Drawing.Point(12, 43);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(749, 404);
            this.lstSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(781, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(85, 40);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(40, 20);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0 TL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSiparisAdedi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(781, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Adedi";
            // 
            // lblToplamSiparisAdedi
            // 
            this.lblToplamSiparisAdedi.AutoSize = true;
            this.lblToplamSiparisAdedi.Location = new System.Drawing.Point(85, 48);
            this.lblToplamSiparisAdedi.Name = "lblToplamSiparisAdedi";
            this.lblToplamSiparisAdedi.Size = new System.Drawing.Size(40, 20);
            this.lblToplamSiparisAdedi.TabIndex = 0;
            this.lblToplamSiparisAdedi.Text = "0 TL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtraMalzemeGeliri);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(781, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 89);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Geliri";
            // 
            // lblExtraMalzemeGeliri
            // 
            this.lblExtraMalzemeGeliri.AutoSize = true;
            this.lblExtraMalzemeGeliri.Location = new System.Drawing.Point(85, 46);
            this.lblExtraMalzemeGeliri.Name = "lblExtraMalzemeGeliri";
            this.lblExtraMalzemeGeliri.Size = new System.Drawing.Size(40, 20);
            this.lblExtraMalzemeGeliri.TabIndex = 0;
            this.lblExtraMalzemeGeliri.Text = "0 TL";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblSatilanUrunAdedi);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(781, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 97);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(85, 50);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(40, 20);
            this.lblSatilanUrunAdedi.TabIndex = 0;
            this.lblSatilanUrunAdedi.Text = "0 TL";
            // 
            // frmSiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 480);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSiparisBilgileri";
            this.Load += new System.EventHandler(this.frmSiparisBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSiparisAdedi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtraMalzemeGeliri;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
    }
}