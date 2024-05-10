using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indicedemasacorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double pesoLbs, altura;
        CalculoPeso cp = new CalculoPeso();

        public void Captura()
        {
            try 
            {
                pesoLbs = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(nudAltura.Value);
            }
            catch
            {
                MessageBox.Show("Error, Tipo de dato no valido.\n"+MessageBoxIcon.Error+"\n"+MessageBoxButtons.OK);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtPeso.Focus();
            nudAltura.Value = 1.50m;
            lbl_IMC.Text = "0";
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Captura();
            cp.altura = altura;
            cp.pesoLbs = pesoLbs;
            lbl_IMC.Text = Convert.ToString(cp.IMC());
            lbl_IMC.Text = string.Format("{0:N2}",cp.IMC());

            if (cp.indiceMasa > 0)
                pictureBox1.Visible = true;
        }
    }
}
