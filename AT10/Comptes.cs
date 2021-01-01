using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT10
{
    public partial class Comptes : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Clients = new SqlDataAdapter("select * from Client", g1.banque_connexion);
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte", g1.banque_connexion);
        BindingManagerBase bmbCompte;
        public Comptes()
        {
            InitializeComponent();
        }

        private void Comptes_Load(object sender, EventArgs e)
        {
            Adp_Comptes.Fill(Ds_Banque, "Comptes");
            Adp_Clients.Fill(Ds_Banque, "Clients");
            bmbCompte = BindingContext[Ds_Banque.Tables["Comptes"]];

            txtNumCompte.DataBindings.Add("Text",Ds_Banque.Tables["Comptes"],"Num_Compte");
            textSolde.DataBindings.Add("Text",Ds_Banque.Tables["Comptes"], "Solde");
            comboTypeCompte.DataBindings.Add("Text",Ds_Banque.Tables["Comptes"], "TypeC");
            comboNumClient.DataBindings.Add("Text",Ds_Banque.Tables["Comptes"], "Num_Client");

            dataGridView1.DataSource = Ds_Banque.Tables["Comptes"];
            comboNumClient.DataSource = Ds_Banque.Tables["Clients"];
            comboNumClient.DisplayMember = "Num_Client";
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bmbCompte.Position = 0;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bmbCompte.Position++;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bmbCompte.Position--;

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bmbCompte.Position = bmbCompte.Count -1;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textSolde.ReadOnly = false;
            bmbCompte.AddNew();
        }
        Boolean BL = false;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNumCompte.Text !="" && textSolde.Text !="" && comboTypeCompte.Text != "")
            {
                try
                {
                    bmbCompte.EndCurrentEdit();
                    textSolde.ReadOnly = true;
                    BL = true;
                    dataGridView1.Refresh();
                    MessageBox.Show("Compte inséré","Ajout Compte",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bmbCompte.AddNew();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur1 : "+ex.Message, "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs", "Warning", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bmbCompte.EndCurrentEdit();
            BL = true;
            MessageBox.Show("Compte modifié", "Modification Compte", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bmbCompte.RemoveAt(bmbCompte.Position);
            BL = true;
            MessageBox.Show("Compte supprimé", "Suppression Compte", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Comptes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BL)
            {
                DialogResult rep =
                    MessageBox.Show("Voulez vous Appliquer les mis à jours à la source de données", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommandBuilder Bld = new SqlCommandBuilder(Adp_Comptes);
                        Adp_Comptes.Update(Ds_Banque.Tables["Comptes"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur2 : " + ex.Message, "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
