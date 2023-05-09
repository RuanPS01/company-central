using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Vacation : UniqueRegistry {
        int usedDays { get; set; }
        int pendingDays { get; set; }
        
        public Vacation(int usedDays = 0, int pendingDays = 30) {
            this.usedDays = usedDays;
            this.pendingDays = pendingDays;
        }
    }
}
