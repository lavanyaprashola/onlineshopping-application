using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class paymenu : Ordermenu
    {
        OrderBo o= new OrderBo();
        public void paydetails() {
            int DISCOUNT;
            List<Order> admin = o.GetAllcart();

            foreach (var item in OrderBo.orderList)
                Console.WriteLine(item);
            Console.ReadLine();
            Ordermenu ordermenu = new Ordermenu();
            Console.WriteLine("enter your quantity in Traditional");
            int quantity1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your quantity in western");
            int quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your quantity in casual");
            int quantity3 = Convert.ToInt32(Console.ReadLine());
            int quantityCost = ((quantity1 * 300) + (quantity2 * 500) + (quantity3 * 250));
            Console.WriteLine();
            Console.WriteLine("availble texture are 1--->warm 2---->shinny 3-->trasperant 4---->rough ");
            Console.WriteLine("enter your texture type");
            int texture = Convert.ToInt32(Console.ReadLine());

            if (texture == 1 || texture == 2 || quantityCost < 2000)

            {
                DISCOUNT = 5;

                int totalCost = ((quantityCost * DISCOUNT) / 100);
                int PayAmount = (totalCost - quantityCost);
                Console.WriteLine("******you get 5% discount*****");
                Console.WriteLine($"*********YOU DISCOUNT IS { totalCost}***********");
                Console.WriteLine($"**********YOU NEED TO PAY ONLY{PayAmount}*********");
                payment();
            }

            else if ((texture == 2 || texture == 3) || quantityCost < 4000)
            {
                DISCOUNT = 10;



                int totalCost = ((quantityCost * DISCOUNT) / 100);
                int PayAmount = (totalCost - quantityCost);
                Console.WriteLine("**********you get 10% discount*********");
                Console.WriteLine($"*********YOU DISCOUNT IS { totalCost}***********");
                Console.WriteLine($"**********YOU NEED TO PAY ONLY{PayAmount}*********");
                payment();
            }
            else if ((texture == 3 || texture == 4) && quantityCost > 7000)
            {
                DISCOUNT = 25;



                int totalCost = ((quantityCost * DISCOUNT) / 100);
                int PayAmount = (totalCost - quantityCost);
                Console.WriteLine("you get 25% discount");
                Console.WriteLine($"*********YOU DISCOUNT IS { totalCost}***********");
                Console.WriteLine($"**********YOU NEED TO PAY ONLY{PayAmount}*********");
                payment();
            }
            else
            {
                Console.WriteLine("ENTER CORRECT DEATILS");
                cart();
            }

        }

        public void payment()
        {
            string opt;
            int pay;

            Console.WriteLine("ENTER BUY FOR CONTINUE AND EXIST FOR  CLOSE  ");
            opt = Console.ReadLine();
            if (opt == "BUY")
            {
                Console.WriteLine(" ENTER METHOD YOU WANT 1.COD 2. DEBIT 3. CREDIT ");
                pay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();

                if (pay == 2 || pay == 3)
                {

                   

                      
                    Console.WriteLine("ENTER  YOUR CARD NUMBER");
                    bool flag = true;
                    while (flag)
                    {
                        string CARDNUM = Console.ReadLine();// phone num input
                        long CARD = CARDNUM.Length;
                        if (CARD == 16)
                        {
                            
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Check your number try again");
                            Console.WriteLine("enter correct card Number:");
                        }
                    }

                    Console.WriteLine("Enter your password:");
                    string Password = Console.ReadLine();
                    bool isValidPassword = PayValidation.ValidatePass(Password);
                    while (isValidPassword == false)
                    {
                        if (!isValidPassword)
                        {
                            Console.WriteLine("Please enter the valid password. ");
                        }
                        Console.WriteLine("Enter your password:");
                        Password = Console.ReadLine();
                        isValidPassword = PayValidation.ValidatePass(Password);
                    }
                }
                else
                {
                    Console.WriteLine();
                    payment();
                }
            }
                Console.WriteLine("Ensure details click ok for place your  order");
                string conclude = Console.ReadLine();
                if (conclude =="ok")
                {
                Console.WriteLine(" your items ---->");
                List<Order> admin =o.GetAllcart();

                    foreach (var item in OrderBo.orderList)
                        Console.WriteLine(item);
                    Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("************Your order is placed!!! it arrived within 7 days************** ");
                Console.WriteLine();
                Console.WriteLine("************THANKS FOR CHOOSING PINKY BOTIQUE************");
                Console.ReadLine();
            }
                else
                {
                    Console.WriteLine(" try again ");
                    payment();
                }
                


        }
    }
    }

