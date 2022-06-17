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
        int x;
        int x1 = 0;
        int x2 = 0;
        int y;
        int y2;
        bool up;
        bool right;
        Random random = new Random();
        const int STOPPED = 0;          // For when the game first starts
        const int MOVE_UP = 1;
        const int MOVE_DOWN = 2;
        const int MOVE_LEFT = 3;
        const int MOVE_RIGHT = 4;
        const int MOVE_AMOUNT = 2;      // How much a character moves in pixels
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
        int spriteTop;
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
        System.Drawing.Graphics surface;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue);
            surface = this.CreateGraphics();
            surface.Clear(Color.Black);
            right = true;
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
            if (spriteDirection == MOVE_UP) spriteTop = spriteTop - MOVE_AMOUNT;
            else if (spriteDirection == MOVE_DOWN) spriteTop = spriteTop + MOVE_AMOUNT;
            else if (spriteDirection == MOVE_LEFT) spriteLeft = spriteLeft - MOVE_AMOUNT;
            else if (spriteDirection == MOVE_RIGHT) spriteLeft = spriteLeft + MOVE_AMOUNT;

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
                MessageBox.Show("Game Over");
                Application.Exit();
            }
            else if (((bulletLeft >= spriteLeft && bulletLeft <= spriteRight) ||
                    (bulletRight >= spriteLeft && bulletRight <= spriteRight)) &&
                    ((bulletTop >= spriteTop && bulletTop <= spriteBottom) ||
                    (bulletBottom >= spriteTop && bulletBottom <= spriteBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over");
                Application.Exit();
            }
            if (((spriteLeft >= bullet2Left && spriteLeft <= bullet2Right) ||
                (spriteRight >= bullet2Left && spriteRight <= bullet2Right)) &&
                ((spriteTop >= bullet2Top && spriteTop <= bullet2Bottom) ||
                (spriteBottom >= bullet2Top && spriteBottom <= bullet2Bottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over");
                Application.Exit();
            }
            else if (((bullet2Left >= spriteLeft && bullet2Left <= spriteRight) ||
                    (bullet2Right >= spriteLeft && bullet2Right <= spriteRight)) &&
                    ((bullet2Top >= spriteTop && bullet2Top <= spriteBottom) ||
                    (bullet2Bottom >= spriteTop && bullet2Bottom <= spriteBottom)))
            {
                tmrBullet1Move.Enabled = false;
                MessageBox.Show("Game Over");
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
                    MessageBox.Show("Game Over");
                    Application.Exit();                   
                }
                else if (((laserBottomLeft >= spriteLeft && laserBottomLeft <= spriteRight) ||
                        (laserBottomRight >= spriteLeft && laserBottomRight <= spriteRight)) &&
                        ((laserBottomTop >= spriteTop && laserBottomTop <= spriteBottom) ||
                        (laserBottomBottom >= spriteTop && laserBottomBottom <= spriteBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over");
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
                    MessageBox.Show("Game Over");
                    Application.Exit();                   
                }
                else if (((laserTopLeft >= spriteLeft && laserTopLeft <= spriteRight) ||
                        (laserTopRight >= spriteLeft && laserTopRight <= spriteRight)) &&
                        ((laserTopTop >= spriteTop && laserTopTop <= spriteBottom) ||
                        (laserTopBottom >= spriteTop && laserTopBottom <= spriteBottom)))
                {
                    tmrBullet1Move.Enabled = false;
                    MessageBox.Show("Game Over");
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
            if (up) y -= 10;
            else y += 10;
            if (right) x += 10;
            else x -= 10;
            
        }
        private void tmrMove_Tick(object sender, EventArgs e)
        {
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
                Move();
            }
            x2 = 0;
            y2 = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
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
    }
}

