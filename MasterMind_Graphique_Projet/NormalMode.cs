using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind_Graphique_Projet
{
    public partial class frm_NormalMode : Form
    {
        string[] goal = new string[4];
        string essai = "";
        int win;
        string finalgoal;

        //Création du tableau de label
        private const int row = 4; 
        private const int col = 10; 
        Label[,] positionLabel = new Label[row,col];
        
        //Marge pour séparer les labels entre eux et le panel des labels
        int marginLbl = 30;
        int marginPnlV = 30;
        int marginPnlH = 45;


        public frm_NormalMode()
        {
            InitializeComponent();

            CreateLblClr();

            //génère la combinaison de couleurs aléatoire dès qu'on entre dans la page
            GenCombinaisonColour();
            btn_Replay.Hide();           
        }
        
        /// <summary>
        /// Génère la combinaison aléatoire de couleurs
        /// </summary>
        /// <returns></returns>
        private string GenCombinaisonColour()
        {
            //generate 4 colors among 7 randomly
            Random random = new Random();

            int[] randomColors = new int[4];
            randomColors[0] = random.Next(6);
            randomColors[1] = random.Next(6);
            randomColors[2] = random.Next(6);
            randomColors[3] = random.Next(6);

            for (int i = 0; i < randomColors.Length; i++)
            {
                if (randomColors[i] == 0)
                {
                    goal[i] = "Green";
                }
                else if (randomColors[i] == 1)
                {
                    goal[i] = "Yellow";
                }
                else if (randomColors[i] == 2)
                {
                    goal[i] = "White";
                }
                else if (randomColors[i] == 3)
                {
                    goal[i] = "Red";
                }
                else if (randomColors[i] == 4)
                {
                    goal[i] = "Magenta";
                }
                else if (randomColors[i] == 5)
                {
                    goal[i] = "Blue";
                }
                else if (randomColors[i] == 6)
                {
                    goal[i] = "Cyan";
                }
            }

            //the combination that the user must find
            finalgoal = goal[0] + goal[1] + goal[2] + goal[3];

            essai = "";
            win = 0;

            return finalgoal;
        }
       
        /// <summary>
        /// Méthode qui envoie la couleur du bouton choisi aux labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Color_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Tag is string colorName)
                {
                    Color color = Color.FromName(colorName);
                    ChangeLabelColor(color);
                }
            }

            for (int i = 0; i < row; i++)
            {
                if (positionLabel[3, i].BackColor != Color.LightGray)
                {
                    foreach (Button item in pnlBtnClr.Controls)
                    {
                        item.Enabled = false;
                    }
                }
            }
                   
        }

        /// <summary>
        /// Méthode qui applique une couleur choisie au label disponible
        /// </summary>
        /// <param name="color"></param>
        private void ChangeLabelColor(Color color)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (positionLabel[j,i].BackColor == Color.LightGray)
                    {
                        positionLabel[j,i].BackColor = color;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Boutton pour revenir au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btn_ExitNormalMode_Click(object sender, EventArgs e)
        {
            //Ferme la page lorsque l'on appuie sur le boutton
            this.Close();

            //réaffiche le menu d'acceuil
            frm_MasterMindGame masterMindGame = new frm_MasterMindGame();
            masterMindGame.Show();
        }
        /// <summary>
        /// Bouton pour recommencer une partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Replay_Click(object sender, EventArgs e)
        {
            btn_Replay.Hide();
            
            GenCombinaisonColour();
            foreach (Label lblClr in positionLabel)
            {
                lblClr.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Bouton qui vérifie si le joueur a rempli toutes les cases, si les couleurs sont justes, et ajoute 4 nouveaux labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Check_Click(object sender, EventArgs e)
        {          
            //affiche un message d'erreur pour chaque ligne
            for (int i = 0; i < col; i++)
            {
                if (positionLabel[3, i].BackColor == Color.LightGray)
                {
                    MessageBox.Show("Vous n'avez pas choisis 4 couleurs");
                    return;
                }
                else if (positionLabel[3,i].BackColor != Color.LightGray)
                {
                    //Montre le bouton recommencer lorsque l'user  fait un essai
                    btn_Replay.Show();
                    
                    return;
                }
            }                      
        }

        /// <summary>
        /// bouton qui éxécute l'annulation d'une couleur choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UndoLabelColor_Click(object sender, EventArgs e)
        {
            UndoLabelColor(Color.LightGray);

            //réactive les boutons de couleurs
            foreach (Button item in pnlBtnClr.Controls)
            {
                item.Enabled = true;
            }
        }

        /// <summary>
        /// méthode qui annule une couleur choisie
        /// </summary>
        /// <param name="color"></param>
        private void UndoLabelColor(Color color)
        {
            Label lastChangedLabel = null;

            // Parcours les labels pour trouver le dernier qui a changé de couleur
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (positionLabel[j, i].BackColor != Color.LightGray)
                    {
                        //Prend les positions du dernier label qui a changé de couleur
                        lastChangedLabel = positionLabel[j, i];
                    }
                }
            }

            // Annule la couleur du dernier label qui a changé
            if (lastChangedLabel != null)
            {
                lastChangedLabel.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Créer un tableau de labels 
        /// </summary>
        private void CreateLblClr()
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //Création du label et de ses caractéristiques
                    positionLabel[j, i] = new Label();
                    positionLabel[j, i].Name = $"lblclr{i}_{j}";
                    positionLabel[j, i].Height = 40;
                    positionLabel[j, i].Width = 40;
                    positionLabel[j, i].BackColor = Color.LightGray;

                    int x = j * positionLabel[j, i].Width + j*marginLbl + marginPnlH;
                    int y = i * positionLabel[j, i].Height + i*marginLbl + marginPnlV;

                    positionLabel[j, i].Location = new Point(x, y);

                    pnlClrChoose.Controls.Add(positionLabel[j, i]);
                }
            }
        }

        private void normalMode()
        {
            //do this code while the user doesn't find the goal or do less than 10 try
            int Ok = 0;
            int MP = 0;

          
            //table that divide each character of the combination
            char[] motsepa = new char[essai.Length];
            char[] restMotsepa = new char[essai.Length];
            char[] goalsa = new char[finalgoal.Length];
            char[] Restgoalsa = new char[finalgoal.Length];

            for (int i = 0; i < 4; i++)
            {
                motsepa[i] = (char)essai[i];
                goalsa[i] = Convert.ToChar(goal[i]);
            }

            //for color that is in the right position
            for (int i = 0; i < 4; i++)
            {
                if (motsepa[i] == Convert.ToChar(goal[i]))
                {
                    Ok = Ok + 1;
                    restMotsepa[i] = 'Z';
                    goalsa[i] = 'Y';
                }
                else
                {
                    restMotsepa[i] = motsepa[i];
                    Restgoalsa[i] = goalsa[i];
                }
            }

            //not accept when there are 2 color that are the same, it's save only one
            bool[] usedIndices = new bool[Restgoalsa.Length];


            //for bad positions
            for (int i = 0; i < restMotsepa.Length; i++)
            {
                for (int j = 0; j < Restgoalsa.Length; j++)
                {
                    if (restMotsepa[i] == Restgoalsa[j] && i != j && !usedIndices[j])
                    {
                        MP++;
                        restMotsepa[i] = 'L';
                        usedIndices[j] = true;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=>Ok: " + Ok);
            Console.WriteLine("Mauvaise position: " + MP);
            Console.ResetColor();           
            
        }
    }               
}
       
    

