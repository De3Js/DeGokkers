﻿namespace gokkers
{
    partial class GameChooseMenu
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
            this.simulatedButton = new System.Windows.Forms.Button();
            this.smashButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simulatedButton
            // 
            this.simulatedButton.Location = new System.Drawing.Point(151, 156);
            this.simulatedButton.Name = "simulatedButton";
            this.simulatedButton.Size = new System.Drawing.Size(121, 45);
            this.simulatedButton.TabIndex = 0;
            this.simulatedButton.Text = "Simulated Game";
            this.simulatedButton.UseVisualStyleBackColor = true;
            this.simulatedButton.Click += new System.EventHandler(this.simulatedButton_Click);
            // 
            // smashButton
            // 
            this.smashButton.Location = new System.Drawing.Point(12, 156);
            this.smashButton.Name = "smashButton";
            this.smashButton.Size = new System.Drawing.Size(121, 45);
            this.smashButton.TabIndex = 1;
            this.smashButton.Text = "Button smash game";
            this.smashButton.UseVisualStyleBackColor = true;
            this.smashButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the Flea Gamble Game.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How do you want to play the game?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Press the button.";
            // 
            // GameChooseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smashButton);
            this.Controls.Add(this.simulatedButton);
            this.Name = "GameChooseMenu";
            this.Text = "GameChooseMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simulatedButton;
        private System.Windows.Forms.Button smashButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}