using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Vacation : UniqueRegistry<Vacation>, ICrudActions<Vacation, Vacation> {
        public override Vacation getOneById(int id) {
            throw new NotImplementedException();
        }

        Vacation ICrudActions<Vacation, Vacation>.create(Vacation entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Vacation, Vacation>.delete(int id) {
            throw new NotImplementedException();
        }

        Vacation[] ICrudActions<Vacation, Vacation>.list() {
            throw new NotImplementedException();
        }

        Vacation ICrudActions<Vacation, Vacation>.update(Vacation entity) {
            throw new NotImplementedException();
        }
    }
}
