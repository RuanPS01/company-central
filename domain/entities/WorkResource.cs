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
    internal class WorkResource : UniqueRegistry, ICrudActions<ResponseCrudAction<WorkResource>, WorkResource, WorkResourceRepository> {
        string name { get; set; }
        string? description { get; set; }
        int quantity { get; set; }

        public WorkResource(string name, string? description, int quantity) {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
        }

        ResponseCrudAction<WorkResource> ICrudActions<ResponseCrudAction<WorkResource>, WorkResource, WorkResourceRepository>
            .saveOnRepo(WorkResourceRepository databaseRepository) {
            try {
                databaseRepository.Save(this);
                return new ResponseCrudAction<WorkResource>(true, this);
            } catch(Exception error) {
                return new ResponseCrudAction<WorkResource>(false, "Error to createOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        ResponseCrudAction<WorkResource> ICrudActions<ResponseCrudAction<WorkResource>, WorkResource, WorkResourceRepository>
            .updateOnRepo(WorkResourceRepository databaseRepository, WorkResource dataToUpdate) {
            try {
                WorkResource dataOfRepository = databaseRepository.Update(dataToUpdate);
                return new ResponseCrudAction<WorkResource>(true, dataOfRepository);
            } catch(Exception error) {
                return new ResponseCrudAction<WorkResource>(false, "Error to updateOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        bool ICrudActions<ResponseCrudAction<WorkResource>, WorkResource, WorkResourceRepository>
            .deleteOnRepo(WorkResourceRepository databaseRepository) {
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
