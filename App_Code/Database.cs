using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Database
/// </summary>
public class Database
{
    string connectionString = "Server='wmaproject.database.windows.net';Database=hlgroup;" +
        "User ID=wmaproject;Password=Password123;";
    public Database()
    {
       
    }

    public SqlConnection getDBConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }
}