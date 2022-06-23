//NAME Iesu Alora
//DATE 23/06/2022
//TEACHER Mr. Wachs
//Assignment Final Project
//PURPOSE to demonstrate all concepts taught in copmuter science.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Testing_2
{
   
    public partial class Form1 : Form
    {
        int x;              // integers for location of projectiles
        int x2 = 0;
        int x3;
        int x4;
        int y;
        int y2;
        int y3;
        int y4;
        bool up;            // booleans to determine direction of porjectiles
        bool right;
        bool dRight;
        bool nextPhase;     // boolean to change difficulty of game
        const int STOPPED = 0;          // For when the game first starts
        const int MOVE_UP = 1;          // integers for movement
        const int MOVE_DOWN = 2;
        const int MOVE_LEFT = 3;
        const int MOVE_RIGHT = 4;
        int moveAmount = 2;      // How much a character moves in pixels
        int bulletMove;
        // More constants for the key pressed on the keyboard they are stored
        // as numbers
        const int KEY_END = 27;         // Escape key
        const int KEY_UP = 38;          // W key
        const int KEY_DOWN = 40;        // S key
        const int KEY_LEFT = 37;        // A key
        const int KEY_RIGHT = 39;       // D key
        // Variables (to track movement and where things are) using geometry 
        // and the cartesian plane (x,y) coordinates
        // Now some variables for sprite (for the coordinates)
        // Variables for each "edge" of the rectangle (or "hitbox" or "bounding" box)
        int spriteTop; // Coordinates
        int spriteBottom;
        int spriteLeft;
        int spriteRight;
        int spriteWidth;
        int spriteHeight;

        int bulletTop;
        int bulletLeft;
        int bulletWidth;
        int bulletHeight;
        int bulletRight;
        int bulletBottom;

        int bullet2Top;
        int bullet2Left;
        int bullet2Width;
        int bullet2Height;
        int bullet2Right;
        int bullet2Bottom;

        int bullet3Top;
        int bullet3Left;
        int bullet3Width;
        int bullet3Height;
        int bullet3Right;
        int bullet3Bottom;

        int bullet4Top;
        int bullet4Left;
        int bullet4Width;
        int bullet4Height;
        int bullet4Right;
        int bullet4Bottom;

        int topWallTop;
        int topWallLeft;
        int topWallWidth;
        int topWallHeight;
        int topWallRight;
        int topWallBottom;

        int bottomWallTop;
        int bottomWallLeft;
        int bottomWallWidth;
        int bottomWallHeight;
        int bottomWallRight;
        int bottomWallBottom;

        int leftWallTop;
        int leftWallLeft;
        int leftWallWidth;
        int leftWallHeight;
        int leftWallRight;
        int leftWallBottom;

        int rightWallTop;
        int rightWallLeft;
        int rightWallWidth;
        int rightWallHeight;
        int rightWallRight;
        int rightWallBottom;

        int laserBottomTop;
        int laserBottomBottom;
        int laserBottomLeft;
        int laserBottomRight;
        int laserBottomWidth;
        int laserBottomHeight;

        int laserTopTop;
        int laserTopBottom;
        int laserTopLeft;
        int laserTopRight;
        int laserTopWidth;
        int laserTopHeight;

        int gameTime;
        // Also one more variable for sprite to track the movement (potentially 
        // could also be made for each projectile)
        int spriteDirection = STOPPED;
        System.Drawing.Pen pen;
        System.Drawing.Pen pen2;
        System.Drawing.Graphics surface;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue);
            pen2 = new Pen(Color.Red);
            surface = this.CreateGraphics();
            surface.Clear(Color.Black);
            right = true;
            bulletMove = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getSpriteCoordinates(); 
            moveCoordinates();         
            redrawTheScreen();      

        }
        private void getSpriteCoordinates()
        {
            spriteTop = picSprite.Top;
            spriteLeft = picSprite.Left;
            spriteWidth = picSprite.Width;
            spriteHeight = picSprite.Height;

            // The bottom and the right are calculated
            spriteRight = spriteLeft + spriteWidth;
            spriteBottom = spriteTop + spriteHeight;

            bulletTop = y;
            bulletLeft = x2;
            bulletWidth = 20;
            bulletHeight = 20;
            bulletRight = bulletLeft + bulletWidth;
            bulletBottom = bulletTop + bulletHeight;

            bullet2Top = y2;
            bullet2Left = x;
            bullet2Width = 20;
            bullet2Height = 20;
            bullet2Right = bullet2Left + bullet2Width;
            bullet2Bottom = bullet2Top + bullet2Height;

            bullet3Top = y3;
            bullet3Left = x3;
            bullet3Width = 30;
            bullet3Height = 30;
            bullet3Right = bullet3Left + bullet3Width;
            bullet3Bottom = bullet3Top + bullet3Height;

            bullet4Top = y4;
            bullet4Left = x4;
            bullet4Width = 30;
            bullet4Height = 30;
            bullet4Right = bullet4Left + bullet4Width;
            bullet4Bottom = bullet4Top + bullet4Height;

            topWallTop = picTopWall.Top;
            topWallLeft = picTopWall.Left;
            topWallWidth = picTopWall.Width;
            topWallHeight = picTopWall.Height;
            topWallRight = topWallLeft + topWallWidth;
            topWallBottom = topWallTop + topWallHeight;

            bottomWallTop = picBottomWall.Top;
            bottomWallLeft = picBottomWall.Left;
            bottomWallWidth = picBottomWall.Width;
            bottomWallHeight = picBottomWall.Height;
            bottomWallRight = bottomWallLeft + bottomWallWidth;
            bottomWallBottom = bottomWallTop + bottomWallHeight;

            leftWallTop = picLeftWall.Top;
            leftWallLeft = picLeftWall.Left;
            leftWallWidth = picLeftWall.Width;
            leftWallHeight = picLeftWall.Height;
            leftWallRight = leftWallLeft + leftWallWidth;
            leftWallBottom = leftWallTop + leftWallHeight;

            rightWallTop = picRightWall.Top;
            rightWallLeft = picRightWall.Left;
            rightWallWidth = picRightWall.Width;
            rightWallHeight = picRightWall.Height;
            rightWallRight = rightWallLeft + rightWallWidth;
            rightWallBottom = rightWallTop + rightWallHeight;

            laserBottomTop = picLaserBottomOver.Top;
            laserBottomLeft = picLaserBottomOver.Left;
            laserBottomWidth = picLaserBottomOver.Width;
            laserBottomHeight = picLaserBottomOver.Height;

            // The bottom and the right are calculated
            laserBottomRight = laserBottomLeft + laserBottomWidth;
            laserBottomBottom = laserBottomTop + laserBottomHeight;

            laserTopTop = picLaserTopOver.Top;
            laserTopLeft = picLaserTopOver.Left;
            laserTopWidth = picLaserTopOver.Width;
            laserTopHeight = picLaserTopOver.Height;

            // The Top and the right are calculated
            laserTopRight = laserTopLeft + laserTopWidth;
            laserTopBottom = laserTopTop + laserTopHeight;


        }
        private void moveCoordinates()
        {
            if (spriteDirection == MOVE_UP) spriteTop = spriteTop - moveAmount;
            else if (spriteDirection == MOVE_DOWN) spriteTop = spriteTop + moveAmount;
            else if (spriteDirection == MOVE_LEFT) spriteLeft = spriteLeft - moveAmount;
            else if (spriteDirection == MOVE_RIGHT) spriteLeft = spriteLeft + moveAmount;

            // Recalculate the other coordinates
            spriteRight = spriteLeft + spriteWidth;
            spriteBottom = spriteTop + spriteHeight;
        }
        private void collisionDetection()
        {
            if (((spriteLeft >= bulletLeft && spriteLeft <= bulletRight) ||
                (spriteRight >= bulletLeft && spriteRight <= bulletRight)) &&
                ((spriteTop >= bulletTop && spriteTop <= bulletBottom) ||
                (spriteBottom >= bulletTop && spriteBottom <= bulletBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }
            else if (((bulletLeft >= spriteLeft && bulletLeft <= spriteRight) ||
                    (bulletRight >= spriteLeft && bulletRight <= spriteRight)) &&
                    ((bulletTop >= spriteTop && bulletTop <= spriteBottom) ||
                    (bulletBottom >= spriteTop && bulletBottom <= spriteBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }
            if (((spriteLeft >= bullet2Left && spriteLeft <= bullet2Right) ||
                (spriteRight >= bullet2Left && spriteRight <= bullet2Right)) &&
                ((spriteTop >= bullet2Top && spriteTop <= bullet2Bottom) ||
                (spriteBottom >= bullet2Top && spriteBottom <= bullet2Bottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }
            else if (((bullet2Left >= spriteLeft && bullet2Left <= spriteRight) ||
                    (bullet2Right >= spriteLeft && bullet2Right <= spriteRight)) &&
                    ((bullet2Top >= spriteTop && bullet2Top <= spriteBottom) ||
                    (bullet2Bottom >= spriteTop && bullet2Bottom <= spriteBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }
            if (nextPhase == true)
            {
                if (((spriteLeft >= bullet3Left && spriteLeft <= bullet3Right) ||
                (spriteRight >= bullet3Left && spriteRight <= bullet3Right)) &&
                ((spriteTop >= bullet3Top && spriteTop <= bullet3Bottom) ||
                (spriteBottom >= bullet3Top && spriteBottom <= bullet3Bottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds");
                    Application.Exit();
                }
                else if (((bullet3Left >= spriteLeft && bullet3Left <= spriteRight) ||
                        (bullet3Right >= spriteLeft && bullet3Right <= spriteRight)) &&
                        ((bullet3Top >= spriteTop && bullet3Top <= spriteBottom) ||
                        (bullet3Bottom >= spriteTop && bullet3Bottom <= spriteBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds");
                    Application.Exit();
                }
            }
    
            if (((spriteLeft >= bullet4Left && spriteLeft <= bullet4Right) ||
                (spriteRight >= bullet4Left && spriteRight <= bullet4Right)) &&
                ((spriteTop >= bullet4Top && spriteTop <= bullet4Bottom) ||
                (spriteBottom >= bullet4Top && spriteBottom <= bullet4Bottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }
            else if (((bullet4Left >= spriteLeft && bullet4Left <= spriteRight) ||
                    (bullet4Right >= spriteLeft && bullet4Right <= spriteRight)) &&
                    ((bullet4Top >= spriteTop && bullet4Top <= spriteBottom) ||
                    (bullet4Bottom >= spriteTop && bullet4Bottom <= spriteBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                Application.Exit();
            }

            if (picLaserBottomOver.Visible == true)
               {
                if (((spriteLeft >= laserBottomLeft && spriteLeft <= laserBottomRight) ||
                   (spriteRight >= laserBottomLeft && spriteRight <= laserBottomRight)) &&
                   ((spriteTop >= laserBottomTop && spriteTop <= laserBottomBottom) ||
                   (spriteBottom >= laserBottomTop && spriteBottom <= laserBottomBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                    Application.Exit();                   
                }
                else if (((laserBottomLeft >= spriteLeft && laserBottomLeft <= spriteRight) ||
                        (laserBottomRight >= spriteLeft && laserBottomRight <= spriteRight)) &&
                        ((laserBottomTop >= spriteTop && laserBottomTop <= spriteBottom) ||
                        (laserBottomBottom >= spriteTop && laserBottomBottom <= spriteBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                    Application.Exit();
                }
            }
            if (((spriteLeft >= topWallLeft && spriteLeft <= topWallRight) ||
                (spriteRight >= topWallLeft && spriteRight <= topWallRight)) &&
                ((spriteTop >= topWallTop && spriteTop <= topWallBottom) ||
                (spriteBottom >= topWallTop && spriteBottom <= topWallBottom)))
            {
                spriteDirection = STOPPED;
            }
            else if (((topWallLeft >= spriteLeft && topWallLeft <= spriteRight) ||
                    (topWallRight >= spriteLeft && topWallRight <= spriteRight)) &&
                    ((topWallTop >= spriteTop && topWallTop <= spriteBottom) ||
                    (topWallBottom >= spriteTop && topWallBottom <= spriteBottom)))
            {
                spriteDirection = STOPPED;
            }

            if (((spriteLeft >= bottomWallLeft && spriteLeft <= bottomWallRight) ||
            (spriteRight >= bottomWallLeft && spriteRight <= bottomWallRight)) &&
            ((spriteTop >= bottomWallTop && spriteTop <= bottomWallBottom) ||
            (spriteBottom >= bottomWallTop && spriteBottom <= bottomWallBottom)))
            {
                spriteDirection = STOPPED;
            }
            else if (((bottomWallLeft >= spriteLeft && bottomWallLeft <= spriteRight) ||
                    (bottomWallRight >= spriteLeft && bottomWallRight <= spriteRight)) &&
                    ((bottomWallTop >= spriteTop && bottomWallTop <= spriteBottom) ||
                    (bottomWallBottom >= spriteTop && bottomWallBottom <= spriteBottom)))
            {
                spriteDirection = STOPPED;
            }

            if (((spriteLeft >= leftWallLeft && spriteLeft <= leftWallRight) ||
                (spriteRight >= leftWallLeft && spriteRight <= leftWallRight)) &&
                ((spriteTop >= leftWallTop && spriteTop <= leftWallBottom) ||
                (spriteBottom >= leftWallTop && spriteBottom <= leftWallBottom)))
            {
                spriteDirection = STOPPED;
            }
            else if (((leftWallLeft >= spriteLeft && leftWallLeft <= spriteRight) ||
                    (leftWallRight >= spriteLeft && leftWallRight <= spriteRight)) &&
                    ((leftWallTop >= spriteTop && leftWallTop <= spriteBottom) ||
                    (leftWallBottom >= spriteTop && leftWallBottom <= spriteBottom)))
            {
                spriteDirection = STOPPED;
            }

            if (((spriteLeft >= rightWallLeft && spriteLeft <= rightWallRight) ||
                (spriteRight >= rightWallLeft && spriteRight <= rightWallRight)) &&
                ((spriteTop >= rightWallTop && spriteTop <= rightWallBottom) ||
                (spriteBottom >= rightWallTop && spriteBottom <= rightWallBottom)))
            {
                spriteDirection = STOPPED;
            }            

            if (picLaserTopOver.Visible == true)
            {
                if (((spriteLeft >= laserTopLeft && spriteLeft <= laserTopRight) ||
                   (spriteRight >= laserTopLeft && spriteRight <= laserTopRight)) &&
                   ((spriteTop >= laserTopTop && spriteTop <= laserTopBottom) ||
                   (spriteBottom >= laserTopTop && spriteBottom <= laserTopBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                    Application.Exit();                   
                }
                else if (((laserTopLeft >= spriteLeft && laserTopLeft <= spriteRight) ||
                        (laserTopRight >= spriteLeft && laserTopRight <= spriteRight)) &&
                        ((laserTopTop >= spriteTop && laserTopTop <= spriteBottom) ||
                        (laserTopBottom >= spriteTop && laserTopBottom <= spriteBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over." + " You lasted " + gameTime + " seconds" );
                    Application.Exit();
                }
            }
        }
        private void redrawTheScreen()
        {
            picSprite.Left = spriteLeft;
            picSprite.Top = spriteTop;            
        }
        
        private new void Move()
        {
            if (up) y -= bulletMove;
            else y += bulletMove;
            if (right) x += bulletMove;
            else x -= bulletMove;
            if (dRight)
            {
                x3 += 20;
                y3 += 20;
            } 
            else
            {
                x3 -= 20;
                y3 -= 20;
            }
        }

        private void DMove()
        {
            if (dRight)
            {
                x3 += 1;
                y3 += 1;
                x4 -= 1;
                y4 += 1;
            }        
            else
            {
                x3 -= 1;
                y3 -= 1;
                x4 += 1;
                y4 -= 1;
            }

        }
        

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            Random randomX = new Random();
            surface.Clear(Color.Black);
            {
                for (int z = 0; z < 8; z++)
                {
                    surface.DrawEllipse(pen, x, y2, 23, 23);
                    getSpriteCoordinates();
                    collisionDetection();
                    y2 += 60;
                }
                for (int u = 0; u < 11; u++)
                {
                    x2 += 60;
                    surface.DrawEllipse(pen, x2, y, 23, 23);
                    getSpriteCoordinates();
                    collisionDetection();
                }
                if (nextPhase)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        DMove();
                        surface.DrawEllipse(pen2, x3, y3, 50, 50);
                        getSpriteCoordinates();
                        collisionDetection();
                    }
                    for (int i = 0; i < 60; i++)
                    {
                        DMove();
                        surface.DrawEllipse(pen2, x4, y4, 50, 50);
                        getSpriteCoordinates();
                        collisionDetection();
                    }
                }
                Move();
            }
            x2 = 0;
            y2 = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrBullet1Move.Enabled = true;
            tmrRun.Enabled = true;
            tmrSwitchDirection.Enabled = true;
            tmrPhaseUp.Enabled = true;
            tmrLasers.Enabled = true;
            tmrGameTime.Enabled = true;
            tmrSwitchCommet.Enabled = true;
            tmrCommet.Enabled = true;
            tmrSwitchXDirection.Enabled = true;
            btnStart.Visible = false;                       
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape) { this.Close(); }
            else if (e.KeyCode == Keys.S) { spriteDirection = MOVE_DOWN; }
            else if (e.KeyCode == Keys.W) { spriteDirection = MOVE_UP; }
            else if (e.KeyCode == Keys.A) { spriteDirection = MOVE_LEFT; }
            else if (e.KeyCode == Keys.D) { spriteDirection = MOVE_RIGHT; }


        }       
        private void tmrSwitchDirection_Tick(object sender, EventArgs e)
        {
            if (up) up = false;
            else up = true;
        }

        private void tmrLasers_Tick(object sender, EventArgs e)
        {
            picLaserBottomUnder.Visible = true;
            picLaserTopUnder.Visible = true;
            tmrActivateLaser.Enabled = true;
            tmrLasers.Enabled = false;
        }

        private void tmrActivateLaser_Tick(object sender, EventArgs e)
        {
            picLaserTopOver.Visible = true;
            picLaserBottomOver.Visible = true;
            picLaserBottomUnder.Visible = false;
            picLaserTopUnder.Visible = false;
            tmrLasersOn.Enabled = true;
        }

        private void tmrLasersOn_Tick(object sender, EventArgs e)
        {  
            tmrLasers.Enabled = true;
            tmrLasersOn.Enabled = false;
            tmrActivateLaser.Enabled = false;
            tmrLasers.Enabled = true;
            picLaserTopOver.Visible = false;
            picLaserBottomOver.Visible = false;
        }

        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            gameTime++;
            lblGameTime.Text = gameTime + "";
        }

        private void tmrSwitchXDirection_Tick(object sender, EventArgs e)
        {
            if (right) right = false;
            else right = true;
        }

        private void tmrCommet_Tick(object sender, EventArgs e)
        {
            Random randomX = new Random();
            if (dRight)
            {
                x3 = randomX.Next(0, 200);
                y3 = x3;
                x4 = randomX.Next(700, 800);
                y4 = 0;
            }
            else
            {
                x3 = randomX.Next(500, 800);
                y3 = x3;
                x4 = randomX.Next(0, 200);
                y4 = 500;
            }
        }

        private void tmrSwitchCommet_Tick(object sender, EventArgs e)
        {
            if (dRight) dRight = false;
            else dRight = true;
        }

        private void tmrPhaseUp_Tick(object sender, EventArgs e)
        {
            nextPhase = true;
            bulletMove += 10;
            moveAmount += 1;
            x = 0;
            x2 = 0;
            x3 = 0;
            y = 0;
            y2 = 0;
            y3 = 0;
            right = true;
            up = false;
            tmrLasers.Interval = 9000;
            tmrSwitchDirection.Enabled = false;
            tmrSwitchDirection.Enabled = true;
            tmrSwitchXDirection.Enabled = false;
            tmrSwitchXDirection.Enabled = true;
        }
    }
}

