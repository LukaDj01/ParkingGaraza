
namespace ParkingGaraza.Forme
{
    partial class InfoOperater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoOperater));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txBoxSmena = new System.Windows.Forms.TextBox();
            this.txBoxJMBG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txBoxIme = new System.Windows.Forms.TextBox();
            this.txBoxPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txBoxSmena
            // 
            this.txBoxSmena.Enabled = false;
            this.txBoxSmena.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxSmena.Location = new System.Drawing.Point(94, 191);
            this.txBoxSmena.Name = "txBoxSmena";
            this.txBoxSmena.Size = new System.Drawing.Size(100, 22);
            this.txBoxSmena.TabIndex = 46;
            // 
            // txBoxJMBG
            // 
            this.txBoxJMBG.Enabled = false;
            this.txBoxJMBG.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxJMBG.Location = new System.Drawing.Point(94, 154);
            this.txBoxJMBG.Name = "txBoxJMBG";
            this.txBoxJMBG.Size = new System.Drawing.Size(100, 22);
            this.txBoxJMBG.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Smena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "JMBG:";
            // 
            // txBoxIme
            // 
            this.txBoxIme.Enabled = false;
            this.txBoxIme.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxIme.Location = new System.Drawing.Point(94, 70);
            this.txBoxIme.Name = "txBoxIme";
            this.txBoxIme.Size = new System.Drawing.Size(100, 22);
            this.txBoxIme.TabIndex = 39;
            // 
            // txBoxPrezime
            // 
            this.txBoxPrezime.Enabled = false;
            this.txBoxPrezime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxPrezime.Location = new System.Drawing.Point(94, 113);
            this.txBoxPrezime.Name = "txBoxPrezime";
            this.txBoxPrezime.Size = new System.Drawing.Size(100, 22);
            this.txBoxPrezime.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ime:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // InfoOperater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(217, 245);
            this.Controls.Add(this.txBoxSmena);
            this.Controls.Add(this.txBoxJMBG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBoxIme);
            this.Controls.Add(this.txBoxPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(233, 284);
            this.MinimumSize = new System.Drawing.Size(233, 284);
            this.Name = "InfoOperater";
            this.Text = "InfoOperater";
            this.Load += new System.EventHandler(this.InfoOperater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txBoxSmena;
        private System.Windows.Forms.TextBox txBoxJMBG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBoxIme;
        private System.Windows.Forms.TextBox txBoxPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}