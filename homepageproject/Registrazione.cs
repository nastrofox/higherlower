using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace homepageproject
{
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        private void Accedi_Click(object sender, EventArgs e)
        {
            /*string server = "localhost";
            string us = "boss";
            string pd = "boss";
            string database = "higherorlower";

            string connectionString = $"Server={server};Database={database};Uid={us};Pwd={pd};";

            MySqlConnection connection = new MySqlConnection(connectionString);
            string queryname = "SELECT username FROM higherorlower";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(queryname, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    MessageBox.Show("Name: " + name);
                }
                reader.Close();
                MessageBox.Show("Connessione riuscita!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connessione fallita: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }*/
        }


        private void Home_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
