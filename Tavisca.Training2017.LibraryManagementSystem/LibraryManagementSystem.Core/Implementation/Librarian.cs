using LibraryManagementSystem.Core.Contracts;
using LibraryManagementSystem.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    public class Librarian
    {
        IRepositoryManager _repositoryManager;
        RepositoryManagerFactory _repositoryManagerFactory;
        public Librarian()
        {
            _repositoryManagerFactory = new RepositoryManagerFactory();
        }
      
        public void ServeRequest(Request request)
        {
            _repositoryManager=_repositoryManagerFactory.ProvideServiceManager(request.Item.Type);
            _repositoryManager.ServeRequest(request);
        }
       
    }
}
