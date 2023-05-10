using company_central.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.external.repository {
    internal class BenefitRepository {
        private List<Benefit> benefit;

        public BenefitRepository() {
            benefit = new List<Benefit>();
        }

        public void Save(Benefit Benefit) {
            benefit.Add(Benefit);
        }

        public Benefit Update(Benefit Benefit) {
            int index = benefit.FindIndex(c => c.id == Benefit.id);
            if(index != -1) {
                benefit[index] = Benefit;
            }
            return benefit[index];
        }

        public List<Benefit> Find(Predicate<Benefit> predicate) {
            return benefit.FindAll(predicate);
        }

        public Benefit? FindOne(string id) {
            return benefit.Find(c => c.id == id);
        }

        public void Delete(string id) {
            Benefit? resourceToDelete = benefit.Find(c => c.id == id);
            if(resourceToDelete != null) {
                benefit.Remove(resourceToDelete);
            }
        }
    }
}
