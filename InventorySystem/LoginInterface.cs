using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    interface LoginInterface
    {
        void onUserLogin();
        void onUserFailToLogin(string message);
    }
}
