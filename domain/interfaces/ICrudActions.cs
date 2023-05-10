using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.interfaces {
    interface ICrudActions<R, T, D> {
        R saveOnRepo(D databaseRepository);
        R updateOnRepo(D databaseRepository, T dataToUpdate);
        bool deleteOnRepo(D databaseRepository);
    }
}
