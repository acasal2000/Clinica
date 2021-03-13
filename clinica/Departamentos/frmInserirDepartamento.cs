using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace clinica.Departamentos
{
    public partial class frmInserirDepartamento : Form
    {
        frmPrincipal frm1 = new frmPrincipal();

        public frmInserirDepartamento(frmPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        #region Métodos

        private void inserirDepartamento()
        {
            baseDados.abrirConexao();

            string query = "INSERT INTO departamentos(nomeDepartamento, abreviaturaDep) VALUES(@nomeDep, @abreviaturaDep)";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@nomeDep", txtNomeDep.Text);
                comm.Parameters.AddWithValue("@abreviaturaDep", txtAbrevDep.Text);

                if (txtNomeDep.Text != "" && txtAbrevDep.Text != "")
                {
                    if (validarNome() == true && validarAbreviatura() == true)
                    {
                        if (verificarDepartamento(txtNomeDep.Text, txtAbrevDep.Text) == true)
                        {
                            comm.ExecuteNonQuery();
                            frm1.numDepartamentos();
                            MessageBox.Show($"O departamento {txtNomeDep.Text} foi inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
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
                    MessageBox.Show("Não é possível introduzir um departamento com campos vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            baseDados.fecharConexao();
        }

        private void limparCampos()
        {
            txtNomeDep.Text = "";
            txtAbrevDep.Text = "";
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
        private void btnInserirDep_Click(object sender, EventArgs e)
        {
            inserirDepartamento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar a inserção de um novo departamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
