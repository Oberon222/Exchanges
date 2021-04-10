using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private ExchangeModel context = new ExchangeModel();
        private GenericRepository<Exchange> exchangeRepository;

        public GenericRepository<Exchange> ExchangeRepos
        {
            get
            {
                // repository lazy loading
                if (this.ExchangeRepos == null)
                {
                    this.exchangeRepository = new GenericRepository<Exchange>(context);
                }
                return exchangeRepository;
            }
        }

        

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
