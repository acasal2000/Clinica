using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica.Clientes
{
    public partial class frmAtualizarCliente : Form
    {
        private frmConsultarClientes frm1 = new frmConsultarClientes();
        frmPrincipal frmP1 = new frmPrincipal();
        int codCliente = 0;

        public frmAtualizarCliente(int codCli, string nome, int numCC, DateTime dataNasc, string morada, string localidade, int telefone, string email, frmConsultarClientes frm)
        {
            InitializeComponent();

            codCliente = codCli;
            txtNome.Text = nome;
            maskedTxtNumCC.Text = numCC.ToString();
            dateTimePickerDataNasc.Value = dataNasc;
            txtMorada.Text = morada;
            txtLocalidade.Text = localidade;
            maskedTxtNumTelefone.Text = telefone.ToString();
            txtEmail.Text = email;

            frm1 = frm;
        }

        #region Métodos

        private void atualizarCliente()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "UPDATE clientes SET nome=@nome, cartaoCidadao=@cc, dataNasc=@dataNasc, morada=@morada, localidade=@localidade, telefone=@telefone, " +
                    "email=@email WHERE codCliente = @codCliente";

                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codCliente", codCliente);
                    comm.Parameters.AddWithValue("@nome", txtNome.Text);
                    comm.Parameters.AddWithValue("@cc", maskedTxtNumCC.Text);
                    comm.Parameters.AddWithValue("@dataNasc", dateTimePickerDataNasc.Value);
                    comm.Parameters.AddWithValue("@morada", txtMorada.Text);
                    comm.Parameters.AddWithValue("@localidade", txtLocalidade.Text);
                    comm.Parameters.AddWithValue("@telefone", maskedTxtNumTelefone.Text);
                    comm.Parameters.AddWithValue("@email", txtEmail.Text);

                    if (txtNome.Text != "" && maskedTxtNumCC.Text != "" && dateTimePickerDataNasc.Value != null && txtMorada.Text != "" && txtLocalidade.Text != "" &&
                        maskedTxtNumTelefone.Text != "")
                    {
                        if (validarNome() == true && validarCC() == true && validarNumTelefone() == true && validarEmail() == true && validarMorada() == true && validarLocalidade())
                        {
                            if (verificarCliente(maskedTxtNumCC.Text) == true)
                            {
                                comm.ExecuteNonQuery();
                                MessageBox.Show($"O cliente {txtNome.Text} foi atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frm1.mostrarClientes();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("O NIF do cliente introduzido já se encontra inserido no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Os campos não estão devidamente preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possível atualizar um cliente com campos incompletos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                baseDados.fecharConexao();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocorreu um erro relacionado com a base de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar um cliente ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool verificarCliente(string cc)
        {
            string query = "SELECT * FROM clientes WHERE cartaoCidadao=@cc";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@cc", cc);

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
            if (txtNome.Text == "")
            {
                errorProvider1.SetError(txtNome, "O nome não pode estar vazio!");
                return false;
            }
            else if (!Regex.Match(txtNome.Text, "^[a-zA-ZÁÉÍÓÚáéíóúÀà ]*$").Success)
            {
                errorProvider1.SetError(txtNome, "O nome tem de ser apenas alfabético!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarEmail()
        {
            if (!Regex.Match(txtEmail.Text, "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[,]{0,1}\\s*)+$").Success)
            {
                errorProvider1.SetError(txtEmail, "O email não se encontra no formato correto!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarLocalidade()
        {
            if (txtNome.Text == "")
            {
                errorProvider1.SetError(txtLocalidade, "A localidade não pode estar vazia!");
                return false;
            }
            else if (!Regex.Match(txtLocalidade.Text, "^[a-zA-ZÁÉÍÓÚáéíóúÀà ]*$").Success)
            {
                errorProvider1.SetError(txtLocalidade, "A localidade tem de ser apenas alfabética!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarMorada()
        {
            if (txtMorada.Text == "")
            {
                errorProvider1.SetError(txtMorada, "A morada não pode estar vazia!");
                return false;
            }
            else if (!Regex.Match(txtMorada.Text, "^[a-zA-ZÁÉÍÓÚáéíóúÀà0-9.,º ]*$").Success)
            {
                errorProvider1.SetError(txtMorada, "A morada tem de ser apenas alfanumérica!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarCC()
        {
            if (!Regex.Match(maskedTxtNumCC.Text, "^[0-9]*$").Success)
            {
                errorProvider1.SetError(maskedTxtNumCC, "O número de CC tem de ser apenas um valor numérico!");
                return false;
            }
            else if (maskedTxtNumCC.TextLength != 9)
            {
                errorProvider1.SetError(maskedTxtNumCC, "O número de CC tem de conter 9 dígitos!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarNumTelefone()
        {
            if (!Regex.Match(maskedTxtNumTelefone.Text, "^[0-9]*$").Success)
            {
                errorProvider1.SetError(maskedTxtNumTelefone, "O número de telefone tem de ser apenas um valor numérico!");
                return false;
            }
            else if (maskedTxtNumTelefone.TextLength != 9)
            {
                errorProvider1.SetError(maskedTxtNumTelefone, "O número de telefone tem de conter 9 dígitos!");
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

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            atualizarCliente();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            validarNome();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validarEmail();
        }

        private void txtMorada_TextChanged(object sender, EventArgs e)
        {
            validarMorada();
        }

        private void txtLocalidade_TextChanged(object sender, EventArgs e)
        {
            validarLocalidade();
        }

        private void maskedTxtNumCC_TextChanged(object sender, EventArgs e)
        {
            validarCC();
        }

        private void maskedTxtNumTelefone_TextChanged(object sender, EventArgs e)
        {
            validarNumTelefone();
        }

        #endregion
    }
}
