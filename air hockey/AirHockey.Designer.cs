
namespace air_hockey
{
    partial class AirHockey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirHockey));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.netBox2 = new System.Windows.Forms.PictureBox();
            this.netBox1 = new System.Windows.Forms.PictureBox();
            this.madeInPaint = new System.Windows.Forms.PictureBox();
            this.airHockeyTitle = new System.Windows.Forms.PictureBox();
            this.player1Image = new System.Windows.Forms.PictureBox();
            this.puckImage = new System.Windows.Forms.PictureBox();
            this.player2Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.netBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeInPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airHockeyTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // netBox2
            // 
            this.netBox2.BackgroundImage = global::air_hockey.Properties.Resources.net2;
            this.netBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.netBox2.Location = new System.Drawing.Point(140, 650);
            this.netBox2.Name = "netBox2";
            this.netBox2.Size = new System.Drawing.Size(160, 50);
            this.netBox2.TabIndex = 1;
            this.netBox2.TabStop = false;
            // 
            // netBox1
            // 
            this.netBox1.BackgroundImage = global::air_hockey.Properties.Resources.net;
            this.netBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.netBox1.Location = new System.Drawing.Point(140, 0);
            this.netBox1.Name = "netBox1";
            this.netBox1.Size = new System.Drawing.Size(160, 50);
            this.netBox1.TabIndex = 2;
            this.netBox1.TabStop = false;
            // 
            // madeInPaint
            // 
            this.madeInPaint.BackColor = System.Drawing.Color.Black;
            this.madeInPaint.BackgroundImage = global::air_hockey.Properties.Resources.madeinpaint;
            this.madeInPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.madeInPaint.Location = new System.Drawing.Point(34, 650);
            this.madeInPaint.Name = "madeInPaint";
            this.madeInPaint.Size = new System.Drawing.Size(100, 50);
            this.madeInPaint.TabIndex = 6;
            this.madeInPaint.TabStop = false;
            // 
            // airHockeyTitle
            // 
            this.airHockeyTitle.BackColor = System.Drawing.Color.Black;
            this.airHockeyTitle.BackgroundImage = global::air_hockey.Properties.Resources.airhockey;
            this.airHockeyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airHockeyTitle.Location = new System.Drawing.Point(34, 0);
            this.airHockeyTitle.Name = "airHockeyTitle";
            this.airHockeyTitle.Size = new System.Drawing.Size(100, 50);
            this.airHockeyTitle.TabIndex = 7;
            this.airHockeyTitle.TabStop = false;
            // 
            // player1Image
            // 
            this.player1Image.BackColor = System.Drawing.Color.Transparent;
            this.player1Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1Image.BackgroundImage")));
            this.player1Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1Image.Location = new System.Drawing.Point(185, 60);
            this.player1Image.Name = "player1Image";
            this.player1Image.Size = new System.Drawing.Size(70, 70);
            this.player1Image.TabIndex = 8;
            this.player1Image.TabStop = false;
            // 
            // puckImage
            // 
            this.puckImage.BackColor = System.Drawing.Color.Transparent;
            this.puckImage.BackgroundImage = global::air_hockey.Properties.Resources.puck;
            this.puckImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.puckImage.Location = new System.Drawing.Point(195, 325);
            this.puckImage.Name = "puckImage";
            this.puckImage.Size = new System.Drawing.Size(50, 50);
            this.puckImage.TabIndex = 9;
            this.puckImage.TabStop = false;
            // 
            // player2Image
            // 
            this.player2Image.BackColor = System.Drawing.Color.Transparent;
            this.player2Image.BackgroundImage = global::air_hockey.Properties.Resources.green;
            this.player2Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player2Image.Location = new System.Drawing.Point(185, 570);
            this.player2Image.Name = "player2Image";
            this.player2Image.Size = new System.Drawing.Size(70, 70);
            this.player2Image.TabIndex = 10;
            this.player2Image.TabStop = false;
            // 
            // AirHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::air_hockey.Properties.Resources.air_hockey_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(440, 700);
            this.Controls.Add(this.player2Image);
            this.Controls.Add(this.puckImage);
            this.Controls.Add(this.player1Image);
            this.Controls.Add(this.airHockeyTitle);
            this.Controls.Add(this.madeInPaint);
            this.Controls.Add(this.netBox1);
            this.Controls.Add(this.netBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AirHockey";
            this.Text = "Air Hockey";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AirHockey_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AirHockey_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AirHockey_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.netBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeInPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airHockeyTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox netBox2;
        private System.Windows.Forms.PictureBox netBox1;
        private System.Windows.Forms.PictureBox madeInPaint;
        private System.Windows.Forms.PictureBox airHockeyTitle;
        private System.Windows.Forms.PictureBox player1Image;
        private System.Windows.Forms.PictureBox puckImage;
        private System.Windows.Forms.PictureBox player2Image;
    }
}

