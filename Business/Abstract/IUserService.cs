using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAllUser();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<User> GetById(int userId);
        IResult Add(User user);
    }
}
