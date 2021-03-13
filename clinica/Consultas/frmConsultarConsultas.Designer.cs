
namespace clinica.Consultas
{
    partial class frmConsultarConsultas
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
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.btnAtualizarConsulta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.cbEditar = new System.Windows.Forms.CheckBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
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
            this.pnlTitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consultar Agendamento de Consultas";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewConsultas.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewConsultas.MultiSelect = false;
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(817, 323);
            this.dataGridViewConsultas.TabIndex = 22;
            // 
            // btnAtualizarConsulta
            // 
            this.btnAtualizarConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarConsulta.Location = new System.Drawing.Point(640, 412);
            this.btnAtualizarConsulta.Name = "btnAtualizarConsulta";
            this.btnAtualizarConsulta.Size = new System.Drawing.Size(188, 40);
            this.btnAtualizarConsulta.TabIndex = 19;
            this.btnAtualizarConsulta.Text = "Atualizar Consulta";
            this.btnAtualizarConsulta.UseVisualStyleBackColor = true;
            this.btnAtualizarConsulta.Click += new System.EventHandler(this.btnAtualizarConsulta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(707, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConsulta.Location = new System.Drawing.Point(446, 412);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(188, 40);
            this.btnEliminarConsulta.TabIndex = 20;
            this.btnEliminarConsulta.Text = "Eliminar Consulta";
            this.btnEliminarConsulta.UseVisualStyleBackColor = true;
            this.btnEliminarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
            // 
            // cbEditar
            // 
            this.cbEditar.AutoSize = true;
            this.cbEditar.Location = new System.Drawing.Point(17, 477);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(217, 17);
            this.cbEditar.TabIndex = 18;
            this.cbEditar.Text = "Efectuar alterações na lista de consultas";
            this.cbEditar.UseVisualStyleBackColor = true;
            this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
            // 
            // frmConsultarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 506);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.btnAtualizarConsulta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarConsulta);
            this.Controls.Add(this.cbEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultarConsultas";
            this.Text = "Clinica - Consultar Consultas";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private System.Windows.Forms.Button btnAtualizarConsulta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarConsulta;
        private System.Windows.Forms.CheckBox cbEditar;
    }
}