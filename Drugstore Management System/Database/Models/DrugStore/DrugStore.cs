using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drugstore_Management_System.Database.Models.Medicines;
using Drugstore_Management_System.Database.Models.Users;

namespace Drugstore_Management_System.Database.Models.DrugStore
{
    internal class DrugStore
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adrress { get; set; }
        public List<Medicine> medicines { get; set; }
        public Owner Owner { get; set; }
        public List<Pharmacist> Pharmacists { get; set; }
        public DrugStore(string name, string description, string adrress, List<Medicine> medicines, Owner owner, List<Pharmacist> pharmacists)
        {
            Name = name;
            Description = description;
            Adrress = adrress;
            this.medicines = medicines;
            Owner = owner;
            Pharmacists = pharmacists;
        }
    }
}
