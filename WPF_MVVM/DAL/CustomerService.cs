using System;
using System.Collections.Generic;
using WPF_MVVM.Models;

namespace WPF_MVVM.DAL
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomer()
        {
            var customers = new List<Customer>();

            for (int i = 0; i < 20; i++)
            {
                customers.Add(new Customer()
                {
                    ID = i,
                    FistName = Guid.NewGuid().ToString(),
                    SecondName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    IsEnable = i > 10,
                    LastLogin = DateTime.Now.AddDays(i)
                });
            }

            return customers;
        }

    }
}
