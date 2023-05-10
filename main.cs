using company_central.domain.entities;
using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using company_central.external.repository;

namespace company_central {
    class CompanyCentral {
        static void Main() {
            #region Fake database repositories
            BenefitRepository benefitRepository = new BenefitRepository();
            DepartmentRepository departmentRepository = new DepartmentRepository();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            WarehouseItemRepository warehouseItemRepository = new WarehouseItemRepository();
            WorkResourceRepository workResourceRepository = new WorkResourceRepository();
            #endregion

            Vacation vacation = new Vacation();
            Position position = new Position("Desenvolvedor Junior 2", 2000, 5000);
            Department department = new Department("Tecnologia", 4000, 10000);
            Address address = new Address(1, "Rua 1", "Bairro 1", "Cidade 1", "MG", "Brasil");
            EmergencyContact emergencyContact = new EmergencyContact(
                "Severino Teste",
                "359999999",
                "severino@yopmail.com",
                2, "Rua 2", "Bairro 2", "Cidade 2", "MG", "Brasil"
            );
            PersonalData personalData = new PersonalData(
                "Cleiton Jurêncio Clementino",
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
            Console.WriteLine(" [[[ COMPANY CENTRAL ]]]");
            Console.WriteLine(" Bem vindo ao sistema de gerenciamento de funcionários!");

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Para exemplificar um cadastro em nossa plataforma, esse é um registro do sistema convertido em JSON (aperte ENTER para visualizar): ");
            Console.ReadKey();
            Console.WriteLine(employee.ToJson());

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Você quer que esse registro esteja salvo no Banco de dados do sistema? (S/N)");
            string input = Console.ReadLine();
            if(input == "S") {
                try {
                    employee.getInstance().saveOnRepo(employeeRepository);
                    Console.WriteLine("Objeto Salvo no banco de dados!");

                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("--Lista dos IDs dos registros de funcionario do banco de dados:");
                    Predicate<Employee> predicate = (b) => b.id != "";
                    List<Employee> listOfEmployees = employeeRepository.Find(predicate);
                    foreach(Employee employeeOfList in listOfEmployees) {
                        Console.WriteLine(employeeOfList.id);
                    }
                    Console.WriteLine("---------------------------------------------------------------------");
                } catch(Exception) {
                    Console.WriteLine("Erro ao salvar objeto no banco de dados!");
                }
                
            } else {
                Console.WriteLine("Ja que não quer, vou deixar você livre.");
            }

            Console.WriteLine("O sistema ainda está em fase inicial. Por enquanto é isso. Atá mais!");
            Console.ReadKey();
        }
    }
}
