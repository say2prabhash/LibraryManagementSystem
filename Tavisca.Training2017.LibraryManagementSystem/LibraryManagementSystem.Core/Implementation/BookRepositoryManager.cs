using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    public class BookRepositoryManager:IRepositoryManager
    {
        BookServiceFactory _factory;
        IService _service;
        public BookRepositoryManager()
        {
            _factory = new BookServiceFactory();
        }
        public void ServeRequest(Request request)
        {
            _service=_factory.RequestedService(request.TypeofRequest);
            _service.PerformOperation(request);            
        }
    }
}
