namespace FinalProject;
using System.Data;
using MySql.Data.MySqlClient;
class LoginScreen
{
   
    static void Main(string[] args)
    {
        bool _continue = true;
        User user;
        StaffLogin appGUI = new StaffLogin();
        StaffData database = new StaffData();

        // start GUI
        user = appGUI.Login();

       
        if (database.LoginCheck(user)){

            while(_continue){
                int option  = appGUI.Dashboard(user);
                switch(option)
                {
                    // Search Resident
                    case 1:
                        Console.WriteLine("...");
                        break;
                    // Send Email Notification
                    case 2:
                        Console.WriteLine("...");
                        break;
                    // Process a picked package
                    case 3:
                        Console.WriteLine("...");
                        break;
                    // Process an unknown package
                    case 4:
                        Console.WriteLine("...");
                        break;
                    // logout
                    case 5:
                        _continue = false;
                        Console.WriteLine("Log out, Goodbye.");
                        break;
                    // wrong input
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

            }
        }
        else{
                Console.WriteLine("Login Failed, Goodbye.");
        }        
    }    
}
