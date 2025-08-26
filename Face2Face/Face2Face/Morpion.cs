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
    public partial class Morpion : Form
    {
        public Morpion()
        {
            InitializeComponent();
        }
        public bool player1Turn;
        List<Label> labelsUp = new List<Label>();
        List<Label> labelsCenter = new List<Label>();
        List<Label> labelsDown = new List<Label>();
        private void Morpion_Load(object sender, EventArgs e)
        {
            player1Turn = true;

            labelsUp.Add(lblCaseLeftUp);
            labelsUp.Add(lblCaseMiddleUp);
            labelsUp.Add(lblCaseRightUp);

            labelsCenter.Add(lblCaseLeftCenter);
            labelsCenter.Add(lblCaseMiddleCenter);
            labelsCenter.Add(lblCaseRightCenter);

            labelsDown.Add(lblCaseLeftDown);
            labelsDown.Add(lblCaseMiddleDown);
            labelsDown.Add(lblCaseRightDown);
        }
        public void CheckLigneCase()
        {
            if (labelsDown[0].BackColor == labelsDown[1].BackColor&& labelsDown[1].BackColor == labelsDown[2].BackColor && labelsDown[0].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }
            if (labelsCenter[0].BackColor == labelsCenter[1].BackColor && labelsCenter[1].BackColor == labelsCenter[2].BackColor && labelsCenter[0].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }
            if (labelsUp[0].BackColor == labelsUp[1].BackColor && labelsUp[1].BackColor == labelsUp[2].BackColor && labelsUp[0].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }
        }
        public void CheckCollumnCase()
        {
            if (labelsDown[0].BackColor == labelsCenter[0].BackColor && labelsCenter[0].BackColor == labelsUp[0].BackColor && labelsDown[0].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }
            if (labelsDown[1].BackColor == labelsCenter[1].BackColor && labelsCenter[1].BackColor == labelsUp[1].BackColor && labelsDown[1].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }
            if (labelsDown[2].BackColor == labelsCenter[2].BackColor && labelsCenter[2].BackColor == labelsUp[2].BackColor && labelsDown[2].BackColor != Color.DeepSkyBlue)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Le joueur 1 à gagner");
                }
                else
                {
                    MessageBox.Show("Le joueur 2 à gagner");
                }

            }

        }

        public void CheckCase()
        {
            CheckLigneCase();
            CheckCollumnCase();
        }
        private void CaseClick(object sender, EventArgs e)
        {
            Label caseClique =  sender as Label;
            if (player1Turn && caseClique.BackColor == Color.DeepSkyBlue)
            {
                caseClique.BackColor = Color.Blue;
                CheckCase();
                player1Turn = false;
            }
            else if (!player1Turn && caseClique.BackColor == Color.DeepSkyBlue)
            {
                caseClique.BackColor = Color.Red;
                CheckCase();
                player1Turn = true;

            }
            else
            {
                lblError.Text = "Cette case est déjà coché";
            }


        }
    }
}
