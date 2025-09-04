using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Face2Face
{
    public partial class Mastermind : Form
    {
        List<Color> listColor;
        List<Color> listColorResult;
        Random rnd;
        bool tourJ1 = true; 
        public Mastermind()
        {
            InitializeComponent();
        }
        private void chooseColor()
        {
            for (int i = 0; i < 5; i++)
            {
                listColorResult.Add(listColor[rnd.Next(listColor.Count)]);
            }
        }
        private void showColor(int id)
        {
            string name = "lblResult";
            int idName = id + 1;
            name = name + idName;
            bool backColor = true;

            Control[] controls = this.Controls.Find(name, true);
            if (controls.Length > 0 && controls[0] is Label label)
            {
                label.BackColor = listColorResult[id];
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl && lbl.Name.StartsWith("lblResult"))
                {
                    if (lbl.BackColor == Color.Black)
                    {
                        backColor = false;
                    }
                }
            }
            if (backColor)
            {
                if (tourJ1)
                {
                    gameMaster.scoreJ1++;
                    lblFin.Text = "Bravo joueur 1 tu a gagné";
                }
                else
                {
                    gameMaster.scoreJ2++;
                    lblFin.Text = "Bravo joueur 2 tu a gagné";
                }
                btnFin.Visible = true;
            }
        }
        void updateTour()
        {
            if (tourJ1)
            {
                btnValiderJ1.Enabled = true;
                cmbChoix1J1.Enabled = true;
                cmbChoix2J1.Enabled = true;
                cmbChoix3J1.Enabled = true;
                cmbChoix4J1.Enabled = true;
                cmbChoix5J1.Enabled = true;

                cmbChoix1J2.Enabled = false;
                cmbChoix2J2.Enabled = false;
                cmbChoix3J2.Enabled = false;
                cmbChoix4J2.Enabled = false;
                cmbChoix5J2.Enabled = false;
                btnValiderJ2.Enabled = false;
            }
            else
            {
                btnValiderJ1.Enabled = false;
                cmbChoix1J1.Enabled = false;
                cmbChoix2J1.Enabled = false;
                cmbChoix3J1.Enabled = false;
                cmbChoix4J1.Enabled = false;
                cmbChoix5J1.Enabled = false;

                cmbChoix1J2.Enabled = true;
                cmbChoix2J2.Enabled = true;
                cmbChoix3J2.Enabled = true;
                cmbChoix4J2.Enabled = true;
                cmbChoix5J2.Enabled = true;
                btnValiderJ2.Enabled = true;
            }
        }
        void checkValide()
        {
            if(cmbChoix1J1.Text == "" || cmbChoix2J1.Text == "" || cmbChoix3J1.Text == "" || cmbChoix4J1.Text == "" || cmbChoix5J1.Text == "")
            {
                btnValiderJ1.Enabled = false;
            }
            else
            {
                btnValiderJ1.Enabled = true;
            }
            if (cmbChoix1J2.Text == "" || cmbChoix2J2.Text == "" || cmbChoix3J2.Text == "" || cmbChoix4J2.Text == "" || cmbChoix5J2.Text == "")
            {
                btnValiderJ2.Enabled = false;
            }
            else
            {
                btnValiderJ2.Enabled = true;
            }
        }
        private void Mastermind_Load(object sender, EventArgs e)
        {
            lblJ1.Text = gameMaster.pseudoJ1;
            lblJ2.Text = gameMaster.pseudoJ2;
            listColor = new List<Color> {
                Color.Red,
                Color.Blue,
                Color.Purple,
                Color.Orange,
                Color.Green,
                Color.Brown
            };
            listColorResult = new List<Color>();
            rnd = new Random();
            foreach (Color color in listColor)
            {
                foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
                {
                    comboBox.Items.Add(color);
                }
            }
            chooseColor();
            updateTour();
        }

        private void SelectIndexChanged_Allcmb(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            Color color = listColor[comboBox.SelectedIndex];
            string name = comboBox.Name;
            name = name.Remove(0, 3);
            name = "lbl" + name;
            Control[] controls = this.Controls.Find(name, true);
            if (controls.Length > 0 && controls[0] is Label label)
            {
                label.BackColor = color;
            }


            checkValide();


        }

        private void btnValiderJ1_Click(object sender, EventArgs e)
        {
            List<Color> reponseJ1 = new List<Color>();
            List<int> listIdReponseCorrect = new List<int>();

            reponseJ1.Add((Color)cmbChoix1J1.SelectedItem);
            reponseJ1.Add((Color)cmbChoix2J1.SelectedItem);
            reponseJ1.Add((Color)cmbChoix3J1.SelectedItem);
            reponseJ1.Add((Color)cmbChoix4J1.SelectedItem);
            reponseJ1.Add((Color)cmbChoix5J1.SelectedItem);

            int i = 0;
            int nbJuste = 0;
            foreach (Color color in reponseJ1)
            {
                if (listColorResult.Contains(color) && listColorResult[i] == color){
                    listIdReponseCorrect.Add(i);
                }
                else if (listColorResult.Contains(color))
                {
                    nbJuste++;
                }
                i++;
            }
            string text = $"Vous avez : \n {nbJuste} bonne(s) couleur(s) dont {listIdReponseCorrect.Count} de couleurs bien placée(s)";
            lblIndication.Text = text;
            foreach (int id in listIdReponseCorrect)
            {
                showColor(id);
            }
            tourJ1 = !tourJ1;
            updateTour();
        }

        private void btnValiderJ2_Click(object sender, EventArgs e)
        {
            List<Color> reponseJ2 = new List<Color>();
            List<int> listIdReponseCorrect = new List<int>();

            reponseJ2.Add((Color)cmbChoix1J2.SelectedItem);
            reponseJ2.Add((Color)cmbChoix2J2.SelectedItem);
            reponseJ2.Add((Color)cmbChoix3J2.SelectedItem);
            reponseJ2.Add((Color)cmbChoix4J2.SelectedItem);
            reponseJ2.Add((Color)cmbChoix5J2.SelectedItem);

            int i = 0;
            int nbJuste = 0;
            foreach (Color color in reponseJ2)
            {
                if (listColorResult.Contains(color) && listColorResult[i] == color)
                {
                    listIdReponseCorrect.Add(i);
                    nbJuste++;
                }
                else if (listColorResult.Contains(color))
                {
                    nbJuste++;
                }
                i++;
            }
            string text = $"Vous avez : \n {nbJuste} bonne(s) couleur(s) dont {listIdReponseCorrect.Count} de couleurs bien placée(s)";
            lblIndication.Text = text ;
            foreach (int id in listIdReponseCorrect)
            {
                showColor(id);
            }
            tourJ1 = !tourJ1;
            updateTour();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            new Form1().ChoseNewGame();
            this.Hide();
        }
    }
}
