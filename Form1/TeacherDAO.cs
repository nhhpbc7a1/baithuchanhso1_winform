using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class TeacherDAO: PersonDAO
    {
        public TeacherDAO() 
        {
            tableName = "Giaovien";
        }

    }
}
