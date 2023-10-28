using bookApp.Models;
using LibApp.Models;

namespace bookApp.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }

        public RandomBookViewModel()
        {
    
        }
    }
}
