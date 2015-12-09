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
    public partial class FM_Employés : Form
    {
        private Donnees bd;
        public FM_Employés(Donnees p_bd, MySqlConnection Cnx)
        {
            InitializeComponent();
            bd = p_bd;
            tbId.Enabled = false;
            tbId.ReadOnly = true;
            bsemployes.DataSource = bd.LesEmployes;
            bsservice.DataSource = bd.LesServices;
            tbId.DataBindings.Add("Text", bsemployes, "ID");
            tbNom.DataBindings.Add("Text", bsemployes, "Nom");
            tbPrenom.DataBindings.Add("Text", bsemployes, "Prenom");
            chCadre.DataBindings.Add("Checked", bsemployes, "Cadre");
            tbSalaire.DataBindings.Add("Text", bsemployes, "Salaire");
            cbService.DataBindings.Add("SelectedValue", bsservice, "Designation");
            bnEmployes.BindingSource = bsemployes;
            bnEmployes.BindingSource = bsservice;
            
        }

        private void FM_Employés_Load(object sender, EventArgs e)
        {

        }

        private void lbAutresDiplomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bsemployes_CurrentChanged(object sender, EventArgs e)
        {
            if (bsemployes.Current != null)
            {
                ClasseEmploye leEmploye = (ClasseEmploye)bsemployes.Current;
                if (leEmploye.Sexe == "M")
                {
                    rbMasculin.Checked = true;
                }
                else
                {
                    rbFéminin.Checked = true;
                }
            }
        }

    }
}
