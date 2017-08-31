using LibraryManagementSystem.Core.Contracts;
using LibraryManagementSystem.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    class RepositoryManagerFactory
    {
        IRepositoryManager manager;
        public IRepositoryManager ProvideServiceManager(ProductType item)
        {
          
            switch(item)
            {
                case ProductType.Book:
                    manager = new BookRepositoryManager();
                    break;
                case ProductType.Magazine:
                    manager = new MagazineRepositoryManager();
                    break;
            }
            return manager;
        }
    }
}
