namespace FinalProject;
using System.Data;
using MySql.Data.MySqlClient;
class StaffLogin{
    User user = new User();
    StaffData database = new StaffData();

    public User Login(){
        Console.WriteLine("--Welcome to the Package Managment Application--");
        Console.WriteLine("Please input your name (staff_username): ");
        user.staffID = Console.ReadLine();
        Console.WriteLine("Please input staff password: ");
        user.staffPassword = Console.ReadLine();
        return user;
    }

    public int Dashboard(User user){
        Console.WriteLine("--Login Screen--");
        Console.WriteLine($"Hello: {user.staffID}");
        Console.WriteLine("Please select an option to continue:");
        Console.WriteLine("1. Search Resident");
        Console.WriteLine("2. Send a Notification Email");
        Console.WriteLine("3. Process a Picked Package");
        Console.WriteLine("4. Process an Unknown Package");
        Console.WriteLine("5. Log Out");
        int option = Convert.ToInt16(Console.ReadLine());
        return option;
    }
}