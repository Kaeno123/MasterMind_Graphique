namespace MasterMind_Graphique_Projet
{
    partial class MasterMindGame
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
            this.lbl_NormalMode = new System.Windows.Forms.Button();
            this.btn_EasyMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MasterMind
            // 
            this.lbl_MasterMind.AutoSize = true;
            this.lbl_MasterMind.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_MasterMind.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MasterMind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_MasterMind.Location = new System.Drawing.Point(244, 126);
            this.lbl_MasterMind.Name = "lbl_MasterMind";
            this.lbl_MasterMind.Size = new System.Drawing.Size(341, 42);
            this.lbl_MasterMind.TabIndex = 0;
            this.lbl_MasterMind.Text = "MasterMind Game";
            this.lbl_MasterMind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_MasterMind.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_WelcomeToTheGame
            // 
            this.lbl_WelcomeToTheGame.AutoSize = true;
            this.lbl_WelcomeToTheGame.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeToTheGame.Location = new System.Drawing.Point(295, 222);
            this.lbl_WelcomeToTheGame.Name = "lbl_WelcomeToTheGame";
            this.lbl_WelcomeToTheGame.Size = new System.Drawing.Size(232, 22);
            this.lbl_WelcomeToTheGame.TabIndex = 1;
            this.lbl_WelcomeToTheGame.Text = "Bienvenue dans le jeu";
            this.lbl_WelcomeToTheGame.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_ChooseAMode
            // 
            this.lbl_ChooseAMode.AutoSize = true;
            this.lbl_ChooseAMode.Location = new System.Drawing.Point(295, 376);
            this.lbl_ChooseAMode.Name = "lbl_ChooseAMode";
            this.lbl_ChooseAMode.Size = new System.Drawing.Size(216, 19);
            this.lbl_ChooseAMode.TabIndex = 2;
            this.lbl_ChooseAMode.Text = "Choisis ton mode de jeu !";
            // 
            // lbl_NormalMode
            // 
            this.lbl_NormalMode.Location = new System.Drawing.Point(190, 511);
            this.lbl_NormalMode.Name = "lbl_NormalMode";
            this.lbl_NormalMode.Size = new System.Drawing.Size(100, 50);
            this.lbl_NormalMode.TabIndex = 3;
            this.lbl_NormalMode.Text = "Mode normal";
            this.lbl_NormalMode.UseVisualStyleBackColor = true;
            this.lbl_NormalMode.Click += new System.EventHandler(this.lbl_NormalMode_Click);
            // 
            // btn_EasyMode
            // 
            this.btn_EasyMode.Location = new System.Drawing.Point(533, 511);
            this.btn_EasyMode.Name = "btn_EasyMode";
            this.btn_EasyMode.Size = new System.Drawing.Size(100, 50);
            this.btn_EasyMode.TabIndex = 4;
            this.btn_EasyMode.Text = "Mode facile";
            this.btn_EasyMode.UseVisualStyleBackColor = true;
            // 
            // MasterMindGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(834, 811);
            this.Controls.Add(this.btn_EasyMode);
            this.Controls.Add(this.lbl_NormalMode);
            this.Controls.Add(this.lbl_ChooseAMode);
            this.Controls.Add(this.lbl_WelcomeToTheGame);
            this.Controls.Add(this.lbl_MasterMind);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MasterMindGame";
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MasterMind;
        private System.Windows.Forms.Label lbl_WelcomeToTheGame;
        private System.Windows.Forms.Label lbl_ChooseAMode;
        private System.Windows.Forms.Button lbl_NormalMode;
        private System.Windows.Forms.Button btn_EasyMode;
    }
}

