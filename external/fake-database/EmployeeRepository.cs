using company_central.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.external.repository {
    internal class EmployeeRepository {
        private List<Employee> employee;

        public EmployeeRepository() {
            employee = new List<Employee>();
        }

        public void Save(Employee Employee) {
            employee.Add(Employee);
        }

        public Employee Update(Employee Employee) {
            int index = employee.FindIndex(c => c.id == Employee.id);
            if(index != -1) {
                employee[index] = Employee;
            }
            return employee[index];
        }

        public List<Employee> Find(Predicate<Employee> predicate) {
            return employee.FindAll(predicate);
        }

        public Employee? FindOne(string id) {
            return employee.Find(c => c.id == id);
        }

        public void Delete(string id) {
            Employee? resourceToDelete = employee.Find(c => c.id == id);
            if(resourceToDelete != null) {
                employee.Remove(resourceToDelete);
            }
        }
    }
}
