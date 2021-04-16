using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new ReCapContext())
            {
                var result = from opClaim in context.OperationClaims
                             join usOpClaim in context.UserOperationClaims
                             on opClaim.Id equals usOpClaim.OperationClaimId
                             where usOpClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = opClaim.Id,
                                 Name = opClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
