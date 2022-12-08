namespace FinalProject;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class StaffData{
    public string connStr = "server=20.172.0.16;user=nsbhakta1;database=nsbhakta1;port=8080;password=nsbhakta1";
    public bool LoginStaffCount(User user){
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {  
            conn.Open();
            string procedure = "LoginStaffCount";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputStaffID", user.staffID);
            cmd.Parameters.AddWithValue("@inputStaffPassword", user.staffPassword);
            cmd.Parameters.Add("@staffCount", MySqlDbType.Int32).Direction =  ParameterDirection.Output;
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            int returnCount = (int) cmd.Parameters["@staffCount"].Value;
            rdr.Close();
            conn.Close();

            if (returnCount ==1){
                return true;
            }
            else{
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            conn.Close();
            return false;
        }
       
    }
}