using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class PersonDAO
    {
        public string tableName = "";
        public PersonDAO() { }
        DBConnection dbx = new DBConnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM " + tableName);
            return dbx.Load(sqlStr);
        }

        public void Add(Person teacher)
        {
            string sqlStr = string.Format("INSERT INTO "+ tableName + "(Ten , Diachi, CMND ,NgaySinh) VALUES ('{0}', '{1}', '{2}','{3}')", teacher.Name, teacher.Address, teacher.Id, teacher.Birth);
            dbx.Execute(sqlStr, "them");
        }
        public void Delete(Person teacher)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE cmnd = '{0}'", teacher.Id);
            dbx.Execute(SQL, "xoa");
        }

        public void Update(Person teacher)
        {
            string SQL = string.Format("UPDATE " + tableName + " SET Ten = '{0}', DiaChi ='{1}' , NgaySinh ='{2}'  WHERE Cmnd  = '{3}'", teacher.Name, teacher.Address, teacher.Birth, teacher.Id);
            dbx.Execute(SQL, "sua");
        }

    }
}
