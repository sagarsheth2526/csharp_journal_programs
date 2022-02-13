using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace login
{
   class Class1
    {
       public SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\kinjal\C#\login\login\bin\Debug\login.mdf;Integrated Security=True;User Instance=True");
    }
}
