using Core.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //operetorler
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filtre vermemizi sağlar
        T Get(Expression<Func<T, bool>> filter);                   //filter zorunlu     
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
