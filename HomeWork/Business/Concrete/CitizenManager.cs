using Business.Abstract;
using Business.Adapters;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CitizenManager : IPersonService
{
    private ICitizenCheckService _citizenCheckService;
    public CitizenManager(ICitizenCheckService citizenCheckService) 
    {
        _citizenCheckService = citizenCheckService;
        
    }
    //encapsulatin
    public void ApplyForMask(Person person)
    {
        
        var date = DateTime.Today;
        // convert person given date string to datetime 
        DateTime person_DateTObject = DateTime.Parse(person.GivenDate);
        //calculate date 
        var cDate = date - person_DateTObject ;

        if (cDate.TotalDays > 7)
        {
            person.IsMaskGiven = false;
            Console.WriteLine("maske alinabilir");
        }
        else if(person.IsMaskGiven)
        {
            Console.WriteLine($"Daha once {person.GivenDate} tarihinde maske verildi");
        }
    

    }
    public List<Person> GetList()
    {
        return null;
    }

    public bool IsExist(Person person)
    {
        return _citizenCheckService.CheckCitizen(person);
    }
}
