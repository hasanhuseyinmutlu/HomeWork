// See https://aka.ms/new-console-template for more information
//Reusability
using Entities.Concrete;
using Business.Concrete;
using Business.Adapters;

string message = "Hello, World!";
Console.WriteLine(message);
//Console.ReadLine();
topla(5,7);
static void topla (int x, int y)
{
    int sonuc = x + y;
    Console.WriteLine($"sonuc = {sonuc}");
}

Person person0 = new Person
{
    NationalIdentity = 0101,
    FirstName = "Hasan",
    LastName = "Mutlu",
    DateOfBirthYear = 0101
};

PttManager pttManager = new PttManager(new CitizenManager(new MernisServiceAdapter()));
pttManager.GiveMask(person0);

CitizenManager citizen = new CitizenManager(new MernisServiceAdapter());
citizen.ApplyForMask(person0);

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1231566";
customer1.FirstName = "Hasan";
customer1.LastName = "Mutlu";
customer1.CustomerNumber = "12345";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1651562";
customer2.FirstName = "enis";
customer2.LastName = "Hatip";
customer2.CustomerNumber = "12346";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Mutluio";
customer3.CustomerNumber = "1278984";
customer3.TaxNumber = "12345";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 3;
customer4.Name = "zink";
customer4.CustomerNumber = "1236158";
customer4.TaxNumber = "23195";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

CourseManager courseManager = new CourseManager();
CategoryManager categoryManager = new CategoryManager();


courseManager.Add(new Course {Name = "C#", Description="Sifirdan ileriye", Price = 14 });
courseManager.Add(new Course { Name = "java", Description = "Sifirdan geriye", Price = 41 });
courseManager.GetAll();

courseManager.Delete(3);
courseManager.Update(new Course {Id=0, Name = "Ruby", Description = "Ruby on reils ile e ticaret sitesi",Price =2 });
courseManager.GetAll();

categoryManager.Add(new Category { CategoryName = "Business" });
categoryManager.GetAll();



