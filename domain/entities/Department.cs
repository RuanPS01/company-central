using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using company_central.external.repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Department : UniqueRegistry, ICrudActions<ResponseCrudAction<Department>, Department, DepartmentRepository> {
        public string name { get; set; }
        public double? cost { get; set; }
        public int quantityOfDepartments { get; set; }

        public Department(string name, int quantityOfDepartments, double cost) {
            this.name = name;
            this.quantityOfDepartments = quantityOfDepartments;
            this.cost = cost;
        }

        ResponseCrudAction<Department> ICrudActions<ResponseCrudAction<Department>, Department, DepartmentRepository>
            .saveOnRepo(DepartmentRepository databaseRepository) {
            try {
                databaseRepository.Save(this);
                return new ResponseCrudAction<Department>(true, this);
            } catch(Exception error) {
                return new ResponseCrudAction<Department>(false, "Error to createOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        ResponseCrudAction<Department> ICrudActions<ResponseCrudAction<Department>, Department, DepartmentRepository>
            .updateOnRepo(DepartmentRepository databaseRepository, Department dataToUpdate) {
            try {
                Department dataOfRepository = databaseRepository.Update(dataToUpdate);
                return new ResponseCrudAction<Department>(true, dataOfRepository);
            } catch(Exception error) {
                return new ResponseCrudAction<Department>(false, "Error to updateOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        bool ICrudActions<ResponseCrudAction<Department>, Department, DepartmentRepository>
            .deleteOnRepo(DepartmentRepository databaseRepository) {
            try {
                databaseRepository.Delete(this.id);
                return true;
            } catch(Exception) {
                return false;
            }
        }

        public string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented,
                new JsonSerializerSettings {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None
                }
            );
        }
    }
}
