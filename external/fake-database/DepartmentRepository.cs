using company_central.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.external.repository {
    internal class DepartmentRepository {
        private List<Department> department;

        public DepartmentRepository() {
            department = new List<Department>();
        }

        public void Save(Department Department) {
            department.Add(Department);
        }

        public Department Update(Department Department) {
            int index = department.FindIndex(c => c.id == Department.id);
            if(index != -1) {
                department[index] = Department;
            }
            return department[index];
        }

        public List<Department> Find(Predicate<Department> predicate) {
            return department.FindAll(predicate);
        }

        public Department? FindOne(string id) {
            return department.Find(c => c.id == id);
        }

        public void Delete(string id) {
            Department? resourceToDelete = department.Find(c => c.id == id);
            if(resourceToDelete != null) {
                department.Remove(resourceToDelete);
            }
        }
    }
}
