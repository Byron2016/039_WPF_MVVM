using System.Collections.Generic;
using System.Windows.Input;
using WPF_MVVM.CoreMVVM;
using WPF_MVVM.DAL;
using WPF_MVVM.Models;

namespace WPF_MVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties
        private List<Customer> customers;

        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                if (customers == value)
                {
                    return;
                }
                customers = value;
                OnPropertyChanged("Customers");
            }
        }

        #endregion

        #region Commands

        private ICommand? customerCommand;
        public ICommand CustomerCommand
        {
            get
            {
                if (customerCommand == null)
                {
                    customerCommand = new RelayCommand(param => this.CustomerComandExecute(), null);
                }

                return customerCommand;
            }
        }

        #endregion

        private void CustomerComandExecute()
        {
            var customerService = new CustomerService();

            var result = customerService.GetCustomer();

            Customers = new List<Customer>(result);
        }

    }
}
