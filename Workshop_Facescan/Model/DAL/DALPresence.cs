using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Facescan.Model.DAO;

namespace Workshop_Facescan.Model.DAL
{
    class DALPresence
    {
        public static void Add(Presence p)
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO presences (date,present,idPersonne) VALUES(@d,@p,@id)";
            cmd.Parameters.AddWithValue("@d", p.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p", p.Present);
            cmd.Parameters.AddWithValue("@id", p.Personne.IdPersonne);


            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("La connexion à la bdd a échoué :/(Add presence)");
                conn.Close();
            }

        }
    }
}
