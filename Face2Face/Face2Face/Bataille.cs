using Face2Face.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face2Face
{
    public partial class Bataille : Form
    {
        public Bataille()
        {
            InitializeComponent();
        }
        public int scoreJ1;
        public int scoreJ2;

        List<Card> cards = new List<Card>();

        public Card cardJ1;
        public Card cardJ2;
        private void Bataille_Load(object sender, EventArgs e)
        {
            cards.Add(new Card(1, false, Resources.AH));
            cards.Add(new Card(2, false, Resources._2H));
            cards.Add(new Card(3, false, Resources._3H));
            cards.Add(new Card(4, false, Resources._4H));
            cards.Add(new Card(5, false, Resources._5H));
            cards.Add(new Card(6, false, Resources._6H));
            cards.Add(new Card(7, false, Resources._7H));
            cards.Add(new Card(8, false, Resources._8H));
            cards.Add(new Card(9, false, Resources._9H));
            cards.Add(new Card(10, false, Resources._10H));
            cards.Add(new Card(11, true, Resources.JH));
            cards.Add(new Card(12, true, Resources.QH));
            cards.Add(new Card(13, true, Resources.KH));

            cards.Add(new Card(1, false, Resources.AD));
            cards.Add(new Card(2, false, Resources._2D));
            cards.Add(new Card(3, false, Resources._3D));
            cards.Add(new Card(4, false, Resources._4D));
            cards.Add(new Card(5, false, Resources._5D));
            cards.Add(new Card(6, false, Resources._6D));
            cards.Add(new Card(7, false, Resources._7D));
            cards.Add(new Card(8, false, Resources._8D));
            cards.Add(new Card(9, false, Resources._9D));
            cards.Add(new Card(10, false, Resources._10D));
            cards.Add(new Card(11, true, Resources.JD));
            cards.Add(new Card(12, true, Resources.QD));
            cards.Add(new Card(13, true, Resources.KD));

            cards.Add(new Card(1, false, Resources.AS));
            cards.Add(new Card(2, false, Resources._2S));
            cards.Add(new Card(3, false, Resources._3S));
            cards.Add(new Card(4, false, Resources._4S));
            cards.Add(new Card(5, false, Resources._5S));
            cards.Add(new Card(6, false, Resources._6S));
            cards.Add(new Card(7, false, Resources._7S));
            cards.Add(new Card(8, false, Resources._8S));
            cards.Add(new Card(9, false, Resources._9S));
            cards.Add(new Card(10, false, Resources._10S));
            cards.Add(new Card(11, true, Resources.JS));
            cards.Add(new Card(12, true, Resources.QS));
            cards.Add(new Card(13, true, Resources.KS));

            cards.Add(new Card(1, false, Resources.AC));
            cards.Add(new Card(2, false, Resources._2C));
            cards.Add(new Card(3, false, Resources._3C));
            cards.Add(new Card(4, false, Resources._4C));
            cards.Add(new Card(5, false, Resources._5C));
            cards.Add(new Card(6, false, Resources._6C));
            cards.Add(new Card(7, false, Resources._7C));
            cards.Add(new Card(8, false, Resources._8C));
            cards.Add(new Card(9, false, Resources._9C));
            cards.Add(new Card(10, false, Resources._10C));
            cards.Add(new Card(11, true, Resources.JC));
            cards.Add(new Card(12, true, Resources.QC));
            cards.Add(new Card(13, true, Resources.KC));
        }                            
        public void DrawCard()
        {
            Random rnd = new Random();
            int j1 = rnd.Next(0, cards.Count);

            int j2 = rnd.Next(0, cards.Count);

            cardJ1 = cards[j1];
            cardJ2 = cards[j2];

            pbxJ1.Image = cardJ1.image;
            pbxJ2.Image = cardJ2.image;
            Battle();
        }
        public void Battle()
        {
            if (cardJ2.isFigure && cardJ1.value == 1)
            {
                scoreJ1++;
                MessageBox.Show("Victoire du joueur 1");
            }
            else if (cardJ1.isFigure && cardJ2.value == 1)
            {
                scoreJ2++;
                MessageBox.Show("Victoire du joueur 2");
            }
            else
            {
                if (cardJ1.value < cardJ2.value)
                {
                    scoreJ2++;
                    MessageBox.Show("Victoire du joueur 2");
                }
                else if (cardJ1.value > cardJ2.value)
                {
                    scoreJ1++;
                    MessageBox.Show("Victoire du joueur 1");
                }
                else
                {
                    MessageBox.Show("Egalité");
                }
            }
            lblScore1.Text = "Score: " + scoreJ1;
            lblScore2.Text = "Score: " + scoreJ2;
            if (scoreJ1 == 5)
            {
                gameMaster.scoreJ1++;
                MessageBox.Show("Le joueur 1 à gagner cette partie");
                Reset();
                this.Hide();
                new Form1().ChoseNewGame();
            }
            else if (scoreJ2 == 5)
            {
                gameMaster.scoreJ2++;
                MessageBox.Show("Le joueur 2 à gagner cette partie");
                Reset();
                this.Hide();
                new Form1().ChoseNewGame();

            }
        }
        private void Bataille_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                DrawCard();
            }
        }
        public void Reset()
        {
            scoreJ1 = 0;
            scoreJ2 = 0;

            lblScore1.Text = "Score: " + scoreJ1;
            lblScore2.Text = "Score: " + scoreJ2;

            pbxJ1.Image = Properties.Resources.b1fv;
            pbxJ2.Image = Properties.Resources.b1fv;
        }
    }
}
