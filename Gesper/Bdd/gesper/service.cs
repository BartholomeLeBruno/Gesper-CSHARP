using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesper
{
   public class service
    {
        private int id;     
        private string designation;      
        private string type;       
        private string produit;       
        private int capacité;   
        private decimal budget;
        private static int dernierId = 0;
        private List<ClasseEmploye> lesEmployes=new List<ClasseEmploye>();

        public List<ClasseEmploye> LesEmployes
        {
            get { return lesEmployes; }
            set { lesEmployes = value; }
        }
        private List<service> LesServices = new List<service>();

        public List<service> GetLesServices
        {
            get { return LesServices; }
            set { LesServices = value; }
        }

        public service(int id, string designation, string type,  decimal budget)
        {
            this.id = id;
            this.designation = designation;
            this.type = type;
           
            this.budget = budget;

        }
        public service(int id, string designation, string type, string produit, int capacité)
        {
            this.id = id;
            this.designation = designation;
            this.type = type;
            this.produit = produit;
            this.capacité = capacité;
            

        }

        public service()
        {
            dernierId++;
            lesEmployes = new List<ClasseEmploye>();
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3} {4} {5} ", this.id, this.designation, this.type, this.produit, this.capacité, this.budget);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Produit
        {
            get { return produit; }
            set { produit = value; }
        }
        public int Capacité
        {
            get { return capacité; }
            set { capacité = value; }
        }
        public decimal Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        //public void PreparerSuppression()
        //{
        //    foreach (ClasseEmploye unEmploye in lesEmployes)
        //    {
        //        unEmploye.SupprimerService();
        //    }
        //}
    }
}
