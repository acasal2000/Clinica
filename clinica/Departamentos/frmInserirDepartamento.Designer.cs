
namespace clinica.Departamentos
{
    partial class frmInserirDepartamento
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeDep = new System.Windows.Forms.Label();
            this.txtNomeDep = new System.Windows.Forms.TextBox();
            this.txtAbrevDep = new System.Windows.Forms.TextBox();
            this.lblAbrevDep = new System.Windows.Forms.Label();
            this.btnInserirDep = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(323, 53);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inserir um Novo Departamento";
            // 
            // lblNomeDep
            // 
            this.lblNomeDep.AutoSize = true;
            this.lblNomeDep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDep.Location = new System.Drawing.Point(27, 92);
            this.lblNomeDep.Name = "lblNomeDep";
            this.lblNomeDep.Size = new System.Drawing.Size(173, 20);
            this.lblNomeDep.TabIndex = 2;
            this.lblNomeDep.Text = "Nome do Departamento";
            // 
            // txtNomeDep
            // 
            this.txtNomeDep.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNomeDep.Location = new System.Drawing.Point(31, 115);
            this.txtNomeDep.Name = "txtNomeDep";
            this.txtNomeDep.Size = new System.Drawing.Size(257, 27);
            this.txtNomeDep.TabIndex = 3;
            this.txtNomeDep.TextChanged += new System.EventHandler(this.txtNomeDep_TextChanged);
            // 
            // txtAbrevDep
            // 
            this.txtAbrevDep.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAbrevDep.Location = new System.Drawing.Point(31, 194);
            this.txtAbrevDep.Name = "txtAbrevDep";
            this.txtAbrevDep.Size = new System.Drawing.Size(257, 27);
            this.txtAbrevDep.TabIndex = 5;
            this.txtAbrevDep.TextChanged += new System.EventHandler(this.txtAbrevDep_TextChanged);
            // 
            // lblAbrevDep
            // 
            this.lblAbrevDep.AutoSize = true;
            this.lblAbrevDep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrevDep.Location = new System.Drawing.Point(27, 171);
            this.lblAbrevDep.Name = "lblAbrevDep";
            this.lblAbrevDep.Size = new System.Drawing.Size(209, 20);
            this.lblAbrevDep.TabIndex = 4;
            this.lblAbrevDep.Text = "Abreviatura do Departamento";
            // 
            // btnInserirDep
            // 
            this.btnInserirDep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirDep.Location = new System.Drawing.Point(124, 262);
            this.btnInserirDep.Name = "btnInserirDep";
            this.btnInserirDep.Size = new System.Drawing.Size(164, 40);
            this.btnInserirDep.TabIndex = 6;
            this.btnInserirDep.Text = "Inserir Departamento";
            this.btnInserirDep.UseVisualStyleBackColor = true;
            this.btnInserirDep.Click += new System.EventHandler(this.btnInserirDep_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(31, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInserirDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 333);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserirDep);
            this.Controls.Add(this.txtAbrevDep);
            this.Controls.Add(this.lblAbrevDep);
            this.Controls.Add(this.txtNomeDep);
            this.Controls.Add(this.lblNomeDep);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInserirDepartamento";
            this.Text = "Clinica - Inserir Departamento";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeDep;
        private System.Windows.Forms.TextBox txtNomeDep;
        private System.Windows.Forms.TextBox txtAbrevDep;
        private System.Windows.Forms.Label lblAbrevDep;
        private System.Windows.Forms.Button btnInserirDep;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}