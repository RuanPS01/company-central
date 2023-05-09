using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Department : UniqueRegistry, ICrudActions<Department, ResponseCrudAction<Department>> {
        string name { get; set; }
        int quantityOfEmployees { get; set; }

        public Department(string name, int quantityOfEmployees) {
            this.name = name;
            this.quantityOfEmployees = quantityOfEmployees;
        }
        ResponseCrudAction<Department> ICrudActions<Department, ResponseCrudAction<Department>>.create(Department entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Department, ResponseCrudAction<Department>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Department>[] ICrudActions<Department, ResponseCrudAction<Department>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Department> ICrudActions<Department, ResponseCrudAction<Department>>.update(Department entity) {
            throw new NotImplementedException();
        }
    }
}
