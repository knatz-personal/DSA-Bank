using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reposiitories
{
    interface IDataRepository<T>
    {
        IQueryable<T> ListAll();
        void Create(T newItem);
        T Read(T itemToRead);
        void Update(T updatedItem);
        void Delete(T itemToDelete);
    }
}
