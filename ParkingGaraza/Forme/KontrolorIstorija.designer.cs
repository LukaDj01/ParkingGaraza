
namespace ParkingGaraza.Forme
{
    partial class KontrolorIstorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolorIstorija));
            this.listaKontrolora = new System.Windows.Forms.ListView();
            this.colHeadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadKraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadJMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaKontrolora
            // 
            this.listaKontrolora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadID,
            this.colHeadPocetak,
            this.colHeadKraj,
            this.colHeadJMBG});
            this.listaKontrolora.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaKontrolora.FullRowSelect = true;
            this.listaKontrolora.GridLines = true;
            this.listaKontrolora.HideSelection = false;
            this.listaKontrolora.Location = new System.Drawing.Point(45, 13);
            this.listaKontrolora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaKontrolora.Name = "listaKontrolora";
            this.listaKontrolora.Size = new System.Drawing.Size(360, 445);
            this.listaKontrolora.TabIndex = 8;
            this.listaKontrolora.UseCompatibleStateImageBehavior = false;
            this.listaKontrolora.View = System.Windows.Forms.View.Details;
            // 
            // colHeadID
            // 
            this.colHeadID.Text = "ID";
            this.colHeadID.Width = 40;
            // 
            // colHeadPocetak
            // 
            this.colHeadPocetak.Text = "Pocetak";
            this.colHeadPocetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadPocetak.Width = 100;
            // 
            // colHeadKraj
            // 
            this.colHeadKraj.Text = "Kraj";
            this.colHeadKraj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadKraj.Width = 100;
            // 
            // colHeadJMBG
            // 
            this.colHeadJMBG.Text = "JMBG";
            this.colHeadJMBG.Width = 100;
            // 
            // KontrolorIstorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 468);
            this.Controls.Add(this.listaKontrolora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(460, 515);
            this.MinimumSize = new System.Drawing.Size(460, 515);
            this.Name = "KontrolorIstorija";
            this.Text = "KontrolorIstorija";
            this.Load += new System.EventHandler(this.KontrolorIstorija_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaKontrolora;
        private System.Windows.Forms.ColumnHeader colHeadID;
        private System.Windows.Forms.ColumnHeader colHeadPocetak;
        private System.Windows.Forms.ColumnHeader colHeadKraj;
        private System.Windows.Forms.ColumnHeader colHeadJMBG;
    }
}