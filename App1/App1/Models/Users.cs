using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Models
{
    class Users
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        public string Login { get; set; }
        public string CachePassword { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }

    }
}
