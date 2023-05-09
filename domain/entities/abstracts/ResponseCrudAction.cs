using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities.abstracts {
    abstract class ResponseCrudAction<T> {
        public bool isSuccess;
        public T data;
    }
}
