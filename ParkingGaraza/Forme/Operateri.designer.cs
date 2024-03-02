
namespace ParkingGaraza.Forme
{
    partial class Operateri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operateri));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOtpusti = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaOperatera = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxSmena = new System.Windows.Forms.ComboBox();
            this.btnKontrolor = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnOtpusti);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(548, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upravljanje podacima";
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOtpusti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOtpusti.ForeColor = System.Drawing.Color.White;
            this.btnOtpusti.Location = new System.Drawing.Point(44, 130);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Size = new System.Drawing.Size(84, 30);
            this.btnOtpusti.TabIndex = 2;
            this.btnOtpusti.Text = "Otpusti";
            this.btnOtpusti.UseVisualStyleBackColor = false;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(44, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(44, 32);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(84, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listaOperatera
            // 
            this.listaOperatera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listaOperatera.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaOperatera.FullRowSelect = true;
            this.listaOperatera.GridLines = true;
            this.listaOperatera.HideSelection = false;
            this.listaOperatera.Location = new System.Drawing.Point(26, 59);
            this.listaOperatera.Name = "listaOperatera";
            this.listaOperatera.Size = new System.Drawing.Size(486, 318);
            this.listaOperatera.TabIndex = 6;
            this.listaOperatera.UseCompatibleStateImageBehavior = false;
            this.listaOperatera.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JMBG";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DatumRođenja";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DatumZaposlenja";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RadniStaz";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Smena";
            this.columnHeader7.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prikaži smenu:";
            // 
            // cmbBoxSmena
            // 
            this.cmbBoxSmena.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSmena.FormattingEnabled = true;
            this.cmbBoxSmena.Items.AddRange(new object[] {
            "Sve",
            "1",
            "2",
            "3",
            "Otpušteni"});
            this.cmbBoxSmena.Location = new System.Drawing.Point(114, 29);
            this.cmbBoxSmena.Name = "cmbBoxSmena";
            this.cmbBoxSmena.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSmena.TabIndex = 8;
            this.cmbBoxSmena.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSmena_SelectedIndexChanged);
            // 
            // btnKontrolor
            // 
            this.btnKontrolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnKontrolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKontrolor.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolor.ForeColor = System.Drawing.Color.White;
            this.btnKontrolor.Location = new System.Drawing.Point(579, 297);
            this.btnKontrolor.Name = "btnKontrolor";
            this.btnKontrolor.Size = new System.Drawing.Size(112, 49);
            this.btnKontrolor.TabIndex = 3;
            this.btnKontrolor.Text = "Kontrolor";
            this.btnKontrolor.UseVisualStyleBackColor = false;
            this.btnKontrolor.Click += new System.EventHandler(this.btnKontrolor_Click);
            // 
            // Operateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(757, 415);
            this.Controls.Add(this.btnKontrolor);
            this.Controls.Add(this.cmbBoxSmena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaOperatera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(773, 454);
            this.MinimumSize = new System.Drawing.Size(773, 454);
            this.Name = "Operateri";
            this.Text = "Operateri";
            this.Load += new System.EventHandler(this.Operateri_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOtpusti;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listaOperatera;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxSmena;
        private System.Windows.Forms.Button btnKontrolor;
    }
}