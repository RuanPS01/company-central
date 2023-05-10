using company_central.domain.entities.abstracts;
using company_central.domain.interfaces;
using company_central.external.repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities {
    internal class WarehouseItem : UniqueRegistry, ICrudActions<ResponseCrudAction<WarehouseItem>, WarehouseItem, WarehouseItemRepository> {
        string name { get; set; }
        string? description { get; set; }
        int quantity { get; set; }

        public WarehouseItem(string name, string? description, int quantidade) {
            this.name = name;
            this.description = description;
            this.quantity = quantidade;
        }

        ResponseCrudAction<WarehouseItem> ICrudActions<ResponseCrudAction<WarehouseItem>, WarehouseItem, WarehouseItemRepository>
            .saveOnRepo(WarehouseItemRepository databaseRepository) {
            try {
                databaseRepository.Save(this);
                return new ResponseCrudAction<WarehouseItem>(true, this);
            } catch(Exception error) {
                return new ResponseCrudAction<WarehouseItem>(false, "Error to createOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        ResponseCrudAction<WarehouseItem> ICrudActions<ResponseCrudAction<WarehouseItem>, WarehouseItem, WarehouseItemRepository>
            .updateOnRepo(WarehouseItemRepository databaseRepository, WarehouseItem dataToUpdate) {
            try {
                WarehouseItem dataOfRepository = databaseRepository.Update(dataToUpdate);
                return new ResponseCrudAction<WarehouseItem>(true, dataOfRepository);
            } catch(Exception error) {
                return new ResponseCrudAction<WarehouseItem>(false, "Error to updateOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        bool ICrudActions<ResponseCrudAction<WarehouseItem>, WarehouseItem, WarehouseItemRepository>
            .deleteOnRepo(WarehouseItemRepository databaseRepository) {
            try {
                databaseRepository.Delete(this.id);
                return true;
            } catch(Exception) {
                return false;
            }
        }

        public string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented,
                new JsonSerializerSettings {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None
                }
            );
        }
    }
}
