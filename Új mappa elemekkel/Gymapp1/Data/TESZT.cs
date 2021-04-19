using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gymapp1.Data
{
    public class TESZT
    {
        public Task teszt(string note, DateTime date, string idoo)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bakalargym;Uid=admin;Pwd=admin;");
            conn.Open();
            MySqlCommand comm = new MySqlCommand("INSERT INTO Foglalt(Note, EventDate, IdoPont) values ('" + note + "', '" + date.ToString("yyyy-MM-dd") + "','" + idoo + "');", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            return null;
        }
    }
}
