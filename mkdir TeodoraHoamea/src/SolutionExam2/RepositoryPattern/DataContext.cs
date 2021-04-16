using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RepositoryPattern
{
    public class DataContext : DbContext, IUnitOfWork, IDataRepository
    {
        public void Commit()
        {
            SaveChanges();
        }

        public void Delete<Sample>(Sample sapmle) where Sample : class
        {
            Delete(sapmle);
        }

        public Sample Insert<Sample>(Sample sample) where Sample : class
        {
            return Insert(sample);
        }

        public IQueryable<Sample> Query<Sample>() where Sample : class
        {
            return Set<Sample>();
        }

        void IDataRepository.Update<Sample>(Sample sample)
        {
           Update(sample);
        }
    }
}
