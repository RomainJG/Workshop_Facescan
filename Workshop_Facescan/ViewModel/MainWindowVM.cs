using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Facescan.Model.DAO;

namespace Workshop_Facescan.ViewModel
{
    class MainWindowVM
    {
        public List<InfoEmploye> persons;
        public MainWindowVM()
        {
            persons = GetEmployes();
        }

        public List<InfoEmploye> GetEmployes()
        {
            return Model.DAL.DALInfoEmploye.GetInfoEmployes();
        }

        public int AddAndGetPerson(string n, string p, string r)
        {
            Model.DAL.DALPersonne.Add(new Personne(n, p, r));
            return Model.DAL.DALPersonne.GetByName(n, p).IdPersonne;
        }

        public void AddImage(string n, string e, int t, string l, int p)
        {
            Model.DAL.DALImage.Add(new Image(n,e,t,l,p));
        }

        public void AddPresence(int id)
        {
            Model.DAL.DALPresence.Add(new Presence(false,id));
        }
    }
}
