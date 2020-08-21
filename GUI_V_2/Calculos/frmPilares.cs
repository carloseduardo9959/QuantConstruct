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
    public partial class frmPilares : Form
    {
        public frmPilares()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cimento = 0;
            double areiaLT = 0, areiaMT = 0;
            double britaLT = 0, britaMT = 0;
            double agua = 0, aditivo = 0;

            double concreto = int.Parse(txtQtdPilares.Text) * double.Parse(txtAltura.Text) * double.Parse(txtLargura1.Text) * double.Parse(txtLargura2.Text);
            double forma = (((double.Parse(txtLargura1.Text)+double.Parse(txtLargura2.Text))*2)*double.Parse(txtAltura.Text))*double.Parse(txtQtdPilares.Text);
            lblConcreto.Text = concreto.ToString();
            lblForma.Text = forma.ToString();

            int FCK = int.Parse(txtFCK.Text);
            if (FCK == 15)
            {
                cimento = ((5.42) * concreto); // [271/50]=5.42

                areiaLT = 6.3 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 5.6 * cimento;
                britaMT = britaLT * 0.018;

                agua = 2 * cimento;
            }
            else if (FCK == 20)
            {
                cimento = ((6.1) * concreto); //[305/50]=6.1

                areiaLT = 5.5 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 5.1 * cimento;
                britaMT = britaLT * 0.018;

                agua = 1.8 * cimento;
            }
            else if (FCK == 25)
            {
                cimento = ((6.58) * concreto); //[329/50]=6.58

                areiaLT = 5.1 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 4.8 * cimento;
                britaMT = britaLT * 0.018;

                agua = 1.6 * cimento;
            }

            aditivo = cimento * 630 / 1000;

            lblCimento.Text = cimento.ToString("0.0");

            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");

            lblBritalt.Text = britaLT.ToString("0.00");
            lblBritamt.Text = britaMT.ToString("0.00");

            lblAgualt.Text = agua.ToString("0.00");

            lblAditivo.Text = aditivo.ToString("0.00");


            //FERRAGEM

            double qtdBarras = 0;
            qtdBarras = ((double.Parse(txtAltura.Text) * double.Parse(txtQtdBarras.Text)) / 12) * double.Parse(txtQtdPilares.Text);
            lblFerro8B.Text = qtdBarras.ToString("0");
            lblFerro10B.Text = qtdBarras.ToString("0");
            lblFerro12B.Text = qtdBarras.ToString("0");

            lblFerro8kg.Text = (qtdBarras * 4.74).ToString("0.00");
            lblFerro10kg.Text = (qtdBarras * 7.404).ToString("0.00");
            lblFerro12kg.Text = (qtdBarras * 11.556).ToString("0.00");

            double estribosB = 0;
            estribosB = (double.Parse(txtAltura.Text) / (double.Parse(txtEspacamento.Text) / 100) * ((((double.Parse(txtLargura1.Text) + double.Parse(txtLargura2.Text) + 0.05) * 2)) + 0.04) / 12) * double.Parse(txtQtdPilares.Text);

            lblFerro5B.Text = estribosB.ToString("0");
            lblFerro5kg.Text = (estribosB * 1.848).ToString("0.00");

            lblFerro6B.Text = estribosB.ToString("0");
            lblFerro6kg.Text = (estribosB * 2.94).ToString("0.00");
        }
    }
}
