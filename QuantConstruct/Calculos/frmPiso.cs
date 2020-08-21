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
    public partial class frmPiso : Form
    {
        public frmPiso()
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

            lblConcreto.Text = concreto.ToString("0.00");
            lblArea.Text = area.ToString("0.00");

            double cimento = ((double.Parse(txtTcimento.Text) / (double.Parse(txtTcimento.Text) + double.Parse(txtTareia.Text) + double.Parse(txtTbrita.Text))) * (concreto / 0.018)) / (50 / 21.6);
            double areiaLT = (double.Parse(txtTareia.Text) / (double.Parse(txtTcimento.Text) + double.Parse(txtTareia.Text) + double.Parse(txtTbrita.Text))) * (concreto / 0.018);
            double areiaMT = areiaLT * 0.018;
            double britaLT = (double.Parse(txtTbrita.Text) / (double.Parse(txtTcimento.Text) + double.Parse(txtTareia.Text) + double.Parse(txtTbrita.Text))) * (concreto / 0.018);
            double britaMT = britaLT * 0.018;
            double agua = cimento * 1.8;

            lblCimento.Text = cimento.ToString("0.00");

            lblAreialt.Text = areiaLT.ToString("0.00");
            lblAreiamt.Text = areiaMT.ToString("0.00");

            lblBritalt.Text = britaLT.ToString("0.00");
            lblBritamt.Text = britaMT.ToString("0.00");

            lblAgua.Text = agua.ToString("0.00");
        }
    }
}
