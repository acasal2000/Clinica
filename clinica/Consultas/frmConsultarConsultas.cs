using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;

namespace clinica.Consultas
{
    public partial class frmConsultarConsultas : Form
    {
        public frmConsultarConsultas()
        {
            InitializeComponent();
            btnAtualizarConsulta.Enabled = false;
            btnEliminarConsulta.Enabled = false;
            mostrarConsultas();
        }

        #region Métodos

        public void mostrarConsultas()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "select consultas.codConsulta AS [Cod. Consulta], consultas.codFunc AS [Cod. Médico], consultas.codCliente AS [Cod. Cliente], consultas.dataConsula AS [Data da Consulta], consultas.Custo as [Custo], consultas.obs AS [Observações], " +
                    "funcionarios.nome AS[Nome do Médico], funcionarios.telefone AS[Telefone do Médico], funcionarios.email AS[Email do Médico], " +
                    "clientes.cartaoCidadao[C.C. do Utente], clientes.nome as [Nome do Utente], clientes.telefone AS[Telefone do Utente], clientes.email AS[Email do Utente]  from consultas inner join funcionarios on consultas.codFunc = funcionarios.codFunc " +
                    "inner join clientes on consultas.codCliente = clientes.codCliente; ";

                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
                    dataAdapter.Fill(dataSet);
                    dataGridViewConsultas.DataSource = dataSet.Tables[0];
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar as consultas existentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void eliminarConsulta()
        {
            try
            {
                DialogResult msg;
                baseDados.abrirConexao();

                for (int i = 0; i < dataGridViewConsultas.SelectedRows.Count; i++)
                {
                    string query = "DELETE FROM consultas WHERE codConsulta = @selecionado";
                    using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                    {
                        comm.Parameters.AddWithValue("@selecionado", dataGridViewConsultas.SelectedRows[i].Cells[0].Value.ToString());
                        msg = MessageBox.Show("Desejas eliminar a consulta selecionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (msg == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show($"A consulta Nº {dataGridViewConsultas.SelectedRows[i].Cells[0].Value.ToString()} foi eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarConsultas();
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
                MessageBox.Show("Ocorreu um erro ao eliminar uma consulta! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarConsulta()
        {
            int numCC = 0;
            for (int i = 0; i < dataGridViewConsultas.SelectedRows.Count; i++)
            {
                int codConsulta = Convert.ToInt32(dataGridViewConsultas.SelectedRows[i].Cells[0].Value.ToString());
                int codFunc = Convert.ToInt32(dataGridViewConsultas.SelectedRows[i].Cells[1].Value.ToString());
                int codCliente = Convert.ToInt32(dataGridViewConsultas.SelectedRows[i].Cells[2].Value.ToString());
                DateTime data = Convert.ToDateTime(dataGridViewConsultas.SelectedRows[i].Cells[3].Value);
                string custo = dataGridViewConsultas.SelectedRows[i].Cells[4].Value.ToString();
                string obs = dataGridViewConsultas.SelectedRows[i].Cells[5].Value.ToString();

                obterCC(out numCC);

                frmAtualizarConsulta abrir = new frmAtualizarConsulta(codConsulta, codFunc, numCC, data, custo, obs, this);
                abrir.Show();
            }
        }

        private void obterCC(out int cc)
        {
            baseDados.abrirConexao();
            cc = 0;
            for (int i = 0; i < dataGridViewConsultas.SelectedRows.Count; i++)
            {
                string query = "SELECT cartaoCidadao FROM clientes WHERE codCliente=@codCliente";

                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codCliente", dataGridViewConsultas.SelectedRows[i].Cells[2].Value.ToString());
                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            cc = Convert.ToInt32(dataReader[0].ToString());
                        }
                    }
                }
            }

            baseDados.fecharConexao();
        }

        #endregion

        #region Botões

        private void btnAtualizarConsulta_Click(object sender, EventArgs e)
        {
            atualizarConsulta();
        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult msg;

            if (cbEditar.Checked == true)
            {
                msg = MessageBox.Show("Ao ativares esta opção as alterações efectuadas não poderão ser revertidas!\nDesejas continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    btnAtualizarConsulta.Enabled = true;
                    btnEliminarConsulta.Enabled = true;
                }
                else
                {
                    cbEditar.Checked = false;
                }
            }
            else
            {
                btnAtualizarConsulta.Enabled = false;
                btnEliminarConsulta.Enabled = false;
            }
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

        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            eliminarConsulta();
        }

        #endregion
    }
}
