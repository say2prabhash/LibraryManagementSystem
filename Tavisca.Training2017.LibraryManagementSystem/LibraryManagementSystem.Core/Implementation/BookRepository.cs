using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
   public class BookRepository:IRepository
    {
        private static List<Product> _books;
        public void Add(Product book)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Product Book)
        {
            throw new NotImplementedException();
        }
    }
}
