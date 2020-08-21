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
    public partial class frmCeramica : Form
    {
        public frmCeramica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double area = double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text) * double.Parse(txtQtd.Text);

            double argamassa;
            if ((double.Parse(txtComprimentoC.Text) * double.Parse(txtLarguraC.Text)) <= 400)
            {
                argamassa = (area * 4) / 20;
            }
            if ((double.Parse(txtComprimentoC.Text) * double.Parse(txtLarguraC.Text)) > 900)
            {
                argamassa = (area * 7.5) / 20;
            }
            else argamassa = (area * 4.5) / 20;

            double rej;
            rej = ((((double.Parse(txtComprimentoC.Text) * 10) + (double.Parse(txtLarguraC.Text) * 10)) * double.Parse(txtAlturaC.Text) * double.Parse(txtRejuntamento.Text) * (double.Parse(txtCoeficiente.Text) * 1.8)) / ((double.Parse(txtComprimentoC.Text) * 10) * (double.Parse(txtLarguraC.Text) * 10))) * area;
            double piso = area * (1.15);

            lblArea.Text = area.ToString("0.00");
            lblArgamassa.Text = argamassa.ToString("0.00");
            lblRejunte.Text = rej.ToString("0.00");
            lblTotalPiso.Text = piso.ToString("0.00");
        }
    }
}
