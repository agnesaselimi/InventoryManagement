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
        protected int Id;
        protected String name;
        protected String surname;

        public abstract Role getRole();

    }
}
