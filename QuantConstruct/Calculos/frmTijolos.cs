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
    public partial class frmTijolos : Form
    {
        public frmTijolos()
        {
            InitializeComponent();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0: //B12/29
                    imgtijolo.Image = Properties.Resources.tijolo_b12291;
                    txtLarguraTijolo.Text = "11,5";
                    txtAlturaTijolo.Text= "19";
                    txtComprimentoTijolo.Text = "29";
                    break;
                case 1: //B15/29
                    imgtijolo.Image = Properties.Resources.tijolo_b15291;
                    txtLarguraTijolo.Text = "14";
                    txtAlturaTijolo.Text = "19";
                    txtComprimentoTijolo.Text = "29";
                    break;
                case 2: //B15/39
                    imgtijolo.Image = Properties.Resources.tijolo_b15391;
                    txtLarguraTijolo.Text = "14";
                    txtAlturaTijolo.Text = "19";
                    txtComprimentoTijolo.Text = "39";
                    break;
                case 3: //B10/19
                    imgtijolo.Image = Properties.Resources.tijolo_b10191;
                    txtLarguraTijolo.Text = "9";
                    txtAlturaTijolo.Text = "19";
                    txtComprimentoTijolo.Text = "19";
                    break;
                case 4: //B10/29
                    imgtijolo.Image = Properties.Resources.tijolo_b10291;
                    txtLarguraTijolo.Text = "9";
                    txtAlturaTijolo.Text = "19";
                    txtComprimentoTijolo.Text = "29";
                    break;
                case 5: //B12/14/24
                    imgtijolo.Image = Properties.Resources.tijolo_b1214241;
                    txtLarguraTijolo.Text = "11,5";
                    txtAlturaTijolo.Text = "14";
                    txtComprimentoTijolo.Text = "24";
                    break;
                case 6: //B10/20
                    imgtijolo.Image = Properties.Resources.tijolo_b10201;
                    txtLarguraTijolo.Text = "9";
                    txtAlturaTijolo.Text = "9";
                    txtComprimentoTijolo.Text = "19";
                    break;
                case 7: //C5/20
                    imgtijolo.Image = Properties.Resources.tijolo_c5201;
                    txtLarguraTijolo.Text = "10";
                    txtAlturaTijolo.Text = "5";
                    txtComprimentoTijolo.Text = "20";
                    break;

            }
        }

        private void frmTijolos_Load(object sender, EventArgs e)
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

            double area = 0;
            double parede = double.Parse(txtComprimento.Text) * double.Parse(txtAltura.Text) * double.Parse(txtQtdParedes.Text);
            if (int.Parse(txtQtdParedes.Text) > 0)
            {
                area = (parede - (areaJanela + areaPorta));
            }
            else area = 0;

            lblArea.Text = area.ToString("0.00");

         
            double qtdTijolo;
            if (int.Parse(txtJunta.Text) > 0)
            {
                qtdTijolo = (area / (((double.Parse(txtComprimentoTijolo.Text) + double.Parse(txtJunta.Text) / 10) / 100) * ((double.Parse(txtAlturaTijolo.Text) + double.Parse(txtJunta.Text) / 10) / 100))) * (1.07);
            }
            else qtdTijolo = 0;

            lblQtdTijolos.Text = qtdTijolo.ToString("0");

            double volume;
            volume = (((double.Parse(txtLarguraTijolo.Text) / 100) * ((double.Parse(txtAlturaTijolo.Text) / 100) + (double.Parse(txtComprimentoTijolo.Text) / 100))) * (double.Parse(txtJunta.Text) / 1000)) * (int)qtdTijolo;
            lblVolume.Text = volume.ToString("0.00");

            double cimento = volume / (0.1 * (50 / 21.6));
            double areiaLT = cimento * 6 * (50 / 21.6);
            double areiaMT = areiaLT * 0.018;
            double aguaLT = cimento * 1.555 * (50 / 21.6);
            double aguaLitro = aguaLT * 18;
            double aditivo = (cimento * 115.7407) / 1000;

            lblCimento.Text = cimento.ToString("0.00");
            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");
            lblAguaLitros.Text = aguaLitro.ToString("0.00");
            lblAguaLT.Text = aguaLT.ToString("0.00");
            lblAditivo.Text = aditivo.ToString("0.00");
        }
    }
}
