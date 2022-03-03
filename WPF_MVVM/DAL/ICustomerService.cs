using System.Collections.Generic;
using WPF_MVVM.Models;

namespace WPF_MVVM.DAL
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomer();
    }
}
