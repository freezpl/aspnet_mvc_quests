﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuestDAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);


        //with include
        IEnumerable<T> GetWithInclude(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetWhereWithInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
      
    }
}
