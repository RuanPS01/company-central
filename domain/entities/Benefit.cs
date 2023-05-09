using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Benefit : UniqueRegistry, ICrudActions<Benefit, ResponseCrudAction<Benefit>> {
        string name { get; set; }
        double? valueGainToEmployee { get; set; }
        double? costToEmployee { get; set; }

        public Benefit(string name, double? valueGainToEmployee, double? costToEmployee) {
            this.name = name;
            this.valueGainToEmployee = valueGainToEmployee;
            this.costToEmployee = costToEmployee;
        }

        ResponseCrudAction<Benefit> ICrudActions<Benefit, ResponseCrudAction<Benefit>>.create(Benefit entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Benefit, ResponseCrudAction<Benefit>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Benefit>[] ICrudActions<Benefit, ResponseCrudAction<Benefit>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Benefit> ICrudActions<Benefit, ResponseCrudAction<Benefit>>.update(Benefit entity) {
            throw new NotImplementedException();
        }
    }
}
