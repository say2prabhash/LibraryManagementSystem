using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Request
    {
        public Product Item { get; }
        public RequestType TypeofRequest { get; }    
    }
}
