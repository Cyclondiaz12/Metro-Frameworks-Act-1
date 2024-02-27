using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fua
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double l;
            double p;
            double s;

            try
            {
                l = double.Parse(txtLados.Text);
                s = double.Parse(txtLargo.Text);
                p = s * l;
                MessageBox.Show(this, "Su perímetro es: " + p.ToString() + " metros", "Resultado");
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Por favor, introduzca valores válidos para los lados y el largo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
