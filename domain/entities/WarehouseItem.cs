using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class WarehouseItem : UniqueRegistry, ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>> {
        string name { get; set; }
        string? description { get; set; }
        int quantity { get; set; }

        public WarehouseItem(string name, string? description, int quantidade) {
            this.name = name;
            this.description = description;
            this.quantity = quantidade;
        }

        ResponseCrudAction<WarehouseItem> ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>>.create(WarehouseItem entity) {
            throw new NotImplementedException();
        }

        bool ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>>.delete(int id) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<WarehouseItem>[] ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>>.list() {
            throw new NotImplementedException();
        }

        ResponseCrudAction<WarehouseItem> ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>>.update(WarehouseItem entity) {
            throw new NotImplementedException();
        }

        ResponseCrudAction<WarehouseItem> ICrudActions<WarehouseItem, ResponseCrudAction<WarehouseItem>>.getOne() {
            throw new NotImplementedException();
        }
    }
}
