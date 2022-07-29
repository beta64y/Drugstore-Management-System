using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drugstore_Management_System.Database.Models.Users;

namespace Drugstore_Management_System.Database.Models.Users
{
    internal class Pharmacist :User
    {
        public string Experience { get; set; }
        public string Education { get; set; }
        public Pharmacist(int id, string name, string surName, string fin)
            : base(id, name, surName, fin) { }
        
    }
}
