using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.interfaces {
    interface ICrudActions<I, O> {
        public O create(I entity);
        public O update(I entity);
        public O[] list();
        public O getOne();
        public bool delete(int id);
    }
}
