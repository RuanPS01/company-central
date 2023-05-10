using company_central.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.external.repository {
    internal class WarehouseItemRepository {
        private List<WarehouseItem> warehouseItem;

        public WarehouseItemRepository() {
            warehouseItem = new List<WarehouseItem>();
        }

        public void Save(WarehouseItem WarehouseItem) {
            warehouseItem.Add(WarehouseItem);
        }

        public WarehouseItem Update(WarehouseItem WarehouseItem) {
            int index = warehouseItem.FindIndex(c => c.id == WarehouseItem.id);
            if(index != -1) {
                warehouseItem[index] = WarehouseItem;
            }
            return warehouseItem[index];
        }

        public List<WarehouseItem> Find(Predicate<WarehouseItem> predicate) {
            return warehouseItem.FindAll(predicate);
        }

        public WarehouseItem? FindOne(string id) {
            return warehouseItem.Find(c => c.id == id);
        }

        public void Delete(string id) {
            WarehouseItem? resourceToDelete = warehouseItem.Find(c => c.id == id);
            if(resourceToDelete != null) {
                warehouseItem.Remove(resourceToDelete);
            }
        }
    }
}
