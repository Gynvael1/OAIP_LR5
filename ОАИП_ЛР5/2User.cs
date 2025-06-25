using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_ЛР5
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Faculty { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public DateTime EntranceDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
