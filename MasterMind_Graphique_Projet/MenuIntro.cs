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
        bool _inEnglish;
        public frm_MasterMindGame()
        {
            InitializeComponent();         
        }

        /// <summary>
        /// Boutton pour aller dans le mode facile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EasyMode_Click(object sender, EventArgs e)
        {
            //créer une instance du mode facile
            frm_EasyMode easyMode = new frm_EasyMode(_inEnglish);

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
            frm_NormalMode normalMode = new frm_NormalMode(_inEnglish);

            
            //Montre le mode normal
            normalMode.Show();

            //Cache le menu principal
            this.Hide();
        }

        /// <summary>
        /// Option pour mettre le jeu en anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void anglaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_EasyMode.Text = "Easy Mode";
            btn_NormalMode.Text = "Normal Mode";
            lbl_ChooseAMode.Text = "Choose your game mode !";
            lbl_WelcomeToTheGame.Text = "Welcome to the game";
            françaisToolStripMenuItem.Text = "French";
            anglaisToolStripMenuItem1.Text = "English";
            reglesDuJeuToolStripMenuItem.Text = "Rules of the game";
            modeFacileToolStripMenuItem.Text = "Easy mode";
            modeNormalToolStripMenuItem.Text = "Normal mode";
            _inEnglish = true;

        }

        /// <summary>
        /// Option pour mettre le jeu en français
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_EasyMode.Text = "Mode facile";
            btn_NormalMode.Text = "Mode normal";
            lbl_ChooseAMode.Text = "Choisis ton mode de jeu !";
            lbl_WelcomeToTheGame.Text = "Bienvenue dans le jeu";
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem1.Text = "Anglais";
            reglesDuJeuToolStripMenuItem.Text = "Règles du jeu";
            modeFacileToolStripMenuItem.Text = "Mode facile";
            modeNormalToolStripMenuItem.Text = "Mode normal";
            _inEnglish = false;
        }
        /// <summary>
        /// Explique les règles de jeu du mode normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modeNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_inEnglish)
            {
                MessageBox.Show("1. The white squares represent the number of correctly placed colours." +
                                             "\n2. The black squares represent the number of colours in the code but incorrectly placed." +
                                             "\n3. Please note! The placement of the squares does not indicate the position of the correctly or incorrectly placed colours.", "Normal mode");
                return;
            }
            MessageBox.Show("1. Les carrées blancs représentent le nombre de couleurs bien placées.\n2. Les carrées noirs représentent le nombre de couleurs se trouvant dans le code mais mal placées.\n3. Attention ! Le placement des carrées n'indique pas la position des couleurs bien ou mal placées.", "Mode normal");


        }

        /// <summary>
        /// Explique les règles de jeu du mode facile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modeFacileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_inEnglish)
            {
                MessageBox.Show("1. The white squares represent the number of colours correctly placed and indicate their position." +
                             "\n 2. The black squares represent the number of colours in the code but incorrectly placed and indicate their position.", "Easy mode");
                return;
            }
            MessageBox.Show("1. Les carrées blancs représentent le nombre de couleurs bien placées et indiquent leur positions\n2. les carrées noirs représentent le nombre de couleurs se trouvant dans le code mais mal placées et indiquent leur position.", "Mode facile");

        }            
    }
}
    

