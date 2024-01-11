namespace MasterMind_Graphique_Projet
{
    partial class Frm_EasyMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCheatCode = new System.Windows.Forms.Panel();
            this.pnl_RIghtOrBadP = new System.Windows.Forms.Panel();
            this.lbl_NumberTry = new System.Windows.Forms.Label();
            this.btn_UndoLabelColor = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.pnlBtnClr = new System.Windows.Forms.Panel();
            this.pnlClrChoose = new System.Windows.Forms.Panel();
            this.btn_Replay = new System.Windows.Forms.Button();
            this.lbl_EasyMode = new System.Windows.Forms.Label();
            this.btn_ExitNormalMode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeTricheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCheatCode
            // 
            this.panelCheatCode.Location = new System.Drawing.Point(15, 107);
            this.panelCheatCode.Name = "panelCheatCode";
            this.panelCheatCode.Size = new System.Drawing.Size(189, 44);
            this.panelCheatCode.TabIndex = 43;
            // 
            // pnl_RIghtOrBadP
            // 
            this.pnl_RIghtOrBadP.Location = new System.Drawing.Point(50, 185);
            this.pnl_RIghtOrBadP.Name = "pnl_RIghtOrBadP";
            this.pnl_RIghtOrBadP.Size = new System.Drawing.Size(120, 683);
            this.pnl_RIghtOrBadP.TabIndex = 42;
            // 
            // lbl_NumberTry
            // 
            this.lbl_NumberTry.AutoSize = true;
            this.lbl_NumberTry.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberTry.Location = new System.Drawing.Point(320, 92);
            this.lbl_NumberTry.Name = "lbl_NumberTry";
            this.lbl_NumberTry.Size = new System.Drawing.Size(71, 23);
            this.lbl_NumberTry.TabIndex = 41;
            this.lbl_NumberTry.Text = "label1";
            // 
            // btn_UndoLabelColor
            // 
            this.btn_UndoLabelColor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UndoLabelColor.Location = new System.Drawing.Point(620, 622);
            this.btn_UndoLabelColor.Name = "btn_UndoLabelColor";
            this.btn_UndoLabelColor.Size = new System.Drawing.Size(111, 50);
            this.btn_UndoLabelColor.TabIndex = 40;
            this.btn_UndoLabelColor.Text = "Annuler";
            this.btn_UndoLabelColor.UseVisualStyleBackColor = true;
            this.btn_UndoLabelColor.Click += new System.EventHandler(this.Btn_UndoLabelColor_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(620, 701);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(111, 50);
            this.btn_Check.TabIndex = 39;
            this.btn_Check.Text = "Valider";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // pnlBtnClr
            // 
            this.pnlBtnClr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtnClr.Location = new System.Drawing.Point(645, 151);
            this.pnlBtnClr.Name = "pnlBtnClr";
            this.pnlBtnClr.Size = new System.Drawing.Size(62, 415);
            this.pnlBtnClr.TabIndex = 38;
            // 
            // pnlClrChoose
            // 
            this.pnlClrChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClrChoose.Location = new System.Drawing.Point(215, 133);
            this.pnlClrChoose.Name = "pnlClrChoose";
            this.pnlClrChoose.Size = new System.Drawing.Size(346, 735);
            this.pnlClrChoose.TabIndex = 37;
            // 
            // btn_Replay
            // 
            this.btn_Replay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Replay.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Replay.Location = new System.Drawing.Point(596, 31);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(166, 50);
            this.btn_Replay.TabIndex = 36;
            this.btn_Replay.Text = "Recommencer";
            this.btn_Replay.UseVisualStyleBackColor = true;
            this.btn_Replay.Click += new System.EventHandler(this.Btn_Replay_Click);
            // 
            // lbl_EasyMode
            // 
            this.lbl_EasyMode.AutoSize = true;
            this.lbl_EasyMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EasyMode.Location = new System.Drawing.Point(333, 43);
            this.lbl_EasyMode.Name = "lbl_EasyMode";
            this.lbl_EasyMode.Size = new System.Drawing.Size(122, 23);
            this.lbl_EasyMode.TabIndex = 35;
            this.lbl_EasyMode.Text = "Mode facile";
            // 
            // btn_ExitNormalMode
            // 
            this.btn_ExitNormalMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitNormalMode.Location = new System.Drawing.Point(43, 31);
            this.btn_ExitNormalMode.Name = "btn_ExitNormalMode";
            this.btn_ExitNormalMode.Size = new System.Drawing.Size(120, 62);
            this.btn_ExitNormalMode.TabIndex = 34;
            this.btn_ExitNormalMode.Text = "Revenir au menu";
            this.btn_ExitNormalMode.UseVisualStyleBackColor = true;
            this.btn_ExitNormalMode.Click += new System.EventHandler(this.Btn_ExitNormalMode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeTricheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeTricheToolStripMenuItem
            // 
            this.modeTricheToolStripMenuItem.Name = "modeTricheToolStripMenuItem";
            this.modeTricheToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.modeTricheToolStripMenuItem.Text = "Mode triche";
            this.modeTricheToolStripMenuItem.Click += new System.EventHandler(this.CheatModeToolStripMenuItem_Click);
            // 
            // Frm_EasyMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(784, 876);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelCheatCode);
            this.Controls.Add(this.pnl_RIghtOrBadP);
            this.Controls.Add(this.lbl_NumberTry);
            this.Controls.Add(this.btn_UndoLabelColor);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.pnlBtnClr);
            this.Controls.Add(this.pnlClrChoose);
            this.Controls.Add(this.btn_Replay);
            this.Controls.Add(this.lbl_EasyMode);
            this.Controls.Add(this.btn_ExitNormalMode);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_EasyMode";
            this.Text = "MasterMind - Mode facile";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCheatCode;
        private System.Windows.Forms.Panel pnl_RIghtOrBadP;
        private System.Windows.Forms.Label lbl_NumberTry;
        private System.Windows.Forms.Button btn_UndoLabelColor;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Panel pnlBtnClr;
        private System.Windows.Forms.Panel pnlClrChoose;
        private System.Windows.Forms.Button btn_Replay;
        private System.Windows.Forms.Label lbl_EasyMode;
        private System.Windows.Forms.Button btn_ExitNormalMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeTricheToolStripMenuItem;
    }
}