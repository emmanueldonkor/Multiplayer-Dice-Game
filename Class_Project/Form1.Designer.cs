namespace Class_Project
{
    partial class Form1
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
            this.lblShowGameInf = new System.Windows.Forms.Label();
            this.btnGameStarter = new System.Windows.Forms.Button();
            this.btnExit_the_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowGameInf
            // 
            this.lblShowGameInf.AutoSize = true;
            this.lblShowGameInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowGameInf.Location = new System.Drawing.Point(224, 51);
            this.lblShowGameInf.Name = "lblShowGameInf";
            this.lblShowGameInf.Size = new System.Drawing.Size(312, 38);
            this.lblShowGameInf.TabIndex = 0;
            this.lblShowGameInf.Text = "The Game of Luck!";
            // 
            // btnGameStarter
            // 
            this.btnGameStarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGameStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStarter.Location = new System.Drawing.Point(231, 128);
            this.btnGameStarter.Name = "btnGameStarter";
            this.btnGameStarter.Size = new System.Drawing.Size(286, 66);
            this.btnGameStarter.TabIndex = 1;
            this.btnGameStarter.Text = "Start The Game";
            this.btnGameStarter.UseVisualStyleBackColor = false;
            this.btnGameStarter.Click += new System.EventHandler(this.btnGameStarter_Click);
            // 
            // btnExit_the_game
            // 
            this.btnExit_the_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit_the_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_the_game.Location = new System.Drawing.Point(260, 239);
            this.btnExit_the_game.Name = "btnExit_the_game";
            this.btnExit_the_game.Size = new System.Drawing.Size(228, 57);
            this.btnExit_the_game.TabIndex = 2;
            this.btnExit_the_game.Text = "Exit";
            this.btnExit_the_game.UseVisualStyleBackColor = false;
            this.btnExit_the_game.Click += new System.EventHandler(this.btnExit_the_game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 475);
            this.Controls.Add(this.btnExit_the_game);
            this.Controls.Add(this.btnGameStarter);
            this.Controls.Add(this.lblShowGameInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowGameInf;
        private System.Windows.Forms.Button btnGameStarter;
        private System.Windows.Forms.Button btnExit_the_game;
    }
}

