using AcademyF_ATCIT.Week8.Core.Entities;
using AcademyF_ATCIT.Week8.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.RepositoryMOCK.Repos
{
    public class RepositoryUserMOCK : IRepositoryUser
    {
        List<User> _users = new List<User>
        {
            new User{ Id = 1, UserName = "Leo", Password = "1234"}
        };
        public bool Add(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
