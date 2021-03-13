using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace clinica.Clientes
{
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();

            btnAtualizarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;

            mostrarClientes();
        }

        #region Métodos

        public void mostrarClientes()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT * FROM clientes";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
                    dataAdapter.Fill(dataSet);
                    dataGridViewClientes.DataSource = dataSet.Tables[0];
                    dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar os funcionários existentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void eliminarCliente()
        {
            try
            {
                DialogResult msg;
                baseDados.abrirConexao();

                for (int i = 0; i < dataGridViewClientes.SelectedRows.Count; i++)
                {
                    string query = "DELETE FROM clientes WHERE codCliente = @selecionado";
                    using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                    {
                        comm.Parameters.AddWithValue("@selecionado", dataGridViewClientes.SelectedRows[i].Cells[0].Value.ToString());
                        msg = MessageBox.Show("Desejas eliminar o cliente selecionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (msg == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show($"O cliente {dataGridViewClientes.SelectedRows[i].Cells[1].Value.ToString()} foi eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarClientes();
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
                MessageBox.Show("Ocorreu um erro ao eliminar um cliente ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarCliente()
        {
            for (int i = 0; i < dataGridViewClientes.SelectedRows.Count; i++)
            {
                int codCliente = Convert.ToInt32(dataGridViewClientes.SelectedRows[i].Cells[0].Value.ToString());
                string nome = dataGridViewClientes.SelectedRows[i].Cells[1].Value.ToString();
                int numCC = Convert.ToInt32(dataGridViewClientes.SelectedRows[i].Cells[2].Value.ToString());
                DateTime dataNasc = Convert.ToDateTime(dataGridViewClientes.SelectedRows[i].Cells[3].Value);
                string morada = dataGridViewClientes.SelectedRows[i].Cells[4].Value.ToString();
                string localidade = dataGridViewClientes.SelectedRows[i].Cells[5].Value.ToString();
                int telefone = Convert.ToInt32(dataGridViewClientes.SelectedRows[i].Cells[6].Value.ToString());
                string email = dataGridViewClientes.SelectedRows[i].Cells[7].Value.ToString();

                frmAtualizarCliente abrir = new frmAtualizarCliente(codCliente, nome, numCC, dataNasc, morada, localidade, telefone, email, this);
                abrir.Show();
            }
        }

        #endregion

        #region Botões

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar a consulta de clientes?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Cancelamento efectuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            eliminarCliente();
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            atualizarCliente();
        }

       

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult msg;

            if (cbEditar.Checked == true)
            {
                msg = MessageBox.Show("Ao ativares esta opção as alterações efectuadas não poderão ser revertidas!\nDesejas continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    btnAtualizarCliente.Enabled = true;
                    btnEliminarCliente.Enabled = true;
                }
                else
                {
                    cbEditar.Checked = false;
                }
            }
            else
            {
                btnAtualizarCliente.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        #endregion
    }
}
