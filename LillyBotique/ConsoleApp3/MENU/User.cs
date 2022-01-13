using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MENU
{
    class User
    {
        public static bool flag = true;
        AdminMenu adminmenu = new AdminMenu();
        UserMenu usermenu = new UserMenu();
        MainMenu mainmenu = new MainMenu();
        public void Login(string EmailID, string Password, List<UserBO> userList)
        {
            //try
            //{
            if (EmailID == "PINKY123" && Password == "123@P")
            {
                Console.WriteLine("*****WELCOME ADMIN ! YOU LOGIN SUCESSFULLY *****....");

                adminmenu.DisplayMenu();


            }

            else if (userList.Count > 0)
            {
                foreach (UserBO user in userList)
                {
                    if (user.Email1.Equals(EmailID) && user.Password1.Equals(Password))
                    {
                        Console.WriteLine("LOGIN SUCESSFULLY!!!! click enter for continue!!...");
                        Console.WriteLine();
                        Console.ReadLine();
                        //usermenu.ChooseUserMenu();
                        usermenu.ChooseUserMenu();
                    }

                    else
                    {
                        Console.WriteLine("SORRY TRY AGAIN !!!");
                        mainmenu.SigninORSignup();
                    }

                }
            }
            else
            {
                Console.WriteLine("Invalid User Details");
                Console.Write("********SORRY !!! YOU DON'T HAVE A ACCOUNT IN PINKY **********");

                Console.Write("********YOU HAVE TO CREATE A NEW ACCOUNT *******");
                Console.WriteLine();
               
                mainmenu.SigninORSignup();

            }
           
        }

        public UserBO Register(string userName, string userMail, string password)
        {
            UserBO newuser = new UserBO(userName, userMail, password);
            return newuser;
        }
        public string CheckUser(string EmailID, List<UserBO> userList)
        {
            try
            {

                foreach (UserBO user in userList)
                {
                    if (user.Username1.Equals(EmailID))
                    {
                        Console.WriteLine(" ****HI CUSTOMER !!!THIS ACCOUNT IS ALREADY EXIST CHOOSE SIGIN OPTION***** ");
                        
                        mainmenu.SigninORSignup();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
                mainmenu.SigninORSignup();
            }

            return EmailID;

        }
    }
}
