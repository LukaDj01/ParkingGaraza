
namespace ParkingGaraza.Forme
{
    partial class Vozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vozila));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaVozila = new System.Windows.Forms.ListView();
            this.colHeadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadRBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadKategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazVlasnika = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Location = new System.Drawing.Point(503, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(204, 174);
            this.groupBox2.TabIndex = 13;
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
            this.pictureBox1.Location = new System.Drawing.Point(580, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listaVozila
            // 
            this.listaVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadID,
            this.colHeadRBr,
            this.colHeadMarka,
            this.colHeadTip,
            this.colHeadKategorija});
            this.listaVozila.FullRowSelect = true;
            this.listaVozila.GridLines = true;
            this.listaVozila.HideSelection = false;
            this.listaVozila.Location = new System.Drawing.Point(28, 27);
            this.listaVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaVozila.Name = "listaVozila";
            this.listaVozila.Size = new System.Drawing.Size(440, 414);
            this.listaVozila.TabIndex = 11;
            this.listaVozila.UseCompatibleStateImageBehavior = false;
            this.listaVozila.View = System.Windows.Forms.View.Details;
            // 
            // colHeadID
            // 
            this.colHeadID.Text = "ID";
            this.colHeadID.Width = 40;
            // 
            // colHeadRBr
            // 
            this.colHeadRBr.Text = "Tablice";
            this.colHeadRBr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.colHeadTip.Width = 100;
            // 
            // colHeadKategorija
            // 
            this.colHeadKategorija.Text = "Kategorija";
            // 
            // btnPrikazVlasnika
            // 
            this.btnPrikazVlasnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnPrikazVlasnika.ForeColor = System.Drawing.Color.White;
            this.btnPrikazVlasnika.Location = new System.Drawing.Point(28, 460);
            this.btnPrikazVlasnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikazVlasnika.Name = "btnPrikazVlasnika";
            this.btnPrikazVlasnika.Size = new System.Drawing.Size(440, 55);
            this.btnPrikazVlasnika.TabIndex = 14;
            this.btnPrikazVlasnika.Text = "PRIKAZ VLASNIKA";
            this.btnPrikazVlasnika.UseVisualStyleBackColor = false;
            this.btnPrikazVlasnika.Click += new System.EventHandler(this.btnPrikazVlasnika_Click);
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 548);
            this.Controls.Add(this.btnPrikazVlasnika);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listaVozila);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(765, 595);
            this.MinimumSize = new System.Drawing.Size(765, 595);
            this.Name = "Vozila";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.Vozila_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listaVozila;
        private System.Windows.Forms.ColumnHeader colHeadID;
        private System.Windows.Forms.ColumnHeader colHeadRBr;
        private System.Windows.Forms.ColumnHeader colHeadMarka;
        private System.Windows.Forms.ColumnHeader colHeadTip;
        private System.Windows.Forms.ColumnHeader colHeadKategorija;
        private System.Windows.Forms.Button btnPrikazVlasnika;
    }
}