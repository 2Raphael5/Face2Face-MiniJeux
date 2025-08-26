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

        List<Form> gameList = new List<Form>();
        List<Form> gameListRetired = new List<Form>();
        private void Form1_Load(object sender, EventArgs e)
        {
            gameList.Add(new Morpion());
            gameList.Add(new Puissance4());
            gameList.Add(new Chifoumi());
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            player1Name = tbxPlayer1.Text;
            player2Name = tbxPlayer2.Text;
            ChoseNewGame();
        }
        public void ChoseNewGame()
        {
            Random rnd = new Random();
            int randomGameIndex = rnd.Next(0, gameList.Count);
            gameList[randomGameIndex].Show();
            this.Hide();
        }
    }
}
