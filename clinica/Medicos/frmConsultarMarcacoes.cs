using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace clinica.Medicos
{
    public partial class frmConsultarMarcacoes : Form
    {
        int codMed = 0;

        public frmConsultarMarcacoes(int codMedico)
        {
            InitializeComponent();
            codMed = codMedico;
            mostrarConsultas();
        }

        private void mostrarConsultas()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "select consultas.dataConsula AS [Data da Consulta], consultas.obs AS [Observações], " +
                    "clientes.cartaoCidadao[C.C. do Utente], clientes.nome as [Nome do Utente], clientes.telefone AS[Telefone do Utente], clientes.email AS[Email do Utente]  from consultas inner join funcionarios on consultas.codFunc = funcionarios.codFunc " +
                    "inner join clientes on consultas.codCliente = clientes.codCliente WHERE consultas.codFunc=@codFunc";

                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codFunc", codMed);

                    DataSet dataSet = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);

                    dataAdapter.Fill(dataSet);
                    dataGridViewConsultas.DataSource = dataSet.Tables[0];
                    dataGridViewConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar as suas consultas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baseDados.fecharConexao();
        }
    }
}
