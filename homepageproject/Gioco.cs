using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace homepageproject
{
    public partial class Gioco : Form
    {
        static int currentCard;
        static int nextCard;
        static int score = 0;
        static int bestscore = 0;
        Random random = new Random();
        private DateTime endTime;
        public Gioco()
        {
            InitializeComponent();

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Punteggiofinale f = new Punteggiofinale();
            f.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            home f = new home();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Gioco_Load_1(object sender, EventArgs e)
        {
            endTime = DateTime.Now.AddSeconds(61);
            timer1.Start();
            currentCard = random.Next(1, 14);
            nextCard = random.Next(1, 14);
            UpdatePictureBox(currentCard);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.Now;
            if (remainingTime <= TimeSpan.Zero)
            {
                timer1.Stop();
                score = 0;
                UpdateScoreLabel(score);
                UpdateBestScoreLabel(bestscore);
                MessageBox.Show("Timer Finished!");
                bestscore = 0;
                this.Hide();
                PunteggioFinaleSingolo f = new PunteggioFinaleSingolo();
                f.Show();
            }
            else
            {
                label1.Text = remainingTime.ToString(@"ss");
            }
        }

        private void Higherbutton_Click(object sender, EventArgs e)
        {
            if (nextCard >= currentCard)
            {
                score++;

            }
            else
            {
                if (score > bestscore)
                {
                    bestscore = score;

                }
                score = 0;
            }
            UpdateScoreLabel(score);
            UpdateBestScoreLabel(bestscore);
            currentCard = nextCard;
            nextCard = random.Next(1, 14);
            UpdatePictureBox(currentCard);
            
        }

        private void Lowerbutton_Click(object sender, EventArgs e)
        {
            if (nextCard <= currentCard)
            {
                score++;

            }
            else
            {
                if (score > bestscore)
                {
                    bestscore = score;

                }
                score = 0;
            }
            UpdateScoreLabel(score);
            UpdateBestScoreLabel(bestscore);
            currentCard = nextCard;
            nextCard = random.Next(1, 14);
            UpdatePictureBox(currentCard);

        }
        void UpdatePictureBox(int currentCard)
        {
            char[] letters = { 'c', 'f', 'p', 'q' };
            int index = random.Next(letters.Length);
            char randomLetter = letters[index];
            string cardText = currentCard.ToString() + randomLetter;

            string imagePath = Path.Combine(@"immagini carte\", cardText + ".jpg");

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Immagine non trovata per la carta " + cardText);
            }
        }
        void UpdateScoreLabel(int score)
        {
            Invoke(new Action(() =>
            {
                LabelScore.Text = score.ToString();
            }));
        }

        void UpdateBestScoreLabel(int bestScore)
        {
            Invoke(new Action(() =>
            {
                LabelBestScore.Text = bestScore.ToString();
            }));
        }
    }
}
