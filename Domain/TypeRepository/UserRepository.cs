using Domain.Context;
using Domain.Entity;
using Domain.Generics;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TypeRepository
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {

        }
    }

}
