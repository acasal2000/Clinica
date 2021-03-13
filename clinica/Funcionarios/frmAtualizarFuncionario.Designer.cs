
namespace clinica.Funcionarios
{
    partial class frmAtualizarFuncionario
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
            this.btnInserirFunc = new System.Windows.Forms.Button();
            this.dateTimePickerDuracaoContrato = new System.Windows.Forms.DateTimePicker();
            this.cbTipoContrato = new System.Windows.Forms.ComboBox();
            this.maskedTxtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.groupBoxInfoContrato = new System.Windows.Forms.GroupBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.groupBoxInfoMorada = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.maskedTxtNumTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblNumTelefone = new System.Windows.Forms.Label();
            this.groupBoxInfoContacto = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDataNasc = new System.Windows.Forms.DateTimePicker();
            this.maskedTxtNumCC = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblNumCC = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBoxInfoPessoais = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInfoContrato.SuspendLayout();
            this.groupBoxInfoMorada.SuspendLayout();
            this.groupBoxInfoContacto.SuspendLayout();
            this.groupBoxInfoPessoais.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserirFunc
            // 
            this.btnInserirFunc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirFunc.Location = new System.Drawing.Point(878, 403);
            this.btnInserirFunc.Name = "btnInserirFunc";
            this.btnInserirFunc.Size = new System.Drawing.Size(164, 40);
            this.btnInserirFunc.TabIndex = 21;
            this.btnInserirFunc.Text = "Atualizar Funcionário";
            this.btnInserirFunc.UseVisualStyleBackColor = true;
            this.btnInserirFunc.Click += new System.EventHandler(this.btnInserirFunc_Click);
            // 
            // dateTimePickerDuracaoContrato
            // 
            this.dateTimePickerDuracaoContrato.Location = new System.Drawing.Point(160, 109);
            this.dateTimePickerDuracaoContrato.Name = "dateTimePickerDuracaoContrato";
            this.dateTimePickerDuracaoContrato.Size = new System.Drawing.Size(235, 27);
            this.dateTimePickerDuracaoContrato.TabIndex = 13;
            // 
            // cbTipoContrato
            // 
            this.cbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoContrato.FormattingEnabled = true;
            this.cbTipoContrato.Location = new System.Drawing.Point(160, 76);
            this.cbTipoContrato.Name = "cbTipoContrato";
            this.cbTipoContrato.Size = new System.Drawing.Size(163, 28);
            this.cbTipoContrato.TabIndex = 12;
            // 
            // maskedTxtVencimento
            // 
            this.maskedTxtVencimento.Location = new System.Drawing.Point(160, 41);
            this.maskedTxtVencimento.Name = "maskedTxtVencimento";
            this.maskedTxtVencimento.Size = new System.Drawing.Size(163, 27);
            this.maskedTxtVencimento.TabIndex = 11;
            this.maskedTxtVencimento.TextChanged += new System.EventHandler(this.maskedTxtVencimento_TextChanged);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(6, 114);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(151, 20);
            this.lblDuracao.TabIndex = 9;
            this.lblDuracao.Text = "Duração Do Contrato";
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(6, 79);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(122, 20);
            this.lblTipoContrato.TabIndex = 7;
            this.lblTipoContrato.Text = "Tipo de Contrato";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(6, 44);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(122, 20);
            this.lblVencimento.TabIndex = 6;
            this.lblVencimento.Text = "Vencimento Base";
            // 
            // groupBoxInfoContrato
            // 
            this.groupBoxInfoContrato.Controls.Add(this.dateTimePickerDuracaoContrato);
            this.groupBoxInfoContrato.Controls.Add(this.cbTipoContrato);
            this.groupBoxInfoContrato.Controls.Add(this.maskedTxtVencimento);
            this.groupBoxInfoContrato.Controls.Add(this.lblDuracao);
            this.groupBoxInfoContrato.Controls.Add(this.lblTipoContrato);
            this.groupBoxInfoContrato.Controls.Add(this.lblVencimento);
            this.groupBoxInfoContrato.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxInfoContrato.Location = new System.Drawing.Point(538, 220);
            this.groupBoxInfoContrato.Name = "groupBoxInfoContrato";
            this.groupBoxInfoContrato.Size = new System.Drawing.Size(504, 155);
            this.groupBoxInfoContrato.TabIndex = 20;
            this.groupBoxInfoContrato.TabStop = false;
            this.groupBoxInfoContrato.Text = "Informações de Contrato";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(160, 75);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(163, 27);
            this.txtLocalidade.TabIndex = 9;
            this.txtLocalidade.TextChanged += new System.EventHandler(this.txtLocalidade_TextChanged);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(160, 41);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(321, 27);
            this.txtMorada.TabIndex = 8;
            this.txtMorada.TextChanged += new System.EventHandler(this.txtMorada_TextChanged);
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(6, 78);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(82, 20);
            this.lblLocalidade.TabIndex = 7;
            this.lblLocalidade.Text = "Localidade";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(6, 44);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(148, 20);
            this.lblMorada.TabIndex = 6;
            this.lblMorada.Text = "Endereço de Morada";
            // 
            // groupBoxInfoMorada
            // 
            this.groupBoxInfoMorada.Controls.Add(this.txtLocalidade);
            this.groupBoxInfoMorada.Controls.Add(this.txtMorada);
            this.groupBoxInfoMorada.Controls.Add(this.lblLocalidade);
            this.groupBoxInfoMorada.Controls.Add(this.lblMorada);
            this.groupBoxInfoMorada.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxInfoMorada.Location = new System.Drawing.Point(538, 89);
            this.groupBoxInfoMorada.Name = "groupBoxInfoMorada";
            this.groupBoxInfoMorada.Size = new System.Drawing.Size(504, 121);
            this.groupBoxInfoMorada.TabIndex = 18;
            this.groupBoxInfoMorada.TabStop = false;
            this.groupBoxInfoMorada.Text = "Informações de Morada";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 27);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // maskedTxtNumTelefone
            // 
            this.maskedTxtNumTelefone.Location = new System.Drawing.Point(171, 41);
            this.maskedTxtNumTelefone.Name = "maskedTxtNumTelefone";
            this.maskedTxtNumTelefone.Size = new System.Drawing.Size(130, 27);
            this.maskedTxtNumTelefone.TabIndex = 5;
            this.maskedTxtNumTelefone.TextChanged += new System.EventHandler(this.maskedTxtNumTelefone_TextChanged);
            // 
            // lblNumTelefone
            // 
            this.lblNumTelefone.AutoSize = true;
            this.lblNumTelefone.Location = new System.Drawing.Point(6, 44);
            this.lblNumTelefone.Name = "lblNumTelefone";
            this.lblNumTelefone.Size = new System.Drawing.Size(108, 20);
            this.lblNumTelefone.TabIndex = 6;
            this.lblNumTelefone.Text = "Nº de Telefone";
            // 
            // groupBoxInfoContacto
            // 
            this.groupBoxInfoContacto.Controls.Add(this.txtEmail);
            this.groupBoxInfoContacto.Controls.Add(this.lblEmail);
            this.groupBoxInfoContacto.Controls.Add(this.maskedTxtNumTelefone);
            this.groupBoxInfoContacto.Controls.Add(this.lblNumTelefone);
            this.groupBoxInfoContacto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxInfoContacto.Location = new System.Drawing.Point(12, 254);
            this.groupBoxInfoContacto.Name = "groupBoxInfoContacto";
            this.groupBoxInfoContacto.Size = new System.Drawing.Size(505, 121);
            this.groupBoxInfoContacto.TabIndex = 17;
            this.groupBoxInfoContacto.TabStop = false;
            this.groupBoxInfoContacto.Text = "Informações de Contacto";
            // 
            // dateTimePickerDataNasc
            // 
            this.dateTimePickerDataNasc.Location = new System.Drawing.Point(171, 104);
            this.dateTimePickerDataNasc.Name = "dateTimePickerDataNasc";
            this.dateTimePickerDataNasc.Size = new System.Drawing.Size(235, 27);
            this.dateTimePickerDataNasc.TabIndex = 3;
            // 
            // maskedTxtNumCC
            // 
            this.maskedTxtNumCC.Location = new System.Drawing.Point(171, 71);
            this.maskedTxtNumCC.Name = "maskedTxtNumCC";
            this.maskedTxtNumCC.Size = new System.Drawing.Size(130, 27);
            this.maskedTxtNumCC.TabIndex = 2;
            this.maskedTxtNumCC.TextChanged += new System.EventHandler(this.maskedTxtNumCC_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 27);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(6, 109);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(145, 20);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblNumCC
            // 
            this.lblNumCC.AutoSize = true;
            this.lblNumCC.Location = new System.Drawing.Point(6, 74);
            this.lblNumCC.Name = "lblNumCC";
            this.lblNumCC.Size = new System.Drawing.Size(155, 20);
            this.lblNumCC.TabIndex = 1;
            this.lblNumCC.Text = "Nº Cartão de Cidadão";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // groupBoxInfoPessoais
            // 
            this.groupBoxInfoPessoais.Controls.Add(this.dateTimePickerDataNasc);
            this.groupBoxInfoPessoais.Controls.Add(this.maskedTxtNumCC);
            this.groupBoxInfoPessoais.Controls.Add(this.txtNome);
            this.groupBoxInfoPessoais.Controls.Add(this.lblDataNasc);
            this.groupBoxInfoPessoais.Controls.Add(this.lblNumCC);
            this.groupBoxInfoPessoais.Controls.Add(this.lblNome);
            this.groupBoxInfoPessoais.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxInfoPessoais.Location = new System.Drawing.Point(12, 89);
            this.groupBoxInfoPessoais.Name = "groupBoxInfoPessoais";
            this.groupBoxInfoPessoais.Size = new System.Drawing.Size(505, 144);
            this.groupBoxInfoPessoais.TabIndex = 16;
            this.groupBoxInfoPessoais.TabStop = false;
            this.groupBoxInfoPessoais.Text = "Informações Pessoais";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Atualizar Funcionários";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(776, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1054, 53);
            this.pnlTitulo.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAtualizarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 460);
            this.Controls.Add(this.btnInserirFunc);
            this.Controls.Add(this.groupBoxInfoContrato);
            this.Controls.Add(this.groupBoxInfoMorada);
            this.Controls.Add(this.groupBoxInfoContacto);
            this.Controls.Add(this.groupBoxInfoPessoais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAtualizarFuncionario";
            this.Text = "Clinica - Atualizar Funcionário";
            this.groupBoxInfoContrato.ResumeLayout(false);
            this.groupBoxInfoContrato.PerformLayout();
            this.groupBoxInfoMorada.ResumeLayout(false);
            this.groupBoxInfoMorada.PerformLayout();
            this.groupBoxInfoContacto.ResumeLayout(false);
            this.groupBoxInfoContacto.PerformLayout();
            this.groupBoxInfoPessoais.ResumeLayout(false);
            this.groupBoxInfoPessoais.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserirFunc;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuracaoContrato;
        private System.Windows.Forms.ComboBox cbTipoContrato;
        private System.Windows.Forms.MaskedTextBox maskedTxtVencimento;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.GroupBox groupBoxInfoContrato;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.GroupBox groupBoxInfoMorada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox maskedTxtNumTelefone;
        private System.Windows.Forms.Label lblNumTelefone;
        private System.Windows.Forms.GroupBox groupBoxInfoContacto;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasc;
        private System.Windows.Forms.MaskedTextBox maskedTxtNumCC;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblNumCC;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBoxInfoPessoais;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}