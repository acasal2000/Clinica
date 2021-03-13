using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace clinica.Departamentos
{
    public partial class frmConsultarDepartamentos : Form
    {
        public frmConsultarDepartamentos()
        {
            InitializeComponent();
            btnAtualizarDep.Enabled = false;
            btnEliminarDep.Enabled = false;

            mostrarDepartamentos();
        }

        #region Métodos

        public void mostrarDepartamentos()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT codDepartamento as [Código], nomeDepartamento as [Nome], abreviaturaDep as [Abreviatura] FROM departamentos";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);

                    dataAdapter.Fill(dataSet);
                    dataGridViewDepartamentos.DataSource = dataSet.Tables[0];
                    dataGridViewDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar os departamentos existentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void eliminarDepartamento()
        {
            try
            {
                DialogResult msg;
                baseDados.abrirConexao();
                for (int i = 0; i < dataGridViewDepartamentos.SelectedRows.Count; i++)
                {
                    string query = "DELETE FROM departamentos WHERE codDepartamento = @selecionado";
                    using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                    {
                        comm.Parameters.AddWithValue("@selecionado", dataGridViewDepartamentos.SelectedRows[i].Cells[0].Value.ToString());


                        msg = MessageBox.Show("Desejas eliminar o departamento selecionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (msg == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show($"O departamento {dataGridViewDepartamentos.SelectedRows[i].Cells[1].Value.ToString()} foi eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarDepartamentos();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao eliminar o departamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarDepartamento()
        {
            try
            {
                for (int i = 0; i < dataGridViewDepartamentos.SelectedRows.Count; i++)
                {
                    string nomeDep = dataGridViewDepartamentos.SelectedRows[i].Cells[1].Value.ToString();
                    string abrevDep = dataGridViewDepartamentos.SelectedRows[i].Cells[2].Value.ToString();
                    Departamentos.frmAtualizarDepartamento abrir = new frmAtualizarDepartamento(nomeDep, abrevDep, this);
                    abrir.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro iniciar a atualização do departamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnAtualizarDep.Enabled = true;
                    btnEliminarDep.Enabled = true;
                }
                else
                {
                    cbEditar.Checked = false;
                }
            }
            else
            {
                btnAtualizarDep.Enabled = false;
                btnEliminarDep.Enabled = false;
            }
        }

        private void btnEliminarDep_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
        }

        private void btnAtualizarDep_Click(object sender, EventArgs e)
        {
            atualizarDepartamento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg;

            msg = MessageBox.Show("Desejas cancelar a consulta dos departamentos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                MessageBox.Show("Cancelamento efectuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
    }
}
