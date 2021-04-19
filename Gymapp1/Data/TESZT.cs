using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gymapp1.Data
{

    public class TESZT
    {
       
        DayEvent _oDayEvent = new DayEvent();
        public int teszt(string note, DateTime date, string idoo, string name, string lastname, string tel, string email)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("INSERT INTO Foglalt(Note, EventDate, IdoPont, Firstname, Lastname, Tel, Email) values ('" + note + "', '" + date.ToString("yyyy-MM-dd") + "','" + idoo + "','" + name + "','" + lastname + "','" + tel + "','" + email + "'); SELECT LAST_INSERT_ID();", conn);
            //comm.ExecuteNonQuery();
            int id = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
          
            
            return id;

        }
        public string Delete(int id)
        {
            string message = "";
            try
            {
                _oDayEvent = new DayEvent()
                {
                    id = id
                };

                using (MySqlConnection con = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;"))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    MySqlCommand comm = new MySqlCommand("DELETE FROM Foglalt WHERE id = " + id, con);
                    comm.ExecuteNonQuery();
                    con.Close();
                    message = "Torolve";

                }


            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }
        public int CheckBookedTimes(DateTime datee)
        {
            //DateTime datee = new DateTime(2021,03,03);
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("SELECT COUNT(IdoPont) FROM Foglalt WHERE EventDate ='"+datee.ToString("yyyy-MM-dd") + "'", conn); 
            //comm.ExecuteNonQuery();
            int number = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
           
            return number;
        }
      public  async Task Checkin(DateTime date, int id)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("UPDATE Foglalt SET Erkezes ='"+date.ToString("yyyy-MM-dd HH:mm:ss")+"' WHERE id = " + id , conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public async Task Checkout(DateTime date , int id)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("UPDATE Foglalt SET Tavozas ='" + date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id = " + id, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
       


    }
}
