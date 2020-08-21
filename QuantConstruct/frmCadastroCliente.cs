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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        public string status = "Navegando";

        private void HabilitarControles()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Inserindo" || status == "Editando");
            cmdExcluir.Enabled = (status == "Editando");
            cmdLimpar.Enabled = (status == "Inserindo" || status == "Editando");
            cmdConsultar.Enabled = (status == "Navegando");

            if(status == "Navegando")
            {
                foreach(Control controles in this.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = false; ;
                    }
                }
                txtCpfCnpj.Enabled = false;
                txtRgIe.Enabled = false;
                txtTelefone.Enabled = false;
                gpbEndereço.Enabled = false;
                gpbPessoa.Enabled = false;
            }
            else
            {
                foreach (Control controles in this.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = true;
                    }
                }
                txtCpfCnpj.Enabled = true;
                txtRgIe.Enabled = true;
                txtTelefone.Enabled = true;
                gpbEndereço.Enabled = true;
                gpbPessoa.Enabled = true;
            }
        }

        private void LimpaControle()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtCpfCnpj.Clear();
            txtRgIe.Clear();
            txtTelefone.Clear();
            foreach(Control control in gpbEndereço.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            rdbPessoaFisica.Checked = false;
            rdbPessoaJuridica.Checked = false;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            HabilitarControles();

            toolTip1.SetToolTip(cmdNovo, "Cadastrar novo cliente");
            toolTip1.SetToolTip(cmdSalvar, "Salvar cliente");
            toolTip1.SetToolTip(cmdExcluir, "Excluir cliente");
            toolTip1.SetToolTip(cmdLimpar, "Limpar controles");
            toolTip1.SetToolTip(cmdConsultar, "Consultar clientes");

        }

        private void rdbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtCpfCnpj.Clear();
            txtCpfCnpj.Mask = "999.999.999-99";
            txtRgIe.Clear();
            txtRgIe.Mask = "??-99.999.999";
        }

        private void rdbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            txtCpfCnpj.Clear();
            txtCpfCnpj.Mask = "99.999.999/9999-99";
            txtRgIe.Clear();
            txtRgIe.Mask = "999.999.999.999";
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitarControles();
            txtCodigo.Text = (cliente.ConsultarID() + 1).ToString();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                cliente.Nome_Cliente = txtNome.Text;
                if (rdbPessoaFisica.Checked == true)
                {
                    cliente.CPF_Cliente = txtCpfCnpj.Text;
                    cliente.RG_Cliente = txtRgIe.Text;
                    cliente.CNPJ_Cliente = "";
                    cliente.InscEst_Cliente = "";
                }
                else if (rdbPessoaJuridica.Checked == true)
                {
                    cliente.CNPJ_Cliente = txtCpfCnpj.Text;
                    cliente.InscEst_Cliente = txtRgIe.Text;
                    cliente.CPF_Cliente = "";
                    cliente.RG_Cliente = "";
                }
                cliente.Tel_Cliente = txtTelefone.Text;
                cliente.Rua_Cliente = txtRua.Text;
                cliente.Num_Cliente = txtNumero.Text;
                cliente.Bairro_Cliente = txtBairro.Text;
                cliente.Cidade_Cliente = txtCidade.Text;
                cliente.CEP_Cliente = txtCEP.Text;
                cliente.Email_Cliente = txtEmail.Text;
                if (status == "Inserindo")
                {
                    cliente.IdCliente = int.Parse(txtCodigo.Text);
                    cliente.IncluirCliente();
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }                    
                else if (status == "Editando")
                {
                    cliente.AlterarCliente();
                    MessageBox.Show("Cliente editado com sucesso!");
                }
                
                status = "Navegando";
                HabilitarControles();
                LimpaControle();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            cliente.IdCliente = int.Parse(txtCodigo.Text);
            if(MessageBox.Show("Deseja apagar esse registro?","Alerta!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cliente.ExcluirCliente();
                MessageBox.Show("Registro apagado com sucesso!");
                LimpaControle();
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            LimpaControle();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {

        }

        public virtual void AlterarRegistro(int ID)
        {
            cliente.IdCliente = ID;
            cliente.ConsultarCliente();
            txtCodigo.Text = cliente.IdCliente.ToString();
            txtNome.Text = cliente.Nome_Cliente;
            if((cliente.CPF_Cliente != "") || (cliente.RG_Cliente != ""))
            {
                rdbPessoaFisica.Checked = true;
                rdbPessoaJuridica.Checked = false;
                txtCpfCnpj.Text = cliente.CPF_Cliente;
                txtRgIe.Text = cliente.RG_Cliente;
            }
            else if ((cliente.CNPJ_Cliente != "") || (cliente.InscEst_Cliente != ""))
            {
                rdbPessoaFisica.Checked = false;
                rdbPessoaJuridica.Checked = true;
                txtCpfCnpj.Text = cliente.CPF_Cliente;
                txtRgIe.Text = cliente.RG_Cliente;
            }
            txtTelefone.Text = cliente.Tel_Cliente;
            txtEmail.Text = cliente.Email_Cliente;
            txtRua.Text = cliente.Rua_Cliente;
            txtNumero.Text = cliente.Num_Cliente;
            txtBairro.Text = cliente.Bairro_Cliente;
            txtCidade.Text = cliente.Cidade_Cliente;
            txtCEP.Text = cliente.CEP_Cliente;
        }
    }
}
