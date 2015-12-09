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
    public partial class FM_Diplômes : Form
    {
        private Donnees bd;

        public FM_Diplômes(Donnees p_bd, MySqlConnection Cnx)
        {
            InitializeComponent();
            bd = p_bd;
            tbId.Enabled = false;
            tbId.ReadOnly = true;
            bsDiplomes.DataSource = bd.LesDiplomes;
            //bsEmployes.DataSource = bd.LesEmployes;

            tbId.DataBindings.Add("Text", bsDiplomes, "ID");
            tbLibelle.DataBindings.Add("Text", bsDiplomes, "Libelle");
            //lbNom.DataBindings.Add("Text", bsEmployes, "Nom");
            bnDiplomes.BindingSource = bsDiplomes;
            lbNom.DataSource = bsEmployes;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FM_Diplômes_Load(object sender, EventArgs e)
        {

        }

        private void bsDiplomes_CurrentChanged(object sender, EventArgs e)
        {
            if (bsDiplomes.Current != null)
            {
                bsEmployes.DataSource = ((diplome)bsDiplomes.Current).LesEmployes;
            }
            else
            {
                bsEmployes.DataSource = null;
            }
        }
    }
}
