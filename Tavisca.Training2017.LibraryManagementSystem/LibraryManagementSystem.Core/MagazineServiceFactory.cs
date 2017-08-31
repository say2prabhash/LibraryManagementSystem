using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    class MagazineServiceFactory
    {
        IService _service;
        public IService RequestedService(RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.Issue:
                    _service = new IssueService();
                    break;
                case RequestType.Return:
                    _service = new ReturnService();
                    break;

            }
            return _service;
        }
    }
}
