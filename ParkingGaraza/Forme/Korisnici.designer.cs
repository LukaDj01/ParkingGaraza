
namespace ParkingGaraza.Forme
{
    partial class Korisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korisnici));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnVlasnici = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnVozila);
            this.groupBox2.Controls.Add(this.btnVlasnici);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacije o:";
            // 
            // btnVozila
            // 
            this.btnVozila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnVozila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVozila.ForeColor = System.Drawing.Color.White;
            this.btnVozila.Location = new System.Drawing.Point(27, 104);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(130, 65);
            this.btnVozila.TabIndex = 1;
            this.btnVozila.Text = "Vozilima";
            this.btnVozila.UseVisualStyleBackColor = false;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnVlasnici
            // 
            this.btnVlasnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnVlasnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVlasnici.ForeColor = System.Drawing.Color.White;
            this.btnVlasnici.Location = new System.Drawing.Point(27, 33);
            this.btnVlasnici.Name = "btnVlasnici";
            this.btnVlasnici.Size = new System.Drawing.Size(130, 65);
            this.btnVlasnici.TabIndex = 0;
            this.btnVlasnici.Text = "Vlasnicima";
            this.btnVlasnici.UseVisualStyleBackColor = false;
            this.btnVlasnici.Click += new System.EventHandler(this.btnVlasnici_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(224, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(240, 349);
            this.MinimumSize = new System.Drawing.Size(240, 349);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnVlasnici;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}