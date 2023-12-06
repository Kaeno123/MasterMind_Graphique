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
        //Création du tableau qui contient le code secret
        Color[] goalColours = new Color[4];
        Label[] goalColoursLabel = new Label[4];//TEMPORAIRE
               
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

        //Création du tableau de labels bonne et mauvaise position
        Label[,] LblRightOrBadPosition = new Label[col,row];

        int rightPositionPlacement = 0;
        int badPositionPlacement = 0;

        /// <summary>
        /// Initialisation de la page et de ses configurations
        /// </summary>
        public frm_NormalMode()
        {
            InitializeComponent();

            //génère la combinaison de couleurs aléatoire dès qu'on entre dans la page
            GenCombinaisonColour();

            //Création des labels et des boutons
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

                //Positionnement des labels
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
            Random random = new Random();
            int[] randomColors = new int[4];

            //génère 4 couleurs parmi 7 aléatoirement
            for (int i = 0; i < randomColors.Length; i++)
            {
                randomColors[i] = random.Next(7);
                goalColours[i] = TabColours[randomColors[i]];
            }            
        }

        /// <summary>
        /// Créer dynamiquement les boutons de couleurs
        /// </summary>
        void CreateBtnColours()
        {
            for (int i = 0; i < MaxColours; i++)
            {
                //Création des boutons et de leurs caractéristiques
                btnClr[i] = new Button();
                btnClr[i].Size = new Size(40, 40);
                btnClr[i].BackColor = TabColours[i];
                btnClr[i].Tag = btnClr[i].BackColor;
                btnClr[i].Text = "";

                //Positionnement des boutons de couleurs
                int a = btnClr[i].Height * i + marginBtn * i + marginBtn;
                btnClr[i].Location = new Point(10, a);
                pnlBtnClr.Controls.Add(btnClr[i]);

                //attache un événement au clic de chaque bouton
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
            //Désactive les boutons si le dernier label d'une ligne est remplie            
            if (positionLabelColours[3, counterRow].BackColor != Color.LightGray)
            {
                foreach (Button item in pnlBtnClr.Controls)
                {
                    item.Enabled = false;
                }
            }
            else
            {
                //Envoie l'information de la couleur choisie à la méthode
                if (sender is Button clickedButton)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (positionLabelColours[j, i].BackColor == Color.LightGray)
                            {
                                positionLabelColours[j, i].BackColor = clickedButton.BackColor;
                                return;
                            }
                        }
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
            foreach (Label lblROBPosition in LblRightOrBadPosition)
            {
                lblROBPosition.BackColor = Color.LightGray;
            }

            //Réinitialisation des valeurs
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
                        
            //Active ou désactive des boutons
            btn_Replay.Enabled = false;
            btn_UndoLabelColor.Enabled = true;            
            btn_Check.Enabled = true;
            foreach (Button item in pnlBtnClr.Controls)
            {
                item.Enabled = true;
            }
        }

        /// <summary>
        /// Méthode qui compare les couleurs choisies avec celles du code secret
        /// </summary>
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

            //Créer un clone du tableau du code secret
            Color[] TempColorGoal = new Color[col];
            Array.Copy(goalColours, TempColorGoal, col);

            //Créer un clone de mon tableau de labels contenant les couleurs choisies par l'user
            Label[,] TempPositionLblClr = new Label[col, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    TempPositionLblClr[j,i] = new Label();
                    TempPositionLblClr[j,i].BackColor = positionLabelColours[j,i].BackColor;
                }
            }

            for (int b = 0; b < col; b++)
            {
                //Vérifie si l'user trouve une couleur bien placée
                if (positionLabelColours[b, counterRow].BackColor == TempColorGoal[b])
                {   
                    TempPositionLblClr[b, counterRow].BackColor = Color.OrangeRed;
                    TempColorGoal[b] = Color.Purple;
                    LblRightOrBadPosition[rightPositionPlacement, counterRow].BackColor = Color.White;
                    rightPositionPlacement++;
                }               
            }
            badPositionPlacement = rightPositionPlacement;
            int ColVerify = 0;                       

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    // Vérifie si l'user trouve une bonne couleur mais mal placée
                    if (TempPositionLblClr[ColVerify, counterRow].BackColor == TempColorGoal[i] && ColVerify != i)
                    {
                        TempColorGoal[i] = Color.Purple;//A améliorer marche pas encore
                        LblRightOrBadPosition[badPositionPlacement, counterRow].BackColor = Color.Black;
                        badPositionPlacement++;
                        break;
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
            if (NumberTry < 10)
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
                    badPositionPlacement = 0;
                    NumberTry++;
                    for (int i = 0; i < col; i++)
                    {
                        if (positionLabelColours[i, counterRow].BackColor != goalColours[i])
                        {
                            lbl_NumberTry.Text = $"Essai numéro {NumberTry}";
                        }
                    }
                    counterRow++;
                }
            }
            else
            {
                MessageBox.Show("Dommage, vous avez perdu :/");

                //Désactive tous les boutons sauf recommencer et retourner au menu
                btn_Check.Enabled = false;
                foreach (Button button in pnlBtnClr.Controls)
                {
                    button.Enabled = false;
                }
                btn_UndoLabelColor.Enabled = false;
                btn_Replay.Enabled = true;
                btn_Replay.Text = "Rejouer";
            }
        }

        /// <summary>
        /// bouton qui éxécute l'annulation d'une couleur choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UndoLabelColor_Click(object sender, EventArgs e)
        {
            UndoLabelColor();

            //réactive les boutons de couleurs
            foreach (Button item in pnlBtnClr.Controls)
            {
                item.Enabled = true;
            }
        }

        /// <summary>
        /// méthode qui annule la dernière couleur choisie
        /// </summary>
        /// <param name="color"></param>
        private void UndoLabelColor()
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
                    //Création des labels et de leurs caractéristiques
                    positionLabelColours[j, i] = new Label();
                    positionLabelColours[j, i].Name = $"lblclr{i}_{j}";
                    positionLabelColours[j, i].Height = 40;
                    positionLabelColours[j, i].Width = 40;
                    positionLabelColours[j, i].BackColor = Color.LightGray;

                    //Positionnement des labels
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
                    //Création des labels et de leurs caractéristiques
                    LblRightOrBadPosition[j, i] = new Label();
                    LblRightOrBadPosition[j, i].Name = $"lblROBPosition{i}_{j}";
                    LblRightOrBadPosition[j, i].Height = 13;
                    LblRightOrBadPosition[j, i].Width = 13;
                    LblRightOrBadPosition[j, i].BackColor = Color.LightGray;

                   //Positionnement des labels
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
    }               
}