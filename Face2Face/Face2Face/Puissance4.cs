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
    public partial class Puissance4 : Form
    {
        public Puissance4()
        {
            InitializeComponent();
        }
        #region Création Liste label
        List<Label> colonneLabel1 = new List<Label>();
        List<Label> colonneLabel2 = new List<Label>();
        List<Label> colonneLabel3 = new List<Label>();
        List<Label> colonneLabel4 = new List<Label>();
        List<Label> colonneLabel5 = new List<Label>();
        List<Label> colonneLabel6 = new List<Label>();
        List<Label> colonneLabel7 = new List<Label>();

        List<Label> ligneLabel1 = new List<Label>();
        List<Label> ligneLabel2 = new List<Label>();
        List<Label> ligneLabel3 = new List<Label>();
        List<Label> ligneLabel4 = new List<Label>();
        List<Label> ligneLabel5 = new List<Label>();
        List<Label> ligneLabel6 = new List<Label>();
        List<Label> ligneLabel7 = new List<Label>();
        #endregion

        public bool player1Turn;
        private void Puissance4_Load(object sender, EventArgs e)
        {
            player1Turn = true;
            AddAllCollumn();
            AddAllLine();
        }
        public void AddAllCollumn()
        {
            colonneLabel1.Add(lblCase1);
            colonneLabel1.Add(lblCase8);
            colonneLabel1.Add(lblCase15);
            colonneLabel1.Add(lblCase22);
            colonneLabel1.Add(lblCase29);
            colonneLabel1.Add(lblCase36);

            colonneLabel2.Add(lblCase2);
            colonneLabel2.Add(lblCase9);
            colonneLabel2.Add(lblCase16);
            colonneLabel2.Add(lblCase23);
            colonneLabel2.Add(lblCase30);
            colonneLabel2.Add(lblCase37);

            colonneLabel3.Add(lblCase3);
            colonneLabel3.Add(lblCase10);
            colonneLabel3.Add(lblCase17);
            colonneLabel3.Add(lblCase24);
            colonneLabel3.Add(lblCase31);
            colonneLabel3.Add(lblCase38);

            colonneLabel4.Add(lblCase4);
            colonneLabel4.Add(lblCase11);
            colonneLabel4.Add(lblCase18);
            colonneLabel4.Add(lblCase25);
            colonneLabel4.Add(lblCase32);
            colonneLabel4.Add(lblCase39);

            colonneLabel5.Add(lblCase5);
            colonneLabel5.Add(lblCase12);
            colonneLabel5.Add(lblCase19);
            colonneLabel5.Add(lblCase26);
            colonneLabel5.Add(lblCase33);
            colonneLabel5.Add(lblCase40);

            colonneLabel6.Add(lblCase6);
            colonneLabel6.Add(lblCase13);
            colonneLabel6.Add(lblCase20);
            colonneLabel6.Add(lblCase27);
            colonneLabel6.Add(lblCase34);
            colonneLabel6.Add(lblCase41);

            colonneLabel7.Add(lblCase7);
            colonneLabel7.Add(lblCase14);
            colonneLabel7.Add(lblCase21);
            colonneLabel7.Add(lblCase28);
            colonneLabel7.Add(lblCase35);
            colonneLabel7.Add(lblCase42);
        }
        public void AddAllLine()
        {
            ligneLabel1.Add(lblCase1);
            ligneLabel1.Add(lblCase2);
            ligneLabel1.Add(lblCase3);
            ligneLabel1.Add(lblCase4);
            ligneLabel1.Add(lblCase5);
            ligneLabel1.Add(lblCase6);
            ligneLabel1.Add(lblCase7);

            ligneLabel2.Add(lblCase8);
            ligneLabel2.Add(lblCase9);
            ligneLabel2.Add(lblCase10);
            ligneLabel2.Add(lblCase11);
            ligneLabel2.Add(lblCase12);
            ligneLabel2.Add(lblCase13);
            ligneLabel2.Add(lblCase14);

            ligneLabel3.Add(lblCase15);
            ligneLabel3.Add(lblCase16);
            ligneLabel3.Add(lblCase17);
            ligneLabel3.Add(lblCase18);
            ligneLabel3.Add(lblCase19);
            ligneLabel3.Add(lblCase20);
            ligneLabel3.Add(lblCase21);

            ligneLabel4.Add(lblCase22);
            ligneLabel4.Add(lblCase23);
            ligneLabel4.Add(lblCase24);
            ligneLabel4.Add(lblCase25);
            ligneLabel4.Add(lblCase26);
            ligneLabel4.Add(lblCase27);
            ligneLabel4.Add(lblCase28);

            ligneLabel5.Add(lblCase29);
            ligneLabel5.Add(lblCase30);
            ligneLabel5.Add(lblCase31);
            ligneLabel5.Add(lblCase32);
            ligneLabel5.Add(lblCase33);
            ligneLabel5.Add(lblCase34);
            ligneLabel5.Add(lblCase35);

            ligneLabel6.Add(lblCase36);
            ligneLabel6.Add(lblCase37);
            ligneLabel6.Add(lblCase38);
            ligneLabel6.Add(lblCase39);
            ligneLabel6.Add(lblCase40);
            ligneLabel6.Add(lblCase41);
            ligneLabel6.Add(lblCase42);
        }
        #region Click event
        private void ClickColumn1(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel1);
            CheckEgality();
        }
        private void ClickColumn2(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel2);
            CheckEgality();
        }

        private void ClickColumn3(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel3);
            CheckEgality();
        }

        private void ClickColumn4(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel4);
            CheckEgality();
        }

        private void ClickColumn5(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel5);
            CheckEgality();
        }

        private void ClickColumn6(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel6);
            CheckEgality();
        }

        private void ClickColumn7(object sender, EventArgs e)
        {
            ColoredCase(colonneLabel7);
            CheckEgality();
        }
        #endregion

        void ColoredCase(List<Label> listLabel)
        {

            bool continuer = true;
            for (int i = 0; i < listLabel.Count - 1; i++)
            {
                if (listLabel[i].BackColor == Color.DeepSkyBlue && listLabel[i + 1].BackColor != Color.DeepSkyBlue)
                {
                    continuer = false;
                    if (player1Turn)
                    {
                        listLabel[i].BackColor = Color.Red;
                        player1Turn = false;
                    }
                    else
                    {
                        listLabel[i].BackColor = Color.Yellow;
                        player1Turn = true;
                    }
                }
            }
            if (continuer)
            {
                if (player1Turn)
                {
                    listLabel[listLabel.Count - 1].BackColor = Color.Red;
                    player1Turn = false;
                }
                else
                {
                    listLabel[listLabel.Count - 1].BackColor = Color.Yellow;
                    player1Turn = true;
                }
            }
            VerifyColumn(listLabel);
            VerifyLines();
            VerifyDiagonal();
        }
        void VerifyColumn(List<Label> listLabel)
        {
            for (int i = 0; i <= listLabel.Count - 4; i++)
            {
                if (listLabel[i].BackColor != Color.DeepSkyBlue)
                {
                    if (listLabel[i].BackColor == listLabel[i + 1].BackColor &&
                        listLabel[i].BackColor == listLabel[i + 2].BackColor &&
                        listLabel[i].BackColor == listLabel[i + 3].BackColor)
                    {
                        if (listLabel[i].BackColor == Color.Red)
                        {
                            gameMaster.scoreJ1++;
                            MessageBox.Show("Le joueur 1 a gagné !");
                        }
                        else if (listLabel[i].BackColor == Color.Yellow)
                        {
                            gameMaster.scoreJ2++;
                            MessageBox.Show("Le joueur 2 a gagné !");
                        }
                        new Form1().ChoseNewGame();
                        this.Hide();
                    }
                }
            }
        }
        void VerifyLines()
        {
            List<List<Label>> toutesLesLignes = new List<List<Label>>()
        {
        ligneLabel1, ligneLabel2, ligneLabel3,
        ligneLabel4, ligneLabel5, ligneLabel6
        };

            foreach (var ligne in toutesLesLignes)
            {
                for (int i = 0; i <= ligne.Count - 4; i++)
                {
                    if (ligne[i].BackColor != Color.DeepSkyBlue)
                    {
                        if (ligne[i].BackColor == ligne[i + 1].BackColor &&
                            ligne[i].BackColor == ligne[i + 2].BackColor &&
                            ligne[i].BackColor == ligne[i + 3].BackColor)
                        {
                            if (ligne[i].BackColor == Color.Red)
                                MessageBox.Show("Le joueur 1 a gagné!");
                            else if (ligne[i].BackColor == Color.Yellow)
                                MessageBox.Show("Le joueur 2 a gagné!");
                            new Form1().ChoseNewGame();
                            this.Hide();
                        }
                    }
                }
            }
        }
        void VerifyDiagonal()
        {
            Label[,] grid = GetGrid();

            // Vérification ↘ (haut-gauche vers bas-droite)
            for (int row = 0; row < 6 - 3; row++) // 6 lignes - 3 pour rester dans la grille
            {
                for (int col = 0; col < 7 - 3; col++) // 7 colonnes - 3
                {
                    if (grid[row, col].BackColor != Color.DeepSkyBlue)
                    {
                        if (grid[row, col].BackColor == grid[row + 1, col + 1].BackColor &&
                            grid[row, col].BackColor == grid[row + 2, col + 2].BackColor &&
                            grid[row, col].BackColor == grid[row + 3, col + 3].BackColor)
                        {
                            DeclareWinner(grid[row, col].BackColor);
                        }
                    }
                }
            }

            // Vérification ↙ (haut-droite vers bas-gauche)
            for (int row = 0; row < 6 - 3; row++)
            {
                for (int col = 3; col < 7; col++) // commence à 3 car on doit pouvoir descendre à gauche
                {
                    if (grid[row, col].BackColor != Color.DeepSkyBlue)
                    {
                        if (grid[row, col].BackColor == grid[row + 1, col - 1].BackColor &&
                            grid[row, col].BackColor == grid[row + 2, col - 2].BackColor &&
                            grid[row, col].BackColor == grid[row + 3, col - 3].BackColor)
                        {
                            DeclareWinner(grid[row, col].BackColor);
                        }
                    }
                }
            }
        }
        void DeclareWinner(Color color)
        {
            if (color == Color.Red)
            {
                gameMaster.scoreJ1++;
                MessageBox.Show("Le joueur 1 a gagné !");
            }
            else if (color == Color.Yellow)
            {
                gameMaster.scoreJ2++;
                MessageBox.Show("Le joueur 2 a gagné !");
            }
            Reset();
            this.Hide();
            new Form1().ChoseNewGame();
        }
        Label[,] GetGrid()
        {
            Label[,] grid = new Label[6, 7];

            List<List<Label>> toutesLesLignes = new List<List<Label>>()
    {
        ligneLabel1, ligneLabel2, ligneLabel3,
        ligneLabel4, ligneLabel5, ligneLabel6
    };

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    grid[row, col] = toutesLesLignes[row][col];
                }
            }

            return grid;
        }
        public void CheckEgality()
        {
            bool isFree = false;
            foreach (Label label in colonneLabel1)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel2)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel3)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel4)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel5)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel6)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            foreach (Label label in colonneLabel7)
            {
                if (label.BackColor == Color.DeepSkyBlue)
                {
                    isFree = true;
                }
            }
            if (!isFree)
            {
                MessageBox.Show("Egalité");
                Reset();
            }
        }
        public void Reset()
        {
            foreach (Label label in colonneLabel1)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel2)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel3)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel4)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel5)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel6)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
            foreach (Label label in colonneLabel7)
            {
                label.BackColor = Color.DeepSkyBlue;
            }
        }
    }
}
