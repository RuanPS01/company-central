using company_central.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.external.repository {
    internal class WorkResourceRepository {
        private List<WorkResource> workResource;

        public WorkResourceRepository() {
            workResource = new List<WorkResource>();
        }

        public void Save(WorkResource WorkResource) {
            workResource.Add(WorkResource);
        }

        public WorkResource Update(WorkResource WorkResource) {
            int index = workResource.FindIndex(c => c.id == WorkResource.id);
            if(index != -1) {
                workResource[index] = WorkResource;
            }
            return workResource[index];
        }

        public List<WorkResource> Find(Predicate<WorkResource> predicate) {
            return workResource.FindAll(predicate);
        }

        public WorkResource? FindOne(string id) {
            return workResource.Find(c => c.id == id);
        }

        public void Delete(string id) {
            WorkResource? resourceToDelete = workResource.Find(c => c.id == id);
            if(resourceToDelete != null) {
                workResource.Remove(resourceToDelete);
            }
        }

    }
}
