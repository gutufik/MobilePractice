using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobilePractice.Data
{
    [Table("Product")]
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
