using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatApi.Data
{
    public interface IGenericRepository<Tent> where Tent : class
    {

        List<Tent> GetAll();
        Tent GetById(int entityid);
        
        void Insert(Tent entity);

        void Update(Tent entity);

        void Delete(int entityId);

        
    }
}
