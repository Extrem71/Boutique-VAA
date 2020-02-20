namespace PPE
{
    partial class Vente
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnexion = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lbIdentifiant = new System.Windows.Forms.Label();
            this.lbMotDePasse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
            this.btConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnexion.Location = new System.Drawing.Point(180, 257);
            this.btConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(155, 38);
            this.btConnexion.TabIndex = 1;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(205, 121);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(130, 22);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(205, 181);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(130, 22);
            this.txtMotDePasse.TabIndex = 3;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // lbIdentifiant
            // 
            this.lbIdentifiant.AutoSize = true;
            this.lbIdentifiant.Location = new System.Drawing.Point(86, 123);
            this.lbIdentifiant.Name = "lbIdentifiant";
            this.lbIdentifiant.Size = new System.Drawing.Size(77, 17);
            this.lbIdentifiant.TabIndex = 4;
            this.lbIdentifiant.Text = "Identifiant :";
            this.lbIdentifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMotDePasse
            // 
            this.lbMotDePasse.AutoSize = true;
            this.lbMotDePasse.Location = new System.Drawing.Point(64, 186);
            this.lbMotDePasse.Name = "lbMotDePasse";
            this.lbMotDePasse.Size = new System.Drawing.Size(101, 17);
            this.lbMotDePasse.TabIndex = 5;
            this.lbMotDePasse.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOCATION DE MATERIAUX";
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::PPE.Properties.Resources.Village_vacance;
            this.ClientSize = new System.Drawing.Size(517, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMotDePasse);
            this.Controls.Add(this.lbIdentifiant);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.btConnexion);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lbIdentifiant;
        private System.Windows.Forms.Label lbMotDePasse;
        private System.Windows.Forms.Label label3;
    }
}

