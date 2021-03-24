
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lumiere.Model
{
    public class Users
    {
        [PrimaryKey,AutoIncrement]
        public int user_id { get; set; }
        public string name { get; set; }
        [MaxLength(15)]
        public string birthdate { get; set; }
        [MaxLength(5)]
        public string isVerified { get; set; }
        [MaxLength(20)]
        public string balance { get; set; }
        [MaxLength(50)]
        public string password { get; set; }
        [MaxLength(50)]
        public string address { get; set; }
        [MaxLength(15)]
        public string phonenumber { get; set; }
    }
}
