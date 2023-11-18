

using _02_Assignment_Database.Models;
using _02_Assignment_Database.Service;
using _02_Assignment_Database.ServiceRepository;
using Castle.Core.Logging;

namespace _02_Assignment_Database.MenuSeervice;

internal class CustomerMenu
{
    private readonly CustomerService _customerSerivce;

    public CustomerMenu(CustomerService customerSerivce)
    {
        _customerSerivce = customerSerivce;
    }

  

    public async Task CreateAsync()
    {
        var RegForm = new CustomerRegForm();

        Console.WriteLine("You chose to file the information below.");

        Console.Write("Enter Driver Info: ");
        Console.Write("-------------------------");

        Console.Clear();

        Console.Write("Title: ");
        RegForm.Titel = Console.ReadLine()!;
        Console.Write("FirstName: ");
        RegForm.FirstName = Console.ReadLine()!;
        Console.Write("LastName: ");
        RegForm.LastName = Console.ReadLine()!;
        Console.Write("PhoneNumber: ");
        RegForm.PhoneNumber = Console.Read()!;

        Console.WriteLine("Enter the driver's Address");
        Console.WriteLine("-----------------------------------");
        Console.Write("StreetName :");
        RegForm.StreetName = Console.ReadLine()!;
        Console.Write("StreetNumber :");
        RegForm.StreetNumber = Console.ReadLine()!;
        Console.Write("PostalCode (000 00) :");
        if (int.TryParse(Console.ReadLine(), out int postalcode))
        {
            RegForm.PostalCode = postalcode.CompareTo(0);
        }
        else

            Console.WriteLine("Invslied Potalcode");

        Console.Write("City: ");
        RegForm.City = Console.ReadLine()!;
        Console.Write("District: ");
        RegForm.District = Console.ReadLine()!;
        Console.Write("Country: ");
        RegForm.Country = Console.ReadLine()!;

        Console.WriteLine("Enter Conpany Information :");
        Console.WriteLine("----------------------------------");
        Console.Write("Company Name :");
        RegForm.CompanyName = Console.ReadLine()!;
        Console.Write("Company Registreringsnumber");
        RegForm.Companyreg = Console.ReadLine()!;
        Console.WriteLine("Company Tax Number :");
        if (int.TryParse(Console.ReadLine(), out int taxNumber))
        {
            RegForm.TaxNumber = taxNumber.CompareTo(0);
        }
        else
            Console.WriteLine("Invalid taxNumber, try again");

        Console.Write("Enter Truck Information:");
        Console.WriteLine("------------------------");
        Console.Write("Truck Reg ´Number :");
        RegForm.RegNumber = Console.ReadLine()!;
        Console.Write("Country Registretion Code :");
        RegForm.CountryregCode = Console.ReadLine()!;
        Console.Write("Truck Colour :");
        RegForm.TruckColour = Console.ReadLine()!;
        Console.Write("Truck weight");
        RegForm.Weight = Console.ReadLine()!;

        Console.Write("Enter Gods Infotmation");
        Console.Write("--------------------------");
        Console.Write("Gods type :");
        RegForm.Typeofgods = Console.ReadLine()!;

        var result = await _customerSerivce.CreateCustomerAsync(RegForm);
        if (result)
            Console.WriteLine(" Information saved successfully!");
        else
            Console.WriteLine("Could not creat the customer, try again!");





    }

    public async Task ListAllAsync()
    {
        var customers = await _customerSerivce.GetAllAsync();
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName}{customer.City}");
            Console.WriteLine($"{customer.StreetName}{customer.StreetNumber}{customer.City}{customer.Country}");
            Console.WriteLine("");
        }
        Console.ReadKey();
    }


}
