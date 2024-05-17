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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrazione f = new Registrazione();
            f.Show();
        }

        private void Accedi_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            //String ConnectionString = "server=127.0.0.1;uid=boss;pwd=boss;database=higherorlower";
           // MySqlConnection conn = new MySqlConnection(ConnectionString);
            //conn.Open();
            String sqlname = "select username from higherorlower;";
            String sqlpassword = "select password from higherorlower;";
            //if (sqlname == username && sqlpassword == password)
            //{
            //connssione al sever principale
            if(username == "admin" &&  password == "admin")
            {
                    
            }
            else
            {
                
            }
            /*Amministrazione n = new Amministrazione();
            n.Show();
            this.Hide();*/
            //conn.Close();
            //connessione alla pagina principale del gioco 
            //}
            this.Hide();
            home f = new home();
            f.Show();

        }

    }
}
