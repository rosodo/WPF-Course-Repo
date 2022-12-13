using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCofeeCustomersApp.Models;

namespace WiredBrainCofeeCustomersApp
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

}