using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities.abstracts {
    abstract class UniqueRegistry {
        private static Guid uuid = Guid.NewGuid();
        public string id = uuid.ToString();
    }
}
