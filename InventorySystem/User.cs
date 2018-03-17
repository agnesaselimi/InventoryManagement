﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    abstract class User : Person
    {
    
        public string username;
        public string password;

        public override Role getRole()
        {
            return Role.Moderator;
        }
    }

}
