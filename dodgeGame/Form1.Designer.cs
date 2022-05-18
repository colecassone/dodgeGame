namespace dodgeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.leftPersonScore = new System.Windows.Forms.Label();
            this.rightPersonScore = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.midButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(159, 92);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 19);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.subTitleLabel.Location = new System.Drawing.Point(144, 161);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(186, 126);
            this.subTitleLabel.TabIndex = 4;
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftPersonScore
            // 
            this.leftPersonScore.AutoSize = true;
            this.leftPersonScore.BackColor = System.Drawing.Color.Transparent;
            this.leftPersonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPersonScore.ForeColor = System.Drawing.Color.White;
            this.leftPersonScore.Location = new System.Drawing.Point(12, 366);
            this.leftPersonScore.Name = "leftPersonScore";
            this.leftPersonScore.Size = new System.Drawing.Size(24, 25);
            this.leftPersonScore.TabIndex = 5;
            this.leftPersonScore.Text = "0";
            this.leftPersonScore.Visible = false;
            // 
            // rightPersonScore
            // 
            this.rightPersonScore.AutoSize = true;
            this.rightPersonScore.BackColor = System.Drawing.Color.Transparent;
            this.rightPersonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPersonScore.ForeColor = System.Drawing.Color.White;
            this.rightPersonScore.Location = new System.Drawing.Point(464, 366);
            this.rightPersonScore.Name = "rightPersonScore";
            this.rightPersonScore.Size = new System.Drawing.Size(24, 25);
            this.rightPersonScore.TabIndex = 6;
            this.rightPersonScore.Text = "0";
            this.rightPersonScore.Visible = false;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.White;
            this.easyButton.ForeColor = System.Drawing.Color.Black;
            this.easyButton.Location = new System.Drawing.Point(63, 264);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 7;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // midButton
            // 
            this.midButton.BackColor = System.Drawing.Color.Gray;
            this.midButton.ForeColor = System.Drawing.Color.Black;
            this.midButton.Location = new System.Drawing.Point(203, 264);
            this.midButton.Name = "midButton";
            this.midButton.Size = new System.Drawing.Size(75, 23);
            this.midButton.TabIndex = 8;
            this.midButton.Text = "MEDIUM";
            this.midButton.UseVisualStyleBackColor = false;
            this.midButton.Click += new System.EventHandler(this.midButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Gray;
            this.hardButton.ForeColor = System.Drawing.Color.Black;
            this.hardButton.Location = new System.Drawing.Point(346, 264);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 23);
            this.hardButton.TabIndex = 9;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gray;
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(203, 310);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Gray;
            this.quitButton.ForeColor = System.Drawing.Color.Black;
            this.quitButton.Location = new System.Drawing.Point(422, 340);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.midButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.rightPersonScore);
            this.Controls.Add(this.leftPersonScore);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label leftPersonScore;
        private System.Windows.Forms.Label rightPersonScore;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button midButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button quitButton;
    }
}

