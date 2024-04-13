using OnlineShopDataServices;

namespace OnlineShopBusinessServices
{
    public class CustomerServices
    {
        public bool VerifyCustomer(string username)
        {
            CustomerDataServices dataService = new CustomerDataServices();
            var result = dataService.GetCustomer(username);

            return result.username != null ? true : false;
        }
    }
}
