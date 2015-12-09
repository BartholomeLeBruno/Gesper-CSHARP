using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesper
{
   public class diplome
    {
        private int id;

        
        private string libelle;
        private List<ClasseEmploye> lesEmployes = new List<ClasseEmploye>();

        public List<ClasseEmploye> LesEmployes
        {
            get { return lesEmployes; }
            set { lesEmployes = value; }
        }

        public diplome(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public override string ToString()
        {
            return string.Format(" {0} {1}", this.id, this.libelle);
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        //public void PreparerSuppression()
        //{
        //    foreach (ClasseEmploye unEmploye in LesEmployes)
        //    {
        //        unEmploye.SupprimerDiplome(this, false);
        //    }
        //}
    }
}
