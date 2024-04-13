using OnlineShopModel;
using System.Collections.Generic;
using UI;

namespace OnlineShopDataServices
{
    public class CustomerDataServices
    {
        List<Customer> DummyCustomer = new List<Customer>();

        public CustomerDataServices()
        {
            List<Customer> DummyCustomer = new List<Customer>();
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            Customer user1 = new Customer
            {
                username = "sellda",
            };

            Customer user2 = new Customer
            {
                username = "meiji",
            };

            Customer user3 = new Customer
            {
                username = "owshi",
            };

            DummyCustomer.Add(user1);
            DummyCustomer.Add(user2);
            DummyCustomer.Add(user3);
        }

        public Customer GetCustomer(string username)
        {
            Customer foundCustomer = new Customer();

            foreach (var customer in DummyCustomer)
            {
                if (username == customer.username)
                {
                    foundCustomer = customer;
                }
            }
            return foundCustomer;
        }
    }
}
