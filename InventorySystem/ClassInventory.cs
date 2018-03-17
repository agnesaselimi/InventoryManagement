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
    class ClassInventory
    {

        private static ClassInventory instance = new ClassInventory();
        private ClassInventory() { }

        public static ClassInventory Instance { get { return instance; } }

        public int InsertCategory(string Category)
        {
            string Query = "Insert into TableCatgory(CategoryName) values('" + Category + "')";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }
        public int InsertCustomer(string Name, string Date, string Email, string Gender, string Address)
        {
            string Query = "Insert into TableCustomer(CustomerName,CustomerDOB,CustomerEmail,CustomerGender,CustomerAddress) values('" + Name + "','" + Date + "','" + Email + "','" + Gender + "','" + Address + "')";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }
        public DataTable TableCustomer()
        {
            string Query = "Select * from TableCustomer";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
        public DataTable ProductCategoryList()
        {
            string Query = "Select CategoryName from TableCatgory";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        public int InsertProduct(string Name, string Cost, string Desc, string Category)
        {
            string Query = "Insert into TableProduct(ProductName,ProductCost,ProductDesc,ProductCategory) values('" + Name + "','" + Cost + "','" + Desc + "','" + Category + "')";

                        Console.WriteLine("Query:::" + Query);


            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }

        public DataTable ProductIDList() 
        {
            string Query = "Select ID from TableProduct";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        public DataTable ProductTable(string ID)
        {
            string Query = "Select * from TableProduct where ID='" + ID + "' ";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        public int UpdateProductTable(string ID, string Name, string Cost, string Desc, string Category)
        {
            string Query = "Update TableProduct set ProductName='" + Name + "',ProductCost='" + Cost + "',ProductDesc='" + Desc + "',ProductCategory='" + Category + "' where ID='" + ID + "'";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }

        public DataTable ProductList()
        {
            string Query = "Select ProductName from TableProduct";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        public int InsertVendor(string Name, string Email, string Address, string Product)
        {
            string Query = "Insert into TableVendor(VendorName,VendorEmail,VendorAddress,VendorProduct) values('" + Name + "','" + Email + "','" + Address + "','" + Product + "')";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            int val = sc.ExecuteNonQuery();
            return val;
        }

        public DataTable VendorTable()
        {
            string Query = "Select * from TableVendor";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        public DataTable ProductTable()
        {
            string Query = "Select * from TableProduct";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        // where ID='" + ID + "' ";
        public DataTable UserTable(string inUsername, string password)
        {
            string Query = "Select * from TableUser WHERE username= '"+inUsername+"' AND password= '"+password+"'";
            SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            MessageBox.Show("count " + dt.Rows.Count);

            if (dt.Rows.Count > 0)
            {
                int idColumn = 0;
                int typeColumn = 5;
                //if(dt.Rows[0][1])
                string name = dt.Rows[0][1].ToString();
                string surnname = dt.Rows[0][2].ToString();
                string username = dt.Rows[0][3].ToString();
                string type = dt.Rows[0][typeColumn].ToString();
                MessageBox.Show("G " + name);

            }
            else
            {

            }

            return dt;
        }


        public DataTable InsertTransaction(string Name,string Date,string Product,string Price,string Quantity,string Total )
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
