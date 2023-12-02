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
    public partial class frm_MasterMindGame : Form
    {
        public frm_MasterMindGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            /// <summary>
            /// Description : Création du jeu MasterMind sur la console
            /// Auteur :Kaeno Eyer
            /// Date : 01.09.2023
            /// </summary>
            /// <param name="args"></param>

            /*{
                string[] goal = new string[4];
                string essai = "";
                string reTry = "oui";
                int win;
                string finalgoal;

            string GenCombinaisonColour()
            {
                //clean the console
                Console.Clear();

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
                        goal[i] = "g";
                    }
                    else if (randomColors[i] == 1)
                    {
                        goal[i] = "y";
                    }
                    else if (randomColors[i] == 2)
                    {
                        goal[i] = "w";
                    }
                    else if (randomColors[i] == 3)
                    {
                        goal[i] = "r";
                    }
                    else if (randomColors[i] == 4)
                    {
                        goal[i] = "m";
                    }
                    else if (randomColors[i] == 5)
                    {
                        goal[i] = "b";
                    }
                    else if (randomColors[i] == 6)
                    {
                        goal[i] = "c";
                    }
                }

                //the combination that the user must find
                 finalgoal = goal[0] + goal[1] + goal[2] + goal[3];

                essai = "";
                win = 0;

                return finalgoal;
            }
              
               
                void Mode(string mode)
                {
                    //launch of the game
                    while (reTry == "oui")
                    {
                        //génère la combinaison de couleur (réponse finale)
                        GenCombinaisonColour();

                        //welcome text and introdocution to the game
                        WelcomeGame(mode);


                        for (int numberTry = 1; numberTry <= 10 && win == 0; numberTry++)
                        {
                            if (mode == "normal")
                            {
                                NormalMode(numberTry);
                                numberTry = NormalMode(numberTry);

                            }
                            else if (mode == "easy")
                            {
                                EasyMode(numberTry);
                                numberTry = EasyMode(numberTry);
                            }


                            //if the user win
                            ShowWhenWin(numberTry);

                            //shows this code if the user loose after 10 try
                            WhenTenTry(numberTry);

                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
               
                }
                int NormalMode(int numberTry)
                {

                    //do this code while the user doesn't find the goal or do less than 10 try
                    int Ok = 0;
                    int MP = 0;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nEssai " + numberTry + " : ");
                    Console.ResetColor();

                    //the combination of color that choose the user
                    essai = Console.ReadLine();

                    if (essai.Length == 4)
                    {
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
                    else if (essai.Length != 4)
                    {
                        numberTry--;
                    }
                    return numberTry;
                }
                int EasyMode(int numberTry)
                {

                    //do this code while the user doesn't find the goal or do less than 10 try                   
                    int MP = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nEssai " + numberTry + " : ");
                    Console.ResetColor();

                    //the combination of color that choose the user
                    essai = Console.ReadLine();

                    if (essai.Length == 4)
                    {
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

                        //shows in the game the number of bad position
                        for (int i = 0; i < MP; i++)
                        {
                            if (MP > 0)
                            {
                                Console.Write("$");
                            }
                        }
                        if (MP > 0)
                        {
                            Console.Write(" : ");
                        }

                        //shows in the game the support for the user
                        for (int i = 0; i < 4; i++)
                        {
                            if (motsepa[i] == Convert.ToChar(goal[i]))
                            {
                                Console.Write(goal[i]);

                            }
                            else
                            {
                                Console.Write("_");

                            }
                        }
                    }
                    else if (essai.Length != 4)
                    {
                        numberTry--;
                    }
                    return numberTry;
                }
                void ShowWhenWin(int numberTry)
                {
                    if (essai == finalgoal)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nBravo, vous avez gagnez en " + numberTry + " essais !! :)");
                        Console.Write("voulez-vous refaire ?\nMettez oui ou non: ");
                        Console.ResetColor();

                        reTry = Console.ReadLine();

                        while (reTry != "oui" && reTry != "non")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nVous n'avez pas écrit les mots attendus\nVeuillez écrire oui ou non: ");
                            Console.ResetColor();
                            reTry = Console.ReadLine();
                        }
                        win = 1;
                    }
                }
                void WhenTenTry(int numberTry)
                {
                    if (numberTry == 10 && essai != finalgoal)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDommage, vous avez perdu :/");
                        Console.WriteLine("Le code était " + finalgoal);
                        Console.Write("voulez-vous réessayer ?\nMettez oui ou non: ");
                        Console.ResetColor();
                        reTry = Console.ReadLine();

                        while (reTry != "oui" && reTry != "non")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nVous n'avez pas écrit les mots attendus\nVeuillez écrire oui ou non: ");
                            Console.ResetColor();
                            reTry = Console.ReadLine();
                        }
                    }
                }
            }*/
        }

        /// <summary>
        /// Boutton pour aller dans le mode facile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EasyMode_Click(object sender, EventArgs e)
        {
            //créer une instance du mode facile
            frm_EasyMode easyMode = new frm_EasyMode();

            //Montre le mode facile
            easyMode.Show();
                     
            //Cache le menu principal
            this.Hide();
        }

        /// <summary>
        /// Boutton pour aller dans le mode normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NormalMode_Click_1(object sender, EventArgs e)
        {
            //créer une instance du mode normal
            frm_NormalMode normalMode = new frm_NormalMode();

            //Montre le mode normal
            normalMode.Show();

            //Cache le menu principal
            this.Hide();
        }
    }
}
    

