using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Address : UniqueRegistry<Address>, ICrudActions<Address, ResponseCrudAction<Address>> {
        public override Address getOneById(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Address> ICrudActions<Address, ResponseCrudAction<Address>>.create(Address entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<Address, ResponseCrudAction<Address>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Address>[] ICrudActions<Address, ResponseCrudAction<Address>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<Address> ICrudActions<Address, ResponseCrudAction<Address>>.update(Address entity) {
            throw new NotImplementedException();
        }
    }
}
