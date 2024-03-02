
namespace ParkingGaraza.Forme
{
    partial class KarticePU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarticePU));
            this.listaKarata = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVozilo = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnOperater = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaKarata
            // 
            this.listaKarata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listaKarata.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaKarata.FullRowSelect = true;
            this.listaKarata.GridLines = true;
            this.listaKarata.HideSelection = false;
            this.listaKarata.Location = new System.Drawing.Point(211, 21);
            this.listaKarata.Name = "listaKarata";
            this.listaKarata.Size = new System.Drawing.Size(265, 394);
            this.listaKarata.TabIndex = 9;
            this.listaKarata.UseCompatibleStateImageBehavior = false;
            this.listaKarata.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VremeOd";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VremeDo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 133);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upravljanje podacima";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnVozilo);
            this.groupBox1.Controls.Add(this.btnPM);
            this.groupBox1.Controls.Add(this.btnOperater);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(492, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 273);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatne informacije:";
            // 
            // btnVozilo
            // 
            this.btnVozilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnVozilo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVozilo.ForeColor = System.Drawing.Color.White;
            this.btnVozilo.Location = new System.Drawing.Point(36, 183);
            this.btnVozilo.Name = "btnVozilo";
            this.btnVozilo.Size = new System.Drawing.Size(120, 40);
            this.btnVozilo.TabIndex = 5;
            this.btnVozilo.Text = "Vozilo";
            this.btnVozilo.UseVisualStyleBackColor = false;
            this.btnVozilo.Click += new System.EventHandler(this.btnVozilo_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPM.ForeColor = System.Drawing.Color.White;
            this.btnPM.Location = new System.Drawing.Point(36, 128);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(120, 40);
            this.btnPM.TabIndex = 4;
            this.btnPM.Text = "Parking mesto";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnOperater
            // 
            this.btnOperater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOperater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOperater.ForeColor = System.Drawing.Color.White;
            this.btnOperater.Location = new System.Drawing.Point(36, 70);
            this.btnOperater.Name = "btnOperater";
            this.btnOperater.Size = new System.Drawing.Size(120, 40);
            this.btnOperater.TabIndex = 3;
            this.btnOperater.Text = "Operater";
            this.btnOperater.UseVisualStyleBackColor = false;
            this.btnOperater.Click += new System.EventHandler(this.btnOperater_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // KarticePU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(719, 440);
            this.Controls.Add(this.listaKarata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(735, 479);
            this.MinimumSize = new System.Drawing.Size(735, 479);
            this.Name = "KarticePU";
            this.Text = "KarticePU";
            this.Load += new System.EventHandler(this.KarticePU_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaKarata;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVozilo;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnOperater;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}