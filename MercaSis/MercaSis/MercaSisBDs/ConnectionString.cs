using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisBDs
{
    public class ConnectionString
    {
        //public string strConn = "Data Source=srv-acd-sql;Initial Catalog=MercaSis;User ID=scie;Password=***********";
        //public string strConn = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + "C:\\Arquivos de programas\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\MercaSis.mdf" + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
        public string strConn = @"Data Source=MICHAEL-PC\SQLEXPRESS;Initial Catalog=MerceSis;User ID=sa;Password=123456";
    }
}
