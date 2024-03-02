
namespace ParkingGaraza.Forme
{
    partial class VozilaDodajVlasnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VozilaDodajVlasnika));
            this.listaVozila = new System.Windows.Forms.ListView();
            this.colHeadRBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txBoxPrezime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txBoxJMBG = new System.Windows.Forms.TextBox();
            this.txBoxIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaVozila
            // 
            this.listaVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadRBr,
            this.colHeadMarka,
            this.colHeadTip});
            this.listaVozila.FullRowSelect = true;
            this.listaVozila.GridLines = true;
            this.listaVozila.HideSelection = false;
            this.listaVozila.Location = new System.Drawing.Point(24, 291);
            this.listaVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaVozila.Name = "listaVozila";
            this.listaVozila.Size = new System.Drawing.Size(371, 125);
            this.listaVozila.TabIndex = 69;
            this.listaVozila.UseCompatibleStateImageBehavior = false;
            this.listaVozila.View = System.Windows.Forms.View.Details;
            // 
            // colHeadRBr
            // 
            this.colHeadRBr.Text = "Registarski broj";
            this.colHeadRBr.Width = 100;
            // 
            // colHeadMarka
            // 
            this.colHeadMarka.Text = "Marka";
            this.colHeadMarka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadMarka.Width = 100;
            // 
            // colHeadTip
            // 
            this.colHeadTip.Text = "Tip";
            this.colHeadTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadTip.Width = 100;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOtkazi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(307, 176);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(88, 55);
            this.btnOtkazi.TabIndex = 67;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnDodaj.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(299, 98);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 50);
            this.btnDodaj.TabIndex = 66;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txBoxPrezime
            // 
            this.txBoxPrezime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxPrezime.Location = new System.Drawing.Point(123, 205);
            this.txBoxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txBoxPrezime.Name = "txBoxPrezime";
            this.txBoxPrezime.Size = new System.Drawing.Size(116, 26);
            this.txBoxPrezime.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Vozilo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Prezime:";
            // 
            // txBoxJMBG
            // 
            this.txBoxJMBG.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxJMBG.Location = new System.Drawing.Point(123, 94);
            this.txBoxJMBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txBoxJMBG.Name = "txBoxJMBG";
            this.txBoxJMBG.Size = new System.Drawing.Size(116, 26);
            this.txBoxJMBG.TabIndex = 62;
            // 
            // txBoxIme
            // 
            this.txBoxIme.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxIme.Location = new System.Drawing.Point(123, 150);
            this.txBoxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txBoxIme.Name = "txBoxIme";
            this.txBoxIme.Size = new System.Drawing.Size(116, 26);
            this.txBoxIme.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "JMBG:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // VozilaDodajVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.listaVozila);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txBoxPrezime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBoxJMBG);
            this.Controls.Add(this.txBoxIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "VozilaDodajVlasnika";
            this.Text = "VozilaDodajVlasnika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaVozila;
        private System.Windows.Forms.ColumnHeader colHeadRBr;
        private System.Windows.Forms.ColumnHeader colHeadMarka;
        private System.Windows.Forms.ColumnHeader colHeadTip;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txBoxPrezime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBoxJMBG;
        private System.Windows.Forms.TextBox txBoxIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}