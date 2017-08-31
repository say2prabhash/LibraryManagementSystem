using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core
{
    public class Library
    {
         Librarian _librarian;

        public void LibraryDesk(Request request)
        {
            _librarian = GetLibrarian();
            _librarian.ServeRequest(request);
        }
        public Librarian GetLibrarian()
        {
            return new Librarian();
        }
    }
}
