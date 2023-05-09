using company_central.domain.entities;
using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace company_central {
    class CompanyCentral {
        static void Main() {
            Vacation vacation = new Vacation();
            Position position = new Position("Desenvolvedor Junior 2", 2000);
            Department department = new Department("Tecnologia", 4000);
            Address address = new Address(1, "Rua 1", "Bairro 1", "Cidade 1", "MG", "Brasil");
            Address address2 = new Address(2, "Rua 2", "Bairro 2", "Cidade 2", "MG", "Brasil");
            EmergencyContact emergencyContact = new EmergencyContact(
                "Severino Teste",
                "359999999",
                address2
            );
            PersonalData personalData = new PersonalData(
                "",
                address,
                "321",
                "123",
                "321654",
                "1997-01-24",
                "M",
                "teste@yopmail.com",
                "35999999999",
                emergencyContact
            );
            Employee employee = new Employee(
                2200,
                DateTime.Now,
                vacation, position, department, personalData
            );
            Console.WriteLine(employee.id);

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\company-central.mdf;Integrated Security=True;Connect Timeout=30";
            //using(SqlConnection connection = new SqlConnection(connectionString)) {
            //    try {
            //        connection.Open();
            //        Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");

            //        // Execute suas operações com o banco de dados aqui

            //        connection.Close();
            //    } catch(Exception ex) {
            //        Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
