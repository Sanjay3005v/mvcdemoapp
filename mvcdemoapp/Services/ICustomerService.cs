using mvcdemoapp.Models;

namespace mvcdemoapp.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer? GetCustomerById(int pid);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
