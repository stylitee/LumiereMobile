
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumiere.Model
{
    public class Users
    {
        [PrimaryKey,AutoIncrement]
        public int user_id { get; set; }
        [MaxLength(50)]
        public string fullName { get; set; }
        [MaxLength(5)]
        public string isVerified { get; set; }
        [MaxLength(20)]
        public string balance { get; set; }
        [MaxLength(50)]
        public string password { get; set; }
        [MaxLength(50)]
        public string address { get; set; }
        [MaxLength(15)]
        public string phoneNumber { get; set; }
    }
}
