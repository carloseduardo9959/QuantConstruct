using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        Cliente Cliente = new Cliente();

        private void FormatarGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows[0].Selected = true;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Cliente.ListarClientes(0).Tables[0];
            FormatarGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            switch (cmbPesquisar.SelectedIndex)
            {
                case 0:
                    Cliente.Nome_Cliente = txtPesquisar.Text;
                    dataGridView1.DataSource = Cliente.ListarClientes(cmbPesquisar.SelectedIndex).Tables[0];
                    FormatarGrid();
                    break;
                case 1:
                    Cliente.CPF_Cliente = txtPesquisar.Text;
                    dataGridView1.DataSource = Cliente.ListarClientes(cmbPesquisar.SelectedIndex).Tables[0];
                    FormatarGrid();
                    break;
                case 2:
                    Cliente.CNPJ_Cliente = txtPesquisar.Text;
                    dataGridView1.DataSource = Cliente.ListarClientes(cmbPesquisar.SelectedIndex).Tables[0];
                    FormatarGrid();
                    break;
                case 3:
                    Cliente.CEP_Cliente = txtPesquisar.Text;
                    dataGridView1.DataSource = Cliente.ListarClientes(cmbPesquisar.SelectedIndex).Tables[0];
                    FormatarGrid();
                    break;
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            cadastroCliente.ShowDialog();

            dataGridView1.DataSource = Cliente.ListarClientes(0).Tables[0];
            FormatarGrid();
        }

        private void tscmdFechar_Click(object sender, EventArgs e)
        {
            frmPrincipal Prin = new frmPrincipal();
            Prin.AbrirFormEnPanel(new InicioResumen());
            
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente.IdCliente = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Cliente.ConsultarCliente();
            if (MessageBox.Show("Deseja editar este registro?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmCadastroCliente cadastroCliente = new frmCadastroCliente();
                cadastroCliente.AlterarRegistro(Cliente.IdCliente);
                cadastroCliente.status = "Editando";
                cadastroCliente.ShowDialog();
                Cliente.Nome_Cliente = "";
                dataGridView1.DataSource = Cliente.ListarClientes(0).Tables[0];
                FormatarGrid();
            }
        }
    }
}
