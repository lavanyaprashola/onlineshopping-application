using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class UserMenu : IOrdermenu
    {
        public void DisplayMenu()
        {
            Ordermenu ORDER = new Ordermenu();
            string[][] items = new string[3][];

            items[0] = new string[] { "1.Traditonal:", "  ", "COLLECTIONS---->  SAREES", "COLLECTIONS---->  KURTIES", "COLLECTIONS---->  LEHANGA CHOLI", "COLLECTIONS---->  ANARKALI", "COLLECTIONS---->  SALWAR" };
            items[1] = new string[] { "2.Westeren:", " ", "COLLECTIONS---->  JEANS", "COLLECTIONS---->  FROCK", "COLLECTIONS---->  SKIRTS", "COLLECTIONS---->  JUMPSUITS" };
            items[2] = new string[] { "3.Casual wear:", " ", "COLLECTIONS---->  T-shirts", "COLLECTIONS---->  shorts", "COLLECTIONS---->  TROUSERS" };


            string[] style = new string[] { "AVAILABLE STYLES ARE \n 1----> Traditional \n 2----> western \n 3---->casual wear" };
            foreach (string itemss in style)
            {
                Console.WriteLine(itemss);
            }
            Console.WriteLine();
            Console.WriteLine("*********ENTER --->style <----- FOR SHOW THE  COLLECTION IN STYLES ********");
            int INPUT = Convert.ToInt32(Console.ReadLine());

            if (INPUT == 1)

            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();

                //IMenu();
                Ordermenu ordermenu = new Ordermenu();
                ordermenu.DisplayMenu();
                //  flag = false;


            }

            else if (INPUT == 2)
            {
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();
                ORDER.DisplayMenu();
                //flag = false;

            }
            else if (INPUT == 3)
            {
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();
                ORDER.DisplayMenu();
                // flag = false;

            }


            else
            {
                Console.WriteLine("enter valid credientls");
                //view();
            }

        }

        public void ChooseUserMenu()
        {

            Console.WriteLine("ENTER interest you want \n1---->view the collection /n2----> visit  items in the cart \n--->exit ");
            int need = Convert.ToInt32(Console.ReadLine());
            if (need == 1)
            {
                //view();
                DisplayMenu();
            }
            else if (need == 2)
            {
                Console.WriteLine(" ********NO ITEMS IN CART********");
                ChooseUserMenu();
            }
            else if (need == 3)
            {
                Console.WriteLine("Thank you visit again!!");

            }
            else
            {
                Console.WriteLine("enter valid creadientls");
                ChooseUserMenu();
            }


        }
    }
}