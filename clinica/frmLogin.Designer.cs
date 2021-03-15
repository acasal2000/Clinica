
namespace clinica
{
    partial class frmLogin
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
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.lblUtilizador = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUtilizador.Location = new System.Drawing.Point(12, 106);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(168, 27);
            this.txtUtilizador.TabIndex = 27;
            // 
            // btnAcesso
            // 
            this.btnAcesso.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAcesso.Location = new System.Drawing.Point(304, 163);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(120, 34);
            this.btnAcesso.TabIndex = 29;
            this.btnAcesso.Text = "Acesso";
            this.btnAcesso.UseVisualStyleBackColor = true;
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblUtilizador.Location = new System.Drawing.Point(8, 83);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(74, 20);
            this.lblUtilizador.TabIndex = 25;
            this.lblUtilizador.Text = "Utilizador";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(256, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 27);
            this.txtPassword.TabIndex = 28;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblPassword.Location = new System.Drawing.Point(252, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(436, 53);
            this.pnlTitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 213);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtUtilizador);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.lblUtilizador);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Clinica - Login";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}