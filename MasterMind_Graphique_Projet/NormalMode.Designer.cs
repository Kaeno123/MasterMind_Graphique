namespace MasterMind_Graphique_Projet
{
    partial class frm_NormalMode
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
            this.btn_ExitNormalMode = new System.Windows.Forms.Button();
            this.lbl_NormalMode = new System.Windows.Forms.Label();
            this.btn_ClrGreen = new System.Windows.Forms.Button();
            this.btn_ClrBlue = new System.Windows.Forms.Button();
            this.btn_ClrMagenta = new System.Windows.Forms.Button();
            this.bt_ClrRed = new System.Windows.Forms.Button();
            this.btn_ClrWhite = new System.Windows.Forms.Button();
            this.btn_ClrYellow = new System.Windows.Forms.Button();
            this.btn_ClrCyan = new System.Windows.Forms.Button();
            this.btn_Replay = new System.Windows.Forms.Button();
            this.pnlClrChoose = new System.Windows.Forms.Panel();
            this.pnlBtnClr = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_UndoLabelColor = new System.Windows.Forms.Button();
            this.pnlBtnClr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ExitNormalMode
            // 
            this.btn_ExitNormalMode.Location = new System.Drawing.Point(12, 12);
            this.btn_ExitNormalMode.Name = "btn_ExitNormalMode";
            this.btn_ExitNormalMode.Size = new System.Drawing.Size(100, 50);
            this.btn_ExitNormalMode.TabIndex = 1;
            this.btn_ExitNormalMode.Text = "Revenir au menu";
            this.btn_ExitNormalMode.UseVisualStyleBackColor = true;
            this.btn_ExitNormalMode.Click += new System.EventHandler(this.btn_ExitNormalMode_Click);
            // 
            // lbl_NormalMode
            // 
            this.lbl_NormalMode.AutoSize = true;
            this.lbl_NormalMode.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NormalMode.Location = new System.Drawing.Point(277, 22);
            this.lbl_NormalMode.Name = "lbl_NormalMode";
            this.lbl_NormalMode.Size = new System.Drawing.Size(199, 32);
            this.lbl_NormalMode.TabIndex = 2;
            this.lbl_NormalMode.Text = "Mode normal";
            // 
            // btn_ClrGreen
            // 
            this.btn_ClrGreen.BackColor = System.Drawing.Color.Green;
            this.btn_ClrGreen.Location = new System.Drawing.Point(10, 14);
            this.btn_ClrGreen.Name = "btn_ClrGreen";
            this.btn_ClrGreen.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrGreen.TabIndex = 3;
            this.btn_ClrGreen.Tag = "Green";
            this.btn_ClrGreen.UseVisualStyleBackColor = false;
            this.btn_ClrGreen.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_ClrBlue
            // 
            this.btn_ClrBlue.BackColor = System.Drawing.Color.Blue;
            this.btn_ClrBlue.Location = new System.Drawing.Point(10, 299);
            this.btn_ClrBlue.Name = "btn_ClrBlue";
            this.btn_ClrBlue.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrBlue.TabIndex = 4;
            this.btn_ClrBlue.Tag = "Blue";
            this.btn_ClrBlue.UseVisualStyleBackColor = false;
            this.btn_ClrBlue.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_ClrMagenta
            // 
            this.btn_ClrMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btn_ClrMagenta.Location = new System.Drawing.Point(10, 242);
            this.btn_ClrMagenta.Name = "btn_ClrMagenta";
            this.btn_ClrMagenta.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrMagenta.TabIndex = 5;
            this.btn_ClrMagenta.Tag = "Magenta";
            this.btn_ClrMagenta.UseVisualStyleBackColor = false;
            this.btn_ClrMagenta.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // bt_ClrRed
            // 
            this.bt_ClrRed.BackColor = System.Drawing.Color.Red;
            this.bt_ClrRed.Location = new System.Drawing.Point(10, 185);
            this.bt_ClrRed.Name = "bt_ClrRed";
            this.bt_ClrRed.Size = new System.Drawing.Size(40, 40);
            this.bt_ClrRed.TabIndex = 6;
            this.bt_ClrRed.Tag = "Red";
            this.bt_ClrRed.UseVisualStyleBackColor = false;
            this.bt_ClrRed.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_ClrWhite
            // 
            this.btn_ClrWhite.BackColor = System.Drawing.Color.White;
            this.btn_ClrWhite.Location = new System.Drawing.Point(10, 128);
            this.btn_ClrWhite.Name = "btn_ClrWhite";
            this.btn_ClrWhite.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrWhite.TabIndex = 7;
            this.btn_ClrWhite.Tag = "White";
            this.btn_ClrWhite.UseVisualStyleBackColor = false;
            this.btn_ClrWhite.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_ClrYellow
            // 
            this.btn_ClrYellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_ClrYellow.Location = new System.Drawing.Point(10, 71);
            this.btn_ClrYellow.Name = "btn_ClrYellow";
            this.btn_ClrYellow.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrYellow.TabIndex = 8;
            this.btn_ClrYellow.Tag = "Yellow";
            this.btn_ClrYellow.UseVisualStyleBackColor = false;
            this.btn_ClrYellow.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_ClrCyan
            // 
            this.btn_ClrCyan.BackColor = System.Drawing.Color.Cyan;
            this.btn_ClrCyan.Location = new System.Drawing.Point(10, 356);
            this.btn_ClrCyan.Name = "btn_ClrCyan";
            this.btn_ClrCyan.Size = new System.Drawing.Size(40, 40);
            this.btn_ClrCyan.TabIndex = 9;
            this.btn_ClrCyan.Tag = "Cyan";
            this.btn_ClrCyan.UseVisualStyleBackColor = false;
            this.btn_ClrCyan.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_Replay
            // 
            this.btn_Replay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Replay.Location = new System.Drawing.Point(609, 12);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(150, 50);
            this.btn_Replay.TabIndex = 10;
            this.btn_Replay.Text = "Recommencer";
            this.btn_Replay.UseVisualStyleBackColor = true;
            this.btn_Replay.Click += new System.EventHandler(this.btn_Replay_Click);
            // 
            // pnlClrChoose
            // 
            this.pnlClrChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClrChoose.Location = new System.Drawing.Point(212, 114);
            this.pnlClrChoose.Name = "pnlClrChoose";
            this.pnlClrChoose.Size = new System.Drawing.Size(346, 735);
            this.pnlClrChoose.TabIndex = 27;
            // 
            // pnlBtnClr
            // 
            this.pnlBtnClr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtnClr.Controls.Add(this.btn_ClrCyan);
            this.pnlBtnClr.Controls.Add(this.btn_ClrGreen);
            this.pnlBtnClr.Controls.Add(this.btn_ClrBlue);
            this.pnlBtnClr.Controls.Add(this.btn_ClrMagenta);
            this.pnlBtnClr.Controls.Add(this.bt_ClrRed);
            this.pnlBtnClr.Controls.Add(this.btn_ClrWhite);
            this.pnlBtnClr.Controls.Add(this.btn_ClrYellow);
            this.pnlBtnClr.Location = new System.Drawing.Point(642, 132);
            this.pnlBtnClr.Name = "pnlBtnClr";
            this.pnlBtnClr.Size = new System.Drawing.Size(62, 415);
            this.pnlBtnClr.TabIndex = 28;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(617, 682);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(111, 50);
            this.btn_Check.TabIndex = 29;
            this.btn_Check.Text = "Valider";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_UndoLabelColor
            // 
            this.btn_UndoLabelColor.Location = new System.Drawing.Point(617, 603);
            this.btn_UndoLabelColor.Name = "btn_UndoLabelColor";
            this.btn_UndoLabelColor.Size = new System.Drawing.Size(111, 50);
            this.btn_UndoLabelColor.TabIndex = 30;
            this.btn_UndoLabelColor.Text = "Annuler";
            this.btn_UndoLabelColor.UseVisualStyleBackColor = true;
            this.btn_UndoLabelColor.Click += new System.EventHandler(this.btn_UndoLabelColor_Click);
            // 
            // frm_NormalMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.Controls.Add(this.btn_UndoLabelColor);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.pnlBtnClr);
            this.Controls.Add(this.pnlClrChoose);
            this.Controls.Add(this.btn_Replay);
            this.Controls.Add(this.lbl_NormalMode);
            this.Controls.Add(this.btn_ExitNormalMode);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_NormalMode";
            this.Text = "MasterMind - Mode normal";
            this.Click += new System.EventHandler(this.btn_Color_Click);
            this.pnlBtnClr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitNormalMode;
        private System.Windows.Forms.Label lbl_NormalMode;
        private System.Windows.Forms.Button btn_ClrGreen;
        private System.Windows.Forms.Button btn_ClrBlue;
        private System.Windows.Forms.Button btn_ClrMagenta;
        private System.Windows.Forms.Button bt_ClrRed;
        private System.Windows.Forms.Button btn_ClrWhite;
        private System.Windows.Forms.Button btn_ClrYellow;
        private System.Windows.Forms.Button btn_ClrCyan;
        private System.Windows.Forms.Button btn_Replay;
        private System.Windows.Forms.Panel pnlClrChoose;
        private System.Windows.Forms.Panel pnlBtnClr;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_UndoLabelColor;
    }
}