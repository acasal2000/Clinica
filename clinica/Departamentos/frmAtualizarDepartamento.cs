using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace clinica.Departamentos
{
    public partial class frmAtualizarDepartamento : Form
    {
        private Departamentos.frmConsultarDepartamentos frm1;

        public frmAtualizarDepartamento(string nomeDep, string abrevDep, frmConsultarDepartamentos frm)
        {
            InitializeComponent();
            txtNomeDep.Text = nomeDep;
            txtAbrevDep.Text = abrevDep;

            frm1 = frm;
        }

        #region Métodos

        private void atualizarDep()
        {
            try
            {
                baseDados.abrirConexao();
                string query = "UPDATE departamentos SET nomeDepartamento=@nomeDep, abreviaturaDep=@abrevDep";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@nomeDep", txtNomeDep.Text);
                    comm.Parameters.AddWithValue("@abrevDep", txtAbrevDep.Text);

                    if (txtNomeDep.Text != "" && txtAbrevDep.Text != "")
                    {
                        if (validarNome() == true && validarAbreviatura() == true)
                        {
                            if (verificarDepartamento(txtNomeDep.Text, txtAbrevDep.Text) == true)
                            {
                                MessageBox.Show($"O departamento de {txtNomeDep.Text} foi atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                comm.ExecuteNonQuery();
                                this.Close();

                                frm1.mostrarDepartamentos();
                            }
                            else
                            {
                                MessageBox.Show("O nome do departamento ou a sua abreviatura já se encontra inserido no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Os campos não estão devidamente preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possível atualizar um departamento com campos vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao eliminar o departamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool verificarDepartamento(string nome, string abreviatura)
        {
            string query = "SELECT * FROM departamentos WHERE nomeDepartamento=@nome OR abreviaturaDep=@abreviatura";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@nome", nome);
                comm.Parameters.AddWithValue("@abreviatura", abreviatura);

                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        // existe
                        return false;
                    }
                    else
                    {
                        // não existe
                        return true;
                    }
                }
            }
        }

        private bool validarNome()
        {
            if (txtNomeDep.Text == "")
            {
                errorProvider1.SetError(txtNomeDep, "O nome não pode estar vazio!");
                return false;
            }
            else if (!Regex.Match(txtNomeDep.Text, "^[a-zA-ZÁÉÍÓÚáéíóúÀà ]*$").Success)
            {
                errorProvider1.SetError(txtNomeDep, "O nome tem de ser apenas alfabético!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarAbreviatura()
        {
            if (txtAbrevDep.Text == "")
            {
                errorProvider1.SetError(txtAbrevDep, "A abreviatura não pode estar vazia!");
                return false;
            }
            else if (!Regex.Match(txtAbrevDep.Text, "^[a-zA-Z0-9 ]*$").Success)
            {
                errorProvider1.SetError(txtAbrevDep, "A abreviatura tem de ser alfanumérica!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        #endregion

        #region Botões

        private void btnAtualizarDep_Click(object sender, EventArgs e)
        {
            atualizarDep();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar a atualização do departamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Cancelamento efectuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtNomeDep_TextChanged(object sender, EventArgs e)
        {
            validarNome();
        }

        private void txtAbrevDep_TextChanged(object sender, EventArgs e)
        {
            validarAbreviatura();
        }

        #endregion
    }
}
