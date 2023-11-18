

using _02_Assignment_Database.Enitities;
using _02_Assignment_Database.Models;
using _02_Assignment_Database.Repository;
using System.Diagnostics;

namespace _02_Assignment_Database.Service;

internal class CustomerService

{
    private readonly AddressRepository _addressRepository;
    private readonly CustomerRepository _customerRepository;
    private readonly CompanyInfoRepository _companyInfoRepository;
    private readonly DriverInfoRepository _driverInfoRepository;
    private readonly GodsInforRepository _godsInforRepository;
    private readonly TruckInfoRepository _truckInfoRepository;




    public CustomerService(AddressRepository addressRepository, CustomerRepository customerRepository, CompanyInfoRepository companyInfoRepository, DriverInfoRepository driverInfoRepository, GodsInforRepository godsInforRepository, TruckInfoRepository truckInfoRepository)
    {
        _addressRepository = addressRepository;
        _customerRepository = customerRepository;
        _companyInfoRepository = companyInfoRepository;
        _driverInfoRepository = driverInfoRepository;
        _godsInforRepository = godsInforRepository;
        _truckInfoRepository = truckInfoRepository;
    }

    public async Task<bool> CreateCustomerAsync(CustomerRegForm regForm)
    {



        if (await _customerRepository.ExistsAsync(x => x.LastName == regForm.LastName))

        {

            AddressEntity addressEntity = await _addressRepository.GetAsync(x => x.StreetName == regForm.StreetName && x.streetNumber == regForm.StreetNumber);
            addressEntity ??= await _addressRepository.CreateAsync(new AddressEntity { StreetName = regForm.StreetName,StreetNumber =regForm.StreetNumber, PostalCode = regForm.PostalCode, District = regForm.District, City=regForm.City,Country=regForm.Country});
        

        //AddressEntity addressEntity = await _addressRepository.GetAsync(x => x.StreetName == regForm.StreetName && PostalCode ==regForm.PostalCode );
        //    //if (addressEntity == null)
            //    addressEntity = await _addressRepository.CreateAsync(new AddressEntity {  });



            // Nu kan du använda addressEntity som behövs i din kod



            //create 
            CreateCustomerEntity createCustomerEntity = await _customerRepository.CreateAsync(new CreateCustomerEntity {FirstName= regForm.FirstName,LastName= regForm.LastName,PhoneNumber =regForm.PhoneNumber,
              StreetName=regForm.StreetName,StreetNumber=regForm.StreetNumber,PostalCode=regForm.PostalCode,
              City=regForm.City,District=regForm.District,Country=regForm.Country,CompanyName=regForm.CompanyName,
              Companyreg=regForm.Companyreg,TaxNumber=regForm.TaxNumber,CompanyAddress=regForm.CompanyAddress,
              RegNumber=regForm.RegNumber,CountryregCode=regForm.CountryregCode,
              TruckColour=regForm.TruckColour,Weight=regForm.Weight,Typeofgods=regForm.Typeofgods});
            if (createCustomerEntity != null)
                return true;
        }

        return false;
        
    }

  public async Task<IEnumerable<CreateCustomerEntity>> GetAllAsync()
    {
        try
        {
            var customer = await _customerRepository.GetAllAsync();
            return customer!;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null! ;
    }
}







   //if (addressEntity == null)
   //         {
   //             addressEntity = new AddressEntity
   //             {
   //                 StreetName = regForm.StreetName,
   //                 StreetNumber = regForm.StreetNumber,
   //                 PostalCode = regForm.PostalCode,
   //                 City = regForm.City,
   //                 District = regForm.District,
   //                 Country = regForm.Country
   //             };
   //         }