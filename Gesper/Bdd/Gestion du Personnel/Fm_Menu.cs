using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using gesper;

namespace GestionduPersonnel
{
    public partial class Fm_Menu : Form
    {
        private Donnees bd;
        MySqlConnection Cnx = new MySqlConnection();
        public Fm_Menu()
        {
            InitializeComponent();
            bd = new Donnees();
            Cnx = bd.ConnexionBDD();
            bd.ToutCharger(Cnx);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            FM_Service fsce = new FM_Service(bd, Cnx);
            fsce.ShowDialog();
        }

        private void Fm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnDiplômes_Click(object sender, EventArgs e)
        {
            FM_Diplômes fsce = new FM_Diplômes(bd, Cnx);
            fsce.ShowDialog();
        }

        private void btnEmployés_Click(object sender, EventArgs e)
        {
            FM_Employés fsce = new FM_Employés(bd, Cnx);
            fsce.ShowDialog();

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            bd.ToutSauvegarder(Cnx);
        }
    }
}
