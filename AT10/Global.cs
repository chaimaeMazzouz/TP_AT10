using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AT10
{
    class Global
    {
        public SqlConnection
         banque_connexion = new SqlConnection(@"data source = .\SQLEXPRESS;database=banque;Integrated Security=True");


    }
}
