using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter() );
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1999, 3, 12), FirstName = "Ali Sefa", LastName = "AKBULUT", NationalityId = "123" });
        }
    }

    
}