using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Mobile_B_D
{
    public class DB
    {
       private readonly SQLiteConnection conn;

        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Item>();
        }
        public List<Item> GetItems()
        {
            return conn.Table<Item>().ToList();
        }
        public int SaveItem(Item item)
        {
            return conn.Insert(item);
        }

    }
}
