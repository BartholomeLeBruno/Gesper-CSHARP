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
    public partial class FM_Service : Form
    {
        private Donnees bd;
        public FM_Service(Donnees p_bd, MySqlConnection Cnx)
        {
            InitializeComponent();
            bd = p_bd;
            tbId.Enabled = false;
            tbId.ReadOnly = true;
            bsServices.DataSource = bd.LesServices;
            //bs_employes.DataSource = bd.LesEmployes;
            tbId.DataBindings.Add("Text", bsServices, "Id");
            tbDesignation.DataBindings.Add("Text", bsServices, "Designation");
            tbType.DataBindings.Add("Text", bsServices, "Type");
            tbProduit.DataBindings.Add("Text", bsServices, "Produit");
            tbCapacité.DataBindings.Add("Text", bsServices, "Capacité");
            tbBudget.DataBindings.Add("Text", bsServices, "Budget");
            bnServices.BindingSource = bsServices;
            lbEmployés.DataSource = bs_employes;
            btntest.DataBindings.Add("Text", bsServices, "");

        }


        private void FM_Service_Load(object sender, EventArgs e)
        {

        }

        private void lblCapacité_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bsServices_CurrentChanged(object sender, EventArgs e)
        {
            if (bsServices.Current != null)
            {
                bs_employes.DataSource = ((service)bsServices.Current).LesEmployes;
            }
            else
            {
                bs_employes.DataSource = null;
            }

        }

        private void lbEmployés_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
