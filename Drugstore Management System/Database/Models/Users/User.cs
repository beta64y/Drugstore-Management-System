using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore_Management_System.Database.Models.Users
{
     abstract public class User
    {
        public int Id { get; set; }
        protected int IdCounter { get; set; } = 1;
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Fin { get; set; }
        public User(string name, string surName, string fin)
        {
            Id = IdCounter++;
            Name = name;
            SurName = surName;
            Fin = fin;
        }
        public User(int id, string name, string surName, string fin)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Fin = fin;
        }
    }
}
