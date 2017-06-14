﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    interface StackInterface
    {
        void Push(int item);
        int Pop();
        int GetMinimumItem();
    }
}
