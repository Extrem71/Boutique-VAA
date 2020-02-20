using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class Vente : Form
    {
        public Vente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            string id = txtIdentifiant.Text;
            string pass = txtMotDePasse.Text;

            ConnexionADO.ConnexionBDD();

            if (ConnexionADO.ConnexionVerif(id, pass))
            {
                MessageBox.Show("Vous êtes connecté");
                FormVacancier form2 = new FormVacancier();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erreur de compte");
            }
           
        }
    }
}
