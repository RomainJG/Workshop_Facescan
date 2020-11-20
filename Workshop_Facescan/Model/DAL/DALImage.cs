using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Facescan.Model.DAO;

namespace Workshop_Facescan.Model.DAL
{
    class DALImage
    {
        public static void Add(Image i)
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO images (nomImage,extensionImage,tailleImage,lienImage,idPersonne) VALUES(@n,@e,@t,@l,@p)";
            cmd.Parameters.AddWithValue("@n", i.NomImage);
            cmd.Parameters.AddWithValue("@e", i.ExtensionImage);
            cmd.Parameters.AddWithValue("@t", i.TailleImage);
            cmd.Parameters.AddWithValue("@l", i.LienImage);
            cmd.Parameters.AddWithValue("@p", i.Personne.IdPersonne);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("La connexion à la bdd a échoué :/(Add image)");
                conn.Close();
            }

        }
    }
}
