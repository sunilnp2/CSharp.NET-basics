using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static List<Person> people = new List<Person>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create Person");
            Console.WriteLine("2. Read Person");
            Console.WriteLine("3. Update Person");
            Console.WriteLine("4. Delete Person");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreatePerson();
                    break;
                case "2":
                    ReadPerson();
                    break;
                case "3":
                    UpdatePerson();
                    break;
                case "4":
                    DeletePerson();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreatePerson()
    {
        Person person = new Person();
        Console.Write("Name: ");
        person.Name = Console.ReadLine();
        Console.Write("Age: ");
        person.Age = int.Parse(Console.ReadLine());
        people.Add(person);
        Console.WriteLine("Person created successfully.");
    }

    static void ReadPerson()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Person person = people.Find(p => p.Name == name);
        if (person != null)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }

    static void UpdatePerson()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Person person = people.Find(p => p.Name == name);
        if (person != null)
        {
            Console.Write("New name (press enter to keep the same): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                person.Name = newName;
            }
            Console.Write("New age (press enter to keep the same): ");
            string newAgeString = Console.ReadLine();
            if (!string.IsNullOrEmpty(newAgeString))
            {
                person.Age = int.Parse(newAgeString);
            }
            Console.WriteLine("Person updated successfully.");
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }

    static void DeletePerson()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Person person = people.Find(p => p.Name == name);
        if (person != null)
        {
            people.Remove(person);
            Console.WriteLine("Person deleted successfully.");
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }
}
