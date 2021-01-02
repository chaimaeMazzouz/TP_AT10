using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AT10
{
    public partial class Mouvement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte", g1.banque_connexion);
        SqlDataAdapter Adp_Mouvements = new SqlDataAdapter("select * from Mouvement", g1.banque_connexion);
        DataView DvCompte;
        BindingManagerBase bmbMouvement;
        public Mouvement()
        {
            InitializeComponent();
        }

        private void Mouvement_Load(object sender, EventArgs e)
        {
            Adp_Comptes.Fill(Ds_Banque, "Comptes");
            Adp_Mouvements.Fill(Ds_Banque, "Mouvements");
            bmbMouvement = BindingContext[Ds_Banque.Tables["Mouvements"]];

            txtNumMouvement.DataBindings.Add("Text", Ds_Banque.Tables["Mouvements"], "Num_Mouvement");
            comboNumCompte.DataBindings.Add("Text", Ds_Banque.Tables["Mouvements"], "Num_Compte");
            textMontant.DataBindings.Add("Text", Ds_Banque.Tables["Mouvements"], "Montant");
            comboTypeMouvement.DataBindings.Add("Text", Ds_Banque.Tables["Mouvements"], "TypeM");
            textDateMouvement.DataBindings.Add("Text", Ds_Banque.Tables["Mouvements"], "DateM");

            dataGridView1.DataSource = Ds_Banque.Tables["Mouvements"];
            dataGridView2.DataSource = Ds_Banque.Tables["Comptes"];
            comboNumCompte.DataSource = Ds_Banque.Tables["Comptes"];
            comboNumCompte.DisplayMember = "Num_Compte";
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bmbMouvement.Position = 0;

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bmbMouvement.Position++;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bmbMouvement.Position--;

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bmbMouvement.Position = bmbMouvement.Count - 1;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bmbMouvement.AddNew();

            textDateMouvement.Text = DateTime.Now.ToString();

        }
        Boolean BL = false;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textMontant.Text != "" && comboNumCompte.Text != "" && comboTypeMouvement.Text != "")
            {
                DvCompte = new DataView(Ds_Banque.Tables["Comptes"], "Num_Compte=" +
                comboNumCompte.SelectedValue, "", DataViewRowState.CurrentRows);
                textDateMouvement.Text = DateTime.Now.ToString();
                if (comboTypeMouvement.Text == "Retrait" && Convert.ToDecimal(DvCompte[0]["Solde"]) <= Convert.ToDecimal(textMontant.Text))
                {
                    MessageBox.Show("Solde inssuffissant");
                }
                else
                {
                    try
                    {
                       
                        if (comboTypeMouvement.Text == "Retrait")
                        {
                            DvCompte[0]["Solde"] = Convert.ToDecimal(DvCompte[0]["Solde"]) - Convert.ToDecimal(textMontant.Text);
                        }
                        else
                        {
                            DvCompte[0]["Solde"] = Convert.ToDecimal(DvCompte[0]["Solde"]) + Convert.ToDecimal(textMontant.Text);
                        }
                        bmbMouvement.EndCurrentEdit();
                        BL = true;
                        dataGridView1.Refresh();
                        MessageBox.Show("Compte inséré", "Ajout Client", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        MessageBox.Show("Ajout effectué");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("remplir les champs!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
