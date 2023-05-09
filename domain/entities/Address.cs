using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Address {
        int? localNumber;
        string? street;
        string? neighbohood;
        string? city;
        string? state;
        string? country;

        public Address(int? localNumber, string? street, string? neighbohood, string? city, string? state, string? country) {
            this.localNumber = localNumber;
            this.street = street;
            this.neighbohood = neighbohood;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}
