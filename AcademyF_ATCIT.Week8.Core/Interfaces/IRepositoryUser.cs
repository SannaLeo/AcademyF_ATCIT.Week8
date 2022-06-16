using AcademyF_ATCIT.Week8.Core.Entities;
using AcademyF_ATCIT.Week8.Core.Interfaces;

namespace AcademyF_ATCIT.Week8.Core.Interfaces
{
    public interface IRepositoryUser : IRepository<User>
    {
        User GetByUserName(string userName);
    }
}