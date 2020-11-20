using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Facescan.Model.DAO;

namespace Workshop_Facescan.Model.DAL
{
    class DALInfoEmploye
    {
        public static List<InfoEmploye> GetInfoEmployes()
        {
            MySqlConnection conn = Bdd.Bdd.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT p.idPersonne, p.prenom, p.nom, i.lienImage, pr.present FROM personnes p join images i on p.idPersonne=i.idPersonne JOIN presences pr on p.idPersonne = pr.idPersonne where p.role!='invité'";

            List<InfoEmploye> ie = ExecQuerry(cmd);
            conn.Close();
            return ie;

        }

        public static List<InfoEmploye> ExecQuerry(MySqlCommand cmd)
        {

            List<InfoEmploye> li = new List<InfoEmploye>();

            int id = -1;
            string p = "";
            string n = "";
            string l = "";
            string pr = "";


            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                id = Convert.ToInt32(rdr[0]);
                p = Convert.ToString(rdr[1]);
                n = Convert.ToString(rdr[2]);
                l = Convert.ToString(rdr[3]);
                if (Convert.ToInt32(rdr[4]) == 0)
                {
                    pr = "red";
                }
                else
                {
                    pr = "green";
                }
                InfoEmploye pers = new InfoEmploye(id, n, p, l,pr);
                    
                li.Add(pers);
                
            }

            return li;
        }
    }
}
