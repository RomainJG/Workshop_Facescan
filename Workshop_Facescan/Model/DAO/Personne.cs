using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Facescan.Model.DAO
{
    class Personne
    {
        private int _idPersonne;
        public int IdPersonne { get => _idPersonne; set => _idPersonne = value; }

        private string _nom;
        public string Nom { get => _nom; set => _nom = value; }

        private string _prenom;
        public string Prenom { get => _prenom; set => _prenom = value; }

        private string _role;
        public string Role { get => _role; set => _role = value; }

        private string _dateLimite;
        public string DateLimite { get => _dateLimite; set => _dateLimite = value; }




        public Personne(int id, string n, string p, string r, string d)
        {
            IdPersonne = id;
            Nom = n;
            Prenom = p;
            Role = r;
            DateLimite = d;
        }

        public Personne(int id, string n, string p, string r)
        {
            IdPersonne = id;
            Nom = n;
            Prenom = p;
            Role = r;
        }

        public Personne(string n, string p, string r)
        {
            Nom = n;
            Prenom = p;
            Role = r;
        }

        public Personne( string n, string p, string r, string d)
        {
            Nom = n;
            Prenom = p;
            Role = r;
            DateLimite = d;
        }

    }
}
