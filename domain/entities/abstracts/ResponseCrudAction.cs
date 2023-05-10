using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_central.domain.entities.abstracts {
    public class ResponseCrudAction<T> {
        public bool isSuccess;
        public T? data;
        public string? message;

        public ResponseCrudAction(bool isSuccess, T data) {
            this.isSuccess = isSuccess;
            this.data = data;
        }

        public ResponseCrudAction(bool isSuccess, string message) {
            this.isSuccess = isSuccess;
            this.message = message;
        }
    }
}
