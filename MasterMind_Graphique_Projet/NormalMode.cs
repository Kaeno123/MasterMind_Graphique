using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind_Graphique_Projet
{
    public partial class frm_NormalMode : Form
    {
        Color[] goalColours = new Color[4];
        Label[] goalColoursLabel = new Label[4];                                
        
        //Compte le nombre d'essai
        int NumberTry = 1;

        //Création du tableau des labels de couleurs
        private const int col = 4; 
        private const int row = 10; 
        Label[,] positionLabelColours = new Label[col,row];

        //Compteur de ligne validée
        int counterRow = 0;
        
        //Marge pour séparer les labels entre eux et le panel des labels
        int marginLbl = 30;
        int marginPnlV = 30;
        int marginPnlH = 45;

        //Création du tableau de couleurs qui sera attribué aux boutons et au code secret
        Color[] TabColours = {Color.Green, Color.Yellow, Color.White, Color.Red, Color.Magenta, Color.Blue, Color.Cyan };

        //Création du tableau de boutons de couleurs
        private const int MaxColours = 7;
        Button[] btnClr = new Button[MaxColours];
        int marginBtn = 15;

        //Création du tableau de labels bonne et mauvais position
        Label[,] LblRightOrBadPosition = new Label[col,row];

        int rightPositionPlacement = 0;

        /// <summary>
        /// Initialisation de la page et de ses configurations
        /// </summary>
        public frm_NormalMode()
        {
            InitializeComponent();

            //génère la combinaison de couleurs aléatoire dès qu'on entre dans la page
            GenCombinaisonColour();

            CreateLblClr();
            CreateBtnColours();
            CreateLblRightOrBadPosition();

            //TEMPORAIRE
            CreateLblClrCode();

            lbl_NumberTry.Text = "Essai numéro 1";

            btn_Replay.Enabled = false;           
        }

        //TEMPORAIRE
        private void CreateLblClrCode()
        {
            for (int i = 0; i < goalColours.Length; i++)
            {
                Color color = goalColours[i];
                               
                //Création du label et de ses caractéristiques
                goalColoursLabel[i] = new Label();
                goalColoursLabel[i].Name = $"lblclrCode{i}";
                goalColoursLabel[i].Height = 15;
                goalColoursLabel[i].Width = 15;
                goalColoursLabel[i].BackColor = goalColours[i];

                int y = i * goalColoursLabel[i].Width + i * marginLbl + marginPnlV;

                goalColoursLabel[i].Location = new Point(y, 0);

                panel1.Controls.Add(goalColoursLabel[i]);                
            }
        }

        /// <summary>
        /// Génère la combinaison aléatoire de couleurs
        /// </summary>
        /// <returns></returns>
        private void GenCombinaisonColour()
        {
            //generate 4 colors among 7 randomly
            Random random = new Random();         
                    

            int[] randomColors = new int[4];
            for (int i = 0; i < 4; i++)
            {
                randomColors[i] = random.Next(6);
            }
           
            for (int i = 0; i < randomColors.Length; i++)
            {
                if (randomColors[i] == 0)
                {
                    goalColours[i] = TabColours[0];
                }
                else if (randomColors[i] == 1)
                {
                    goalColours[i] = TabColours[1];
                }
                else if (randomColors[i] == 2)
                {
                    goalColours[i] = TabColours[2];
                }
                else if (randomColors[i] == 3)
                {
                    goalColours[i] = TabColours[3];
                }
                else if (randomColors[i] == 4)
                {
                    goalColours[i] = TabColours[4];
                }
                else if (randomColors[i] == 5)
                {
                    goalColours[i] = TabColours[5];
                }
                else if (randomColors[i] == 6)
                {
                    goalColours[i] = TabColours[6];
                }
            }            
        }

        /// <summary>
        /// Créer dynamiquement les boutons de couleurs
        /// </summary>
        void CreateBtnColours()
        {
            for (int i = 0; i < MaxColours; i++)
            {
                btnClr[i] = new Button();
                btnClr[i].Size = new Size(40, 40);
                btnClr[i].BackColor = TabColours[i];
                btnClr[i].Tag = btnClr[i].BackColor;
                btnClr[i].Text = "";

                int a = btnClr[i].Height * i + marginBtn * i + marginBtn;

                btnClr[i].Location = new Point(10, a);

                pnlBtnClr.Controls.Add(btnClr[i]);

                btnClr[i].Click += btn_Color_Click;
            }
        }

        /// <summary>
        /// Méthode qui envoie la couleur du bouton choisi aux labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Color_Click(object sender, EventArgs e)
        {
            //Envoie l'information de la couleur choisie à la méthode
            if (sender is Button clickedButton)
            {
                if (clickedButton.BackColor is Color colorName)
                {
                    Color color = colorName;
                    ChangeLabelColor(color);
                }
            }

            //Désactive les boutons si le dernier label d'une ligne est remplie
            for (int i = 0; i < row; i++)
            {
               if (positionLabelColours[3, counterRow].BackColor != Color.LightGray)
               {
                    foreach (Button item in pnlBtnClr.Controls)
                    {
                        item.Enabled = false;
                    }
                    break;                   
               }                           
            }                 
        }

        /// <summary>
        /// Méthode qui applique une couleur choisie au label disponible
        /// </summary>
        /// <param name="color"></param>
        private void ChangeLabelColor(Color color)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (positionLabelColours[j,i].BackColor == Color.LightGray)
                    {
                        positionLabelColours[j,i].BackColor = color;
                        return;
                    }
                }
            }
        }
       
        /// <summary>
        /// Bouton pour recommencer une partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Replay_Click(object sender, EventArgs e)
        {
            foreach (Label lblClr in positionLabelColours)
            {
                lblClr.BackColor = Color.LightGray;
            }
            foreach (Label label in LblRightOrBadPosition)
            {
                label.BackColor = Color.LightGray;
            }
            counterRow = 0;
            NumberTry = 1;
            
            //Génère un nouveau code secret
            GenCombinaisonColour();

            //TEMPORAIRE
            for (int i = 0; i < 4; i++)
            {
                goalColoursLabel[i].BackColor = goalColours[i];
            }
                        
            lbl_NumberTry.Text = $"Essai numéro {NumberTry}";
            btn_Replay.Text = "Recommencer";
                        
            btn_Replay.Enabled = false;
            btn_UndoLabelColor.Enabled = true;            
            btn_Check.Enabled = true;
            foreach (Button item in pnlBtnClr.Controls)
            {
                item.Enabled = true;
            }
        }

        private void VerifiyCode()
        {            
            //Si l'user trouve le code secret
            if (positionLabelColours[0, counterRow].BackColor == goalColours[0] && positionLabelColours[1, counterRow].BackColor == goalColours[1] && positionLabelColours[2, counterRow].BackColor == goalColours[2] && positionLabelColours[3, counterRow].BackColor == goalColours[3])
            {
                MessageBox.Show($"Bravoooo, vous avez gagné en {NumberTry} essai(s) !!!!", "Victoire");

                //Désactive tous les boutons sauf recommencer et retourner au menu
                btn_Check.Enabled = false;

                foreach (Button item in pnlBtnClr.Controls)
                {
                    item.Enabled = false;
                }
                btn_UndoLabelColor.Enabled = false;
                btn_Replay.Enabled = true;
                btn_Replay.Text = "Rejouer";
                    
            }
            for (int b = 0; b < col; b++)
            {
                //Si l'user trouve une couleur bien placée
                if (positionLabelColours[b, counterRow].BackColor == goalColours[b])
                {
                    LblRightOrBadPosition[rightPositionPlacement, counterRow].BackColor = Color.White;
                    rightPositionPlacement++;
                }               
            }
            int ColVerify = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    //Si l'user trouve une bonne couleur mais mal placée
                    if (positionLabelColours[ColVerify, counterRow].BackColor == goalColours[i])
                    {
                        LblRightOrBadPosition[, counterRow].BackColor = Color.Black;
                    }
                }
                ColVerify++;
            }
            
        }

        /// <summary>
        /// Bouton qui vérifie si le joueur a rempli toutes les cases, si les couleurs sont justes, et ajoute 4 nouveaux labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Check_Click(object sender, EventArgs e)
        {
            //affiche un message d'erreur pour chaque ligne si l'user valide avec moins de 4 couleurs                          
               
            if (positionLabelColours[3, counterRow].BackColor == Color.LightGray)
            {
                MessageBox.Show("Vous n'avez pas choisis 4 couleurs");
                
            }
            else 
            {
                //Active le bouton recommencer lorsque l'user fait un essai
                btn_Replay.Enabled = true;

                foreach (Button item in pnlBtnClr.Controls)
                {
                    item.Enabled = true;
                }

                VerifiyCode();
                rightPositionPlacement = 0;
                counterRow++;
                NumberTry++;
                lbl_NumberTry.Text = $"Essai numéro {NumberTry}";
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
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (positionLabelColours[j, i].BackColor != Color.LightGray && positionLabelColours[0,counterRow].BackColor != Color.LightGray)
                    {
                        //Prend les positions du dernier label qui a changé de couleur
                        lastChangedLabel = positionLabelColours[j, i];
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
        /// Créer un tableau de labels qui contient les couleurs que l'user choisit
        /// </summary>
        private void CreateLblClr()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Création du label et de ses caractéristiques
                    positionLabelColours[j, i] = new Label();
                    positionLabelColours[j, i].Name = $"lblclr{i}_{j}";
                    positionLabelColours[j, i].Height = 40;
                    positionLabelColours[j, i].Width = 40;
                    positionLabelColours[j, i].BackColor = Color.LightGray;

                    int x = j * positionLabelColours[j, i].Width + j*marginLbl + marginPnlH;
                    int y = i * positionLabelColours[j, i].Height + i*marginLbl + marginPnlV;

                    positionLabelColours[j, i].Location = new Point(x, y);

                    pnlClrChoose.Controls.Add(positionLabelColours[j, i]);
                }
            }
        }

        /// <summary>
        /// Créer un tableau de labels qui affiche les bonnes et mauvaises positions
        /// </summary>
        private void CreateLblRightOrBadPosition()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Création du label et de ses caractéristiques
                    LblRightOrBadPosition[j, i] = new Label();
                    LblRightOrBadPosition[j, i].Name = $"lblROBPosition{i}_{j}";
                    LblRightOrBadPosition[j, i].Height = 13;
                    LblRightOrBadPosition[j, i].Width = 13;
                    LblRightOrBadPosition[j, i].BackColor = Color.LightGray;

                    int x = j * LblRightOrBadPosition[j, i].Width + j * marginBtn;
                    int y = i * LblRightOrBadPosition[j, i].Height + i + 55*i;

                    LblRightOrBadPosition[j, i].Location = new Point(x, y);

                    pnl_RIghtOrBadP.Controls.Add(LblRightOrBadPosition[j, i]);
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
        /*private void normalMode()
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
            
        }*/
    }               
}
       
    

