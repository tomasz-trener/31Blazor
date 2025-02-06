using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13P06Shop.Shared
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; } = default;

        public bool Success { get; set; } = false;

        public string Message { get; set; } = string.Empty;
    }
}
