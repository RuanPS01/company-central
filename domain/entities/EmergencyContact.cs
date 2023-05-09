using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class EmergencyContact : UniqueRegistry, ICrudActions<EmergencyContact, ResponseCrudAction<EmergencyContact>> {
        string completeName { get; set; }
        string phone { get; set; }
        Address address { get; set; }
        public EmergencyContact(string completeName, string phone, Address address) {
            this.completeName = completeName;
            this.phone = phone;
            this.address = address;
        }

        ResponseCrudAction<EmergencyContact> ICrudActions<EmergencyContact, ResponseCrudAction<EmergencyContact>>.create(EmergencyContact entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<EmergencyContact, ResponseCrudAction<EmergencyContact>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<EmergencyContact>[] ICrudActions<EmergencyContact, ResponseCrudAction<EmergencyContact>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<EmergencyContact> ICrudActions<EmergencyContact, ResponseCrudAction<EmergencyContact>>.update(EmergencyContact entity) {
            throw new NotImplementedException();
        }
    }
}
