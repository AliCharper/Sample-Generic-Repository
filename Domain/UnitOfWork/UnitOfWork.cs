using Domain.Context;
using Domain.Interfaces;
using Domain.TypeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext context;
        public IUserRepository Users { get; private set; }
        public UnitOfWork(ApplicationContext context)
        {
            this.context = context;
            Users = new UserRepository(this.context);
        }
        
        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
