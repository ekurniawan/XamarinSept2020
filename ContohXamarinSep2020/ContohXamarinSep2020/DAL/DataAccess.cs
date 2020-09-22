using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using Xamarin.Essentials;

namespace ContohXamarinSep2020.DAL
{
    public class DataAccess
    {
        //membuat database sqlite
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlConn;
            var dbName = "sampledb.db3";
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, dbName);
            sqlConn = new SQLiteConnection(dbPath);
            return sqlConn;
        }

        public DataAccess()
        {
        }
    }
}
