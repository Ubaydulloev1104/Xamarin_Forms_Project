using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Mobile_B_D
{
    public class Item
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }


    }
}
