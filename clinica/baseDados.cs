using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinica
{
    class baseDados
    {
        private static string connString = @"Data Source=desktop-jdijqgq\sqlexpress;Initial Catalog=clinica;Integrated Security=True";
        public static SqlConnection conn;

        public static void abrirConexao()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch { throw; }
        }

        public static void fecharConexao()
        {
            try
            {
                conn.Close();
            }
            catch { throw; }
        }
    }
}
