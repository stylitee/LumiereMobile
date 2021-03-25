using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumiere.Model
{
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int transaction_id { get; set; }
        [MaxLength(20)]
        public string date { get; set; }
        [MaxLength(30)]
        public string time { get; set; }
        [Indexed]
        public int user_id { get; set; }
        [MaxLength(250)]
        public string description { get; set; }
    }
}
