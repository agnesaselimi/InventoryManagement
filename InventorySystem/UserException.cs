﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    public class UserException : System.Exception
    {
        public UserException(string text) : base(text) { }
    }
}
