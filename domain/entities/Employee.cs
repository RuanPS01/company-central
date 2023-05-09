using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace company_central.domain.entities {
    internal class Employee : UniqueRegistry, ICrudActions<Employee, ResponseCrudAction<Employee>> {
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

        ResponseCrudAction<Employee> ICrudActions<Employee, ResponseCrudAction<Employee>>.getOne() {
            throw new NotImplementedException();
        }

        //public Employee getData() {
        //    return { };
        //}
    }
}
