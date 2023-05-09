using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Benefit : UniqueRegistry<Benefit>, ICrudActions<Benefit, ResponseCrudAction<Benefit>> {
        public override Benefit getOneById(int id) {
            throw new NotImplementedException();
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
