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
    }
}
