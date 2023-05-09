using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class WorkResource : UniqueRegistry, ICrudActions<WorkResource, ResponseCrudAction<WorkResource>> {
        string name { get; set; }
        string? description { get; set; }
        int quantity { get; set; }

        public WorkResource(string name, string? description, int quantity) {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
        }

        ResponseCrudAction<WorkResource> ICrudActions<WorkResource, ResponseCrudAction<WorkResource>>.create(WorkResource entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<WorkResource, ResponseCrudAction<WorkResource>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<WorkResource>[] ICrudActions<WorkResource, ResponseCrudAction<WorkResource>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<WorkResource> ICrudActions<WorkResource, ResponseCrudAction<WorkResource>>.update(WorkResource entity) {
            throw new NotImplementedException();
        }
    }
}
