using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using gesper;

namespace Bdd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MySqlConnection Cnx;
            gesper.Donnees donnees = new Donnees();

            Cnx = donnees.ConnexionBDD();

            donnees.ToutCharger(Cnx);
            donnees.ToutAfficher(Cnx);
          
            Console.ReadLine();
            
            Cnx.Close();




        }
    }
}
