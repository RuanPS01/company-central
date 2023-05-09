using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class WorkResource : UniqueRegistry<WorkResource>, ICrudActions<WorkResource, WorkResource> {
        public override WorkResource getOneById(int id) {
            throw new NotImplementedException();
        }

        WorkResource ICrudActions<WorkResource, WorkResource>.create(WorkResource entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<WorkResource, WorkResource>.delete(int id) {
            throw new NotImplementedException();
        }

        WorkResource[] ICrudActions<WorkResource, WorkResource>.list() {
            throw new NotImplementedException();
        }

        WorkResource ICrudActions<WorkResource, WorkResource>.update(WorkResource entity) {
            throw new NotImplementedException();
        }
    }
}
