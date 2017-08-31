using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    interface IService
    {
        bool PerformOperation(Request request);
    }
}
