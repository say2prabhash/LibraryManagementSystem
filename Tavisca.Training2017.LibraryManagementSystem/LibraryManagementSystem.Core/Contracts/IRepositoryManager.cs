﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    interface IRepositoryManager
    {
        void ServeRequest(Request request);
    }
}
