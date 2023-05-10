using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class PersonalData {
        public string completeName;
        public Address? address;
        public string? rg;
        public string? cpf;
        public string? workCardNumber;
        public string? dateOfBirth;
        public string? gender;
        public string? email;
        public string? telefone;
        public EmergencyContact? emergencyContact;

        public PersonalData(string completeName, Address? address, string? rg, string? cpf, string? workCardNumber, string? dateOfBirth, string? gender, string? email, string? telefone, EmergencyContact? emergencyContact) {
            this.completeName = completeName;
            this.address = address;
            this.rg = rg;
            this.cpf = cpf;
            this.workCardNumber = workCardNumber;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.email = email;
            this.telefone = telefone;
            this.emergencyContact = emergencyContact;
        }

        public string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented,
                new JsonSerializerSettings {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None
                }
            );
        }
    }
}
