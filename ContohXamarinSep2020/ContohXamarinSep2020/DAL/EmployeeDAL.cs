using ContohXamarinSep2020.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContohXamarinSep2020.DAL
{
    public class EmployeeDAL
    {
        private SQLiteConnection conn;
        public EmployeeDAL()
        {
            DataAccess da = new DataAccess();
            conn = da.GetConnection();
            conn.CreateTable<Employee>();
        }

        public IEnumerable<Employee> GetAll()
        {
            /*string strSql = @"select * from Employee order by EmpName asc";
            var results = conn.Query<Employee>(strSql);*/
            var results = from e in conn.Table<Employee>()
                          orderby e.EmpName
                          select e;

            return results;
        }

        public int Insert(Employee emp)
        {
            return conn.Insert(emp);
        }

        public int Edit(Employee emp)
        {
            return conn.Update(emp);
        }

        public int Delete(Employee emp)
        {
            return conn.Delete(emp);
        }
    }
}
