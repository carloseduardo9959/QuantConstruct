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
    public partial class frmLaje : Form
    {
        public frmLaje()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cimento = 0;
            double areiaLT = 0, areiaMT = 0;
            double britaLT = 0, britaMT = 0;
            double agua = 0, aditivo = 0;

            double concreto = int.Parse(txtQtd.Text) * double.Parse(txtAltura.Text) * double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text);
            double forma = double.Parse(txtQtd.Text) * (double.Parse(txtAltura.Text) * double.Parse(txtLargura.Text) * 2 + double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text) * 2);
            lblConcreto.Text = concreto.ToString();
            lblForma.Text = forma.ToString();

            int FCK = int.Parse(txtFCK.Text);
            if (FCK == 15)
            {
                cimento = ((271 / 50) * concreto);
                cimento += (cimento * 0.10);

                areiaLT = 6.3 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 5.6 * cimento;
                britaMT = britaLT * 0.018;

                agua = 2 * cimento;
            }
            else if (FCK == 20)
            {
                cimento = ((305 / 50) * concreto);
                cimento += (cimento * 0.10);

                areiaLT = 5.5 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 5.1 * cimento;
                britaMT = britaLT * 0.018;

                agua = 1.8 * cimento;
            }
            else if (FCK == 25)
            {
                cimento = ((329 / 50) * concreto);
                cimento += (cimento * 0.10);

                areiaLT = 5.1 * cimento;
                areiaMT = areiaLT * 0.018;

                britaLT = 4.8 * cimento;
                britaMT = britaLT * 0.018;

                agua = 1.6 * cimento;
            }

            aditivo = cimento * 630 / 1000;
            double area = double.Parse(txtQtd.Text) * double.Parse(txtLargura.Text) * double.Parse(txtComprimento.Text);

            lblCimento.Text = cimento.ToString("0.0");

            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");

            lblBritalt.Text = britaLT.ToString("0.00");
            lblBritamt.Text = britaMT.ToString("0.00");

            lblAgua.Text = agua.ToString("0.00");

            lblAditivo.Text = aditivo.ToString("0.00");

            lblArea.Text = area.ToString("0.00");
        }
    }
}
