using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinica.Medicos
{
    public partial class frmPrincipalMedico : Form
    {
        int codFunc = 0;
        public frmPrincipalMedico(int codFuncionario)
        {
            InitializeComponent();
            codFunc = codFuncionario;
            obterNumMarcacoes();
        }

        private void obterNumMarcacoes()
        {
            try
            {
                baseDados.abrirConexao();

                string query = "SELECT COUNT(*) FROM consultas WHERE codFunc=@codFunc";
                using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
                {
                    comm.Parameters.AddWithValue("@codFunc", codFunc);

                    using (SqlDataReader dataReader = comm.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lblNumConsultas.Text = dataReader[0].ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar o total de consultas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultarMarcaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos.frmConsultarMarcacoes abrir = new frmConsultarMarcacoes(codFunc);
            abrir.Show();
        }
    }
}
