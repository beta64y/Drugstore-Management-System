using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore_Management_System.Database.Models.Medicines
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool IsPsychotropic { get; set; } = false;
        public Medicine(string name, string description, int price, bool isPsychotropic)
        {
            Name = name;
            Description = description;
            Price = price;
            IsPsychotropic = isPsychotropic;
        }
    }
}
