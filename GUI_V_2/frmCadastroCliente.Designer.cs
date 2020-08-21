namespace GUI_V_2
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.rdbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRgIe = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbEndereço = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpbPessoa.SuspendLayout();
            this.gpbEndereço.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(187, 158);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(65, 26);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(180, 199);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(441, 26);
            this.txtNome.TabIndex = 7;
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.rdbPessoaJuridica);
            this.gpbPessoa.Controls.Add(this.rdbPessoaFisica);
            this.gpbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPessoa.Location = new System.Drawing.Point(730, 140);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(117, 85);
            this.gpbPessoa.TabIndex = 8;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Pessoa: ";
            // 
            // rdbPessoaJuridica
            // 
            this.rdbPessoaJuridica.AutoSize = true;
            this.rdbPessoaJuridica.Location = new System.Drawing.Point(6, 55);
            this.rdbPessoaJuridica.Name = "rdbPessoaJuridica";
            this.rdbPessoaJuridica.Size = new System.Drawing.Size(81, 24);
            this.rdbPessoaJuridica.TabIndex = 9;
            this.rdbPessoaJuridica.TabStop = true;
            this.rdbPessoaJuridica.Text = "Jurídica";
            this.rdbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdbPessoaJuridica_CheckedChanged);
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(6, 25);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(68, 24);
            this.rdbPessoaFisica.TabIndex = 8;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Física";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            this.rdbPessoaFisica.CheckedChanged += new System.EventHandler(this.rdbPessoaFisica_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "RG/IE:";
            // 
            // txtRgIe
            // 
            this.txtRgIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgIe.Location = new System.Drawing.Point(560, 243);
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(215, 26);
            this.txtRgIe.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "CPF/CNPJ:";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(214, 243);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(218, 26);
            this.txtCpfCnpj.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefone: ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(200, 288);
            this.txtTelefone.Mask = "(99) 99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(138, 26);
            this.txtTelefone.TabIndex = 12;
            // 
            // gpbEndereço
            // 
            this.gpbEndereço.Controls.Add(this.txtCEP);
            this.gpbEndereço.Controls.Add(this.label15);
            this.gpbEndereço.Controls.Add(this.txtCidade);
            this.gpbEndereço.Controls.Add(this.label14);
            this.gpbEndereço.Controls.Add(this.txtBairro);
            this.gpbEndereço.Controls.Add(this.label13);
            this.gpbEndereço.Controls.Add(this.txtNumero);
            this.gpbEndereço.Controls.Add(this.label12);
            this.gpbEndereço.Controls.Add(this.txtRua);
            this.gpbEndereço.Controls.Add(this.label11);
            this.gpbEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereço.Location = new System.Drawing.Point(130, 342);
            this.gpbEndereço.Name = "gpbEndereço";
            this.gpbEndereço.Size = new System.Drawing.Size(717, 149);
            this.gpbEndereço.TabIndex = 14;
            this.gpbEndereço.TabStop = false;
            this.gpbEndereço.Text = "Endereço";
            this.gpbEndereço.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(440, 106);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(157, 26);
            this.txtCEP.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(104, 106);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(265, 26);
            this.txtCidade.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cidade/UF:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(70, 66);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(226, 26);
            this.txtBairro.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(550, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 26);
            this.txtNumero.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Número:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(58, 26);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(391, 26);
            this.txtRua.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rua: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(365, 291);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(419, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(398, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::GUI_V_2.Properties.Resources.iconAddCliente;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNovo.Location = new System.Drawing.Point(13, 19);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(77, 61);
            this.cmdNovo.TabIndex = 1;
            this.cmdNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackgroundImage = global::GUI_V_2.Properties.Resources.Save_icon;
            this.cmdSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalvar.Location = new System.Drawing.Point(96, 19);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(77, 61);
            this.cmdSalvar.TabIndex = 2;
            this.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = global::GUI_V_2.Properties.Resources.iconExcluirCliente;
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExcluir.Location = new System.Drawing.Point(179, 19);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(77, 61);
            this.cmdExcluir.TabIndex = 3;
            this.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackgroundImage = global::GUI_V_2.Properties.Resources.iconConsultarpng;
            this.cmdConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Location = new System.Drawing.Point(345, 19);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(77, 61);
            this.cmdConsultar.TabIndex = 5;
            this.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.BackgroundImage = global::GUI_V_2.Properties.Resources.iconLimpar;
            this.cmdLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpar.Location = new System.Drawing.Point(262, 19);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(77, 61);
            this.cmdLimpar.TabIndex = 4;
            this.cmdLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdLimpar);
            this.groupBox3.Controls.Add(this.cmdConsultar);
            this.groupBox3.Controls.Add(this.cmdExcluir);
            this.groupBox3.Controls.Add(this.cmdSalvar);
            this.groupBox3.Controls.Add(this.cmdNovo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(298, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 89);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MENU";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gpbEndereço);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.txtRgIe);
            this.Controls.Add(this.gpbPessoa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbEndereço.ResumeLayout(false);
            this.gpbEndereço.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.RadioButton rdbPessoaJuridica;
        private System.Windows.Forms.RadioButton rdbPessoaFisica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtRgIe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.GroupBox gpbEndereço;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}