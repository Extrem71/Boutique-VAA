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
    public partial class FormVacancier : Form
    {
        public FormVacancier()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormVacancier_Load(object sender, EventArgs e)
        {
            List<Matériaux> unMat = new List<Matériaux>();

            unMat = ConnexionADO.ChargerMat();

            foreach(Matériaux m in unMat)
            {
                Console.WriteLine(lstMateriaux.Items.Add(m));
            }
        }
    }
}
