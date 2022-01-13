using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.MENU;


namespace ConsoleApp3.MENU
{
    public class MainMenu
    {
        public static string strChoiceReader;
        public static int intChoice;
        static string EmailID, Password, UserName;
        //static string strUserDetails;
        static List<UserBO> userList = new List<UserBO>();
        public void SigninORSignup()
        {

            //User user= new User();
            User user = new User();
            Console.WriteLine();
            Console.WriteLine("     ********************************************************************************************************");
            Console.WriteLine("                                     WELCOME TO PINKY :) BOUTIQUE                                                   ");
            Console.WriteLine();
            Console.WriteLine("                                    !!!!!!  TRY ONCE BUY EVER  !!!!!!                                        ");
            Console.WriteLine("     ********************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("                         HOME                          ");
            Console.WriteLine("==========================================================");
            Console.WriteLine();
            Console.WriteLine("  1->ALREADY HAVE ACCOUNT    \n  2->NEW USER     \n  3->Canel");
            Console.WriteLine();
            //try
            //{
            //strChoiceReader = Console.ReadLine();
            try
            {
                intChoice = Convert.ToInt32(Console.ReadLine());
                //intChoice = InputNotStringCharException.check(strChoiceReader);

                switch (intChoice)
                {
                    case 1:
                        Console.WriteLine("===============================================");
                        Console.WriteLine("                      LOGIN                    ");
                        Console.WriteLine("================================================");
                        Console.WriteLine();
                        Console.WriteLine("Enter your emailID:");
                        EmailID = Console.ReadLine();

                        Console.WriteLine("Enter your password:");
                        Password = Console.ReadLine();

                        user.Login(EmailID, Password, userList);


                        break;
                    case 2:
                        Console.WriteLine("==================================================");
                        Console.WriteLine("                REGISTER ACCOUNT                ");
                        Console.WriteLine("==================================================");
                        //Console.WriteLine("Input Format => Name,Email,Password,User_Type(Admin or User)");
                        Console.WriteLine("Please enter your details for registration");
                        Console.WriteLine();

                        // Validate user details
                        Console.WriteLine("Enter your user name:  EX:Lavanya123(length 5-11)");
                        UserName = Console.ReadLine();
                        bool isValidUserName = UserValidation.ValidateUsername(UserName);
                        while (isValidUserName == false)
                        {
                            if (!isValidUserName)
                            {
                                Console.WriteLine("Please enter the valid user name");
                            }
                            Console.WriteLine("Enter your user name");
                            UserName = Console.ReadLine();
                            isValidUserName = UserValidation.ValidateUsername(UserName);
                        }

                        //Validate email 
                        Console.WriteLine("Enter your email: EX:abc@abc.com");
                        EmailID = Console.ReadLine();

                        bool isValidEmail = UserValidation.ValidateEmail(EmailID);
                        while (isValidEmail == false)
                        {
                            if (!isValidEmail)
                            {
                                Console.WriteLine("Please enter the valid email address");
                            }
                            Console.WriteLine("Enter your email:");
                            EmailID = Console.ReadLine();
                            isValidEmail = UserValidation.ValidateEmail(EmailID);
                        }

                        // Validate password
                        Console.WriteLine("Enter your password:Ex:Lava@123");
                        Password = Console.ReadLine();
                        bool isValidPassword = UserValidation.ValidatePassword(Password);
                        while (isValidPassword == false)
                        {
                            if (!isValidPassword)
                            {
                                Console.WriteLine("Please enter the valid password. ");
                            }
                            Console.WriteLine("Enter your password:");
                            Password = Console.ReadLine();
                            isValidPassword = UserValidation.ValidatePassword(EmailID);
                        }
                        user.CheckUser(EmailID, userList);
                        UserBO userBO = user.Register(UserName, EmailID, Password);
                        if (userBO != null)
                        {
                            userList.Add(userBO);
                            Console.WriteLine("**********Your User Account Has Been Created!!!!!!.***********..");
                            Console.WriteLine();
                            Console.WriteLine("*****  HELLO CUSTOMER  ****");

                            SigninORSignup();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("****** Try Again! CHECK YOUR DETAILS ENTER IT CORRECTLY ******");
                            SigninORSignup();
                        }
                        break;
                    case 3:
                        Console.WriteLine("****** Thank You ! VISIT AGAIN ******");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("CHECK YOUR DETAIL TRY AGAIN");
                        SigninORSignup();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SigninORSignup();
            }
        }
    }
}