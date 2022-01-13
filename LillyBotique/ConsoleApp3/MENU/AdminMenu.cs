using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class AdminMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.Write("Welcome Admin");
            Console.WriteLine("Select the Any Options");
            Console.WriteLine("1.Add Route, 2. Update Route 3. Delete Route 4. Display All Route 5.Exist");
            int adminOption = 0;
            try
            {
                adminOption = Convert.ToInt32(Console.ReadLine());

                // Create Instance user Bo Class to Access Funalities 
                AdminBo adminBo = new AdminBo();
                string COLLECTIONS, FABRIC, COLOR, BRAND, SIZE;
                switch (adminOption)
                {
                    case 1:
                        Console.WriteLine("Enter tITEMS Details");
                        Console.WriteLine("Enter the COLLECTION");
                        COLLECTIONS = Console.ReadLine();
                        Console.WriteLine("Enter the FABRIC");
                        FABRIC = Console.ReadLine();
                        Console.WriteLine("Enter the COLOR");
                        COLOR = Console.ReadLine();
                        Console.WriteLine("Enter the BRAND");
                        BRAND = Console.ReadLine();
                        Console.WriteLine("Enter SIZE");
                        SIZE = Console.ReadLine();
                        bool res = adminBo.CreateNewRoute(COLLECTIONS, FABRIC, COLOR, BRAND, SIZE);

                        if (res)
                        {
                            Console.WriteLine(" items Added SuccessFully");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(" items Not Added SuccessFully... ");
                        }
                        DisplayMenu();
                        break;
                    case 2:
                        Console.WriteLine("Enter the items Details");
                        Console.WriteLine("Enter the COLLECTION");
                        COLLECTIONS = Console.ReadLine();
                        Console.WriteLine("Enter the FABRIC");
                        FABRIC = Console.ReadLine();
                        Console.WriteLine("Enter the COLOR");
                        COLOR = Console.ReadLine();
                        Console.WriteLine("Enter the BRAND");
                        BRAND = Console.ReadLine();
                        Console.WriteLine("Enter the SIZE");
                        SIZE = Console.ReadLine();

                        bool res1 = adminBo.UpdateItems(BRAND, COLLECTIONS, FABRIC, COLOR, SIZE);
                        if (res1) { Console.WriteLine(" ITEMS Updated SuccessFully"); }
                        else
                        {
                            Console.WriteLine(" ITEMS Not Updated SuccessFully - Check the Route Number");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the ITEM No you want to delete : ");
                        BRAND = Console.ReadLine();
                        bool res2 = adminBo.DeleteItems(BRAND);
                        if (res2)
                        {
                            Console.WriteLine("items deleted successfully..");
                        }
                        else
                        {
                            Console.WriteLine("ITEMS not deleted successfully - Check the Route Number..");
                        }
                        DisplayMenu();
                        break;
                    case 4:
                        Console.ReadLine();
                        List<Admin> admin = adminBo.GetAllItems();


                        Console.ReadLine();

                        foreach (var item in AdminBo.adminList)
                        {


                            Console.WriteLine(item);

                        }
                        Console.ReadLine();

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                DisplayMenu();
            }
        }
    }
}

