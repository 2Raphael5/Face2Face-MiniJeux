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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {

            gameMaster.gameList.Add(new Morpion());
            gameMaster.gameList.Add(new Puissance4());
            gameMaster.gameList.Add(new Chifoumi());
            gameMaster.gameList.Add(new Mastermind());
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameMaster.pseudoJ1 = tbxPlayer1.Text;
            gameMaster.pseudoJ2 = tbxPlayer2.Text;
            ChoseNewGame();
        }
        public void ChoseNewGame()
        {
            rnd = new Random();
            int randomGameIndex = rnd.Next(0, gameMaster.gameList.Count);
            gameMaster.gameList[randomGameIndex].Show();
            this.Hide();
        }

        private void lblPseudoJoueur_TextChanged(object sender, EventArgs e)
        {
            if(tbxPlayer1.Text != "" && tbxPlayer1.Text.Length >= 2  && tbxPlayer2.Text != "" && tbxPlayer2.Text.Length >= 2)
            {
                btnStartGame.Enabled = true;
            }
            else
            {

                btnStartGame.Enabled = false;
            }
        }
    }
}
