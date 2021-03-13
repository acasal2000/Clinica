
namespace clinica.Departamentos
{
    partial class frmConsultarDepartamentos
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
            this.cbEditar = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarDep = new System.Windows.Forms.Button();
            this.btnAtualizarDep = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(535, 53);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consulta de Departamentos";
            // 
            // dataGridViewDepartamentos
            // 
            this.dataGridViewDepartamentos.AllowUserToAddRows = false;
            this.dataGridViewDepartamentos.AllowUserToDeleteRows = false;
            this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDepartamentos.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewDepartamentos.MultiSelect = false;
            this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            this.dataGridViewDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartamentos.Size = new System.Drawing.Size(511, 258);
            this.dataGridViewDepartamentos.TabIndex = 2;
            // 
            // cbEditar
            // 
            this.cbEditar.AutoSize = true;
            this.cbEditar.Location = new System.Drawing.Point(17, 457);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(212, 17);
            this.cbEditar.TabIndex = 1;
            this.cbEditar.Text = "Realizar Edições nos Departamentos";
            this.cbEditar.UseVisualStyleBackColor = true;
            this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(402, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminarDep
            // 
            this.btnEliminarDep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDep.Location = new System.Drawing.Point(335, 397);
            this.btnEliminarDep.Name = "btnEliminarDep";
            this.btnEliminarDep.Size = new System.Drawing.Size(188, 40);
            this.btnEliminarDep.TabIndex = 3;
            this.btnEliminarDep.Text = "Eliminar Departamento";
            this.btnEliminarDep.UseVisualStyleBackColor = true;
            this.btnEliminarDep.Click += new System.EventHandler(this.btnEliminarDep_Click);
            // 
            // btnAtualizarDep
            // 
            this.btnAtualizarDep.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDep.Location = new System.Drawing.Point(335, 351);
            this.btnAtualizarDep.Name = "btnAtualizarDep";
            this.btnAtualizarDep.Size = new System.Drawing.Size(188, 40);
            this.btnAtualizarDep.TabIndex = 2;
            this.btnAtualizarDep.Text = "Atualizar Departamento";
            this.btnAtualizarDep.UseVisualStyleBackColor = true;
            this.btnAtualizarDep.Click += new System.EventHandler(this.btnAtualizarDep_Click);
            // 
            // frmConsultarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 492);
            this.Controls.Add(this.btnAtualizarDep);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarDep);
            this.Controls.Add(this.cbEditar);
            this.Controls.Add(this.dataGridViewDepartamentos);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultarDepartamentos";
            this.Text = "Clínica - Consultar Departamentos";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
        private System.Windows.Forms.CheckBox cbEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarDep;
        private System.Windows.Forms.Button btnAtualizarDep;
    }
}