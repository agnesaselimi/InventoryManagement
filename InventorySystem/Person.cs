using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
  
    abstract class Person
    {
        public String name;
        public String surname;

        public abstract UserRole getRole();

    }
}
