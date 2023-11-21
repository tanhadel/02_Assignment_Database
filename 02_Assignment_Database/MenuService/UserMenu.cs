



//{

//    public UserMenu()
//    {
//        string val;

//        do
//        {
//            Console.WriteLine("---------------------------------------");
//            Console.WriteLine("Welcome to the border line");
//            Console.WriteLine("To Cross the border we need the following information from you");
//            Console.WriteLine("1: To File the information below press one");
//            Console.WriteLine("2: If you need personal service press two");
//            Console.WriteLine("3: If you do not have the information press three");
//            Console.WriteLine("-------------------------------------------");

//            val = Console.ReadLine()!;
//            switch (val)
//            {
//                case "1":
//                    Console.WriteLine("You chose to file the information below.");

//                    Console.Write("Enter Driver Info: ");
//                    string driverInfo = Console.ReadLine()!;

//                    Console.Write("Enter Address Info: ");
//                    string driverAddressInfo = Console.ReadLine()!;

//                    Console.Write("Enter Company Info: ");
//                    string companyInfo = Console.ReadLine()!;

//                    Console.Write("Enter Truck Info: ");
//                    string userTruckInfo = Console.ReadLine()!;

//                    Console.Write("Enter Goods Info: ");
//                    string userGoodsInfo = Console.ReadLine()!;

//                    using (var context = new DataContext())
//                    {
//                        var driverInfoEntity = new DriverInfoEntity
//                        {
//                            DriverInfo = driverInfo,
//                            AddressInfo = driverAddressInfo,
//                            CompanyInfo = companyInfo,
//                            TruckInfo = userTruckInfo,
//                            GodsInfo = userGoodsInfo
//                        };

//                        context.DriverInfo.Add(driverInfoEntity);
//                        context.SaveChanges();

//                    }
//                    break;

//                case "2":
//                    Console.WriteLine("if you need personal service,");
//                    Console.WriteLine("Please visit the service center for personal assistance.");
//                    break;

//                case "3":
//                    Console.WriteLine("You chose to exit the program.");
//                    Environment.Exit(0);
//                    break;

//                default:
//                    Console.WriteLine("Your selection was invalid. Try again ;)");
//                    break;
//            }

//            Console.WriteLine("Press any key to continue...");
//            Console.ReadKey();

//        }
//        while (true);
//    }
//}


//using _02_Assignment_Database.Enitities;
//using Microsoft.EntityFrameworkCore;
//namespace _02_Assignment_Database.MenuSeervice;


//public  UserMenu()
//{
//    string val;

//    do
//    {
//        Console.WriteLine("---------------------------------------");
//        Console.WriteLine("Welcome to the border line");
//        Console.WriteLine("To Cross the border we need the following information from you");
//        Console.WriteLine("1: To File the information below press one");
//        Console.WriteLine("2: If you need personal service press two");
//        Console.WriteLine("3: If you do not have the information press three");
//        Console.WriteLine("-------------------------------------------");

//        val = Console.ReadLine()!;
//        switch (val)
//        {
//            case "1":
//                Console.WriteLine("You chose to file the information below.");

//                Console.Write("Enter Driver Info: ");
//                string driverInfo = Console.ReadLine()!;

//                Console.Write("Enter Address Info: ");
//                string driverAddressInfo = Console.ReadLine()!;

//                Console.Write("Enter Company Info: ");
//                string companyInfo = Console.ReadLine()!;

//                Console.Write("Enter Truck Info: ");
//                string userTruckInfo = Console.ReadLine()!;

//                Console.Write("Enter Goods Info: ");
//                string userGoodsInfo = Console.ReadLine()!;

//                // Visa formuläret
//                DisplayForm(driverInfo, driverAddressInfo, companyInfo, userTruckInfo, userGoodsInfo);

//                break;

//            case "2":
//                Console.WriteLine("if you need personal service,");
//                Console.WriteLine("Please visit the service center for personal assistance.");
//                break;

//            case "3":
//                Console.WriteLine("You chose to exit the program.");
//                Environment.Exit(0);
//                break;

//            default:
//                Console.WriteLine("Your selection was invalid. Try again ;)");
//                break;
//        }

//        Console.WriteLine("Press any key to continue...");
//        Console.ReadKey();

//    } while (true);
//}

//private void DisplayForm(string driverInfo, string driverAddressInfo, string companyInfo, string userTruckInfo, string userGoodsInfo)
//{
//    // Visa formuläret här med hjälp av Console.WriteLine och Console.ReadLine
//    Console.WriteLine("************ Information Form ************");
//    Console.WriteLine($"Driver Info: {driverInfo}");
//    Console.WriteLine($"Address Info: {driverAddressInfo}");
//    Console.WriteLine($"Company Info: {companyInfo}");
//    Console.WriteLine($"Truck Info: {userTruckInfo}");
//    Console.WriteLine($"Goods Info: {userGoodsInfo}");
//    Console.WriteLine("******************************************");

//    // Lägg till eventuell ytterligare logik för att hantera formuläret eller spara informationen
//    // Exempel: spara informationen i en databas
//    using (var context = new DataContext())
//    {
//        var driverInfoEntity = new DriverInfoEntity
//        {
//            DriverInfo = driverInfo,
//            AddressInfo = driverAddressInfo,
//            CompanyInfo = companyInfo,
//            TruckInfo = userTruckInfo,
//            GodsInfo = userGoodsInfo
//        };

//        context.DriverInfo.Add(driverInfoEntity);
//        context.SaveChanges();

//        Console.WriteLine("Information saved successfully!");

//using _02_Assignment_Database.Enitities;

//DriverInfoEntity driverInfoEntity = new DriverInfoEntity();
//AddressEntity addressEntity = new AddressEntity();
//CompanyInfoEntity companyInfoEntity = new CompanyInfoEntity();
//TruckInfoEntity truckInfoEntity = new TruckInfoEntity();
//GodsInfoEntity godsInfoEntity = new GodsInfoEntity();
//    }
//}

using _02_Assignment_Database.ConTexts;
using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_Assignment_Database.MenuSeervice
{
    internal class UserMenu
    {
        private readonly CustomerMenu _customerMenu;

        public UserMenu(CustomerMenu customerMenu)
        {
            _customerMenu = customerMenu;
        }

        public async Task BorderMainMenu()                                                           
        {

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Welcome to the border line");
                Console.WriteLine("To Cross the border we need the following information from you");
                Console.WriteLine("1: Press 1 to fill in the forme");
                Console.WriteLine("2: press 2 to list all customer");
                Console.WriteLine("3: press 3 If you need personal service ");
                Console.WriteLine("0: press 0 to exit the program");
                Console.WriteLine("-------------------------------------------");

                var option = Console.ReadLine()!;
                switch (option)
                {
                    case "1":

                        await _customerMenu.CreateAsync();

                        break;

                    case "2":
                        await _customerMenu.ListAllAsync();

                        break;
                    case "3":
                       
                        Console.WriteLine("Go to gauge number 3 to get personal service");
                        
                        break;
                    case "0":
                      
                        Console.WriteLine("You chose to exit the program .");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Your selection was invalid. Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            } while (true);
        }




        private void DisplayForm(
            DriverInfoEntity driverInfoEntity,
            AddressEntity addressEntity,
            CompanyInfoEntity companyInfoEntity,
            TruckInfoEntity truckInfoEntity,
            GodsInfoEntity godsInfoEntity)
        {
            Console.WriteLine("************ Information Form ************");
            Console.WriteLine($"Driver Info: {driverInfoEntity.Titel} {driverInfoEntity.FirstName} {driverInfoEntity.LastName}");
            Console.WriteLine($"Address Info: {addressEntity.StreetName} {addressEntity.StreetNumber}, {addressEntity.PostalCode} {addressEntity.City}, {addressEntity.District}, {addressEntity.Country}");
            Console.WriteLine($"Company Info: {companyInfoEntity.CompanyName}, Reg: {companyInfoEntity.Companyreg}, Tax: {companyInfoEntity.TaxNumber}");
            Console.WriteLine($"Truck Info: {truckInfoEntity.RegNumber}, {truckInfoEntity.CountryregCode}, Color: {truckInfoEntity.TruckColour}, Weight: {truckInfoEntity.Weight}");
            Console.WriteLine($"Goods Info: {godsInfoEntity.Typeofgods}");
            Console.WriteLine("******************************************");

            //using (var context = new DataContext())
            using (var context = new DataContext())
            {
                var driverInfo = new DriverInfoEntity
                {
                    Titel = driverInfoEntity.Titel,
                    FirstName = driverInfoEntity.FirstName,
                    LastName = driverInfoEntity.LastName,
                    PhoneNumber = driverInfoEntity.PhoneNumber,

                };

                context.DriverInfo.Add(driverInfo);
                try
                {
                    context.SaveChanges();
                    Console.WriteLine("Information saved successfully!");
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                }
            }
        }

    }


}


















