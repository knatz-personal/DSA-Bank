using System;
using System.Collections;
using System.Linq;

namespace DataAccess.Reposiitories
{
    internal interface IFiltereable<T>
    {
        

        IQueryable<T> FileredList(int id);

        IQueryable<T> FileredList(string key);

        IQueryable<T> FileredList(DateTime start, DateTime end);

        IQueryable<T> FileredList(IEnumerable keys);


    }
}