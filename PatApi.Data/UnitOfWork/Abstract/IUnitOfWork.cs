using PatApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatApi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Staff> StaffRepository { get; }
        void Complete();
    }
}
