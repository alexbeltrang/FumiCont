using FumiCont.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Database
{
    public class DatabaseHelper
    {
        private static string NameDatabase = FunctionsEncrip.Cifrado(2, ConfigurationManager.AppSettings["NameLDB"]);
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, NameDatabase);
        public static bool Insert<T>(T item)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Insert(item);
                if (rows > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool Insert<T>(T item, out T objetoaux)
        {
            bool result = false;
            T objeto = default(T);
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Insert(item);
                if (rows > 0)
                {
                    objeto = item;
                    result = true;
                }
            }
            objetoaux = objeto;
            return result;
        }


        public static bool Create<T>()
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                try
                {
                    conn.CreateTable<T>();
                    result = true;
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    result = false;
                }

            }
            return result;
        }

        public static bool Drop<T>()
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                try
                {
                    conn.DropTable<T>();
                    result = true;
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    result = false;
                }

            }
            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Update(item);
                if (rows > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Delete(item);
                if (rows > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public static List<T> Read<T>() where T : new()
        {
            List<T> items;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                items = conn.Table<T>().ToList();

            }
            return items;
        }


    }
}
