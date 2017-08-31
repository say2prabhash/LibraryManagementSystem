using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    class IssueService : IService
    {
        IRepository _shelf;
        RepositoryFactory _factory;
        public IssueService()
        {
            _factory = new RepositoryFactory();
        }
        public bool PerformOperation(Request request)
        {
            throw new NotImplementedException();
        }
        public IRepository GetRepository()
        {
            throw new NotImplementedException();
        }
    }
}
