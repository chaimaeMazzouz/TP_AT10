namespace AT10
{
    partial class Comptes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.comboNumClient = new System.Windows.Forms.ComboBox();
            this.comboTypeCompte = new System.Windows.Forms.ComboBox();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Gestion Comptes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Num Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Num Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Solde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Type Compte";
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Location = new System.Drawing.Point(170, 75);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(127, 20);
            this.txtNumCompte.TabIndex = 43;
            // 
            // comboNumClient
            // 
            this.comboNumClient.FormattingEnabled = true;
            this.comboNumClient.Location = new System.Drawing.Point(170, 124);
            this.comboNumClient.Name = "comboNumClient";
            this.comboNumClient.Size = new System.Drawing.Size(127, 21);
            this.comboNumClient.TabIndex = 44;
            // 
            // comboTypeCompte
            // 
            this.comboTypeCompte.FormattingEnabled = true;
            this.comboTypeCompte.Location = new System.Drawing.Point(170, 212);
            this.comboTypeCompte.Name = "comboTypeCompte";
            this.comboTypeCompte.Size = new System.Drawing.Size(127, 21);
            this.comboTypeCompte.TabIndex = 45;
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(170, 169);
            this.textSolde.Name = "textSolde";
            this.textSolde.ReadOnly = true;
            this.textSolde.Size = new System.Drawing.Size(127, 20);
            this.textSolde.TabIndex = 46;
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.LightCoral;
            this.btnPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.ForeColor = System.Drawing.Color.White;
            this.btnPremier.Location = new System.Drawing.Point(367, 60);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(61, 35);
            this.btnPremier.TabIndex = 47;
            this.btnPremier.Text = "|<<";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.LightCoral;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(367, 110);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(61, 35);
            this.btnSuivant.TabIndex = 48;
            this.btnSuivant.Text = ">>";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.ForeColor = System.Drawing.Color.White;
            this.btnPrecedent.Location = new System.Drawing.Point(367, 159);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(61, 35);
            this.btnPrecedent.TabIndex = 49;
            this.btnPrecedent.Text = "<<";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.LightCoral;
            this.btnDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernier.ForeColor = System.Drawing.Color.White;
            this.btnDernier.Location = new System.Drawing.Point(367, 207);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(61, 35);
            this.btnDernier.TabIndex = 50;
            this.btnDernier.Text = ">>|";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.LightCoral;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(466, 60);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 35);
            this.btnNouveau.TabIndex = 51;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightCoral;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(466, 110);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 35);
            this.btnAjouter.TabIndex = 52;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightCoral;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(466, 159);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 35);
            this.btnModifier.TabIndex = 53;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(466, 203);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 35);
            this.btnSupprimer.TabIndex = 54;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 178);
            this.dataGridView1.TabIndex = 55;
            // 
            // Comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.comboTypeCompte);
            this.Controls.Add(this.comboNumClient);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Comptes";
            this.Text = "Gestion Comptes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comptes_FormClosing);
            this.Load += new System.EventHandler(this.Comptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.ComboBox comboNumClient;
        private System.Windows.Forms.ComboBox comboTypeCompte;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

