using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            numDepartamentos();
            numFuncionarios();
            numConsultas();
            numCliente();
        }

        private void inserirDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos.frmInserirDepartamento abrir = new Departamentos.frmInserirDepartamento(this);
            abrir.Show();
        }

        private void consultarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos.frmConsultarDepartamentos abrir = new Departamentos.frmConsultarDepartamentos();
            abrir.Show();
        }

        private void inserirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.frmInserirFuncionario abrir = new Funcionarios.frmInserirFuncionario(this);
            abrir.Show();
        }

        private void consultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.frmConsultarFuncionarios abrir = new Funcionarios.frmConsultarFuncionarios();
            abrir.Show();
        }

        private void agendarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.frmInserirConsulta abrir = new Consultas.frmInserirConsulta(this);
            abrir.Show();
        }

        private void visualizarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.frmConsultarConsultas abrir = new Consultas.frmConsultarConsultas();
            abrir.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmInserirCliente abrir = new Clientes.frmInserirCliente(this);
            abrir.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmConsultarClientes abrir = new Clientes.frmConsultarClientes();
            abrir.Show();
        }

        public void numDepartamentos()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT COUNT(*) FROM departamentos";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            lblNumDepartamentos.Text = dataReader[0].ToString();
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o total de departamentos no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void numFuncionarios()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT COUNT(*) FROM funcionarios";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            lblNumFuncionarios.Text = dataReader[0].ToString();
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o total de funcionários no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void numConsultas()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT COUNT(*) FROM consultas";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            lblNumConsultas.Text = dataReader[0].ToString();
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o total de consultas no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void numCliente()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT COUNT(*) FROM clientes";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            lblNumClientes.Text = dataReader[0].ToString();
                        }
                    }
                }

                baseDados.fecharConexao();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o total de clientes no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
