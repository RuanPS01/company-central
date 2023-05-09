using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Position : UniqueRegistry, ICrudActions<Position, ResponseCrudAction<Position>> {
        string name { get; set; }
        double baseSalaryValue { get; set; }

        public Position(string name, double baseSalaryValue) {
            this.name = name;
            this.baseSalaryValue = baseSalaryValue;
        }

        ResponseCrudAction<Position> ICrudActions<Position, ResponseCrudAction<Position>>.create(Position entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Position, ResponseCrudAction<Position>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Position>[] ICrudActions<Position, ResponseCrudAction<Position>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Position> ICrudActions<Position, ResponseCrudAction<Position>>.update(Position entity) {
            throw new NotImplementedException();
        }
    }
}
