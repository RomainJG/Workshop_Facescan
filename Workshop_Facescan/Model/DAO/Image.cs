using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Facescan.Model.DAO
{
    class Image
    {
        private int _idImage;
        public int IdImage { get => _idImage; set => _idImage = value; }

        private string _nomImage;
        public string NomImage { get => _nomImage; set => _nomImage = value; }

        private string _extensionImage;
        public string ExtensionImage { get => _extensionImage; set => _extensionImage = value; }

        private int _tailleImage;
        public int TailleImage { get => _tailleImage; set => _tailleImage = value; }

        private string _lienImage;
        public string LienImage { get => _lienImage; set => _lienImage = value; }

        private Personne _personne;
        public Personne Personne { get => _personne; set => _personne = value; }


        public Image(string n, string e, int t, string l, int p)
        {
            NomImage = n;
            ExtensionImage = e;
            TailleImage = t;
            LienImage = l;
            Personne = DAL.DALPersonne.GetById(p);
        }

    }
}
