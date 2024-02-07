using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ForeignManager : IPersonService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }

    public bool IsExist(Person person)
    {
        throw new NotImplementedException();
    }
}
