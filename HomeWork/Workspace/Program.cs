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