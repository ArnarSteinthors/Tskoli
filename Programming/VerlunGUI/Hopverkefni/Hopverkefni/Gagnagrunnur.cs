using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Hopverkefni
{
    class Gagnagrunnur
    {
        private string server;

        private string database;

        private string uid;

        private string password;

        string tengistrengur = null;

        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqlLesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "3001992599_GRU";
            uid = "3001992599";
            password = "mypassword";

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }


        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }


        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }



        
        public List<string> LesaNotendur()
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT id, Heiti FROM starfsmenn";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {
                    for (int i = 0; i < sqlLesari.FieldCount; i++)
                    {
                        lina += (sqlLesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }


        public string GetPassword(string id)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT lykilorð FROM starfsmenn WHERE id = '"+id+"'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {
                    
                       faersla= (sqlLesari.GetValue(0).ToString());
                    
                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }
        public string GetVara(string voruheiti)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Heiti FROM vara WHERE Heiti = '"+voruheiti+"'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }
        public string GetVaraVerd(string voruheiti)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Verð FROM vara WHERE Heiti = '"+voruheiti+"'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }

        public string Numbpad_heiti(int tala)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Heiti FROM vara WHERE ARTnr ='" + tala + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }

        public string Numbpad_verd(int tala)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Verð FROM vara WHERE ARTnr ='" + tala + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }
        public List<string> Voruleit()
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            
 if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ARTnr, Heiti, Verð FROM vara";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {
                    for (int i = 0; i < sqlLesari.FieldCount; i++)
                    {
                        lina += (sqlLesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }
        public List<string> Leitarorð(string leitarorð)
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ARTnr, Heiti, Verð FROM vara WHERE Heiti LIKE '%"+leitarorð+"%'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {
                    for (int i = 0; i < sqlLesari.FieldCount; i++)
                    {
                        lina += (sqlLesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }
        

        public string GetVaraFromArt(string artnr)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Heiti FROM vara WHERE ARTnr = '" + artnr + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }
        public string GetVaraVerdFromArt(string artnr)
        {
            string faersla = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Verð FROM vara WHERE ARTnr = '" + artnr + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {

                    faersla = (sqlLesari.GetValue(0).ToString());

                }
                CloseConnection();
                return faersla;
            }
            return faersla;
        }

    }
}
