/* Taiyo Suzuki
 * January 7, 2021
 * A simple Air Hockey game. First to score 3 points wins.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace air_hockey
{
    public partial class AirHockey : Form
    {
        int striker1X = 185;
        int striker1Y = 60;
        int player1Score = 0;

        int striker2X = 185;
        int striker2Y = 570;
        int player2Score = 0;

        int strikerSize = 70;
        int strikerSpeed = 8;

        int puckX = 195;
        int puckY = 325;
        int puckSize = 50;
        int puckXSpeed = 0;
        int puckYSpeed = 0;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush greenBrush = new SolidBrush(Color.LawnGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Font screenFont = new Font("Consolas", 16);

        Random randGen = new Random();
        int randomX1 = 0;
        int randomY1 = 0;
        int randomX2 = 0;
        int randomY2 = 0;

        public AirHockey()
        {
            InitializeComponent();
        }

        private void AirHockey_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void AirHockey_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move puck
            puckX += puckXSpeed;
            puckY += puckYSpeed;

            //move player 1 
            if (wDown == true && striker1Y > 50)
            {
                striker1Y -= strikerSpeed;
            }

            if (sDown == true && striker1Y < 260)
            {
                striker1Y += strikerSpeed;
            }

            if (aDown == true && striker1X > 20)
            {
                striker1X -= strikerSpeed;
            }

            if (dDown == true && striker1X < 350)
            {
                striker1X += strikerSpeed;
            }

            //move player 2 
            if (upArrowDown == true && striker2Y > 370)
            {
                striker2Y -= strikerSpeed;
            }

            if (downArrowDown == true && striker2Y < 580)
            {
                striker2Y += strikerSpeed;
            }

            if (leftArrowDown == true && striker2X > 20)
            {
                striker2X -= strikerSpeed;
            }

            if (rightArrowDown == true && striker2X < 350)
            {
                striker2X += strikerSpeed;
            }

            //if puck hits left or right borders, change direction
            if (puckX < 20 || puckX > 370)
            {
                puckXSpeed *= -1;
                puckXSpeed--;
            }
            //top and bottom
            if (puckY < 50 || puckY > 600)
            {
                puckYSpeed *= -1;
                puckYSpeed--;
            }

            //create hitboxes for collison detetcion
            Rectangle player1Rec = new Rectangle(striker1X, striker1Y, strikerSize, strikerSize);
            Rectangle player2Rec = new Rectangle(striker2X, striker2Y, strikerSize, strikerSize);
            Rectangle puckRec = new Rectangle(puckX, puckY, puckSize, puckSize);
            Rectangle net1Rec = new Rectangle(165, 0, 110, 50);
            Rectangle net2Rec = new Rectangle(165, 650, 110, 50);

            //collision detection for players
            if (player1Rec.IntersectsWith(puckRec))
            {
                if (puckXSpeed < 35 && puckYSpeed < 35)
                {
                    randomX1 = randGen.Next(-17, 17);
                    randomY1 = randGen.Next(7, 17);
                    puckXSpeed += randomX1;
                    puckYSpeed += randomY1;
                    puckXSpeed *= -1;
                }
            }
            if (player2Rec.IntersectsWith(puckRec))
            {
                if (puckXSpeed < 35 && puckYSpeed < 35)
                {
                    randomX2 = randGen.Next(-17, 17);
                    randomY2 = randGen.Next(7, 17);
                    puckXSpeed += randomX2 * -1;
                    puckYSpeed += randomY2 * -1;
                    puckXSpeed *= -1;
                }
            }
            //collision detection for nets / scoring
            if (puckRec.IntersectsWith(net1Rec))
            {
                player2Score++;
                puckX = 195;
                puckY = 325;
                puckXSpeed = 0;
                puckYSpeed = 0;
                striker1X = 185;
                striker1Y = 60;
                striker2X = 185;
                striker2Y = 570;
            }
            if (puckRec.IntersectsWith(net2Rec))
            {
                player1Score++;
                puckX = 195;
                puckY = 325;
                puckXSpeed = 0;
                puckYSpeed = 0;
                striker1X = 185;
                striker1Y = 60;
                striker2X = 185;
                striker2Y = 570;
            }
            //puck speed decreases over time
            if (puckXSpeed > 0)
            {
                puckXSpeed--;
            }
            else if (puckXSpeed < 0)
            {
                puckXSpeed++;
            }
            else if (puckXSpeed == 0)
            {
                puckXSpeed = 0;
            }

            if (puckYSpeed > 0)
            {
                puckYSpeed--;
            }
            else if (puckYSpeed < 0)
            {
                puckYSpeed++;
            }
            else if (puckYSpeed == 0)
            {
                puckYSpeed = 0;
            }

            //check if either player has reached 3 points
            if (player1Score == 3 || player2Score == 3)
            {
                gameTimer.Enabled = false;
            }



            Refresh();
        }

        //draw everything on screen
        private void AirHockey_Paint(object sender, PaintEventArgs e)
        {
            Point puck = new Point(puckX, puckY);
            puckImage.Location = puck;

            Point striker1 = new Point(striker1X, striker1Y);
            Point striker2 = new Point(striker2X, striker2Y);
            player1Image.Location = striker1;
            player2Image.Location = striker2;

            e.Graphics.DrawString($"P1: {player1Score}", screenFont, whiteBrush, 310, 10);
            e.Graphics.DrawString($"P2: {player2Score}", screenFont, whiteBrush, 310, 660);
        }
    }
}
