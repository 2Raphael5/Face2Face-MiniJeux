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
        string player1Name;
        string player2Name;
        Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {

            listeJeu.gameList.Add(new Morpion());
            listeJeu.gameList.Add(new Puissance4());
            listeJeu.gameList.Add(new Chifoumi());
            listeJeu.gameList.Add(new Mastermind());
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            player1Name = tbxPlayer1.Text;
            player2Name = tbxPlayer2.Text;
            ChoseNewGame();
        }
        public void ChoseNewGame()
        {
            rnd = new Random();
            int randomGameIndex = rnd.Next(0, listeJeu.gameList.Count);
            listeJeu.gameList[randomGameIndex].Show();
            this.Hide();
        }
    }
}
