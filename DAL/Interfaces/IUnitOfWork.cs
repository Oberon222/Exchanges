using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Exchange> ExchangeRepos { get; }

        void Save();
    }
}
