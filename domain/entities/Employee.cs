using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Employee : UniqueRegistry<Employee>, ICrudActions<Employee, ResponseCrudAction<Employee>> {
        public override Employee getOneById(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Employee> ICrudActions<Employee, ResponseCrudAction<Employee>>.create(Employee entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Employee, ResponseCrudAction<Employee>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Employee>[] ICrudActions<Employee, ResponseCrudAction<Employee>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Employee> ICrudActions<Employee, ResponseCrudAction<Employee>>.update(Employee entity) {
            throw new NotImplementedException();
        }
    }
}
