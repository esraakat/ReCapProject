using Core.DataAccess.EntityFamework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cus in context.Customers
                             join u in context.Users
                             on cus.UserId equals u.UserId

                             select new CustomerDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = cus.CompanyName,
                             };

                return result.ToList();
            }

            

        }
    }
}
