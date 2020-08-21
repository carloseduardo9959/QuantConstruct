using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Calculos
{
    public partial class frmPintura : Form
    {
        public frmPintura()
        {
            InitializeComponent();
        }

        private void frmPintura_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Não";
            comboBox2.SelectedItem = "Não";
            textBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Não")
            {
                txtQtdJanelas.Enabled = false;
                txtBaseJanela.Enabled = false;
                txtAlturaJanela.Enabled = false;
            }
            else
            {
                txtQtdJanelas.Enabled = true;
                txtBaseJanela.Enabled = true;
                txtAlturaJanela.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Não")
            {
                txtQtdPorta.Enabled = false;
                txtBasePorta.Enabled = false;
                txtAlturaPorta.Enabled = false;
            }
            else
            {
                txtQtdPorta.Enabled = true;
                txtBasePorta.Enabled = true;
                txtAlturaPorta.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double areaJanela = 0, areaPorta = 0;
            //Janela
            if (comboBox1.SelectedItem.ToString() == "Não")
                areaJanela = 0;
            else
            {
                areaJanela = (double.Parse(txtQtdJanelas.Text) * double.Parse(txtBaseJanela.Text) * double.Parse(txtAlturaJanela.Text));
            }

            //Porta
            if (comboBox2.SelectedItem.ToString() == "Não")
                areaPorta = 0;
            else
            {
                areaPorta = (double.Parse(txtQtdPorta.Text) * double.Parse(txtBasePorta.Text) * double.Parse(txtAlturaPorta.Text));
            }

            double areaTeto = double.Parse(txtComprimentoTeto.Text) * double.Parse(txtLarguraTeto.Text);
            double areaParede = (double.Parse(txtComprimentoParede.Text) * double.Parse(txtAlturaParede.Text) * double.Parse(txtQtdLado.Text)) - (areaJanela + areaPorta);
            double massaLitro = (areaParede + areaTeto) / 1.555; //[28/18 = 1.555]
            double massaLT = massaLitro / 18;
            double tintaLitros = areaTeto / (180 / 18);
            double tintaLT = tintaLitros / 18;
            double acrLitros = areaParede / 4.444; //[80/18 = 4.444]
            double acrLT = acrLitros / 18;

            lblAreaParede.Text = areaParede.ToString("0.00");
            lblAreaTeto.Text = areaTeto.ToString("0.00");
            lblAcrLitros.Text = acrLitros.ToString("0.00");
            lblAcrLT.Text = acrLT.ToString("0.00");
            lblMassaLitros.Text = massaLitro.ToString("0.00");
            lblMassaLT.Text = massaLT.ToString("0.00");
            lblTintaLitros.Text = tintaLitros.ToString("0.00");
            lblTintaLT.Text = tintaLT.ToString("0.00");
        }
    }
}
