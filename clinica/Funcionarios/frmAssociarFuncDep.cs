using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;

namespace clinica.Funcionarios
{
    public partial class frmAssociarFuncDep : Form
    {
        int codDep = 0;

        public frmAssociarFuncDep()
        {
            InitializeComponent();
            carregarDepartamentos();
        }

        #region Métodos

        private void carregarDepartamentos()
        {
            baseDados.abrirConexao();

            string query = "SELECT abreviaturaDep FROM departamentos";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        cbDepartamento.Items.Add(dataReader[0].ToString());
                    }
                }
            }

            baseDados.fecharConexao();
        }

        private void verificarCodFuncEstaAssociado()
        {
            baseDados.abrirConexao();

            string query = "select funcionarios.codFunc from funcionarios where funcionarios.codFunc = @codFunc AND codFunc in(select FuncDepartamentos.codFunc from FuncDepartamentos)";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@codFunc", txtCodFuncionario.Text);

                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        MessageBox.Show("O funcionário introduzido já está associado a um departamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        verificarCodFunc();
                    }
                }
            }
        }

        private void verificarCodFunc()
        {
            baseDados.abrirConexao();

            string query = "SELECT codFunc FROM funcionarios WHERE codFunc=@codigo";

            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@codigo", txtCodFuncionario.Text);

                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        associarFuncDep();
                    }
                    else
                    {
                        MessageBox.Show("O código introduzido não se encontra no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void obterCodDep(out int codDep)
        {
            codDep = 0;

            baseDados.abrirConexao();

            string query = "SELECT codDepartamento FROM departamentos WHERE abreviaturaDep = @abreviatura";

            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@abreviatura", cbDepartamento.Text);

                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        codDep = Convert.ToInt32(dataReader[0]);
                    }
                }
            }
        }

        private void associarFuncDep()
        {
            baseDados.abrirConexao();

            string query = "INSERT INTO FuncDepartamentos(codFunc, codDepartamento) VALUES(@codFunc, @codDep)";

            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                obterCodDep(out codDep);

                comm.Parameters.AddWithValue("@codFunc", txtCodFuncionario.Text);
                comm.Parameters.AddWithValue("@codDep", codDep);

                comm.ExecuteNonQuery();
                MessageBox.Show("O funcionário foi associado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodFuncionario.Clear();
                cbDepartamento.Text = "";
            }

            baseDados.fecharConexao();
        }

        #endregion

        #region Botões

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            verificarCodFuncEstaAssociado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar a consulta de funcionários?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Cancelamento efectuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        #endregion
    }
}
