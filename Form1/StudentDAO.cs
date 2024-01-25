using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class StudentDAO:PersonDAO
    {
        public StudentDAO() 
        {
            tableName = "hocsinh";
        }
    }
}
