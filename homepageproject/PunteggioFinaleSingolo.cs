using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepageproject
{
    public partial class PunteggioFinaleSingolo : Form
    {
        public PunteggioFinaleSingolo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }
    }
}
