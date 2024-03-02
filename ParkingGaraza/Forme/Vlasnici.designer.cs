
namespace ParkingGaraza.Forme
{
    partial class Vlasnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vlasnici));
            this.listaVlasnika = new System.Windows.Forms.ListView();
            this.colHeadJMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazVozila = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaVlasnika
            // 
            this.listaVlasnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadJMBG,
            this.colHeadIme,
            this.colHeadPrezime});
            this.listaVlasnika.FullRowSelect = true;
            this.listaVlasnika.GridLines = true;
            this.listaVlasnika.HideSelection = false;
            this.listaVlasnika.Location = new System.Drawing.Point(28, 38);
            this.listaVlasnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaVlasnika.Name = "listaVlasnika";
            this.listaVlasnika.Size = new System.Drawing.Size(365, 414);
            this.listaVlasnika.TabIndex = 7;
            this.listaVlasnika.UseCompatibleStateImageBehavior = false;
            this.listaVlasnika.View = System.Windows.Forms.View.Details;
            // 
            // colHeadJMBG
            // 
            this.colHeadJMBG.Text = "JMBG";
            this.colHeadJMBG.Width = 100;
            // 
            // colHeadIme
            // 
            this.colHeadIme.Text = "Ime";
            this.colHeadIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadIme.Width = 100;
            // 
            // colHeadPrezime
            // 
            this.colHeadPrezime.Text = "Prezime";
            this.colHeadPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadPrezime.Width = 100;
            // 
            // btnPrikazVozila
            // 
            this.btnPrikazVozila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnPrikazVozila.ForeColor = System.Drawing.Color.White;
            this.btnPrikazVozila.Location = new System.Drawing.Point(28, 475);
            this.btnPrikazVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikazVozila.Name = "btnPrikazVozila";
            this.btnPrikazVozila.Size = new System.Drawing.Size(367, 72);
            this.btnPrikazVozila.TabIndex = 8;
            this.btnPrikazVozila.Text = "PRIKAZ LISTE VOZILA";
            this.btnPrikazVozila.UseVisualStyleBackColor = false;
            this.btnPrikazVozila.Click += new System.EventHandler(this.btnPrikazVozila_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(415, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(204, 181);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upravljanje podacima";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(52, 104);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 39);
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
            this.btnDodaj.Location = new System.Drawing.Point(52, 41);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 39);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Vlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(642, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrikazVozila);
            this.Controls.Add(this.listaVlasnika);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(660, 610);
            this.MinimumSize = new System.Drawing.Size(660, 610);
            this.Name = "Vlasnici";
            this.Text = "Vlasnici";
            this.Load += new System.EventHandler(this.Vlasnici_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaVlasnika;
        private System.Windows.Forms.ColumnHeader colHeadJMBG;
        private System.Windows.Forms.ColumnHeader colHeadIme;
        private System.Windows.Forms.ColumnHeader colHeadPrezime;
        private System.Windows.Forms.Button btnPrikazVozila;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}