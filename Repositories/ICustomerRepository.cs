using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {

        //Remeber to change interface form private to public

        List<Customer> GetCustomers();

        //If including a sub entity
        //List<subCustomer> GetsubCustomers();

        Customer GetCustomerById(int id);

        void DeleteCustomer(Customer o);

        void UpdateCustomer(Customer o);

        void SaveCustomer(Customer o);
    }
}
