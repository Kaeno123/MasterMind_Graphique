namespace MasterMind_Graphique_Projet
{
    partial class frm_MasterMindGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_MasterMind = new System.Windows.Forms.Label();
            this.lbl_WelcomeToTheGame = new System.Windows.Forms.Label();
            this.lbl_ChooseAMode = new System.Windows.Forms.Label();
            this.btn_NormalMode = new System.Windows.Forms.Button();
            this.btn_EasyMode = new System.Windows.Forms.Button();
            this.mnuStrpLanguages = new System.Windows.Forms.MenuStrip();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reglesDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeFacileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrpLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MasterMind
            // 
            this.lbl_MasterMind.AutoSize = true;
            this.lbl_MasterMind.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_MasterMind.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MasterMind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_MasterMind.Location = new System.Drawing.Point(284, 112);
            this.lbl_MasterMind.Name = "lbl_MasterMind";
            this.lbl_MasterMind.Size = new System.Drawing.Size(414, 49);
            this.lbl_MasterMind.TabIndex = 0;
            this.lbl_MasterMind.Text = "MasterMind Game";
            this.lbl_MasterMind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_WelcomeToTheGame
            // 
            this.lbl_WelcomeToTheGame.AutoSize = true;
            this.lbl_WelcomeToTheGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeToTheGame.Location = new System.Drawing.Point(348, 208);
            this.lbl_WelcomeToTheGame.Name = "lbl_WelcomeToTheGame";
            this.lbl_WelcomeToTheGame.Size = new System.Drawing.Size(265, 26);
            this.lbl_WelcomeToTheGame.TabIndex = 1;
            this.lbl_WelcomeToTheGame.Text = "Bienvenue dans le jeu";
            // 
            // lbl_ChooseAMode
            // 
            this.lbl_ChooseAMode.AutoSize = true;
            this.lbl_ChooseAMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChooseAMode.Location = new System.Drawing.Point(352, 352);
            this.lbl_ChooseAMode.Name = "lbl_ChooseAMode";
            this.lbl_ChooseAMode.Size = new System.Drawing.Size(257, 23);
            this.lbl_ChooseAMode.TabIndex = 2;
            this.lbl_ChooseAMode.Text = "Choisis ton mode de jeu !";
            // 
            // btn_NormalMode
            // 
            this.btn_NormalMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NormalMode.Location = new System.Drawing.Point(243, 497);
            this.btn_NormalMode.Name = "btn_NormalMode";
            this.btn_NormalMode.Size = new System.Drawing.Size(100, 60);
            this.btn_NormalMode.TabIndex = 3;
            this.btn_NormalMode.Text = "Mode normal";
            this.btn_NormalMode.UseVisualStyleBackColor = true;
            this.btn_NormalMode.Click += new System.EventHandler(this.Btn_NormalMode_Click_1);
            // 
            // btn_EasyMode
            // 
            this.btn_EasyMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EasyMode.Location = new System.Drawing.Point(586, 497);
            this.btn_EasyMode.Name = "btn_EasyMode";
            this.btn_EasyMode.Size = new System.Drawing.Size(100, 60);
            this.btn_EasyMode.TabIndex = 4;
            this.btn_EasyMode.Text = "Mode facile";
            this.btn_EasyMode.UseVisualStyleBackColor = true;
            this.btn_EasyMode.Click += new System.EventHandler(this.Btn_EasyMode_Click);
            // 
            // mnuStrpLanguages
            // 
            this.mnuStrpLanguages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem,
            this.reglesDuJeuToolStripMenuItem});
            this.mnuStrpLanguages.Location = new System.Drawing.Point(0, 0);
            this.mnuStrpLanguages.Name = "mnuStrpLanguages";
            this.mnuStrpLanguages.Size = new System.Drawing.Size(934, 24);
            this.mnuStrpLanguages.TabIndex = 5;
            this.mnuStrpLanguages.Text = "Langue";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem1});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.LanguageToolStripMenuItem.Text = "Langues";
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            this.françaisToolStripMenuItem.Click += new System.EventHandler(this.FrançaisToolStripMenuItem_Click);
            // 
            // anglaisToolStripMenuItem1
            // 
            this.anglaisToolStripMenuItem1.Name = "anglaisToolStripMenuItem1";
            this.anglaisToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.anglaisToolStripMenuItem1.Text = "Anglais";
            this.anglaisToolStripMenuItem1.Click += new System.EventHandler(this.AnglaisToolStripMenuItem1_Click);
            // 
            // reglesDuJeuToolStripMenuItem
            // 
            this.reglesDuJeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeNormalToolStripMenuItem,
            this.modeFacileToolStripMenuItem});
            this.reglesDuJeuToolStripMenuItem.Name = "reglesDuJeuToolStripMenuItem";
            this.reglesDuJeuToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.reglesDuJeuToolStripMenuItem.Text = "Règles du jeu";
            // 
            // modeNormalToolStripMenuItem
            // 
            this.modeNormalToolStripMenuItem.Name = "modeNormalToolStripMenuItem";
            this.modeNormalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modeNormalToolStripMenuItem.Text = "Mode normal";
            this.modeNormalToolStripMenuItem.Click += new System.EventHandler(this.ModeNormalToolStripMenuItem_Click);
            // 
            // modeFacileToolStripMenuItem
            // 
            this.modeFacileToolStripMenuItem.Name = "modeFacileToolStripMenuItem";
            this.modeFacileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modeFacileToolStripMenuItem.Text = "Mode facile";
            this.modeFacileToolStripMenuItem.Click += new System.EventHandler(this.ModeFacileToolStripMenuItem_Click);
            // 
            // frm_MasterMindGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btn_EasyMode);
            this.Controls.Add(this.btn_NormalMode);
            this.Controls.Add(this.lbl_ChooseAMode);
            this.Controls.Add(this.lbl_WelcomeToTheGame);
            this.Controls.Add(this.lbl_MasterMind);
            this.Controls.Add(this.mnuStrpLanguages);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuStrpLanguages;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_MasterMindGame";
            this.Text = "MasterMind";
            this.mnuStrpLanguages.ResumeLayout(false);
            this.mnuStrpLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MasterMind;
        private System.Windows.Forms.Label lbl_WelcomeToTheGame;
        private System.Windows.Forms.Label lbl_ChooseAMode;
        private System.Windows.Forms.Button btn_NormalMode;
        private System.Windows.Forms.Button btn_EasyMode;
        private System.Windows.Forms.MenuStrip mnuStrpLanguages;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglaisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reglesDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeFacileToolStripMenuItem;
    }
}

