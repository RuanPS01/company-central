using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class Vacation : UniqueRegistry {
        int usedDays { get; set; } = 0;
        int pendingDays { get; set; } = 30;
        
        public Vacation(int usedDays, int pendingDays) {
            this.usedDays = usedDays;
            this.pendingDays = pendingDays;
        }
    }
}
