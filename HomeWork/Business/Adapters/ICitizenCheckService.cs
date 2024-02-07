using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters;

public interface ICitizenCheckService
{
    bool CheckCitizen(Person person);
}
