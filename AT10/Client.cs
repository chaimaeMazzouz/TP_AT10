using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AT10
{
    public partial class Client : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Clients = new SqlDataAdapter("select * from Client", g1.banque_connexion);
        BindingManagerBase bmbCompte;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            
            Adp_Clients.Fill(Ds_Banque, "Clients");
            bmbCompte = BindingContext[Ds_Banque.Tables["Clients"]];

            txtNumClient.DataBindings.Add("Text", Ds_Banque.Tables["Clients"], "Num_Client");
            textNomClient.DataBindings.Add("Text", Ds_Banque.Tables["Clients"], "Nom_Client");
            textPrenomClient.DataBindings.Add("Text", Ds_Banque.Tables["Clients"], "Prenom_Client");
            comboNumClient.DataBindings.Add("Text", Ds_Banque.Tables["Clients"], "Num_Client");

            dataGridView1.DataSource = Ds_Banque.Tables["Clients"];
            comboNumClient.DataSource = Ds_Banque.Tables["Clients"];
            comboNumClient.DisplayMember = "Num_Client";


            comboNumClient.Visible = true;
            txtNumClient.Visible = false;
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
            bmbCompte.Position = bmbCompte.Count - 1;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            txtNumClient.Visible = true;
            comboNumClient.Visible = false;
            bmbCompte.AddNew();
        }
        Boolean BL = false;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNumClient.Text != "" && textNomClient.Text != "" && textPrenomClient.Text != "")
            {

                comboNumClient.Visible = true;
                txtNumClient.Visible = false;
                try
                {
                    bmbCompte.EndCurrentEdit();
                    BL = true;
                    dataGridView1.Refresh();
                    MessageBox.Show("Compte inséré", "Ajout Client", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur1 : " + ex.Message, "Erreur", MessageBoxButtons.OK,
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
            comboNumClient.Visible = true;
            txtNumClient.Visible = false;
            BL = true;
            MessageBox.Show("Compte modifié", "Modification Compte", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            comboNumClient.Visible = true;
            txtNumClient.Visible = false;
            bmbCompte.RemoveAt(bmbCompte.Position);
            BL = true;
            MessageBox.Show("Compte supprimé", "Suppression Compte", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
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
                        SqlCommandBuilder Bld = new SqlCommandBuilder(Adp_Clients);
                        Adp_Clients.Update(Ds_Banque.Tables["Clients"]);
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
