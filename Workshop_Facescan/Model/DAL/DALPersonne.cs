using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Facescan.Model.DAO;
using Workshop_Facescan.Bdd;
using MySql.Data.MySqlClient;


namespace Workshop_Facescan.Model.DAL
{
    class DALPersonne
    {
        public static void Add (Personne p)
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();         
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert INTO personnes (nom, prenom, role) VALUES(@n, @p, @r)";
            cmd.Parameters.AddWithValue("@n",p.Nom);
            cmd.Parameters.AddWithValue("@p", p.Prenom);
            cmd.Parameters.AddWithValue("@r", p.Role);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("La connexion à la bdd a échoué :/(Add personne)");
                conn.Close();
            }

        }

        public static Personne GetByName(string n, string p)
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM personnes WHERE nom=@nom AND prenom=@prenom";
            cmd.Parameters.AddWithValue("@nom", n);
            cmd.Parameters.AddWithValue("@prenom", p);

            Personne pers = ExecQuerry(cmd)[0];
            conn.Close();
            return pers;

        }

        public static Personne GetById(int id)
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Personnes WHERE idPersonne=@id";
            cmd.Parameters.AddWithValue("@id", id);

            Personne p = ExecQuerry(cmd)[0];
            conn.Close();
            return p;

        }

        public static List<Personne> GetAll()
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Personnes WHERE role!='invité'";


            List<Personne> p = ExecQuerry(cmd);
            conn.Close();
            return p;

        }


        public static List<Personne> ExecQuerry(MySqlCommand cmd)
        {
            
            List<Personne> lp = new List<Personne>();

            int id = -1;
            string n = "";
            string p = "";
            string r = "";
            string d = "";
                   
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                id = Convert.ToInt32(rdr[0]);
                n = Convert.ToString(rdr[1]);
                p = Convert.ToString(rdr[2]);
                r = Convert.ToString(rdr[3]);

                if (rdr[4] == null)
                {
                    Personne pers = new Personne(id,n,p,r);
                    lp.Add(pers);
                }
                else
                {
                    d = Convert.ToString(rdr[4]);
                    Personne pers = new Personne(id, n, p, r, d);
                    lp.Add(pers);
                }                              
            }
            

            return lp;
        }


        
    }
}
