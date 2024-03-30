using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Customer> GetCustomers()
        => CustomerDAO.Instance.GetCustomers();

        //If including a sub entity
        //public List<subCustomer> GetsubCustomers()
        //=> CustomerDAO.Instance.GetsubCustomers();

        public Customer GetCustomerById(int id)
        => CustomerDAO.Instance.GetCustomerById(id);

        public void DeleteCustomer(Customer o)
        => CustomerDAO.Instance.DeleteCustomer(o);

        public void UpdateCustomer(Customer o)
        => CustomerDAO.Instance.UpdateCustomer(o);

        public void SaveCustomer(Customer o)
        => CustomerDAO.Instance.SaveCustomer(o);
    }
}
