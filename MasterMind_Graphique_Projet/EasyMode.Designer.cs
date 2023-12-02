namespace MasterMind_Graphique_Projet
{
    partial class frm_EasyMode
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
            this.btn_ExitEasyMode = new System.Windows.Forms.Button();
            this.lbl_EasyMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ExitEasyMode
            // 
            this.btn_ExitEasyMode.Location = new System.Drawing.Point(12, 12);
            this.btn_ExitEasyMode.Name = "btn_ExitEasyMode";
            this.btn_ExitEasyMode.Size = new System.Drawing.Size(100, 50);
            this.btn_ExitEasyMode.TabIndex = 0;
            this.btn_ExitEasyMode.Text = "Revenir au menu";
            this.btn_ExitEasyMode.UseVisualStyleBackColor = true;
            this.btn_ExitEasyMode.Click += new System.EventHandler(this.btn_ExitEasyMode_Click);
            // 
            // lbl_EasyMode
            // 
            this.lbl_EasyMode.AutoSize = true;
            this.lbl_EasyMode.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EasyMode.Location = new System.Drawing.Point(274, 22);
            this.lbl_EasyMode.Name = "lbl_EasyMode";
            this.lbl_EasyMode.Size = new System.Drawing.Size(182, 32);
            this.lbl_EasyMode.TabIndex = 3;
            this.lbl_EasyMode.Text = "Mode facile";
            // 
            // frm_EasyMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.Controls.Add(this.lbl_EasyMode);
            this.Controls.Add(this.btn_ExitEasyMode);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_EasyMode";
            this.Text = "MasterMind - Mode facile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitEasyMode;
        private System.Windows.Forms.Label lbl_EasyMode;
    }
}