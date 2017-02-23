namespace gokkers
{
    partial class Form2
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
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox3 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nameLabel4 = new System.Windows.Forms.Label();
            this.nameChangeButton = new System.Windows.Forms.Button();
            this.nameTextBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(142, 187);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(210, 20);
            this.nameTextBox1.TabIndex = 0;
            // 
            // nameTextBox3
            // 
            this.nameTextBox3.Location = new System.Drawing.Point(142, 241);
            this.nameTextBox3.Name = "nameTextBox3";
            this.nameTextBox3.Size = new System.Drawing.Size(210, 20);
            this.nameTextBox3.TabIndex = 1;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(142, 213);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(210, 20);
            this.nameTextBox2.TabIndex = 2;
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(94, 190);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(42, 13);
            this.nameLabel1.TabIndex = 6;
            this.nameLabel1.Text = "Player1";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(94, 216);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(42, 13);
            this.nameLabel2.TabIndex = 7;
            this.nameLabel2.Text = "Player2";
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Location = new System.Drawing.Point(94, 244);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(42, 13);
            this.nameLabel3.TabIndex = 8;
            this.nameLabel3.Text = "Player3";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 92);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nameLabel4
            // 
            this.nameLabel4.AutoSize = true;
            this.nameLabel4.Location = new System.Drawing.Point(94, 270);
            this.nameLabel4.Name = "nameLabel4";
            this.nameLabel4.Size = new System.Drawing.Size(42, 13);
            this.nameLabel4.TabIndex = 12;
            this.nameLabel4.Text = "Player4";
            // 
            // nameChangeButton
            // 
            this.nameChangeButton.Location = new System.Drawing.Point(142, 296);
            this.nameChangeButton.Name = "nameChangeButton";
            this.nameChangeButton.Size = new System.Drawing.Size(98, 49);
            this.nameChangeButton.TabIndex = 11;
            this.nameChangeButton.Text = "Change names";
            this.nameChangeButton.UseVisualStyleBackColor = true;
            this.nameChangeButton.Click += new System.EventHandler(this.nameButton4_Click);
            // 
            // nameTextBox4
            // 
            this.nameTextBox4.Location = new System.Drawing.Point(142, 267);
            this.nameTextBox4.Name = "nameTextBox4";
            this.nameTextBox4.Size = new System.Drawing.Size(210, 20);
            this.nameTextBox4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Change names here";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel4);
            this.Controls.Add(this.nameChangeButton);
            this.Controls.Add(this.nameTextBox4);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.nameTextBox3);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox nameTextBox3;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label nameLabel4;
        private System.Windows.Forms.Button nameChangeButton;
        private System.Windows.Forms.TextBox nameTextBox4;
        private System.Windows.Forms.Label label2;
    }
}