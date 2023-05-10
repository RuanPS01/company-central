using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Position {
        public string name { get; set; }
        public double minSalaryValue { get; set; }
        public double? maxSalaryValue { get; set; }

        public Position(string name, double minSalaryValue, double maxSalaryValue) {
            this.name = name;
            this.minSalaryValue = minSalaryValue;
            this.maxSalaryValue = maxSalaryValue;
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
