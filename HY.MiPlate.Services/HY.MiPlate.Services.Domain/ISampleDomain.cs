using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using HY.MiPlate.Services.Contact;

namespace HY.MiPlate.Services.Domain
{
    public interface ISampleDomain
    {
        ResultBase<SampleDto> GetSampleData(int id);
    }
}
