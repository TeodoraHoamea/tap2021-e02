using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RepositoryPattern;

namespace Sample
{
    public class Sample : IDataRepository, IUnitOfWork
    {
        private DataContext dataContext = new DataContext();
        
        public void Commit()
        {
            dataContext.SaveChanges();
        }

        public void Delete<Sample>(Sample entity) where Sample : class
        {
            throw new NotImplementedException();
        }

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
