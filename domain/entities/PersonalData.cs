using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class PersonalData : UniqueRegistry {
        string completeName;
        Address? address;
        string? rg;
        string? cpf;
        string? workCardNumber;
        string? dateOfBirth;
        string? gender;
        string? email;
        string? telefone;
        EmergencyContact? emergencyContact;

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
    }
}
