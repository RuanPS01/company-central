using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class EmergencyContact : Address {
        public string completeName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public EmergencyContact(
            string completeName, 
            string phone,
            string email,
            int? localNumber, 
            string? street, 
            string? neighbohood, 
            string? city, 
            string? state, 
            string? country
        ) : base(
            localNumber, 
            street, 
            neighbohood, 
            city, 
            state, 
            country
        ) {
            this.completeName = completeName;
            this.email = email;
            this.phone = phone;
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
