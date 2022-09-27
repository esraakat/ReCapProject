using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {
        public List<UserDetailDto> GetAll()
        {
            using (var context = new RentACarContext())
            {
                var result = from user in context.Users
                             join userOperationClaim in context.UserOperationClaims
                             on user.Id equals userOperationClaim.UserId
                             join operationClaim in context.OperationClaims
                             on userOperationClaim.OperationClaimId equals operationClaim.Id
                             select new UserDetailDto 
                             { 
                                 Email = user.Email, 
                                 FirstName = user.FirstName, 
                                 LastName = user.LastName,
                                 OperationClaim = operationClaim.Name,
                                 Status = user.Status 
                             };
                return result.ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentACarContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim 
                             { 
                                 Id = operationClaim.Id, 
                                 Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
