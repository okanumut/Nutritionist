using Nutritionist.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        object Entity<T>();

        ILoginUsers LoginUsers { get; } 
        IList List { get; } 
        IBaskets Baskets { get; } 

        int Save();
    }
}
