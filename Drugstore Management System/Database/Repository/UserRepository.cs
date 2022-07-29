using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drugstore_Management_System.Database.Models.DrugStore;
using Drugstore_Management_System.Database.Models.Medicines;
using Drugstore_Management_System.Database.Models.Users;


namespace Drugstore_Management_System.Database.Repository
{
    internal class UserRepository
    {
        private static List<User> Users = new List<User>();

        public static void AddOwer(string firstName, string surName, string fin)
        {
            Owner owner = new Owner(firstName, surName, fin);
            Users.Add(owner);

        }
        public static void AddOwer(string firstName, string surName, string fin, int id)
        {
            Owner owner = new Owner(id, firstName, surName, fin);
            Users.Add(owner);

        }
        public static void AddPharmacist(string firstName, string surName, string fin, string experience, string education)
        {
            Pharmacist pharmacist = new Pharmacist(firstName, surName, fin, experience, education);
            Users.Add(pharmacist);

        }
        public static void AddPharmacist(int id, string firstName, string surName, string fin, string experience, string education)
        {
            Pharmacist pharmacist = new Pharmacist(id, firstName, surName, fin, experience, education);
            Users.Add(pharmacist);

        }
        public static List<User> GetUsers()
        {
            return Users;
        }
        public static List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();

            foreach (User user in Users)
            {
                Owner owner = user as Owner;

                if (owner != null)
                {
                    owners.Add(owner);
                }
            }

            return owners;
        }


        public static List<Pharmacist> GetAllPharmacists()
        {
            List<Pharmacist> druggists = new List<Pharmacist>();

            foreach (User user in Users)
            {
                if (user is Pharmacist)
                {
                    druggists.Add((Pharmacist)user);
                }
            }

            return druggists;
        }





    }
}
