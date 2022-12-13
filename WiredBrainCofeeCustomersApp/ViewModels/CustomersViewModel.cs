using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCofeeCustomersApp.Models;

namespace WiredBrainCofeeCustomersApp.ViewModels
{
    public class CustomersViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

    }
}
