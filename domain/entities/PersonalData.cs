using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class PersonalData : UniqueRegistry<PersonalData>, ICrudActions<PersonalData, ResponseCrudAction<PersonalData>> {
        public override PersonalData getOneById(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<PersonalData> ICrudActions<PersonalData, ResponseCrudAction<PersonalData>>.create(PersonalData entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<PersonalData, ResponseCrudAction<PersonalData>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<PersonalData>[] ICrudActions<PersonalData, ResponseCrudAction<PersonalData>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<PersonalData> ICrudActions<PersonalData, ResponseCrudAction<PersonalData>>.update(PersonalData entity) {
            throw new NotImplementedException();
        }
    }
}
