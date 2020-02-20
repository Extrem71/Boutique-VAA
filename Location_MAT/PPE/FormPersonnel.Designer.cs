namespace PPE
{
    partial class FormPersonnel
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
            this.btMontagneP = new System.Windows.Forms.Button();
            this.btRandonneP = new System.Windows.Forms.Button();
            this.btSkiP = new System.Windows.Forms.Button();
            this.btEscaladeP = new System.Windows.Forms.Button();
            this.btSortieMat = new System.Windows.Forms.Button();
            this.btAjoutMat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMontagneP
            // 
            this.btMontagneP.Location = new System.Drawing.Point(31, 137);
            this.btMontagneP.Name = "btMontagneP";
            this.btMontagneP.Size = new System.Drawing.Size(110, 37);
            this.btMontagneP.TabIndex = 0;
            this.btMontagneP.Text = "MONTAGNE";
            this.btMontagneP.UseVisualStyleBackColor = true;
            // 
            // btRandonneP
            // 
            this.btRandonneP.Location = new System.Drawing.Point(31, 213);
            this.btRandonneP.Name = "btRandonneP";
            this.btRandonneP.Size = new System.Drawing.Size(110, 34);
            this.btRandonneP.TabIndex = 1;
            this.btRandonneP.Text = "RANDONNE";
            this.btRandonneP.UseVisualStyleBackColor = true;
            // 
            // btSkiP
            // 
            this.btSkiP.Location = new System.Drawing.Point(31, 295);
            this.btSkiP.Name = "btSkiP";
            this.btSkiP.Size = new System.Drawing.Size(110, 37);
            this.btSkiP.TabIndex = 2;
            this.btSkiP.Text = "SKI";
            this.btSkiP.UseVisualStyleBackColor = true;
            // 
            // btEscaladeP
            // 
            this.btEscaladeP.Location = new System.Drawing.Point(31, 376);
            this.btEscaladeP.Name = "btEscaladeP";
            this.btEscaladeP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEscaladeP.Size = new System.Drawing.Size(110, 37);
            this.btEscaladeP.TabIndex = 3;
            this.btEscaladeP.Text = "ESCALADE";
            this.btEscaladeP.UseVisualStyleBackColor = true;
            // 
            // btSortieMat
            // 
            this.btSortieMat.Location = new System.Drawing.Point(836, 195);
            this.btSortieMat.Name = "btSortieMat";
            this.btSortieMat.Size = new System.Drawing.Size(124, 52);
            this.btSortieMat.TabIndex = 4;
            this.btSortieMat.Text = "SORTIR UN MATERIEL";
            this.btSortieMat.UseVisualStyleBackColor = true;
            // 
            // btAjoutMat
            // 
            this.btAjoutMat.Location = new System.Drawing.Point(836, 315);
            this.btAjoutMat.Name = "btAjoutMat";
            this.btAjoutMat.Size = new System.Drawing.Size(124, 52);
            this.btAjoutMat.TabIndex = 5;
            this.btAjoutMat.Text = "AJOUTER DU MATERIEL";
            this.btAjoutMat.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(204, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 356);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU DU PERSONNEL ";
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(992, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btAjoutMat);
            this.Controls.Add(this.btSortieMat);
            this.Controls.Add(this.btEscaladeP);
            this.Controls.Add(this.btSkiP);
            this.Controls.Add(this.btRandonneP);
            this.Controls.Add(this.btMontagneP);
            this.Name = "FormPersonnel";
            this.Text = "FormPersonnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMontagneP;
        private System.Windows.Forms.Button btRandonneP;
        private System.Windows.Forms.Button btSkiP;
        private System.Windows.Forms.Button btEscaladeP;
        private System.Windows.Forms.Button btSortieMat;
        private System.Windows.Forms.Button btAjoutMat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}