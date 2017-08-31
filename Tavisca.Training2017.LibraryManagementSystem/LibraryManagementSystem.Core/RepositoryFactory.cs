using LibraryManagementSystem.Core.Contracts;
using LibraryManagementSystem.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    class RepositoryFactory
    {
        IRepository _repository;
        public IRepository ProvideRepository(ProductType type)
        {
            switch(type)
            {
                case ProductType.Book:
                    _repository = new BookRepository();
                    break;
                case ProductType.Magazine:
                    _repository = new MagazineRepository();
                    break;
            }
            return _repository;
        }
    }
}
