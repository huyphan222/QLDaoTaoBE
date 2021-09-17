using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL
{
    public class BaseConnection
    {
        protected IDbConnection connection;
        public BaseConnection()
        {
            string connectString = @"Data Source=LAPTOP-0RDE9RCI\SQLEXPRESS;Initial Catalog=QLDaoTao;Integrated Security=True";
            connection = new SqlConnection(connectString);
        }
    }
}
