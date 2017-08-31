using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Implementation
{
    class MagazineRepositoryManager:IRepositoryManager
    {
        MagazineServiceFactory _factory;
        public MagazineRepositoryManager()
        {
            _factory = new MagazineServiceFactory();
        }
        public void ServeRequest(Request request)
        {
            _service = _factory.RequestedService(request.TypeofRequest);
            _service.PerformOperation(request);
        }
    }
}
