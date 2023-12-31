﻿

using _02_Assignment_Database.Models;
using _02_Assignment_Database.Service;
using System.Diagnostics;

namespace _02_Assignment_Database.MenuSeervice;

internal class CustomerMenu
{
    private readonly CustomerService _customerSerivce;

    public CustomerMenu(CustomerService customerSerivce)
    {
        _customerSerivce = customerSerivce;
    }

  
    //Menu

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
        Console.WriteLine("Street Name: ");
        RegForm.StreetName = Console.ReadLine()!;


        Console.WriteLine("Street Number:");
        RegForm.StreetNumber = Console.ReadLine()!;

   
      
        Console.Write("PostalCode (00000) :");
        if (int.TryParse(Console.ReadLine(), out int postalcode))
        {
            RegForm.PostalCode = postalcode.CompareTo(0);
        }
        else

        Console.WriteLine("Invslied Potalcode");

        Console.WriteLine("City: ");
        RegForm.City = Console.ReadLine()!;
        Console.WriteLine("District: ");
        RegForm.District = Console.ReadLine()!;
        Console.WriteLine("Country: ");
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
        Console.WriteLine("Truck Reg ´Number :");
        RegForm.RegNumber = Console.ReadLine()!;
        Console.WriteLine("Country Registretion Code :");
        RegForm.CountryregCode = Console.ReadLine()!;
        Console.Write("Truck Colour :");
        RegForm.TruckColour = Console.ReadLine()!;
        Console.WriteLine("Truck weight");
        RegForm.Weight = Console.ReadLine()!;
        Console.WriteLine("--------------------------");

        Console.WriteLine("Enter Gods Infotmation");
        Console.WriteLine("Gods type :");
        RegForm.Typeofgods = Console.ReadLine()!;

        try
        {
            var result = await _customerSerivce.CreateCustomerAsync(RegForm);
            if (result)
                Console.WriteLine(" Information saved successfully!");
            else
                Console.WriteLine("Could not creat the customer, try again!");
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }





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
