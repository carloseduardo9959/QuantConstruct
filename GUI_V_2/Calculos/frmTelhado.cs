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
    public partial class frmTelhado : Form
    {
        public frmTelhado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxVazias()) 
                MessageBox.Show("Preencha todas as informações");
            else
            {
                double area = 0;

                double largura = double.Parse(txtLargura.Text);
                double comprimento = double.Parse(txtComprimento.Text);
                double altura = double.Parse(txtAltura.Text);
                int qtd = int.Parse(txtQtd.Text);

                double aux = Math.Sqrt(Math.Pow((largura + 0.15), 2) + Math.Pow(altura, 2));
                area = aux * comprimento * qtd;

                lblArea.Text = area.ToString("0.00");

                double TFrancesa = area * 16;
                double TAmericana = area * 13.5;
                double TColonial = area * 24;
                double TRomana = area * 17;

                lblTelhaFrancesa.Text = TFrancesa.ToString("0.00");
                lblTelhaAmericana.Text = TAmericana.ToString("0.00");
                lblTelhaColonial.Text = TColonial.ToString("0.00");
                lblTelhaRomana.Text = TRomana.ToString("0.00");

                double areaTGrossa = double.Parse(txtLarguraTelha.Text) * double.Parse(txtComprimentoTelha.Text);
                double qtdTGrossa;
                if (string.IsNullOrWhiteSpace(txtComprimento.Text) && string.IsNullOrWhiteSpace(txtLarguraTelha.Text))
                {
                    qtdTGrossa = 0;
                }

                else
                    qtdTGrossa = (area / areaTGrossa) * double.Parse(txtQtd.Text);


                lblTelhaGrossa.Text = qtdTGrossa.ToString("0.00");
            }

            
        }

        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }
    }
}
