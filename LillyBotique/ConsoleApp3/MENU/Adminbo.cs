using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class AdminBo
    {
        public static List<Admin> adminList = new List<Admin>();

        // Create a new User
        public bool CreateNewRoute(string COLLECTIONS, string FABRIC, string COLOR, string SIZE, string BRAND)
        {
            Admin admin = FindItems(BRAND);
            if (admin == null)
            {
                admin = new Admin(COLLECTIONS, FABRIC, COLOR, SIZE, BRAND);
                adminList.Add(admin);
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Admin> GetAllItems()
        {

            if (adminList.Count == 0)
            {
                Console.WriteLine("No items Avaiable..");
                return null;
            }
            else
            {
                return adminList;
            }
        }
        public bool UpdateItems(string BRAND, string COLLECTIONS, string FABRIC, string COLOR, string SIZE)
        {
            Admin admin = FindItems(BRAND);
            Console.WriteLine("Existing ITEMS Details");
            Console.WriteLine(admin);
            if (admin != null)
            {
                Admin temUer = admin;
                admin.Collections = COLLECTIONS;
                admin.Fabric = FABRIC;
                admin.Color = COLOR;
                admin.Size = SIZE;
                admin.Brand = BRAND;
                adminList.Remove(temUer);
                adminList.Add(admin);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteItems(string BRAND)
        {
            Admin admin = FindItems(BRAND);
            if (admin != null)
            {
                adminList.Remove(admin);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Admin FindItems(string BRAND)
        {
            var admin = (from k in adminList
                         where k.Brand == BRAND
                         select k).FirstOrDefault();
            return admin;
        }
    }
}
