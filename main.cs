using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central {
    class CompanyCentral {
        static void Main() {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using(SqlConnection connection = new SqlConnection(connectionString)) {
                try {
                    connection.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");

                    // Execute suas operações com o banco de dados aqui

                    connection.Close();
                } catch(Exception ex) {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
