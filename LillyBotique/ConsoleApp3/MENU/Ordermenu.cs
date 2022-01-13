using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class Ordermenu : IOrdermenu
    {

        UserMenu usermenu = new UserMenu();
        // paymenu PAYMENU = new paymenu();
        public void DisplayMenu()
        {
            Console.WriteLine("Hi customer!!!");


            // Create Instance user Bo Class to Access Funalities 
            OrderBo orderbo = new OrderBo();
            string collection;
            string fabric;
            string color;
            string BranD;
            string size;


            Console.WriteLine("enter your collection you want ");
            collection = Console.ReadLine();

            Console.WriteLine();
            List<string> FABRIC = new List<string>() { "FABRIC---->", "cotton", "synthetic", "velvet", "silk" };
            foreach (string F in FABRIC)
            {
                Console.WriteLine(F);
            }
            Console.WriteLine();
            Console.WriteLine("Enter fabrictype  you want : ");
            fabric = Console.ReadLine();

            Console.WriteLine();
            List<string> SIZE = new List<string>() { "List---->", "S", "M", "L", "XL", "XXL" };
            foreach (string S in SIZE)
            {
                Console.WriteLine(S);
            }
            Console.WriteLine();
            Console.WriteLine("Enter  size you want : ");
            size = Console.ReadLine();
            Console.WriteLine();

            List<string> COLOR = new List<string>() { "COLOR-->", "RED", "BLUE", "YELLOW", "BLACK", "GREEN", "PURPLE", "WHITE" };
            Console.WriteLine();
            foreach (string C in COLOR)
            {
                Console.WriteLine(C);
            }
            Console.WriteLine();
            Console.WriteLine("Enter color you want: ");
            color = Console.ReadLine();

            Console.WriteLine();
            List<string> BRAND = new List<string>() { "BranD--->", "EASY BUY ", "TRENDS", "PANTALOONS", "MAX" };

            foreach (string D in BRAND)
            {
                Console.WriteLine(D);
            }
            Console.WriteLine();
            Console.WriteLine("Enter brand  you want: ");
            BranD = Console.ReadLine();

            bool res = orderbo.CreateNewCart(collection, fabric, color, size, BranD);
            if (res)
            {
                Console.WriteLine();
                Console.WriteLine(" ***********ITEMS Added SuccessFully**********");
                Console.WriteLine("your items are--->");
                List<Order> admin = orderbo.GetAllcart();

                foreach (var item in OrderBo.orderList)
                    Console.WriteLine(item);
                Console.WriteLine();
                cart();
                usermenu.DisplayMenu();
            }
            else
            {
                Console.WriteLine(" CART  not Added SuccessFully");
            }
        }
        public void cart()
        {
            OrderBo orderbo = new OrderBo();
            Console.WriteLine("1. order \n2. add morre items");
            try
            {
                int inpu = Convert.ToInt32(Console.ReadLine());
                if (inpu == 1)
                {
                    Console.WriteLine("**********YOUR ORDER IS PLACED *************");
                    Console.WriteLine();
                    Console.WriteLine("GO FOR AN PAYMENT --->");

                    //Console.WriteLine("*******************All the ITEMS are displayed successfully.......****************");

                    Console.WriteLine("==============================================");



                    Console.WriteLine();
                    Console.WriteLine("ensure ,please enter OK for payment");
                    string op = Console.ReadLine();
                    if (op == "OK")
                    {
                        paymenu PAYMENU = new paymenu();
                        Console.WriteLine();
                        PAYMENU.paydetails();
                    }
                    else
                    {
                        Console.WriteLine(" Enter valid creatienls");
                        cart();
                    }

                }
                else if (inpu == 2)
                {
                    usermenu.DisplayMenu();

                }


                else
                {
                    Console.WriteLine("ENTER VALID DETAILS ");
                    cart();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                cart();
            }


        }



    }

}


