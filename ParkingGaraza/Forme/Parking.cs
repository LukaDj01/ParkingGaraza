using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingGaraza.Forme
{
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
            cmbBoxSprat.SelectedItem = cmbBoxSprat.Items[0];
            cmbBoxSprat.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void tableParking_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            string hexColor1 = "#CCF5AC", hexColor2= "#BB342F"; 

            Color customColor1 = ColorTranslator.FromHtml(hexColor1);
            Color customColor2 = ColorTranslator.FromHtml(hexColor2);
            SolidBrush customBrushGreen = new SolidBrush(customColor1);
            SolidBrush customBrushRed = new SolidBrush(customColor2);

            int a;
            List<ParkingMestoPregled> Parking = DTOManager.GetPMInfos();
            if (cmbBoxSprat.Text == "Prizemlje")
            {
                a = (e.Row * 3 + e.Column);
                if (Parking[a].Zauzeto == "Da")
                {
                    e.Graphics.FillRectangle(customBrushRed, e.CellBounds);

                }
                else
                    e.Graphics.FillRectangle(customBrushGreen, e.CellBounds);
                string aValue = (a + 1).ToString();
                using (var font = new Font("Arial", 16, FontStyle.Bold))
                {
                    e.Graphics.DrawString(aValue, font, Brushes.White, e.CellBounds.Location);
                }
            }
            else
            {
                a = (e.Row * 3 + e.Column) + 9;
                if (Parking[a].Zauzeto == "Da")
                    e.Graphics.FillRectangle(customBrushRed, e.CellBounds);
                else
                    e.Graphics.FillRectangle(customBrushGreen, e.CellBounds);
                string aValue = (a + 1).ToString();
                using (var font = new Font("Arial", 16, FontStyle.Bold))
                {
                    e.Graphics.DrawString(aValue, font, Brushes.White, e.CellBounds.Location);
                }
            }

        }

        private void cmbBoxSprat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tableParking_MouseUp(object sender, MouseEventArgs e)
        {
            int a = (e.Y / 70 * 3 + e.X / 70) + 1;
            if (cmbBoxSprat.Text != "Prizemlje")
            {
                a += 9;
            }
            List<ParkingMestoPregled> Parking = DTOManager.GetPMInfos();
            if (Parking[a-1].Zauzeto == "Da")
            {
                MessageBox.Show("Dato mesto je zauzeto");

            }
            else textBoxPM.Text = a.ToString();
        }

        public string TheValue
        {
            get { return textBoxPM.Text; }
        }
    }
}
