
namespace ParkingGaraza.Forme
{
    partial class KontrolorNovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolorNovi));
            this.listaOperatera = new System.Windows.Forms.ListView();
            this.colHeadJMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadRadniStaz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaOperatera
            // 
            this.listaOperatera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadJMBG,
            this.colHeadIme,
            this.colHeadPrezime,
            this.colHeadRadniStaz});
            this.listaOperatera.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaOperatera.FullRowSelect = true;
            this.listaOperatera.GridLines = true;
            this.listaOperatera.HideSelection = false;
            this.listaOperatera.Location = new System.Drawing.Point(39, 26);
            this.listaOperatera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaOperatera.Name = "listaOperatera";
            this.listaOperatera.Size = new System.Drawing.Size(430, 419);
            this.listaOperatera.TabIndex = 7;
            this.listaOperatera.UseCompatibleStateImageBehavior = false;
            this.listaOperatera.View = System.Windows.Forms.View.Details;
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
            // colHeadRadniStaz
            // 
            this.colHeadRadniStaz.Text = "RadniStaz";
            this.colHeadRadniStaz.Width = 95;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOdaberi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.ForeColor = System.Drawing.Color.White;
            this.btnOdaberi.Location = new System.Drawing.Point(180, 476);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(143, 36);
            this.btnOdaberi.TabIndex = 54;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // KontrolorNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.listaOperatera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(530, 600);
            this.MinimumSize = new System.Drawing.Size(530, 600);
            this.Name = "KontrolorNovi";
            this.Text = "KontrolorNovi";
            this.Load += new System.EventHandler(this.KontrolorNovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaOperatera;
        private System.Windows.Forms.ColumnHeader colHeadJMBG;
        private System.Windows.Forms.ColumnHeader colHeadIme;
        private System.Windows.Forms.ColumnHeader colHeadPrezime;
        private System.Windows.Forms.ColumnHeader colHeadRadniStaz;
        private System.Windows.Forms.Button btnOdaberi;
    }
}