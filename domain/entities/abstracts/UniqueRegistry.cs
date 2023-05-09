using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities.abstracts {
    abstract class UniqueRegistry<T> {
        public int id;

        public abstract T getOneById(int id);
    }
}
