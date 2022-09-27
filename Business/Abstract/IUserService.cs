using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        IDataResult<List<UserDetailDto>> GetAll();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string mail);
    }

}
