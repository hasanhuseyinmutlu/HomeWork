using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager:ISupplyService
{
    IPersonService _personService;

    //execute when constructor call
    public PttManager(IPersonService personService)
    {
        _personService = personService;
    }
    public void GiveMask(Person person)
    {
        if (_personService.IsExist(person))
        {
            person.GivenDate = DateTime.Today.ToString("dd/MM/yyyy");

            person.IsMaskGiven = true;

            Console.WriteLine($"{person.FirstName} icin  Maske verildi ");
            
            
        }
        else
        {
            Console.WriteLine($"{person.FirstName} icin Maske VERILMEDI! ");
        }
    }
}
