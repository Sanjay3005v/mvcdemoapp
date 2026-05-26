using mvcdemoapp.Models;
using mvcdemoapp.Services;

namespace mvcdemoapp.Services
{ }
public class CustomerService : ICustomerService
{
    private readonly List<Customer> _customers = new List<Customer>
    {
        new Customer
        {
            CustomerId = 1,
            FirstName = "Sanjay",
            LastName = "V",
            PhoneNumber = 987654321,
            Email = "sanjay@gmail.com",
            IsActive=true,
            CreatedAt = new DateOnly(2026, 5, 26)
        },

        new Customer
        {
            CustomerId = 2,
            FirstName = "Rahul",
            LastName = "Sharma",
            PhoneNumber = 987654322,
            Email = "rahul@gmail.com",
            IsActive=true,
            CreatedAt = new DateOnly(2026, 5, 20)
        },

        new Customer
        {
            CustomerId = 3,
            FirstName = "Priya",
            LastName = "Devi",
            PhoneNumber = 987654323,
            Email = "priya@gmail.com",
            IsActive=true,
            CreatedAt = new DateOnly(2026, 5, 15)
        }
    };

    public IEnumerable<Customer> GetAllCustomer()
    {
        return _customers;
    }

    public Customer? GetCustomerById(int id)
    {
        return _customers.FirstOrDefault(c => c.CustomerId == id);
    }

    public void AddCustomer(Customer customer)
    {
        if (customer != null)
        {
            _customers.Add(customer);
        }
    }

    public void UpdateCustomer(Customer customer)
    {
        var existingCustomer =
            _customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);

        if (existingCustomer != null)
        {
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Email = customer.Email;
            existingCustomer.IsActive = customer.IsActive;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
        }
    }

    public void DeleteCustomer(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.CustomerId == id);

        if (customer != null)
        {
            _customers.Remove(customer);
        }
    }
}

