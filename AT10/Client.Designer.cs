namespace AT10
{
    partial class Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.txtNumClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrenomClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNumClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 178);
            this.dataGridView1.TabIndex = 73;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(559, 205);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 35);
            this.btnSupprimer.TabIndex = 72;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightCoral;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(559, 161);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 35);
            this.btnModifier.TabIndex = 71;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightCoral;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(559, 112);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 35);
            this.btnAjouter.TabIndex = 70;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.LightCoral;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(559, 62);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 35);
            this.btnNouveau.TabIndex = 69;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.LightCoral;
            this.btnDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernier.ForeColor = System.Drawing.Color.White;
            this.btnDernier.Location = new System.Drawing.Point(460, 209);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(61, 35);
            this.btnDernier.TabIndex = 68;
            this.btnDernier.Text = ">>|";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.ForeColor = System.Drawing.Color.White;
            this.btnPrecedent.Location = new System.Drawing.Point(460, 161);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(61, 35);
            this.btnPrecedent.TabIndex = 67;
            this.btnPrecedent.Text = "<<";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.LightCoral;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(460, 112);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(61, 35);
            this.btnSuivant.TabIndex = 66;
            this.btnSuivant.Text = ">>";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.LightCoral;
            this.btnPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.ForeColor = System.Drawing.Color.White;
            this.btnPremier.Location = new System.Drawing.Point(460, 62);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(61, 35);
            this.btnPremier.TabIndex = 65;
            this.btnPremier.Text = "|<<";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // txtNumClient
            // 
            this.txtNumClient.Location = new System.Drawing.Point(263, 77);
            this.txtNumClient.Name = "txtNumClient";
            this.txtNumClient.Size = new System.Drawing.Size(127, 20);
            this.txtNumClient.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Num Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Gestion Clients";
            // 
            // textNomClient
            // 
            this.textNomClient.Location = new System.Drawing.Point(263, 127);
            this.textNomClient.Name = "textNomClient";
            this.textNomClient.Size = new System.Drawing.Size(127, 20);
            this.textNomClient.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nom Client";
            // 
            // textPrenomClient
            // 
            this.textPrenomClient.Location = new System.Drawing.Point(263, 176);
            this.textPrenomClient.Name = "textPrenomClient";
            this.textPrenomClient.Size = new System.Drawing.Size(127, 20);
            this.textPrenomClient.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Prénom Client";
            // 
            // comboNumClient
            // 
            this.comboNumClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumClient.FormattingEnabled = true;
            this.comboNumClient.Location = new System.Drawing.Point(263, 75);
            this.comboNumClient.Name = "comboNumClient";
            this.comboNumClient.Size = new System.Drawing.Size(127, 21);
            this.comboNumClient.TabIndex = 78;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboNumClient);
            this.Controls.Add(this.textPrenomClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNomClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.txtNumClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Gestion Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.TextBox txtNumClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrenomClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboNumClient;
    }
}