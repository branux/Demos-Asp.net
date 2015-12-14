using ObjectdataSource.Data;
using System.Collections.Generic;
using System.Linq;

namespace ObjectdataSource.BLL
{
    public class CustomerBLL
    {

        public IList<string> GetCountries()
        {
            using (var contexto = new NorthWindDataContext())
            {
                return
                    (
                        from c in contexto.Customers
                        select c.Country
                    )
                    .Distinct()
                    .ToList();
            }
        }

        public IList<Customer> GetCustomerByCountry(string country) {
            using (var contexto = new NorthWindDataContext())
            {
                return
                (
                    from c in contexto.Customers
                        where c.Country == country
                    select c

                )
                .ToList();
            }
        }

        public Customer GetCustomerByID(string id)
        {
            using (var contexto = new NorthWindDataContext())
            {
                return 
                    (
                        from c in contexto.Customers
                            where c.CustomerID==id
                        select c
                    )
                    .FirstOrDefault();
            }
        }


    }
}