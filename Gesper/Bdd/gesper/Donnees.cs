using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using gesper;

namespace gesper
{
    public class Donnees
    {
        private List<service> lesServices;

      
        private List<ClasseEmploye> lesEmployes;

       
        public List<diplome> lesDiplomes;

        #region accesseurs
        public List<service> LesServices
        {
            get { return lesServices; }
            set { lesServices = value; }
        }
        public List<ClasseEmploye> LesEmployes
        {
            get { return lesEmployes; }
            set { lesEmployes = value; }
        }
        public List<diplome> LesDiplomes
        {
            get { return lesDiplomes; }
            set { lesDiplomes = value; }
        }
        #endregion

        public Donnees()
        {
            lesDiplomes = new List<diplome>();
            lesServices = new List<service>();
            lesEmployes = new List<ClasseEmploye>();
        }
        public void ChargerServices(MySqlConnection Cnx)
        {
            string requete = "select * from service";
            MySqlCommand Cmd = new MySqlCommand(requete, Cnx);

            MySqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            
            while (Rdr.Read())
            {
                if (Rdr["ser_type"].ToString() == "A")
                {
                    service nService = new service(
                        Convert.ToInt32(Rdr["ser_id"]),
                        Convert.ToString(Rdr["ser_designation"]),
                        Convert.ToString(Rdr["ser_type"]),
                        
                        Convert.ToDecimal(Rdr["ser_budget"]));

                    lesServices.Add(nService);
                }
                if (Rdr["ser_type"].ToString() == "P")
                {
                    service nService = new service(
                        Convert.ToInt32(Rdr["ser_id"]),
                        Convert.ToString(Rdr["ser_designation"]),
                        Convert.ToString(Rdr["ser_type"]),
                         Convert.ToString(Rdr["ser_produit"]),
                        Convert.ToInt32(Rdr["ser_capacite"]));

                    lesServices.Add(nService);
                }
                

            }
           
            Rdr.Close();
        }
        public void ChargerDiplomes(MySqlConnection Cnx)
        {
            string requete = "select * from diplome";
            MySqlCommand Cmd = new MySqlCommand(requete, Cnx);

            MySqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();

            while (Rdr.Read())
            {

                diplome nDiplome = new diplome(
                    Convert.ToInt32(Rdr["dip_id"]),
                    Convert.ToString(Rdr["dip_libelle"]));
                        
                      lesDiplomes.Add(nDiplome);
                   
                
            }
           
            Rdr.Close();
        }

        public void ChargerEmployes(MySqlConnection Cnx)
        {
            string requete = "select * from employe";
            MySqlCommand Cmd = new MySqlCommand(requete, Cnx);

            MySqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
           

            while (Rdr.Read())
            {
                    ClasseEmploye nEmploye = new ClasseEmploye(
                         Convert.ToInt32(Rdr["emp_id"]),
                         Convert.ToString(Rdr["emp_nom"]),
                         Convert.ToString(Rdr["emp_prenom"]),
                         Convert.ToString(Rdr["emp_sexe"]),
                         Convert.ToByte(Rdr["emp_cadre"]),
                         Convert.ToDecimal(Rdr["emp_salaire"])
                         );
                int i = 0;
                while (i < lesServices.Count() && lesServices[i].Id != Convert.ToInt32(Rdr["emp_service"]))
                {
                    i++;
                }
                if (i < lesServices.Count() && lesServices[i].Id == Convert.ToInt32(Rdr["emp_service"]))
                {
                    nEmploye.leService = lesServices[i];
                }
 
                    lesEmployes.Add(nEmploye);
                
                


            }
           
            Rdr.Close();
        }
        public MySqlConnection ConnexionBDD()
        {
            string sCnx = "server=localhost;uid=root;database=gesper;port=3306;pwd=siojjr";
            MySqlConnection Cnx = new MySqlConnection(sCnx);
            try
            {
                Cnx.Open();
                Console.WriteLine("connexion réussie");
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur connexion " + e.Message.ToString());
            }
            return Cnx;
        }

        private void deConnexionBDD(MySqlConnection cnx)
        {
            cnx.Close();
        }
        
        public void AfficherServices()
        {
            foreach (service s in lesServices)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public void AfficherEmployes()
        {
            foreach (ClasseEmploye e in lesEmployes)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void AfficherDiplomes()
        {
            foreach (diplome d in lesDiplomes)
            {
                Console.WriteLine(d.ToString());
            }
        }

        public void ChargerLesEmployesDesServices(MySqlConnection cnx)
        {
            foreach (service s in lesServices)
            {
                string requete = " Select * from employe where emp_service =" + s.Id;
                MySqlCommand command = new MySqlCommand(requete,cnx);
                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    int i = 0;
                    while (i < lesEmployes.Count() && lesEmployes[i].Id !=Convert.ToInt32((rdr["emp_id"])))
                    {
                        i++;
                    }
                    if (i < lesEmployes.Count() && lesEmployes[i].Id == Convert.ToInt32((rdr["emp_id"])))
                    {
                        s.LesEmployes.Add(lesEmployes[i]);
                    }
                    
                }
                rdr.Close();
            }
            
        }
        public void ChargerLesDiplomesDesEmployes(MySqlConnection cnx)
        {
            foreach (ClasseEmploye e in LesEmployes)
            {
                string requete = " Select * from diplome, posseder, employe where dip_id = pos_diplome and pos_employe = emp_id and emp_id =" + e.Id;
                MySqlCommand command = new MySqlCommand(requete, cnx);
                MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    int i = 0;
                    while (i < lesDiplomes.Count() && lesDiplomes[i].Id != Convert.ToInt32((rdr["emp_id"])))
                    {
                        i++;
                    }
                    if (i < lesEmployes.Count() && lesEmployes[i].Id == Convert.ToInt32((rdr["emp_id"])))
                    {
                        e.GetLesDiplomes.Add(LesDiplomes[i]);
                    }

                }
                rdr.Close();
                
            }    
        }
        public void ChargerLesEmployesTitulairesDesDiplomes(MySqlConnection cnx)
        {
            foreach (diplome d in lesDiplomes)
            {
                string requete = " Select * from employe,posseder,diplome where emp_id = pos_employe and pos_diplome = dip_id and dip_id =" + d.Id ;
                MySqlCommand command = new MySqlCommand(requete, cnx);
                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    int i = 0;
                    while (i < lesEmployes.Count() && lesEmployes[i].Id != Convert.ToInt32((rdr["emp_id"])))
                    {
                        i++;
                    }
                    if (i < lesEmployes.Count() && lesEmployes[i].Id == Convert.ToInt32((rdr["emp_id"])))
                    {
                        d.LesEmployes.Add(lesEmployes[i]);
                    }

                }
                rdr.Close();

            }

        }
        public void ToutCharger(MySqlConnection cnx)
        {
            ChargerServices(cnx);
            ChargerDiplomes(cnx);
            ChargerEmployes(cnx);
            ChargerLesDiplomesDesEmployes(cnx);
            ChargerLesEmployesDesServices(cnx);
            ChargerLesEmployesTitulairesDesDiplomes(cnx);
            
        }
        public void ToutAfficher(MySqlConnection CnX)
        {
            AfficherServices();
            Console.WriteLine("");
            AfficherDiplomes();
            Console.WriteLine("");
            AfficherEmployes();
            Console.WriteLine("");
        }
        public void ToutSupprimer(MySqlConnection CnX)
        {
            MySqlCommand ToutSupprimer = new MySqlCommand();
            ToutSupprimer.Connection = CnX;
            ToutSupprimer.CommandType = System.Data.CommandType.StoredProcedure;
            ToutSupprimer.CommandText = "ToutSupprimer";
            
            ToutSupprimer.Prepare();
            try
            {
                ToutSupprimer.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }

        }
        public void ToutSauvegarder(MySqlConnection cnX)
        {
            MySqlCommand ToutSupprimer = new MySqlCommand();
            ToutSupprimer.Connection = cnX;
            cnX.Open();
            ToutSupprimer.CommandType = System.Data.CommandType.StoredProcedure;
            ToutSupprimer.CommandText = "ToutSupprimer";
            ToutSupprimer.Prepare();
            MySqlCommand requete = new MySqlCommand();
            foreach (service unService in LesServices)
            {
                requete.CommandText = "insert into employe values(@id,@designation@type,@produit,@capacite,@budget);";
                requete.Parameters["@id"].Value = unService.Id;
                requete.Parameters["@designation"].Value = unService.Designation;
                requete.Parameters["@type"].Value = unService.Type;
                requete.Parameters["@produit"].Value = unService.Produit;
                requete.Parameters["@capacite"].Value = unService.Capacité;
                requete.Parameters["@budget"].Value = unService.Budget;
                requete.ExecuteNonQuery();
            }
            foreach (diplome unDiplome in LesDiplomes)
            {
                requete.CommandText = "insert into employe values(@id,@libelle);";
                requete.Parameters["@id"].Value = unDiplome.Id;
                requete.Parameters["@libelle"].Value = unDiplome.Libelle;
                requete.ExecuteNonQuery();
            }
            foreach (ClasseEmploye unEmploye in LesEmployes)
            {
                requete.CommandText = "insert into employe values(@id, @nom, @prenom, @sexe, @cadre, @salaire, @service);";
                requete.Parameters["@id"].Value = unEmploye.Id;
                requete.Parameters["@nom"].Value = unEmploye.Nom;
                requete.Parameters["@prenom"].Value = unEmploye.Prenom;
                requete.Parameters["@sexe"].Value = unEmploye.Sexe;
                requete.Parameters["@cadre"].Value = unEmploye.Cadre;
                requete.Parameters["@salaire"].Value = unEmploye.Salaire;
                //requete.Parameters["@service"].Value = unEmploye.leService;
                requete.ExecuteNonQuery();
            }


        }
        
    



    }
}
