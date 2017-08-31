using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    interface IRepository
    {
        void Add(Product product);
        bool Remove(Product product);
    }
}
