using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore_Management_System.Database.Models.Users
{
    internal class Owner : User
    {
        public Owner( string name, string surName, string fin)
            : base(name, surName, fin) { }
        public Owner(int id, string name, string surName, string fin)
            : base(id, name, surName, fin) { }
    }
}
