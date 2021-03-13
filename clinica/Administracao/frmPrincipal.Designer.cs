
namespace clinica
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumDepartamentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumFuncionarios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumConsultas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumClientes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirDepartamentoToolStripMenuItem,
            this.consultarDepartamentosToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // inserirDepartamentoToolStripMenuItem
            // 
            this.inserirDepartamentoToolStripMenuItem.Name = "inserirDepartamentoToolStripMenuItem";
            this.inserirDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.inserirDepartamentoToolStripMenuItem.Text = "Inserir Departamento";
            this.inserirDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.inserirDepartamentoToolStripMenuItem_Click);
            // 
            // consultarDepartamentosToolStripMenuItem
            // 
            this.consultarDepartamentosToolStripMenuItem.Name = "consultarDepartamentosToolStripMenuItem";
            this.consultarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultarDepartamentosToolStripMenuItem.Text = "Consultar Departamentos";
            this.consultarDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.consultarDepartamentosToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirFuncionárioToolStripMenuItem,
            this.consultarFuncionáriosToolStripMenuItem,
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // inserirFuncionárioToolStripMenuItem
            // 
            this.inserirFuncionárioToolStripMenuItem.Name = "inserirFuncionárioToolStripMenuItem";
            this.inserirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.inserirFuncionárioToolStripMenuItem.Text = "Inserir Funcionário";
            this.inserirFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.inserirFuncionárioToolStripMenuItem_Click);
            // 
            // consultarFuncionáriosToolStripMenuItem
            // 
            this.consultarFuncionáriosToolStripMenuItem.Name = "consultarFuncionáriosToolStripMenuItem";
            this.consultarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultarFuncionáriosToolStripMenuItem.Text = "Consultar Funcionários";
            this.consultarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionáriosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaToolStripMenuItem,
            this.visualizarConsultasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Agendar Consulta";
            this.agendarConsultaToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultaToolStripMenuItem_Click);
            // 
            // visualizarConsultasToolStripMenuItem
            // 
            this.visualizarConsultasToolStripMenuItem.Name = "visualizarConsultasToolStripMenuItem";
            this.visualizarConsultasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.visualizarConsultasToolStripMenuItem.Text = "Visualizar Consultas";
            this.visualizarConsultasToolStripMenuItem.Click += new System.EventHandler(this.visualizarConsultasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.consultarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNumDepartamentos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 79);
            this.panel1.TabIndex = 1;
            // 
            // lblNumDepartamentos
            // 
            this.lblNumDepartamentos.AutoSize = true;
            this.lblNumDepartamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDepartamentos.Location = new System.Drawing.Point(11, 44);
            this.lblNumDepartamentos.Name = "lblNumDepartamentos";
            this.lblNumDepartamentos.Size = new System.Drawing.Size(15, 17);
            this.lblNumDepartamentos.TabIndex = 1;
            this.lblNumDepartamentos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Departamentos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblNumFuncionarios);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(224, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 79);
            this.panel2.TabIndex = 2;
            // 
            // lblNumFuncionarios
            // 
            this.lblNumFuncionarios.AutoSize = true;
            this.lblNumFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFuncionarios.Location = new System.Drawing.Point(11, 44);
            this.lblNumFuncionarios.Name = "lblNumFuncionarios";
            this.lblNumFuncionarios.Size = new System.Drawing.Size(15, 17);
            this.lblNumFuncionarios.TabIndex = 1;
            this.lblNumFuncionarios.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de Funcionários";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblNumConsultas);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(436, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 79);
            this.panel3.TabIndex = 3;
            // 
            // lblNumConsultas
            // 
            this.lblNumConsultas.AutoSize = true;
            this.lblNumConsultas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConsultas.Location = new System.Drawing.Point(11, 44);
            this.lblNumConsultas.Name = "lblNumConsultas";
            this.lblNumConsultas.Size = new System.Drawing.Size(15, 17);
            this.lblNumConsultas.TabIndex = 1;
            this.lblNumConsultas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número de Consultas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumClientes);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(648, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 79);
            this.panel4.TabIndex = 4;
            // 
            // lblNumClientes
            // 
            this.lblNumClientes.AutoSize = true;
            this.lblNumClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClientes.Location = new System.Drawing.Point(11, 44);
            this.lblNumClientes.Name = "lblNumClientes";
            this.lblNumClientes.Size = new System.Drawing.Size(15, 17);
            this.lblNumClientes.TabIndex = 1;
            this.lblNumClientes.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número de Clientes";
            // 
            // associarFuncionárioAUmDepartamentoToolStripMenuItem
            // 
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem.Name = "associarFuncionárioAUmDepartamentoToolStripMenuItem";
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem.Text = "Associar Funcionário a um Departamento";
            this.associarFuncionárioAUmDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.associarFuncionárioAUmDepartamentoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Clínica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumDepartamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumFuncionarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumConsultas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem associarFuncionárioAUmDepartamentoToolStripMenuItem;
    }
}

