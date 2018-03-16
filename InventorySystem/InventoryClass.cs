using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
namespace InventorySystem
{
    class InventoryClass
    {
        public static DataTable StaffTable()
        {
            string Query = "Select * from StaffTable";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
    }
}
