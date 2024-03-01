using System;

namespace Interfaces;

internal class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();
        //Demo();

        ICustomerDal[] customerDals = new ICustomerDal[3] 
        {
            new SqlServerCustomerDal(), 
            new OracleServerCustomerDal(),
            new MySqlServerCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }


    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        Customer customer = new Customer();
        customer.Id = 1;
        customer.FirstName = "yunus";
        customer.LastName = "kaya";
        customer.Address = "İstanbul";

        Customer customer2 = new Customer()
        {
            Id = 2,
            FirstName = "Hüseyin",
            LastName = "Kaya",
            Address = "Kayseri"
        };

        Student student = new Student()
        {
            Id = 3,
            FirstName = "Fazlı",
            LastName = "Demir",
            Department = "Computer Engineer"
        };

        PersonManager personManager = new PersonManager();
        personManager.Add(customer);
        personManager.Add(student);

        //PersonManager personManager1 = new PersonManager();
        //personManager1.Add(new Customer { Id=10,FirstName="Hasan",LastName="Kaya", Address="Kayseri"});
    }
}

interface IPerson
{
    // interfaceler yazılırken tamamen methodun imzası void ise void static ise static  dönüş değeri varsa onu yazarız.
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

class PersonManager
{
    // burada direkt olarak bir class vermek yerine onun atasını implemente ettiği interfaci vermek daha büyük kolaylık sağlıyor.
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}