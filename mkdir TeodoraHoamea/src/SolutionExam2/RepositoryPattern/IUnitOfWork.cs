using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
