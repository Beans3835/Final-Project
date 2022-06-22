namespace Final_Project_Testing_2
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
            this.tmrRun = new System.Windows.Forms.Timer(this.components);
            this.tmrBullet1Move = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSwitchDirection = new System.Windows.Forms.Timer(this.components);
            this.tmrPhaseUp = new System.Windows.Forms.Timer(this.components);
            this.picLaserTopUnder = new System.Windows.Forms.PictureBox();
            this.picLaserBottomOver = new System.Windows.Forms.PictureBox();
            this.picLaserTopOver = new System.Windows.Forms.PictureBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picLaserBottomUnder = new System.Windows.Forms.PictureBox();
            this.tmrLasers = new System.Windows.Forms.Timer(this.components);
            this.tmrActivateLaser = new System.Windows.Forms.Timer(this.components);
            this.tmrLasersOn = new System.Windows.Forms.Timer(this.components);
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblGameTime = new System.Windows.Forms.Label();
            this.tmrSwitchXDirection = new System.Windows.Forms.Timer(this.components);
            this.picLeftWall = new System.Windows.Forms.PictureBox();
            this.picRightWall = new System.Windows.Forms.PictureBox();
            this.picTopWall = new System.Windows.Forms.PictureBox();
            this.picBottomWall = new System.Windows.Forms.PictureBox();
            this.tmrSwitchCommet = new System.Windows.Forms.Timer(this.components);
            this.tmrCommet = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLaserTopUnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserBottomOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserTopOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserBottomUnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomWall)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRun
            // 
            this.tmrRun.Interval = 10;
            this.tmrRun.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrBullet1Move
            // 
            this.tmrBullet1Move.Interval = 60;
            this.tmrBullet1Move.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.ForeColor = System.Drawing.Color.Teal;
            this.btnStart.Location = new System.Drawing.Point(319, 174);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSwitchDirection
            // 
            this.tmrSwitchDirection.Interval = 3400;
            this.tmrSwitchDirection.Tick += new System.EventHandler(this.tmrSwitchDirection_Tick);
            // 
            // tmrPhaseUp
            // 
            this.tmrPhaseUp.Interval = 10000;
            this.tmrPhaseUp.Tick += new System.EventHandler(this.tmrPhaseUp_Tick);
            // 
            // picLaserTopUnder
            // 
            this.picLaserTopUnder.Image = global::Final_Project_Testing_2.Properties.Resources.short_laser_real__2_;
            this.picLaserTopUnder.Location = new System.Drawing.Point(-2, 76);
            this.picLaserTopUnder.Name = "picLaserTopUnder";
            this.picLaserTopUnder.Size = new System.Drawing.Size(823, 78);
            this.picLaserTopUnder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLaserTopUnder.TabIndex = 6;
            this.picLaserTopUnder.TabStop = false;
            this.picLaserTopUnder.Visible = false;
            // 
            // picLaserBottomOver
            // 
            this.picLaserBottomOver.Image = global::Final_Project_Testing_2.Properties.Resources.short_laser_real;
            this.picLaserBottomOver.Location = new System.Drawing.Point(-2, 276);
            this.picLaserBottomOver.Name = "picLaserBottomOver";
            this.picLaserBottomOver.Size = new System.Drawing.Size(823, 78);
            this.picLaserBottomOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLaserBottomOver.TabIndex = 5;
            this.picLaserBottomOver.TabStop = false;
            this.picLaserBottomOver.Visible = false;
            // 
            // picLaserTopOver
            // 
            this.picLaserTopOver.Image = global::Final_Project_Testing_2.Properties.Resources.short_laser_real;
            this.picLaserTopOver.Location = new System.Drawing.Point(-2, 76);
            this.picLaserTopOver.Name = "picLaserTopOver";
            this.picLaserTopOver.Size = new System.Drawing.Size(823, 78);
            this.picLaserTopOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLaserTopOver.TabIndex = 4;
            this.picLaserTopOver.TabStop = false;
            this.picLaserTopOver.Visible = false;
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.Lime;
            this.picSprite.Location = new System.Drawing.Point(348, 225);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(12, 12);
            this.picSprite.TabIndex = 1;
            this.picSprite.TabStop = false;
            // 
            // picLaserBottomUnder
            // 
            this.picLaserBottomUnder.Image = global::Final_Project_Testing_2.Properties.Resources.short_laser_real__2_;
            this.picLaserBottomUnder.Location = new System.Drawing.Point(-13, 276);
            this.picLaserBottomUnder.Name = "picLaserBottomUnder";
            this.picLaserBottomUnder.Size = new System.Drawing.Size(823, 78);
            this.picLaserBottomUnder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLaserBottomUnder.TabIndex = 7;
            this.picLaserBottomUnder.TabStop = false;
            this.picLaserBottomUnder.Visible = false;
            // 
            // tmrLasers
            // 
            this.tmrLasers.Interval = 6000;
            this.tmrLasers.Tick += new System.EventHandler(this.tmrLasers_Tick);
            // 
            // tmrActivateLaser
            // 
            this.tmrActivateLaser.Interval = 2000;
            this.tmrActivateLaser.Tick += new System.EventHandler(this.tmrActivateLaser_Tick);
            // 
            // tmrLasersOn
            // 
            this.tmrLasersOn.Interval = 2000;
            this.tmrLasersOn.Tick += new System.EventHandler(this.tmrLasersOn_Tick);
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblGameTime.ForeColor = System.Drawing.Color.Black;
            this.lblGameTime.Location = new System.Drawing.Point(27, 9);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(0, 13);
            this.lblGameTime.TabIndex = 8;
            // 
            // tmrSwitchXDirection
            // 
            this.tmrSwitchXDirection.Interval = 5400;
            this.tmrSwitchXDirection.Tick += new System.EventHandler(this.tmrSwitchXDirection_Tick);
            // 
            // picLeftWall
            // 
            this.picLeftWall.Location = new System.Drawing.Point(-2, -2);
            this.picLeftWall.Name = "picLeftWall";
            this.picLeftWall.Size = new System.Drawing.Size(13, 459);
            this.picLeftWall.TabIndex = 9;
            this.picLeftWall.TabStop = false;
            // 
            // picRightWall
            // 
            this.picRightWall.Location = new System.Drawing.Point(724, -2);
            this.picRightWall.Name = "picRightWall";
            this.picRightWall.Size = new System.Drawing.Size(13, 459);
            this.picRightWall.TabIndex = 10;
            this.picRightWall.TabStop = false;
            // 
            // picTopWall
            // 
            this.picTopWall.Location = new System.Drawing.Point(-2, -4);
            this.picTopWall.Name = "picTopWall";
            this.picTopWall.Size = new System.Drawing.Size(739, 10);
            this.picTopWall.TabIndex = 11;
            this.picTopWall.TabStop = false;
            // 
            // picBottomWall
            // 
            this.picBottomWall.Location = new System.Drawing.Point(-2, 447);
            this.picBottomWall.Name = "picBottomWall";
            this.picBottomWall.Size = new System.Drawing.Size(739, 10);
            this.picBottomWall.TabIndex = 12;
            this.picBottomWall.TabStop = false;
            // 
            // tmrSwitchCommet
            // 
            this.tmrSwitchCommet.Interval = 3000;
            this.tmrSwitchCommet.Tick += new System.EventHandler(this.tmrSwitchCommet_Tick);
            // 
            // tmrCommet
            // 
            this.tmrCommet.Interval = 1000;
            this.tmrCommet.Tick += new System.EventHandler(this.tmrCommet_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.picSprite);
            this.Controls.Add(this.picLaserBottomUnder);
            this.Controls.Add(this.picLaserTopUnder);
            this.Controls.Add(this.picBottomWall);
            this.Controls.Add(this.picTopWall);
            this.Controls.Add(this.picRightWall);
            this.Controls.Add(this.picLeftWall);
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.picLaserBottomOver);
            this.Controls.Add(this.picLaserTopOver);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Bullet Hell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLaserTopUnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserBottomOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserTopOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaserBottomUnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrBullet1Move;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.Timer tmrRun;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSwitchDirection;
        private System.Windows.Forms.Timer tmrPhaseUp;
        private System.Windows.Forms.PictureBox picLaserTopOver;
        private System.Windows.Forms.PictureBox picLaserBottomOver;
        private System.Windows.Forms.PictureBox picLaserTopUnder;
        private System.Windows.Forms.PictureBox picLaserBottomUnder;
        private System.Windows.Forms.Timer tmrLasers;
        private System.Windows.Forms.Timer tmrActivateLaser;
        private System.Windows.Forms.Timer tmrLasersOn;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Timer tmrSwitchXDirection;
        private System.Windows.Forms.PictureBox picLeftWall;
        private System.Windows.Forms.PictureBox picRightWall;
        private System.Windows.Forms.PictureBox picTopWall;
        private System.Windows.Forms.PictureBox picBottomWall;
        private System.Windows.Forms.Timer tmrSwitchCommet;
        private System.Windows.Forms.Timer tmrCommet;
    }
}

