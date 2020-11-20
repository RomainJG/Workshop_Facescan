using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Facescan.Model.DAO
{
    class Presence
    {
        private int _idPresence;
        public int IdPresence { get => _idPresence; set => _idPresence = value; }

        private DateTime _date;
        public DateTime Date { get => _date; set => _date = value; }

        private bool _present;
        public bool Present { get => _present; set => _present = value; }

        private Personne _personne;
        public Personne Personne { get => _personne; set => _personne = value; }

        public Presence(bool p, int pe)
        {
            Date = DateTime.Today;
            Present = p;
            Personne = DAL.DALPersonne.GetById(pe);
        }
    }
}
