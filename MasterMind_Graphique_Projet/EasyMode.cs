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
    public partial class frm_EasyMode : Form
    {      
        //Création du tableau qui contient le code secret
        Color[] _goalColours = new Color[4];
        Label[] _goalColoursLabel = new Label[4];

        //Compte le nombre d'essai
        int _numberTry = 1; 
        
        bool _inEnglish;

        //Création du tableau des labels de couleurs
        private const int _COL = 4;
        private const int _ROW = 10;
        Label[,] _positionLabelColours = new Label[_COL, _ROW];

        //Compteur de ligne validée
        int _counterRow = 0;

        //Marge pour séparer les labels entre eux et le panel des labels
        int _marginLbl = 30;
        int _marginPnlV = 30;
        int _marginPnlH = 45;

        //Création du tableau de couleurs qui sera attribué aux boutons et au code secret
        Color[] _tabColours = { Color.Green, Color.Yellow, Color.White, Color.Red, Color.Magenta, Color.Blue, Color.Cyan };

        //Création du tableau de boutons de couleurs
        private const int _MAXCOLOURS = 7;
        Button[] _btnClr = new Button[_MAXCOLOURS];
        int _marginBtn = 15;

        //Création du tableau de labels bonne et mauvaise position
        Label[,] _lblRightOrBadPosition = new Label[_COL, _ROW];

        bool _countClickCheatCode = false;

        /// <summary>
        /// Initialisation de la page et de ses configurations
        /// </summary>
        public frm_EasyMode(bool inEnglish)
        {
            InitializeComponent();

            //génère la combinaison de couleurs aléatoire dès qu'on entre dans la page
            GenCombinaisonColour();

            //Création des labels et des boutons
            CreateLblClr();
            CreateBtnColours();
            CreateLblRightOrBadPosition();
            CreateLblClrCode();

            //Cache le code
            for (int i = 0; i < 4; i++)
            {
                _goalColoursLabel[i].BackColor = Color.BurlyWood;
            }

            lbl_NumberTry.Text = "Essai numéro 1";

            btn_Replay.Enabled = false;
            if (inEnglish)
            {
                btn_Check.Text = "Check";
                btn_Replay.Text = "Replay";
                btn_UndoLabelColor.Text = "Undo";
                btn_ExitNormalMode.Text = "Return to menu";
                lbl_EasyMode.Text = "Normal mode";
                lbl_NumberTry.Text = $"Try number {_numberTry}";
            }
        }

        /// <summary>
        /// Créer les labels qui affichent le code secret
        /// </summary>
        private void CreateLblClrCode()
        {
            for (int i = 0; i < _goalColours.Length; i++)
            {
                Color color = _goalColours[i];

                //Création du label et de ses caractéristiques
                _goalColoursLabel[i] = new Label();
                _goalColoursLabel[i].Name = $"lblclrCode{i}";
                _goalColoursLabel[i].Height = 15;
                _goalColoursLabel[i].Width = 15;
                _goalColoursLabel[i].BackColor = _goalColours[i];

                //Positionnement des labels
                int y = i * _goalColoursLabel[i].Width + i * _marginLbl + _marginPnlV;
                _goalColoursLabel[i].Location = new Point(y, 0);
                panel1.Controls.Add(_goalColoursLabel[i]);
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
                _goalColours[i] = _tabColours[randomColors[i]];
            }
        }

        /// <summary>
        /// Créer dynamiquement les boutons de couleurs
        /// </summary>
        void CreateBtnColours()
        {
            for (int i = 0; i < _MAXCOLOURS; i++)
            {
                //Création des boutons et de leurs caractéristiques
                _btnClr[i] = new Button();
                _btnClr[i].Size = new Size(40, 40);
                _btnClr[i].BackColor = _tabColours[i];
                _btnClr[i].Tag = _btnClr[i].BackColor;
                _btnClr[i].Text = "";

                //Positionnement des boutons de couleurs
                int a = _btnClr[i].Height * i + _marginBtn * i + _marginBtn;
                _btnClr[i].Location = new Point(10, a);
                pnlBtnClr.Controls.Add(_btnClr[i]);

                //attache un événement au clic de chaque bouton
                _btnClr[i].Click += btn_Color_Click;
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
            if (_positionLabelColours[3, _counterRow].BackColor != Color.LightGray)
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
                    for (int i = 0; i < _ROW; i++)
                    {
                        for (int j = 0; j < _COL; j++)
                        {
                            if (_positionLabelColours[j, i].BackColor == Color.LightGray)
                            {
                                _positionLabelColours[j, i].BackColor = clickedButton.BackColor;
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
            foreach (Label lblClr in _positionLabelColours)
            {
                lblClr.BackColor = Color.LightGray;
            }
            foreach (Label lblROBPosition in _lblRightOrBadPosition)
            {
                lblROBPosition.BackColor = Color.LightGray;
            }

            //Réinitialisation des valeurs
            _counterRow = 0;
            _numberTry = 1;
            _countClickCheatCode = false;

            //Génère un nouveau code secret
            GenCombinaisonColour();

            if (_inEnglish)
            {
                lbl_NumberTry.Text = $"Try number {_numberTry}";
                btn_Replay.Text = "Restart";
            }
            else
            {
                lbl_NumberTry.Text = $"Essai numéro {_numberTry}";
                btn_Replay.Text = "Recommencer";
            }

            //Active ou désactive des boutons
            btn_Replay.Enabled = false;
            btn_UndoLabelColor.Enabled = true;
            btn_Check.Enabled = true;
            foreach (Button item in pnlBtnClr.Controls)
            {
                item.Enabled = true;
            }

            //Cache le code secret
            for (int i = 0; i < 4; i++)
            {
                _goalColoursLabel[i].BackColor = Color.BurlyWood;
            }
        }


        /// <summary>
        /// Méthode qui compare les couleurs choisies avec celles du code secret
        /// </summary>
        private void VerifiyCode()
        {
            //Si l'user trouve le code secret
            if (_positionLabelColours[0, _counterRow].BackColor == _goalColours[0] && _positionLabelColours[1, _counterRow].BackColor == _goalColours[1] && _positionLabelColours[2, _counterRow].BackColor == _goalColours[2] && _positionLabelColours[3, _counterRow].BackColor == _goalColours[3])
            {
                MessageBox.Show($"Bravoooo, vous avez gagné en {_numberTry} essai(s) !!!!", "Victoire");

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
            Color[] TempColorGoal = new Color[_COL];
            Array.Copy(_goalColours, TempColorGoal, _COL);

            //Créer un clone de mon tableau de labels contenant les couleurs choisies par l'user
            Label[,] TempPositionLblClr = new Label[_COL, _ROW];

            for (int i = 0; i < _ROW; i++)
            {
                for (int j = 0; j < _COL; j++)
                {
                    TempPositionLblClr[j, i] = new Label();
                    TempPositionLblClr[j, i].BackColor = _positionLabelColours[j, i].BackColor;
                }
            }

            for (int b = 0; b < _COL; b++)
            {
                //Vérifie si l'user trouve une couleur bien placée
                if (_positionLabelColours[b, _counterRow].BackColor == TempColorGoal[b])
                {
                    TempPositionLblClr[b, _counterRow].BackColor = Color.OrangeRed;
                    TempColorGoal[b] = Color.Purple;
                    _lblRightOrBadPosition[b, _counterRow].BackColor = Color.White;                   
                }
            }          
            int ColVerify = 0;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < _COL; i++)
                {
                    // Vérifie si l'user trouve une bonne couleur mais mal placée
                    if (TempPositionLblClr[ColVerify, _counterRow].BackColor == TempColorGoal[i] && ColVerify != i)
                    {
                        TempColorGoal[i] = Color.Purple;
                        if (_lblRightOrBadPosition[i,j].BackColor != Color.White)
                        {
                            _lblRightOrBadPosition[ColVerify, _counterRow].BackColor = Color.Black;
                            break;
                        }
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
            if (_numberTry < 10)
            {
                //affiche un message d'erreur pour chaque ligne si l'user valide avec moins de 4 couleurs                          

                if (_positionLabelColours[3, _counterRow].BackColor == Color.LightGray)
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
                    _numberTry++;
                    for (int i = 0; i < _COL; i++)
                    {
                        if (_positionLabelColours[i, _counterRow].BackColor != _goalColours[i])
                        {
                            if (_inEnglish)
                            {
                                lbl_NumberTry.Text = $"Try number {_numberTry}";
                            }
                            else
                            {
                                lbl_NumberTry.Text = $"Essai numéro {_numberTry}";
                            }
                        }
                    }
                    _counterRow++;
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
            for (int i = 0; i < _ROW; i++)
            {
                for (int j = 0; j < _COL; j++)
                {
                    if (_positionLabelColours[j, i].BackColor != Color.LightGray && _positionLabelColours[0, _counterRow].BackColor != Color.LightGray)
                    {
                        //Prend les positions du dernier label qui a changé de couleur
                        lastChangedLabel = _positionLabelColours[j, i];
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
            for (int i = 0; i < _ROW; i++)
            {
                for (int j = 0; j < _COL; j++)
                {
                    //Création des labels et de leurs caractéristiques
                    _positionLabelColours[j, i] = new Label();
                    _positionLabelColours[j, i].Name = $"lblclr{i}_{j}";
                    _positionLabelColours[j, i].Height = 40;
                    _positionLabelColours[j, i].Width = 40;
                    _positionLabelColours[j, i].BackColor = Color.LightGray;

                    //Positionnement des labels
                    int x = j * _positionLabelColours[j, i].Width + j * _marginLbl + _marginPnlH;
                    int y = i * _positionLabelColours[j, i].Height + i * _marginLbl + _marginPnlV;
                    _positionLabelColours[j, i].Location = new Point(x, y);
                    pnlClrChoose.Controls.Add(_positionLabelColours[j, i]);
                }
            }
        }

        /// <summary>
        /// Créer un tableau de labels qui affiche les bonnes et mauvaises positions
        /// </summary>
        private void CreateLblRightOrBadPosition()
        {
            for (int i = 0; i < _ROW; i++)
            {
                for (int j = 0; j < _COL; j++)
                {
                    //Création des labels et de leurs caractéristiques
                    _lblRightOrBadPosition[j, i] = new Label();
                    _lblRightOrBadPosition[j, i].Name = $"lblROBPosition{i}_{j}";
                    _lblRightOrBadPosition[j, i].Height = 13;
                    _lblRightOrBadPosition[j, i].Width = 13;
                    _lblRightOrBadPosition[j, i].BackColor = Color.LightGray;

                    //Positionnement des labels
                    int x = j * _lblRightOrBadPosition[j, i].Width + j * _marginBtn;
                    int y = i * _lblRightOrBadPosition[j, i].Height + i + 55 * i;
                    _lblRightOrBadPosition[j, i].Location = new Point(x, y);
                    pnl_RIghtOrBadP.Controls.Add(_lblRightOrBadPosition[j, i]);
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

        private void modeTricheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _countClickCheatCode = !_countClickCheatCode;

            if (_countClickCheatCode == true)
            {               

                for (int i = 0; i < 4; i++)
                {
                    _goalColoursLabel[i].BackColor = _goalColours[i];
                }
            }
            else if (_countClickCheatCode == false)
            {                
                for (int i = 0; i < 4; i++)
                {
                    _goalColoursLabel[i].BackColor = Color.BurlyWood;
                }
            }
        }
    }
}