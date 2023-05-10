using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Vacation : UniqueRegistry {
        public int usedDays { get; set; }
        public int pendingDays { get; set; }
        public DateTime nextDateToVacations { get; set; }

        public Vacation(int usedDays = 0, int pendingDays = 30, DateTime? nextDateToVacations = default) {
            this.usedDays = usedDays;
            this.pendingDays = pendingDays;
            this.nextDateToVacations = nextDateToVacations ?? DateTime.Now.AddYears(1);
        }

        public string ToJson() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
