using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using company_central.external.repository;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace company_central.domain.entities {
    internal class Employee : UniqueRegistry, ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository> {
        double salary { get; set; }
        DateTime hiringDate { get; set; }
        Vacation vacation { get; set; }
        Position position { get; set; }
        Department department { get; set; }
        PersonalData personalData { get; set; }

        public Employee(double salary, DateTime hiringDate, Vacation vacation, Position position, Department department, PersonalData personalData) {
            this.salary = salary;
            this.hiringDate = hiringDate;
            this.vacation = vacation;
            this.position = position;
            this.department = department;
            this.personalData = personalData;
        }

        ResponseCrudAction<Employee> ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository>
            .saveOnRepo(EmployeeRepository databaseRepository) {
            try {
                databaseRepository.Save(this);
                return new ResponseCrudAction<Employee>(true, this);
            } catch(Exception error) {
                return new ResponseCrudAction<Employee>(false, "Error to createOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        ResponseCrudAction<Employee> ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository>
            .updateOnRepo(EmployeeRepository databaseRepository, Employee dataToUpdate) {
            try {
                Employee dataOfRepository = databaseRepository.Update(dataToUpdate);
                return new ResponseCrudAction<Employee>(true, dataOfRepository);
            } catch(Exception error) {
                return new ResponseCrudAction<Employee>(false, "Error to updateOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        bool ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository>
            .deleteOnRepo(EmployeeRepository databaseRepository) {
            try {
                databaseRepository.Delete(this.id);
                return true;
            } catch(Exception) {
                return false;
            }
        }

        public ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository> 
            getInstance() {
                return (ICrudActions<ResponseCrudAction<Employee>, Employee, EmployeeRepository>)this;
        }

        public object ToObject() {
            var objectDictionary = new Dictionary<string, object>();
            var fields = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            string pattern = "<(.*?)>";

            foreach(var field in fields) {
                Match match = Regex.Match(field.Name, pattern);
                objectDictionary[match.Groups[1].Value] = field.GetValue(this);
            }

            return objectDictionary;
        }

        public string ToJson() {
            var settings = new JsonSerializerSettings {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.None,
            };

            return JsonConvert.SerializeObject(this.ToObject(), Formatting.Indented, settings);
        }

    }
}
