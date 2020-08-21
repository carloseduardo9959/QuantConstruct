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
    public partial class frmContraPiso : Form
    {
        public frmContraPiso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double area = double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text) * double.Parse(txtQtd.Text);
            double concreto = 0;
            if (int.Parse(txtQtd.Text) > 0)
                concreto = double.Parse(txtEspessura.Text) * double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text) * double.Parse(txtQtd.Text);
            else
                concreto = 0;

            double cimento = ((concreto / 0.018) * (double.Parse(txtTcimento.Text) / (double.Parse(txtTcimento.Text) + double.Parse(txtTareia.Text)))) / (50 / 21.6);
            double areiaMT = (double.Parse(txtTareia.Text) / (double.Parse(txtTcimento.Text) + double.Parse(txtTareia.Text))) * concreto;
            double areiaLT = areiaMT / 0.018;
            double agua = cimento * 2;

            lblConcreto.Text = concreto.ToString("0.00");
            lblArea.Text = area.ToString("0.00");

            lblCimento.Text = cimento.ToString("0.00");

            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");


            lblAgua.Text = agua.ToString("0.00");
        }
    }
}
