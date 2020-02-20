namespace PPE
{
    partial class FormVacancier
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
            this.btMontagne = new System.Windows.Forms.Button();
            this.btSki = new System.Windows.Forms.Button();
            this.btEscalade = new System.Windows.Forms.Button();
            this.btRandonne = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstMateriaux = new System.Windows.Forms.ListBox();
            this.btConsulter = new System.Windows.Forms.Button();
            this.btReserver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMontagne
            // 
            this.btMontagne.Location = new System.Drawing.Point(26, 137);
            this.btMontagne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMontagne.Name = "btMontagne";
            this.btMontagne.Size = new System.Drawing.Size(133, 37);
            this.btMontagne.TabIndex = 0;
            this.btMontagne.Text = "MONTAGNE";
            this.btMontagne.UseVisualStyleBackColor = true;
            // 
            // btSki
            // 
            this.btSki.Location = new System.Drawing.Point(26, 206);
            this.btSki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSki.Name = "btSki";
            this.btSki.Size = new System.Drawing.Size(133, 37);
            this.btSki.TabIndex = 1;
            this.btSki.Text = "SKI ";
            this.btSki.UseVisualStyleBackColor = true;
            // 
            // btEscalade
            // 
            this.btEscalade.Location = new System.Drawing.Point(26, 285);
            this.btEscalade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEscalade.Name = "btEscalade";
            this.btEscalade.Size = new System.Drawing.Size(133, 36);
            this.btEscalade.TabIndex = 2;
            this.btEscalade.Text = "ESCALADE";
            this.btEscalade.UseVisualStyleBackColor = true;
            // 
            // btRandonne
            // 
            this.btRandonne.Location = new System.Drawing.Point(26, 354);
            this.btRandonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRandonne.Name = "btRandonne";
            this.btRandonne.Size = new System.Drawing.Size(133, 33);
            this.btRandonne.TabIndex = 3;
            this.btRandonne.Text = "RANDONNE";
            this.btRandonne.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lstMateriaux
            // 
            this.lstMateriaux.FormattingEnabled = true;
            this.lstMateriaux.ItemHeight = 16;
            this.lstMateriaux.Location = new System.Drawing.Point(202, 104);
            this.lstMateriaux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMateriaux.Name = "lstMateriaux";
            this.lstMateriaux.Size = new System.Drawing.Size(505, 340);
            this.lstMateriaux.TabIndex = 5;
            // 
            // btConsulter
            // 
            this.btConsulter.Location = new System.Drawing.Point(766, 365);
            this.btConsulter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsulter.Name = "btConsulter";
            this.btConsulter.Size = new System.Drawing.Size(119, 45);
            this.btConsulter.TabIndex = 6;
            this.btConsulter.Text = "VOIR MON PANIER";
            this.btConsulter.UseVisualStyleBackColor = true;
            this.btConsulter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReserver
            // 
            this.btReserver.Location = new System.Drawing.Point(766, 258);
            this.btReserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReserver.Name = "btReserver";
            this.btReserver.Size = new System.Drawing.Size(119, 45);
            this.btReserver.TabIndex = 7;
            this.btReserver.Text = "RESERVER";
            this.btReserver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "BOUTIQUE VVA";
            // 
            // FormVacancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(943, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReserver);
            this.Controls.Add(this.btConsulter);
            this.Controls.Add(this.lstMateriaux);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btRandonne);
            this.Controls.Add(this.btEscalade);
            this.Controls.Add(this.btSki);
            this.Controls.Add(this.btMontagne);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormVacancier";
            this.Text = "Boutique VACANCIER";
            this.Load += new System.EventHandler(this.FormVacancier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMontagne;
        private System.Windows.Forms.Button btSki;
        private System.Windows.Forms.Button btEscalade;
        private System.Windows.Forms.Button btRandonne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstMateriaux;
        private System.Windows.Forms.Button btConsulter;
        private System.Windows.Forms.Button btReserver;
        private System.Windows.Forms.Label label1;
    }
}