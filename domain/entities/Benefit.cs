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
    internal class Benefit : UniqueRegistry, ICrudActions<ResponseCrudAction<Benefit>, Benefit, BenefitRepository> {
        string name { get; set; }
        double? valueGainToEmployee { get; set; }
        double? costToEmployee { get; set; }

        public Benefit(string name, double? valueGainToEmployee, double? costToEmployee) {
            this.name = name;
            this.valueGainToEmployee = valueGainToEmployee;
            this.costToEmployee = costToEmployee;
        }

        ResponseCrudAction<Benefit> ICrudActions<ResponseCrudAction<Benefit>, Benefit, BenefitRepository>
            .saveOnRepo(BenefitRepository databaseRepository) {
            try {
                databaseRepository.Save(this);
                return new ResponseCrudAction<Benefit>(true, this);
            } catch(Exception error) {
                return new ResponseCrudAction<Benefit>(false, "Error to createOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        ResponseCrudAction<Benefit> ICrudActions<ResponseCrudAction<Benefit>, Benefit, BenefitRepository>
            .updateOnRepo(BenefitRepository databaseRepository, Benefit dataToUpdate) {
            try {
                Benefit dataOfRepository = databaseRepository.Update(dataToUpdate);
                return new ResponseCrudAction<Benefit>(true, dataOfRepository);
            } catch(Exception error) {
                return new ResponseCrudAction<Benefit>(false, "Error to updateOnRepo in " + this.GetType().Name + ". Exception:" + error.Message.ToString());
            }
        }

        bool ICrudActions<ResponseCrudAction<Benefit>, Benefit, BenefitRepository>
            .deleteOnRepo(BenefitRepository databaseRepository) {
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
