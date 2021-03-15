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

namespace clinica
{
    public partial class frmLogin : Form
    {
        string utilizador = "";
        string password = "";
        string funcao = "";
        int codFunc = 0;
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void obterCredenciais()
        {
            baseDados.abrirConexao();

            string query = "select login.utilizador, login.password, loginFunc.funcao, loginFunc.codFunc from login INNER JOIN loginFunc ON login.codLogin = loginFunc.codLogin " +
                "INNER JOIN funcionarios ON loginFunc.codFunc = funcionarios.codFunc WHERE login.utilizador=@utilizador AND login.password=@password";

            using (SqlCommand comm = new SqlCommand(query, baseDados.conn))
            {
                comm.Parameters.AddWithValue("@utilizador", txtUtilizador.Text);
                comm.Parameters.AddWithValue("@password", txtPassword.Text);

                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        utilizador = dataReader[0].ToString();
                        password = dataReader[1].ToString();
                        funcao = dataReader[2].ToString();
                        codFunc = Convert.ToInt32(dataReader[3].ToString());

                        if (funcao == "A")
                        {
                            frmPrincipal abrir = new frmPrincipal();
                            abrir.Show();
                        }
                        else if (funcao == "R")
                        {

                        }
                        else if(funcao == "M")
                        {
                            Medicos.frmPrincipalMedico abrir = new Medicos.frmPrincipalMedico(codFunc);
                            abrir.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("As credênciais introduzidas estão incorretas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void btnAcesso_Click(object sender, EventArgs e)
        {
            obterCredenciais();
        }
    }
}
