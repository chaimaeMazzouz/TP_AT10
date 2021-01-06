using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AT10
{
    public partial class Virement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte"
            , g1.banque_connexion);
        SqlDataAdapter Adp_Virements = new SqlDataAdapter("select * from Virement"
            , g1.banque_connexion);
        DataView Dv_Compte;
        BindingManagerBase bmbVirement;
        public Virement()
        {
            InitializeComponent();
        }

        private void Virement_Load(object sender, EventArgs e)
        {
            Adp_Comptes.Fill(Ds_Banque, "Comptes");
            Adp_Virements.Fill(Ds_Banque, "Virements");
            bmbVirement = BindingContext[Ds_Banque.Tables["Virements"]];

            txtNumVirement.DataBindings.Add("Text", Ds_Banque.Tables["Virements"], "Num_Virement");
            combo_Num_Debiteur.DataBindings.Add("Text", Ds_Banque.Tables["Virements"], "Num_Debiteur");
            comboCrediteur.DataBindings.Add("Text", Ds_Banque.Tables["Virements"], "Num_Crediteur");
            textMontantVirement.DataBindings.Add("Text", Ds_Banque.Tables["Virements"], "Montant_Vr");
            textDateVr.DataBindings.Add("Text", Ds_Banque.Tables["Virements"], "Date_Vr");

            dataGridView1.DataSource = Ds_Banque.Tables["Virements"];
            dataGridView2.DataSource = Ds_Banque.Tables["Comptes"];
            combo_Num_Debiteur.DisplayMember = "Num_Compte";
            combo_Num_Debiteur.ValueMember = "Num_Compte";
            DataTable dtDebiteur = Ds_Banque.Tables["Comptes"].Copy();
            combo_Num_Debiteur.DataSource = dtDebiteur;

            comboCrediteur.DisplayMember = "Num_Compte";
            comboCrediteur.ValueMember = "Num_Compte";
            DataTable dtCrediteur = Ds_Banque.Tables["Comptes"].Copy();
            comboCrediteur.DataSource = dtCrediteur;
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bmbVirement.Position = 0;

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bmbVirement.Position++;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bmbVirement.Position--;

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bmbVirement.Position = bmbVirement.Count - 1;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bmbVirement.AddNew();
            textDateVr.Text = DateTime.Now.ToString();
        }
        Boolean BL = false;

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textMontantVirement.Text != "" && comboCrediteur.Text != "" && combo_Num_Debiteur.Text != "")
            {
                
                if (soldeDebiteur < Convert.ToDecimal(textMontantVirement.Text))
                {
                    MessageBox.Show("Solde inssuffissant");
                }
                else
                {
                    try
                    {
                        DataRow ligne = Ds_Banque.Tables["Virements"].NewRow();
                        Dv_Compte[0].BeginEdit();
                        Dv_Compte[0]["Solde"] = soldeDebiteur - Convert.ToDecimal(textMontantVirement.Text);
                        Dv_Compte[0].EndEdit();
                        Dv_Compte = new DataView(Ds_Banque.Tables["Comptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

                        soldeCrediteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
                        Dv_Compte[0].BeginEdit();
                        Dv_Compte[0]["Solde"] = soldeCrediteur + Convert.ToDecimal(textMontantVirement.Text);
                        Dv_Compte[0].EndEdit();

                        bmbVirement.EndCurrentEdit();
                        BL = true;
                        dataGridView1.Refresh();
                        MessageBox.Show("Virement inséré", "Ajout Virement", MessageBoxButtons.OK,
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

        private void Virement_FormClosing(object sender, FormClosingEventArgs e)
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
                        SqlCommandBuilder Bld = new SqlCommandBuilder(Adp_Virements);
                        SqlCommandBuilder BldC = new SqlCommandBuilder(Adp_Comptes);
                        Adp_Virements.Update(Ds_Banque.Tables["Virements"]);
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
        decimal soldeDebiteur;
        decimal soldeCrediteur;
        private void combo_Num_Debiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dv_Compte = new DataView(Ds_Banque.Tables["Comptes"], "Num_Compte =" + combo_Num_Debiteur.SelectedValue, "", DataViewRowState.CurrentRows);

            soldeDebiteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
        }

        private void comboCrediteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView Dv_CompteCr = new DataView(Ds_Banque.Tables["Comptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

            soldeCrediteur = Convert.ToDecimal(Dv_CompteCr[0]["Solde"]);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (soldeCrediteur < Convert.ToDecimal(textMontantVirement.Text))
            {
                MessageBox.Show("Solde inssuffissant");
            }
            else
            {
                try
                {

                    Dv_Compte[0].BeginEdit();
                    Dv_Compte[0]["Solde"] = soldeDebiteur + Convert.ToDecimal(textMontantVirement.Text);
                    Dv_Compte[0].EndEdit();
                    Dv_Compte = new DataView(Ds_Banque.Tables["Comptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

                    soldeCrediteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
                    Dv_Compte[0].BeginEdit();
                    Dv_Compte[0]["Solde"] = soldeCrediteur - Convert.ToDecimal(textMontantVirement.Text);
                    Dv_Compte[0].EndEdit();

                    bmbVirement.RemoveAt(bmbVirement.Position);
                    BL = true;
                    MessageBox.Show("Virement supprimé", "Suppression Virement", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
