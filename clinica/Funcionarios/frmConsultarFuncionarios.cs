using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace clinica.Funcionarios
{
    public partial class frmConsultarFuncionarios : Form
    {
        public frmConsultarFuncionarios()
        {
            InitializeComponent();
            
            btnAtualizarFunc.Enabled = false;
            btnEliminarFunc.Enabled = false;

            mostrarFuncionarios();
        }

        #region Métodos

        public void mostrarFuncionarios()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT * FROM funcionarios";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
                    dataAdapter.Fill(dataSet);
                    dataGridViewFuncionarios.DataSource = dataSet.Tables[0];
                    dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar os funcionários existentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void eliminarFuncionario()
        {
            try
            {
                DialogResult msg;
                baseDados.abrirConexao();

                for (int i = 0; i < dataGridViewFuncionarios.SelectedRows.Count; i++)
                {
                    string query = "DELETE FROM funcionarios WHERE codFunc = @selecionado";
                    using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                    {
                        comm.Parameters.AddWithValue("@selecionado", dataGridViewFuncionarios.SelectedRows[i].Cells[0].Value.ToString());
                        msg = MessageBox.Show("Desejas eliminar o funcionário selecionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if (msg == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show($"O funcionário {dataGridViewFuncionarios.SelectedRows[i].Cells[1].Value.ToString()} foi eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarFuncionarios();
                        }
                        else { return; }
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
                MessageBox.Show("Ocorreu um erro ao eliminar um funcionário ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarFuncionario()
        {
            for (int i = 0; i < dataGridViewFuncionarios.SelectedRows.Count; i++)
            {
                int codFunc = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[i].Cells[0].Value.ToString());
                string nome = dataGridViewFuncionarios.SelectedRows[i].Cells[1].Value.ToString();
                int numCC = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[i].Cells[2].Value.ToString());
                DateTime dataNasc = Convert.ToDateTime(dataGridViewFuncionarios.SelectedRows[i].Cells[3].Value);
                string morada = dataGridViewFuncionarios.SelectedRows[i].Cells[4].Value.ToString();
                string localidade = dataGridViewFuncionarios.SelectedRows[i].Cells[5].Value.ToString();
                int telefone = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[i].Cells[6].Value.ToString());
                string email = dataGridViewFuncionarios.SelectedRows[i].Cells[7].Value.ToString();
                string vencimento = dataGridViewFuncionarios.SelectedRows[i].Cells[8].Value.ToString();
                string contrato = dataGridViewFuncionarios.SelectedRows[i].Cells[9].Value.ToString();
                DateTime limiteContrato = Convert.ToDateTime(dataGridViewFuncionarios.SelectedRows[i].Cells[10].Value);

                frmAtualizarFuncionario abrir = new frmAtualizarFuncionario(codFunc,nome, numCC, dataNasc, morada, localidade, telefone, email, vencimento, contrato, limiteContrato, this);
                abrir.Show();
            }
        }

        #endregion

        #region Botões

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult msg;

            if (cbEditar.Checked == true)
            {
                msg = MessageBox.Show("Ao ativares esta opção as alterações efectuadas não poderão ser revertidas!\nDesejas continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    btnAtualizarFunc.Enabled = true;
                    btnEliminarFunc.Enabled = true;
                }
                else
                {
                    cbEditar.Checked = false;
                }
            }
            else
            {
                btnAtualizarFunc.Enabled = false;
                btnEliminarFunc.Enabled = false;
            }
        }

        private void btnEliminarFunc_Click(object sender, EventArgs e)
        {
            eliminarFuncionario();
        }

        private void btnAtualizarFunc_Click(object sender, EventArgs e)
        {
            atualizarFuncionario();
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
