using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.MiPlate.Services.Contact
{
    public class ResultBase
    {
        public bool IsSuccessful { get; set; }
        public int TotailRecords { get; set; }
        public string Message { get; set; }
    }

    public class ResultBase<T> : ResultBase
    {
        public T Data { get; set; }
        public IEnumerable<T> DataList { get; set; }
    }
}
