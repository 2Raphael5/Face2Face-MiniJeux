using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Face2Face.Properties;

namespace Face2Face
{
    public partial class Chifoumi : Form
    {
        private enum Choix
        {
            aucun,
            pierre,
            feuille,
            ciseau
        }


        private int phase = 0;
        private double timer = 0.0;
        private int tempsTimer = 3;
        private int pointsMax = 3;
        private Choix choixJ1;
        private Choix choixJ2;
        public Chifoumi()
        {
            InitializeComponent();
            tmrGame.Start();
            choixJ1 = new Choix();
            choixJ2 = new Choix();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            timer++;
            double temps = tempsTimer - timer / 10;
            lblTimer.Text = temps.ToString();
            if (temps <= 0)
            {
                phase++;
                timer = 0;
                updatePhase();
            }
        }
        private void updatePhase()
        {
            if (phase == 0)
            {
                lblPhase.Text = "Préparation";
            }
            else if (phase == 1)
            {
                lblPhase.Text = "Jeu";
                pbxChoixJ1.Image = null;
                pbxChoixJ2.Image = null;
                lblResultat.Text = "";
                tempsTimer = 3;
            }
            else if (phase == 2)
            {
                lblPhase.Text = "Attente du prochain round";
                pbxChoixJ1.Image = Getimage(choixJ1);
                pbxChoixJ2.Image = Getimage(choixJ2);
                checkVictoire();
                choixJ1 = Choix.aucun;
                choixJ2 = Choix.aucun;
                tempsTimer = 2;
            }
            else
            {
                phase = 1;
                updatePhase();
            }
        }
        private Image Getimage(Choix choix)
        {
            if (choix == Choix.pierre)
                return Resources.pierre;
            else if (choix == Choix.feuille)
                return Resources.feuille;
            else if (choix == Choix.ciseau)
                return Resources.ciseau;
            else
                return null;
        }
        private void checkVictoire()
        {
            const string victoireJ1 = "Joueur 1 a gagné le round";
            const string victoireJ2 = "Joueur 2 a gagné le round";
            if (choixJ1 == choixJ2)
            {
                lblResultat.Text = "Égalité";
            }
            else
            {
                if (choixJ1 == Choix.pierre && choixJ2 == Choix.ciseau)
                {
                    lblResultat.Text = victoireJ1;
                }
                else if (choixJ1 == Choix.pierre && choixJ2 == Choix.feuille)
                {
                    lblResultat.Text = victoireJ2;
                }
                else if (choixJ1 == Choix.ciseau && choixJ2 == Choix.feuille)
                {
                    lblResultat.Text = victoireJ1;
                }
                else if (choixJ1 == Choix.ciseau && choixJ2 == Choix.pierre)
                {
                    lblResultat.Text = victoireJ2;
                }
                else if (choixJ1 == Choix.feuille && choixJ2 == Choix.pierre)
                {
                    lblResultat.Text = victoireJ1;
                }
                else if (choixJ1 == Choix.feuille && choixJ2 == Choix.ciseau)
                {
                    lblResultat.Text = victoireJ2;
                }
                else
                {
                    if (choixJ1 == Choix.aucun)
                    {
                        lblResultat.Text = victoireJ2;
                    }
                    else
                    {
                        lblResultat.Text = victoireJ1;
                    }
                }
            }
            int scoreJ1 = Convert.ToInt32(lblScoreJ1.Text);
            int scoreJ2 = Convert.ToInt32(lblScoreJ2.Text);
            if (lblResultat.Text == victoireJ1)
            {

                scoreJ1++;
                lblScoreJ1.Text = scoreJ1.ToString();
            }
            else if (lblResultat.Text == victoireJ2)
            {
                scoreJ2++;
                lblScoreJ2.Text = scoreJ2.ToString();
            }

            if (scoreJ1 == pointsMax || scoreJ2 == pointsMax)
            {
                tmrGame.Stop();
                btnNextGame.Visible = true;
                if (scoreJ1 == 5)
                {
                    lblResultat.Text = "Bravo j1 pour ta victoire";
                    gameMaster.scoreJ1++;
                }
                else
                {
                    lblResultat.Text = "Bravo j2 pour ta victoire";
                    gameMaster.scoreJ2++;
                }
            }            
        }

        private void Chifoumi_KeyDown(object sender, KeyEventArgs e)
        { 
            if (phase == 1)
            {
                if (e.KeyCode == Keys.Q)
                {
                    choixJ1 = Choix.pierre;
                }
                else if (e.KeyCode == Keys.W)
                {
                    choixJ1 = Choix.feuille;
                }
                else if (e.KeyCode == Keys.E)
                {
                    choixJ1 = Choix.ciseau;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    choixJ2 = Choix.pierre;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    choixJ2 = Choix.feuille;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    choixJ2 = Choix.ciseau;
                }
            }
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            new Form1().ChoseNewGame();
            Reset();
            this.Hide();
        }

        private void Chifoumi_Load(object sender, EventArgs e)
        {
            lblJ1.Text = gameMaster.pseudoJ1;
            lblJ2.Text = gameMaster.pseudoJ2;

            for (int i = 1; i <= gameMaster.scoreJ1; i++)
            {
                string name = $"lblScore{i}J1";
                Control[] control = this.Controls.Find(name,true);
                foreach (Control item in control)
                {
                    Label label = item as Label;
                    label.BackColor = Color.Black;
                }
            }
            for (int i = 1; i <= gameMaster.scoreJ2; i++)
            {
                string name = $"lblScore{i}J2";
                Control[] control = this.Controls.Find(name, true);
                foreach (Control item in control)
                {
                    Label label = item as Label;
                    label.BackColor = Color.Black;
                }
            }
        }
        public void Reset()
        {

        }
    }
}
