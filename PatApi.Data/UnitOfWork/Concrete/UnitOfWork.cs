using PatApi.Data;
using PatApi.Data;
using PatApi.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatApi.Data.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private bool disposed;
        public IGenericRepository<Staff> StaffRepository { get; private set; }
        public UnitOfWork(AppDbContext context)
        {

            this.context = context;

            StaffRepository = new GenericRepository<Staff>(context);
        }
        public void Complete()
        {
            context.SaveChanges();
        }

      

        protected virtual void Clean(bool disposing) {
        if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();

                }
            
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
        }
    }
}
