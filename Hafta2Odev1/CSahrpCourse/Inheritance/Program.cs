using System;

namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer
            {
                Id = 1,
                FirstName = "Yunus",
                LastName = "Kaya",
                City = "İstanbul"
            },
            new Student
            {
                Id=2,
                FirstName="Student",
                LastName="Student",
                Department ="Accounting"
            },
            new Person
            {
                Id=3,
                FirstName = "human",
                LastName="word"
                
            }
        };

        foreach (Person person in persons)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
// bir tane inheritance önce inheritance sonra interfaceler
class Person 
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}