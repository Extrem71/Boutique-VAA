using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class ConnexionADO
    {
        private static string Connexion = @"server=localhost;password=;userid=root;database=ppe_loc";
        private static MySqlConnection connec;


        public static bool ConnexionBDD()
        {
            // Méthode static qui se connect à la base de donnée.
            connec = new MySqlConnection(Connexion);
            connec.Open();
            return (connec.State == System.Data.ConnectionState.Open);

        }

        public static bool DeconnexionBDD()
        {
            connec = new MySqlConnection(Connexion);
            connec.Close();
            return (connec.State == System.Data.ConnectionState.Closed);
        }

        public static bool ConnexionVerif(string id, string pass)
        {
            bool res = false;
            MySqlCommand commande = connec.CreateCommand();
            // Récupère USER / MOT DE PASSE 
            string req0 = "SELECT Identifiant, Pass FROM compte WHERE Identifiant='" + id + "' AND Pass='" + pass + "'";
            commande.CommandText = req0;


            MySqlDataReader lire = commande.ExecuteReader();

            if  (lire.Read())
            {

                res = true;         
             
            }
            lire.Close();
            
                return res;
        }


        public static List<Matériaux> ChargerMat()
        {
            MySqlCommand commande = connec.CreateCommand();

            List<Matériaux> LesMateriaux = new List<Matériaux>();

            string req = "SELECT * FROM materiaux";
            commande.CommandText = req;

            // Récupération des matériaux par un foreach
            MySqlDataReader reader = commande.ExecuteReader();

            while (reader.Read())
            {
                Matériaux mat = new Matériaux((string)reader["nom_mat"], (string)reader["COUL_MAT"], (int)reader["PRIX_MAT"]);
                LesMateriaux.Add(mat);
            }

            reader.Close();
            return LesMateriaux;
        }
    }
}
