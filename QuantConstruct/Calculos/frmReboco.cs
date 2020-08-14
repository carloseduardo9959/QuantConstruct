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
    public partial class frmReboco : Form
    {
        public frmReboco()
        {
            InitializeComponent();
        }

     
        private void frmReboco_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Não";
            comboBox2.SelectedItem = "Não";
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

            double reboco = (double.Parse(txtQtdLado.Text) * double.Parse(txtComprimento.Text) * double.Parse(txtAltura.Text));

            double argamassa = (reboco - (areaJanela + areaPorta)) * (double.Parse(txtEspessura.Text) / 1000);
            double area = reboco - (areaJanela + areaPorta);

            lblArgamassa.Text = argamassa.ToString("0.000");
            lblArea.Text = area.ToString("0.000");

            double cimento = argamassa / (0.1 *(50 / 21.6));
            double areiaLT = cimento * 6 * (50 / 21.6);
            double areiaMT = areiaLT * 0.018;
            double aguaLT = cimento * 1.555 * (50 / 21.6);
            double aguaLitro = aguaLT * 18;
            double aditivo = (cimento * 231.4814) / 1000;

            lblCimento.Text = cimento.ToString("0.00");
            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");
            lblAguaLitros.Text = aguaLitro.ToString("0.00");
            lblAguaLT.Text = aguaLT.ToString("0.00");
            lblAditivo.Text = aditivo.ToString("0.00");
        }
    }
}
