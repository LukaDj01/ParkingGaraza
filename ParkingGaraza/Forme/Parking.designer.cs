
namespace ParkingGaraza.Forme
{
    partial class Parking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking));
            this.tableParking = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxSprat = new System.Windows.Forms.ComboBox();
            this.textBoxPM = new System.Windows.Forms.TextBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableParking
            // 
            this.tableParking.ColumnCount = 3;
            this.tableParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableParking.Location = new System.Drawing.Point(28, 107);
            this.tableParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableParking.Name = "tableParking";
            this.tableParking.RowCount = 3;
            this.tableParking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableParking.Size = new System.Drawing.Size(210, 210);
            this.tableParking.TabIndex = 0;
            this.tableParking.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableParking_CellPaint);
            this.tableParking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableParking_MouseUp);
            // 
            // cmbBoxSprat
            // 
            this.cmbBoxSprat.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSprat.FormattingEnabled = true;
            this.cmbBoxSprat.Items.AddRange(new object[] {
            "Prizemlje",
            "Prvi"});
            this.cmbBoxSprat.Location = new System.Drawing.Point(269, 141);
            this.cmbBoxSprat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxSprat.Name = "cmbBoxSprat";
            this.cmbBoxSprat.Size = new System.Drawing.Size(116, 20);
            this.cmbBoxSprat.TabIndex = 1;
            this.cmbBoxSprat.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSprat_SelectedIndexChanged);
            // 
            // textBoxPM
            // 
            this.textBoxPM.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPM.Location = new System.Drawing.Point(269, 203);
            this.textBoxPM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPM.Name = "textBoxPM";
            this.textBoxPM.Size = new System.Drawing.Size(116, 21);
            this.textBoxPM.TabIndex = 2;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnOdaberi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOdaberi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.ForeColor = System.Drawing.Color.White;
            this.btnOdaberi.Location = new System.Drawing.Point(269, 235);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(116, 37);
            this.btnOdaberi.TabIndex = 47;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Odaberite sprat:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.textBoxPM);
            this.Controls.Add(this.cmbBoxSprat);
            this.Controls.Add(this.tableParking);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(475, 400);
            this.MinimumSize = new System.Drawing.Size(475, 400);
            this.Name = "Parking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableParking;
        private System.Windows.Forms.ComboBox cmbBoxSprat;
        private System.Windows.Forms.TextBox textBoxPM;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}