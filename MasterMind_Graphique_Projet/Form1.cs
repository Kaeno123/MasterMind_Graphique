﻿using System;
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
    public partial class MasterMindGame : Form
    {
        public MasterMindGame()
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
                string choice = "1";
                string finalgoal;


                while (choice == "1" || choice == "2")
                {
                    Menu();
                }

                void Menu()
                {
                    reTry = "oui";

                    //clean the console
                    Console.Clear();

                    //Menu of MasterMind
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*******************************\nBIENVENUE SUR MASTERMIND !");
                    Console.WriteLine("*******************************\n");
                    Console.Write("1. Mode normal\n2. Mode facile\n3. Quitter\n\nInsérez le chiffre de l'action que vous souhaitez exécuter: ");
                    Console.ResetColor();

                    choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        //normal mode
                        Mode("normal");
                    }
                    else if (choice == "2")
                    {
                        //easy mode
                        Mode("easy");
                    }
                    else if (choice == "3")
                    {

                    }
                    else
                    {
                        while (choice != "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nVous n'avez pas insérez les caractères attendus.\nVeuillez recommencer en appuyant sur le chiffre 1.");
                            Console.ResetColor();
                            choice = Console.ReadLine();
                        }
                    }
                }
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
                void WelcomeGame(string mode)
                {
                    if (mode == "normal")
                    {
                        //welcome text and introdocution to the game
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Couleurs possibles: gywrmbc");
                        Console.WriteLine("Devine le code en 4 couleurs.\n*******************************\n");
                        Console.ResetColor();
                    }
                    else if (mode == "easy")
                    {
                        //welcome text and introdocution to the game
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Couleurs possibles: gywrmbc");
                        Console.WriteLine("Devine le code en 4 couleurs.");
                        Console.WriteLine("Le symbole '$' signifie que vous avez trouvé une bonne couleur, mais mal positionée.\n*******************************\n");
                        Console.ResetColor();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Boutton pour aller dans le mode normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_NormalMode_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    

