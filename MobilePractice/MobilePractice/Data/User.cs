using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePractice.Data
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        [Unique]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
