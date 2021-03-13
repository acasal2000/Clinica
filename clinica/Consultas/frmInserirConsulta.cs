using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace clinica.Consultas
{
    public partial class frmInserirConsulta : Form
    {
        frmPrincipal frm1 = new frmPrincipal();

        int codFunc;
        int codCliente;

        public frmInserirConsulta(frmPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        #region Métodos

        private void obterCliente()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT codCliente FROM clientes WHERE cartaoCidadao = @cc";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@cc", maskedTxtNumCC.Text);

                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            codCliente = Convert.ToInt32(dataReader[0].ToString());
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {

            }
        }

        private void obterFuncionario()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT codFunc FROM funcionarios WHERE codFunc = @codFunc";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codFunc", maskedTxtNumFunc.Text);

                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            codFunc = Convert.ToInt32(dataReader[0].ToString());
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {

            }
        }

        private void agendarConsulta()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "INSERT INTO consultas(codFunc, codCliente, dataConsula, obs, custo) VALUES(@codFunc, @codCliente, @data, @obs, @custo)";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codFunc", codFunc);
                    comm.Parameters.AddWithValue("@codCliente", codCliente);
                    comm.Parameters.AddWithValue("@data", dateTimePickerData.Value);
                    comm.Parameters.AddWithValue("@obs", richTxtOBS.Text);
                    comm.Parameters.AddWithValue("@custo", maskedTxtCusto.Text);

                    if (maskedTxtNumFunc.Text != "" && maskedTxtNumCC.Text != "" && dateTimePickerData.Value != null && richTxtOBS.Text != "")
                    {
                        if (validarCodFunc() == true && validarCC() == true && validarObs() == true && validarCusto() == true)
                        {
                            if (verificarConsulta(codFunc, codCliente, dateTimePickerData.Value) == true)
                            {
                                comm.ExecuteNonQuery();
                                frm1.numConsultas();
                                MessageBox.Show($"A consulta foi agendada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Já se encontra inserida uma consulta para este utente no dia marcado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Os campos não estão devidamente preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Não é possível agendar uma consulta com campos incompletos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                baseDados.fecharConexao();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limparCampos()
        {
            maskedTxtNumCC.Text = "";
            maskedTxtNumFunc.Text = "";
            richTxtOBS.Text = "";
            dateTimePickerData.Value = DateTime.Now;
            maskedTxtCusto.Text = "";
        }

        private static bool verificarConsulta(int codFunc, int codCliente, DateTime data)
        {
            string query = "SELECT * FROM consultas WHERE codFunc=@codFunc AND codCliente=@codCliente AND dataConsula = @data";
            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@codFunc", codFunc);
                comm.Parameters.AddWithValue("@codCliente", codCliente);
                comm.Parameters.AddWithValue("@data", data);

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

        private bool validarCodFunc()
        {
            if (!Regex.Match(maskedTxtNumFunc.Text, "^[0-9]*$").Success)
            {
                errorProvider1.SetError(maskedTxtNumFunc, "O código do funcionário tem de ser apenas um valor numérico!");
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
        private bool validarCusto()
        {
            if (maskedTxtCusto.Text == "")
            {
                errorProvider1.SetError(maskedTxtCusto, "O custo da consulta não pode ser um campo vazio!");
                return false;
            }
            else if (!Regex.Match(maskedTxtCusto.Text, "^[0-9]*$").Success)
            {
                errorProvider1.SetError(maskedTxtCusto, "O custo só pode ser numérico!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool validarObs()
        {
            if (richTxtOBS.Text == "")
            {
                errorProvider1.SetError(richTxtOBS, "A observação não pode ficar vazia!");
                return false;
            }
            else if (!Regex.Match(richTxtOBS.Text, "^[a-zA-Z0-9ÁÉÍÓÚáéíóúÀà0 .,:;~+-_*^]*$").Success)
            {
                errorProvider1.SetError(richTxtOBS, "A observação tem de ser alfanumérica!");
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
        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            agendarConsulta();
        }

        private void maskedTxtNumFunc_TextChanged(object sender, EventArgs e)
        {
            obterFuncionario();
            validarCodFunc();
        }

        private void maskedTxtNumCC_TextChanged(object sender, EventArgs e)
        {
            obterCliente();
            validarCC();
        }

        private void richTxtOBS_TextChanged(object sender, EventArgs e)
        {
            validarObs();
        }

        private void maskedTxtCusto_TextChanged(object sender, EventArgs e)
        {
            validarCusto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar o agendamento da consulta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Cancelamento efectuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        #endregion
    }
}
