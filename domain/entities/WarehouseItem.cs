using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class WarehouseItem : UniqueRegistry<WarehouseItem>, ICrudActions<WarehouseItem, WarehouseItem> {
        public override WarehouseItem getOneById(int id) {
            throw new NotImplementedException();
        }

        WarehouseItem ICrudActions<WarehouseItem, WarehouseItem>.create(WarehouseItem entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<WarehouseItem, WarehouseItem>.delete(int id) {
            throw new NotImplementedException();
        }

        WarehouseItem[] ICrudActions<WarehouseItem, WarehouseItem>.list() {
            throw new NotImplementedException();
        }

        WarehouseItem ICrudActions<WarehouseItem, WarehouseItem>.update(WarehouseItem entity) {
            throw new NotImplementedException();
        }
    }
}
