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
        public frm_EasyMode()
        {
            InitializeComponent();

           
        }
        /// <summary>
        /// Boutton pour revenir au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExitEasyMode_Click(object sender, EventArgs e)
        {
            //Retourne au menu lorsque l'on appuie sur le boutton
            this.Close();

            //réaffiche le menu d'acceuil
            frm_MasterMindGame masterMindGame = new frm_MasterMindGame();
            masterMindGame.Show();
        }
    }

}

