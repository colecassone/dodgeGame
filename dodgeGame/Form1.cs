using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace dodgeGame
{


    public partial class Form1 : Form
    {
        Rectangle rightHero = new Rectangle(205, 350, 10, 10);
        Rectangle leftHero = new Rectangle(295, 350, 10, 10);
        Rectangle midLine = new Rectangle(250, 300, 5, 100);
        Pen drawPen = new Pen(Color.White, 5);

        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;
        bool wDown = false;
        bool sDown = false;
        List<Rectangle> leftBalls = new List<Rectangle>();
        List<Rectangle> rightBalls = new List<Rectangle>();

        int heroSpeed = 5;
        int leftSpeed = 8;
        int rightSpeed = 8;


        int WballSize = 3;
        int LballSize = 3;
        int leftCounter = 0;
        int rightCounter = 0;
        // 1 == waiting 
        // 2 == lost
        // 3 === P1winner 
        // 4 == P2winner
        int gameState = 1;


        int leftScore = 0;
        int rightScore = 0;
        int numBall = 60;

        Random randGen = new Random();

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();
        }

        public void GameInitialize()
        {
            // starting the game
            upDown = false;
            downDown = false;
            wDown = false;
            sDown = false;

            leftPersonScore.Visible = true;
            rightPersonScore.Visible = true;

            titleLabel.Text = "";
            subTitleLabel.Text = "";

            gameTimer.Enabled = true;
            gameState = 2;

            leftHero.X = 205;
            leftHero.Y = 350;

            rightHero.X = 295;
            rightHero.Y = 350;

            rightPersonScore.Text = "0";
            leftPersonScore.Text = "0";

            leftScore = 0;
            rightScore = 0;

            easyButton.Visible = false;
            midButton.Visible = false;
            hardButton.Visible = false;
            startButton.Visible = false;

            leftBalls.Clear();
            rightBalls.Clear();


        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        { // to check what are being pushed 
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { // to check what are being pushed 
                case Keys.Down:
                    downDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // waiting for game to sart and to see the level 
            if (gameState == 1)
            {
                titleLabel.Text = "THIS IS THE GAME";
                subTitleLabel.Text = "Press Space Bar to Start or Q to Exit";
            }
            //The game is running in this state 
            else if (gameState == 2)
            {
                titleLabel.Text = "";
                subTitleLabel.Text = "";
                e.Graphics.FillRectangle(whiteBrush, leftHero);
                e.Graphics.FillRectangle(whiteBrush, rightHero);
                e.Graphics.FillRectangle(whiteBrush, midLine);
                for (int i = 0; i < leftBalls.Count(); i++)
                {
                    e.Graphics.FillRectangle(whiteBrush, leftBalls[i]);
                }
                for (int i = 0; i < rightBalls.Count(); i++)
                {
                    e.Graphics.FillRectangle(whiteBrush, rightBalls[i]);
                }
            }
            // right player won the game and gives the option to restart or quit and choose the level 
            else if (gameState == 3)
            {
                gameTimer.Stop();
                leftPersonScore.Visible = false;
                rightPersonScore.Visible = false;
                easyButton.Visible = true;
                midButton.Visible = true;
                hardButton.Visible = true;
                startButton.Visible = true;
                quitButton.Visible = true;
                easyButton.Enabled = true;
                midButton.Enabled = true;
                hardButton.Enabled = true;
                startButton.Enabled = true;
                quitButton.Enabled = true;


                titleLabel.Text = "Left Player Won";
                subTitleLabel.Text = "Press Space Bar to Start Over or Q to Exit";

            }
            // Left player won the game and gives the option to restart or quit and choose the level 
            else
            {
                leftPersonScore.Visible = false;
                rightPersonScore.Visible = false;
                gameTimer.Stop();
                easyButton.Visible = true;
                midButton.Visible = true;
                hardButton.Visible = true;
                startButton.Visible = true;
                quitButton.Visible = true;
                easyButton.Enabled = true;
                midButton.Enabled = true;
                hardButton.Enabled = true;
                startButton.Enabled = true;
                quitButton.Enabled = true;

                titleLabel.Text = "Right Player Won";
                subTitleLabel.Text = "Press Space Bar to Start Over or Q to Exit";
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //lefthHero move up or down when the up or down keys are pressed.
            if (upDown == true)
            {
                rightHero.Y -= heroSpeed;
            }

            if (downDown == true && rightHero.Y < 390)
            {
                rightHero.Y += heroSpeed;
            }

            // rightHero move when the W or S keys are pressed 
            if (wDown == true && leftHero.Y > 0)
            {
                leftHero.Y -= heroSpeed;
            }

            if (sDown == true && leftHero.Y < 390)
            {
                leftHero.Y += heroSpeed;
            }
            // Adding balls to the list and uses a counter to limit the amount of balls per time 
            leftCounter++;
            rightCounter++;

            if (leftCounter == numBall)
            {
                int leftRandom = randGen.Next(1, 301);

                leftBalls.Add(new Rectangle(0, leftRandom, LballSize, WballSize));
                leftCounter = 0;
            }

            if (rightCounter == numBall)
            {
                int rightRandom = randGen.Next(1, 301);

                rightBalls.Add(new Rectangle(500, rightRandom, LballSize, WballSize));
                rightCounter = 0;
            }

            // moving the left side balls right to left
            for (int i = 0; i < leftBalls.Count; i++)
            {
                int x = leftBalls[i].X + leftSpeed;
                leftBalls[i] = (new Rectangle(x, leftBalls[i].Y, LballSize, WballSize));
            }
            // moveing the right side balls left to right 
            for (int i = 0; i < rightBalls.Count; i++)
            {
                int x = rightBalls[i].X - rightSpeed;
                rightBalls[i] = (new Rectangle(x, rightBalls[i].Y, LballSize, WballSize));
            }
            // this is check the heros and balls to see of there is intersections and if there is play a sound a reset hero 
            SoundPlayer wrong = new SoundPlayer(Properties.Resources.wrong);

            for (int i = 0; i < rightBalls.Count; i++)
            {
                if (leftHero.IntersectsWith(rightBalls[i]))
                {
                    wrong.Play();
                    leftHero.Y = 350;
                }

                if (rightHero.IntersectsWith(rightBalls[i]))
                {
                    wrong.Play();
                    rightHero.Y = 350;
                }
            }
            // this is check the heros and balls to see of there is intersections and if there is play a sound a reset hero 
            for (int i = 0; i < leftBalls.Count; i++)
            {
                if (leftHero.IntersectsWith(leftBalls[i]))
                {
                    wrong.Play();

                    leftHero.Y = 350;
                }

                if (rightHero.IntersectsWith(leftBalls[i]))
                {
                    wrong.Play();

                    rightHero.Y = 350;
                }
            }

            SoundPlayer player = new SoundPlayer(Properties.Resources.someoneWon);
            SoundPlayer playerGG = new SoundPlayer(Properties.Resources.bell);

            // See if left hero has hit the back and if he has add to the score and if the score is greater then 3 go to a different game state 
            if (leftHero.Y == 0)
            {
                playerGG.Play();
                leftScore++;

                if (leftScore == 3)
                {
                    player.Play();
                    gameState = 3;
                }
                else
                {
                    leftPersonScore.Text = $"{leftScore}";
                    leftHero.Y = 350;
                }

            }
            // See if right hero has hit the back and if he has add to the score and if the score is greater then 3 go to a different game state 
            if (rightHero.Y == 0)
            {
                rightScore++;
                playerGG.Play();

                if (rightScore == 3)
                {
                    gameState = 4;
                    player.Play();
                }
                else
                {
                    rightPersonScore.Text = $"{rightScore}";
                    rightHero.Y = 350;
                }

            }

            Refresh();

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            midButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Gray;
            easyButton.BackColor = Color.White;
            numBall = 60;
        }

        private void midButton_Click(object sender, EventArgs e)
        {

            midButton.BackColor = Color.White;
            hardButton.BackColor = Color.Gray;
            easyButton.BackColor = Color.Gray;
            numBall = 13;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {

            midButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.White;
            easyButton.BackColor = Color.Gray;
            numBall = 4;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            midButton.Enabled = false;
            hardButton.Enabled = false;
            easyButton.Enabled = false;
            midButton.Visible = false;
            hardButton.Visible = false;
            easyButton.Visible = false;
            startButton.Enabled = false;
            startButton.Visible = false;
            quitButton.Enabled = false;
            quitButton.Visible = false;
            GameInitialize();
            this.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
