using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    class Moderator : User
    {
        public override Role getRole()
        {
            return Role.Moderator;
        }
    }
}
