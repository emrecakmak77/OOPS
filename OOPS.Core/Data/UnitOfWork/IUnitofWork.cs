using Microsoft.EntityFrameworkCore;
using OOPS.Core.Data.Repository;
using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Core.Data.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity<int>;
        int SaveChanges();
    }
}
