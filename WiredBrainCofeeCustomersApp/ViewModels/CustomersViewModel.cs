using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCofeeCustomersApp.Models;


namespace WiredBrainCofeeCustomersApp.ViewModels
{

    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private Customer? _selectedCustomer;

        public CustomersViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
        }

        public ObservableCollection<Customer> Customers { get; set; } = new();

        public Customer? SelectedCustomer { 
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                RaisePropertyChanged();
            }
            
        }

        public async Task LoadAsync()
        {
            if (Customers.Any())
            {
                return;
            }

            var customers = await _customerDataProvider.GetAllAsync();
            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    Customers.Add(customer);
                }
            }

        }

        internal void Add()
        {
            var customer = new Customer { FirstName = "New" };
            Customers.Add(customer);
            SelectedCustomer = customer;
        }
        
       
    }
}
