using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class btnChapisco : Form
    {
        public btnChapisco()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVigas_Click(object sender, EventArgs e)
        {
            frmVigas frm = new frmVigas();
            AddOwnedForm(frm);

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();

            frm.Show();
        }

        private void btnPilares_Click(object sender, EventArgs e)
        {
            Calculos.frmPilares frP = new Calculos.frmPilares();
            AddOwnedForm(frP);

            frP.FormBorderStyle = FormBorderStyle.None;
            frP.TopLevel = false;
            frP.Dock = DockStyle.Fill;
            this.Controls.Add(frP);
            this.Tag = frP;
            frP.BringToFront();

            frP.Show();
        }

        private void btnLaje_Click(object sender, EventArgs e)
        {
            Calculos.frmLaje frL = new Calculos.frmLaje();
            AddOwnedForm(frL);

            frL.FormBorderStyle = FormBorderStyle.None;
            frL.TopLevel = false;
            frL.Dock = DockStyle.Fill;
            this.Controls.Add(frL);
            this.Tag = frL;
            frL.BringToFront();

            frL.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calculos.frmChapisco frch = new Calculos.frmChapisco();
            AddOwnedForm(frch);

            frch.FormBorderStyle = FormBorderStyle.None;
            frch.TopLevel = false;
            frch.Dock = DockStyle.Fill;
            this.Controls.Add(frch);
            this.Tag = frch;
            frch.BringToFront();

            frch.Show();
        }

        private void btnReboco_Click(object sender, EventArgs e)
        {
            Calculos.frmReboco frr = new Calculos.frmReboco();
            AddOwnedForm(frr);

            frr.FormBorderStyle = FormBorderStyle.None;
            frr.TopLevel = false;
            frr.Dock = DockStyle.Fill;
            this.Controls.Add(frr);
            this.Tag = frr;
            frr.BringToFront();

            frr.Show();
        }

        private void btnTijolo_Click(object sender, EventArgs e)
        {
            Calculos.frmTijolos frmj = new Calculos.frmTijolos();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            Calculos.frmPiso frmj = new Calculos.frmPiso();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }

        private void btnContraPiso_Click(object sender, EventArgs e)
        {
            Calculos.frmContraPiso frmj = new Calculos.frmContraPiso();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }

        private void btnCeramica_Click(object sender, EventArgs e)
        {
            Calculos.frmCeramica frmj = new Calculos.frmCeramica();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }

        private void btnPintura_Click(object sender, EventArgs e)
        {
            Calculos.frmPintura frmj = new Calculos.frmPintura();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }

        private void btnTelhado_Click(object sender, EventArgs e)
        {
            Calculos.frmTelhado frmj = new Calculos.frmTelhado();
            AddOwnedForm(frmj);

            frmj.FormBorderStyle = FormBorderStyle.None;
            frmj.TopLevel = false;
            frmj.Dock = DockStyle.Fill;
            this.Controls.Add(frmj);
            this.Tag = frmj;
            frmj.BringToFront();

            frmj.Show();
        }
    }
}
