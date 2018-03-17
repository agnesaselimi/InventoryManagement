using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;


namespace InventorySystem
{
    class ConnectionString
    {
        public static SqlConnection My_Sql_Connection;
        public static SqlConnection GetConnection()
    {

        if (My_Sql_Connection == null)
        {
            My_Sql_Connection = new SqlConnection();
            My_Sql_Connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Gent Berani\Desktop\InventorySystem\InventorySystem\DBInventory.mdf;Integrated Security=True;User Instance=True";
                
                Console.WriteLine("Coonnection string:::"+ My_Sql_Connection.ConnectionString);



                My_Sql_Connection.Open();
        }
        return My_Sql_Connection;
    }
    }
}
