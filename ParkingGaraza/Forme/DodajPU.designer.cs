
namespace ParkingGaraza.Forme
{
    partial class DodajPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPU));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.cbBoxOperater = new System.Windows.Forms.ComboBox();
            this.txBoxVozilo = new System.Windows.Forms.TextBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.textBoxPM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnDodaj.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(309, 69);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 46);
            this.btnDodaj.TabIndex = 41;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Operater:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Vozilo ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Parking mesto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnNastavi
            // 
            this.btnNastavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnNastavi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNastavi.ForeColor = System.Drawing.Color.White;
            this.btnNastavi.Location = new System.Drawing.Point(309, 121);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(97, 46);
            this.btnNastavi.TabIndex = 42;
            this.btnNastavi.Text = "Nastavi dodavanje";
            this.btnNastavi.UseVisualStyleBackColor = false;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOtkazi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(309, 172);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(97, 46);
            this.btnOtkazi.TabIndex = 43;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // cbBoxOperater
            // 
            this.cbBoxOperater.FormattingEnabled = true;
            this.cbBoxOperater.Location = new System.Drawing.Point(112, 93);
            this.cbBoxOperater.Name = "cbBoxOperater";
            this.cbBoxOperater.Size = new System.Drawing.Size(156, 21);
            this.cbBoxOperater.TabIndex = 44;
            // 
            // txBoxVozilo
            // 
            this.txBoxVozilo.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxVozilo.Location = new System.Drawing.Point(112, 172);
            this.txBoxVozilo.Name = "txBoxVozilo";
            this.txBoxVozilo.Size = new System.Drawing.Size(156, 22);
            this.txBoxVozilo.TabIndex = 37;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOdaberi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.ForeColor = System.Drawing.Color.White;
            this.btnOdaberi.Location = new System.Drawing.Point(211, 130);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(56, 28);
            this.btnOdaberi.TabIndex = 46;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // textBoxPM
            // 
            this.textBoxPM.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPM.Location = new System.Drawing.Point(112, 134);
            this.textBoxPM.Name = "textBoxPM";
            this.textBoxPM.Size = new System.Drawing.Size(94, 22);
            this.textBoxPM.TabIndex = 47;
            // 
            // DodajPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 249);
            this.Controls.Add(this.textBoxPM);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.cbBoxOperater);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBoxVozilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 288);
            this.MinimumSize = new System.Drawing.Size(458, 288);
            this.Name = "DodajPU";
            this.Text = "DodajPU";
            this.Load += new System.EventHandler(this.DodajPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ComboBox cbBoxOperater;
        private System.Windows.Forms.TextBox txBoxVozilo;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.TextBox textBoxPM;
    }
}