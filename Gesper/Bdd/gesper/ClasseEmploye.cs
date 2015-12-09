using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesper
{
    public class ClasseEmploye
    {
        private int id;


        private byte cadre;


        private string nom;


        private string prenom;


        private string sexe;


        private decimal salaire;

        private service service;
        private List<diplome> LesDiplomes = new List<diplome>();

        public List<diplome> GetLesDiplomes
        {
            get { return LesDiplomes; }
            set { LesDiplomes = value; }
        }


        public ClasseEmploye(int id, string nom, string prenom, string sexe, byte cadre, decimal salaire)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.cadre = cadre;
            this.salaire = salaire;

        }
        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3} {4} {5} ", this.Id, this.Nom, this.Prenom, this.Sexe, this.Salaire, this.leService);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public byte Cadre
        {
            get { return cadre; }
            set { cadre = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public decimal Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public service leService
        {
            get { return service; }
            set { service = value; }
        }
        //public service leService
        //{
        //    get { return leService; }
        //    set
        //    {
        //        if (leService != null)
        //        {
        //            leService.LesEmployes.Remove(this);
        //        }
        //        leService = value;
        //        if (leService != null)
        //        {
        //            leService.LesEmployes.Add(this);
        //        }
        //    }
        //}
        //public void AjouterDiplome(diplome p_diplome)
        //{
        //    LesDiplomes.Add(p_diplome);
        //    p_diplome.LesEmployes.Add(this);
        //}
        //public void SupprimerDiplome(diplome p_diplome, bool majdiplome)
        //{
        //    LesDiplomes.Remove(p_diplome);
        //    if (majdiplome)
        //    {
        //        p_diplome.LesEmployes.Remove(this);
        //    }
        //}
        //public void SupprimerService()
        //{
        //    leService = null;
        //}
        //public void PreparerSuppression()
        //{
        //    leService = null;
        //    foreach (diplome unDiplome in LesDiplomes)
        //    {
        //        unDiplome.LesEmployes.Remove(this);
        //    }
        //}

    }
}

    


    

