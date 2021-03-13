
namespace clinica.Funcionarios
{
    partial class frmConsultarFuncionarios
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
            this.btnAtualizarFunc = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarFunc = new System.Windows.Forms.Button();
            this.cbEditar = new System.Windows.Forms.CheckBox();
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(841, 53);
            this.pnlTitulo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consulta de Funcionários";
            // 
            // btnAtualizarFunc
            // 
            this.btnAtualizarFunc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarFunc.Location = new System.Drawing.Point(641, 404);
            this.btnAtualizarFunc.Name = "btnAtualizarFunc";
            this.btnAtualizarFunc.Size = new System.Drawing.Size(188, 40);
            this.btnAtualizarFunc.TabIndex = 13;
            this.btnAtualizarFunc.Text = "Atualizar Funcionário";
            this.btnAtualizarFunc.UseVisualStyleBackColor = true;
            this.btnAtualizarFunc.Click += new System.EventHandler(this.btnAtualizarFunc_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(708, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminarFunc
            // 
            this.btnEliminarFunc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFunc.Location = new System.Drawing.Point(447, 404);
            this.btnEliminarFunc.Name = "btnEliminarFunc";
            this.btnEliminarFunc.Size = new System.Drawing.Size(188, 40);
            this.btnEliminarFunc.TabIndex = 14;
            this.btnEliminarFunc.Text = "Eliminar Funcionário";
            this.btnEliminarFunc.UseVisualStyleBackColor = true;
            this.btnEliminarFunc.Click += new System.EventHandler(this.btnEliminarFunc_Click);
            // 
            // cbEditar
            // 
            this.cbEditar.AutoSize = true;
            this.cbEditar.Location = new System.Drawing.Point(17, 470);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(247, 17);
            this.cbEditar.TabIndex = 12;
            this.cbEditar.Text = "Efectuar alterações na lista de funcionários";
            this.cbEditar.UseVisualStyleBackColor = true;
            this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.AllowUserToAddRows = false;
            this.dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewFuncionarios.MultiSelect = false;
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(817, 323);
            this.dataGridViewFuncionarios.TabIndex = 16;
            // 
            // frmConsultarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 504);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.Controls.Add(this.btnAtualizarFunc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarFunc);
            this.Controls.Add(this.cbEditar);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultarFuncionarios";
            this.Text = "Clinica - Consultar Funcionários";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAtualizarFunc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarFunc;
        private System.Windows.Forms.CheckBox cbEditar;
        private System.Windows.Forms.DataGridView dataGridViewFuncionarios;
    }
}