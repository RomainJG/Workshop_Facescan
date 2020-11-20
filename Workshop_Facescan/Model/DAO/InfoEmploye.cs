using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Facescan.Model.DAO
{
    class InfoEmploye
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }

        private string _prenom;
        public string Prenom { get => _prenom; set => _prenom = value; }

        private string _nom;
        public string Nom { get => _nom; set => _nom = value; }

        private string _lien;
        public string Lien { get => _lien; set => _lien = value; }

        private string _present;
        public string Present { get => _present; set => _present = value; }


        public InfoEmploye(int id,string nom, string prenom, string lien, string present)
        {
            Id = id;
            Prenom = prenom;
            Nom = nom;
            Lien = lien;
            Present = present;
        }




    }
}
