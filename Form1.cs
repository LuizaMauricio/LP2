using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Altura, PesoAtual;
            double PesoIdeal;

            if (double.TryParse(txtAltura.Text, out Altura) &&
                double.TryParse(txtPesoAtual.Text, out PesoAtual))
            {
                if (rbtnMulher.Checked)
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                }
                else
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                }
                PesoIdeal = Math.Round(PesoIdeal, 2);

                if (PesoAtual < PesoIdeal)
                {
                    MessageBox.Show("Pode comer a vontade");
                }
                else if (PesoAtual == PesoIdeal)
                {
                    MessageBox.Show("Está no peso ideal");
                }
                else if (Convert.ToDouble(txtPesoAtual.Text) > PesoIdeal)
                {
                    MessageBox.Show("É bom dar uma controlada");
                }
            }
            else
            {
                MessageBox.Show("Peso ou altura inválidos");
            }
        }
    }
}




        
