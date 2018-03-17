using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    public enum Role
    {
        Admin,
        Moderator,
        Guest
    }
    abstract class Person
    {
        public String name;
        public String surname;

        public abstract Role getRole();

    }
}
