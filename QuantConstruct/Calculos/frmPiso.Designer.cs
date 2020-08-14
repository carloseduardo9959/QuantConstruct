namespace GUI_V_2.Calculos
{
    partial class frmPiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPiso));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtEspessura = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblConcreto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAgua = new System.Windows.Forms.Label();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.lblBritalt = new System.Windows.Forms.Label();
            this.lblAreialt = new System.Windows.Forms.Label();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.lblCimento = new System.Windows.Forms.Label();
            this.lblBritamt = new System.Windows.Forms.Label();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblAreiamt = new System.Windows.Forms.Label();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTbrita = new System.Windows.Forms.TextBox();
            this.txtTareia = new System.Windows.Forms.TextBox();
            this.txtTcimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PISOS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 521);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtEspessura);
            this.groupBox1.Controls.Add(this.txtComprimento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLargura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 165);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Levantamento de Quantidades";
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQtd.Location = new System.Drawing.Point(93, 34);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(65, 22);
            this.txtQtd.TabIndex = 1;
            // 
            // txtEspessura
            // 
            this.txtEspessura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEspessura.ForeColor = System.Drawing.Color.Black;
            this.txtEspessura.Location = new System.Drawing.Point(108, 125);
            this.txtEspessura.Name = "txtEspessura";
            this.txtEspessura.Size = new System.Drawing.Size(65, 22);
            this.txtEspessura.TabIndex = 4;
            this.txtEspessura.Text = "0,05";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(123, 92);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(65, 22);
            this.txtComprimento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(87, 62);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(65, 22);
            this.txtLargura.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Comprimento (C):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Espessura (E):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Largura (L):";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(84, 55);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(15, 16);
            this.lblArea.TabIndex = 70;
            this.lblArea.Text = "0";
            // 
            // lblConcreto
            // 
            this.lblConcreto.AutoSize = true;
            this.lblConcreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcreto.Location = new System.Drawing.Point(122, 31);
            this.lblConcreto.Name = "lblConcreto";
            this.lblConcreto.Size = new System.Drawing.Size(15, 16);
            this.lblConcreto.TabIndex = 69;
            this.lblConcreto.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "Área (m2):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 67;
            this.label15.Text = "Concreto (m3):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.lblAgua);
            this.groupBox2.Controls.Add(this.lblConcreto);
            this.groupBox2.Controls.Add(this.metroTile8);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblBritalt);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblAreialt);
            this.groupBox2.Controls.Add(this.metroTile7);
            this.groupBox2.Controls.Add(this.metroTile2);
            this.groupBox2.Controls.Add(this.metroTile4);
            this.groupBox2.Controls.Add(this.lblCimento);
            this.groupBox2.Controls.Add(this.lblBritamt);
            this.groupBox2.Controls.Add(this.metroTile3);
            this.groupBox2.Controls.Add(this.metroTile1);
            this.groupBox2.Controls.Add(this.lblAreiamt);
            this.groupBox2.Controls.Add(this.metroTile5);
            this.groupBox2.Controls.Add(this.metroTile6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(305, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 283);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Location = new System.Drawing.Point(120, 248);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(15, 16);
            this.lblAgua.TabIndex = 35;
            this.lblAgua.Text = "0";
            // 
            // metroTile8
            // 
            this.metroTile8.Location = new System.Drawing.Point(6, 239);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(108, 25);
            this.metroTile8.TabIndex = 27;
            this.metroTile8.Text = "Água (lata):";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBritalt
            // 
            this.lblBritalt.AutoSize = true;
            this.lblBritalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBritalt.Location = new System.Drawing.Point(120, 217);
            this.lblBritalt.Name = "lblBritalt";
            this.lblBritalt.Size = new System.Drawing.Size(15, 16);
            this.lblBritalt.TabIndex = 32;
            this.lblBritalt.Text = "0";
            // 
            // lblAreialt
            // 
            this.lblAreialt.AutoSize = true;
            this.lblAreialt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreialt.Location = new System.Drawing.Point(121, 155);
            this.lblAreialt.Name = "lblAreialt";
            this.lblAreialt.Size = new System.Drawing.Size(15, 16);
            this.lblAreialt.TabIndex = 29;
            this.lblAreialt.Text = "0";
            // 
            // metroTile7
            // 
            this.metroTile7.Location = new System.Drawing.Point(6, 84);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(108, 25);
            this.metroTile7.TabIndex = 26;
            this.metroTile7.Text = "Cimento (saco):";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(67, 146);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(48, 25);
            this.metroTile2.TabIndex = 34;
            this.metroTile2.Text = "lata:";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(66, 208);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(48, 25);
            this.metroTile4.TabIndex = 25;
            this.metroTile4.Text = "lata:";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCimento
            // 
            this.lblCimento.AutoSize = true;
            this.lblCimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCimento.Location = new System.Drawing.Point(120, 93);
            this.lblCimento.Name = "lblCimento";
            this.lblCimento.Size = new System.Drawing.Size(15, 16);
            this.lblCimento.TabIndex = 27;
            this.lblCimento.Text = "0";
            // 
            // lblBritamt
            // 
            this.lblBritamt.AutoSize = true;
            this.lblBritamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBritamt.Location = new System.Drawing.Point(120, 186);
            this.lblBritamt.Name = "lblBritamt";
            this.lblBritamt.Size = new System.Drawing.Size(15, 16);
            this.lblBritamt.TabIndex = 31;
            this.lblBritamt.Text = "0";
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(67, 115);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(48, 25);
            this.metroTile3.TabIndex = 33;
            this.metroTile3.Text = "m3:";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(6, 115);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(55, 56);
            this.metroTile1.TabIndex = 20;
            this.metroTile1.Text = "Areia";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreiamt
            // 
            this.lblAreiamt.AutoSize = true;
            this.lblAreiamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreiamt.Location = new System.Drawing.Point(121, 124);
            this.lblAreiamt.Name = "lblAreiamt";
            this.lblAreiamt.Size = new System.Drawing.Size(15, 16);
            this.lblAreiamt.TabIndex = 30;
            this.lblAreiamt.Text = "0";
            // 
            // metroTile5
            // 
            this.metroTile5.Location = new System.Drawing.Point(6, 177);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(55, 56);
            this.metroTile5.TabIndex = 23;
            this.metroTile5.Text = "Brita";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile6
            // 
            this.metroTile6.Location = new System.Drawing.Point(66, 177);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(48, 25);
            this.metroTile6.TabIndex = 24;
            this.metroTile6.Text = "m3:";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(305, 71);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(294, 141);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 67;
            this.btnlogoInicio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTbrita);
            this.groupBox3.Controls.Add(this.txtTareia);
            this.groupBox3.Controls.Add(this.txtTcimento);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 144);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Traço do Concreto";
            // 
            // txtTbrita
            // 
            this.txtTbrita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTbrita.Location = new System.Drawing.Point(72, 97);
            this.txtTbrita.Name = "txtTbrita";
            this.txtTbrita.Size = new System.Drawing.Size(65, 22);
            this.txtTbrita.TabIndex = 7;
            this.txtTbrita.Text = "6";
            // 
            // txtTareia
            // 
            this.txtTareia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTareia.Location = new System.Drawing.Point(72, 61);
            this.txtTareia.Name = "txtTareia";
            this.txtTareia.Size = new System.Drawing.Size(65, 22);
            this.txtTareia.TabIndex = 6;
            this.txtTareia.Text = "4";
            // 
            // txtTcimento
            // 
            this.txtTcimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTcimento.Location = new System.Drawing.Point(72, 31);
            this.txtTcimento.Name = "txtTcimento";
            this.txtTcimento.Size = new System.Drawing.Size(65, 22);
            this.txtTcimento.TabIndex = 5;
            this.txtTcimento.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Areia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Brita:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Cimento:";
            // 
            // frmPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogoInicio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPiso";
            this.Text = "frmPiso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblConcreto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAgua;
        private MetroFramework.Controls.MetroTile metroTile8;
        private System.Windows.Forms.Label lblBritalt;
        private System.Windows.Forms.Label lblAreialt;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.Label lblCimento;
        private System.Windows.Forms.Label lblBritamt;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label lblAreiamt;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTbrita;
        private System.Windows.Forms.TextBox txtTareia;
        private System.Windows.Forms.TextBox txtTcimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEspessura;
    }
}