using FirstProject.Models;

namespace FirstProject.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } // just for iterate, list function will not used
        public Customer Customer { get; set; }
    }
}
