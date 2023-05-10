using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    public class Address {
        public int? localNumber;
        public string? street;
        public string? neighbohood;
        public string? city;
        public string? state;
        public string? country;

        public Address(int? localNumber, string? street, string? neighbohood, string? city, string? state, string? country) {
            this.localNumber = localNumber;
            this.street = street;
            this.neighbohood = neighbohood;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public string getFullAddress() {
            return this.localNumber 
                    + ", " + this.street 
                    + ", " + this.neighbohood 
                    + ", " + this.city 
                    + ", " + this.state 
                    + ", " + this.country;
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
