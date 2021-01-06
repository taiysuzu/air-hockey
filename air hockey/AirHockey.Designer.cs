
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.netBox2 = new System.Windows.Forms.PictureBox();
            this.netBox1 = new System.Windows.Forms.PictureBox();
            this.p1Striker = new System.Windows.Forms.PictureBox();
            this.p2Striker = new System.Windows.Forms.PictureBox();
            this.puck = new System.Windows.Forms.PictureBox();
            this.madeInPaint = new System.Windows.Forms.PictureBox();
            this.airHockeyTitle = new System.Windows.Forms.PictureBox();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.netBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Striker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Striker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeInPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airHockeyTitle)).BeginInit();
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
            // p1Striker
            // 
            this.p1Striker.BackColor = System.Drawing.Color.Transparent;
            this.p1Striker.BackgroundImage = global::air_hockey.Properties.Resources.blue;
            this.p1Striker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p1Striker.Location = new System.Drawing.Point(190, 60);
            this.p1Striker.Name = "p1Striker";
            this.p1Striker.Size = new System.Drawing.Size(60, 60);
            this.p1Striker.TabIndex = 3;
            this.p1Striker.TabStop = false;
            // 
            // p2Striker
            // 
            this.p2Striker.BackColor = System.Drawing.Color.Transparent;
            this.p2Striker.BackgroundImage = global::air_hockey.Properties.Resources.green;
            this.p2Striker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p2Striker.Location = new System.Drawing.Point(190, 580);
            this.p2Striker.Name = "p2Striker";
            this.p2Striker.Size = new System.Drawing.Size(60, 60);
            this.p2Striker.TabIndex = 4;
            this.p2Striker.TabStop = false;
            // 
            // puck
            // 
            this.puck.BackColor = System.Drawing.Color.Transparent;
            this.puck.BackgroundImage = global::air_hockey.Properties.Resources.puck;
            this.puck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.puck.Location = new System.Drawing.Point(190, 320);
            this.puck.Name = "puck";
            this.puck.Size = new System.Drawing.Size(60, 60);
            this.puck.TabIndex = 5;
            this.puck.TabStop = false;
            // 
            // madeInPaint
            // 
            this.madeInPaint.BackColor = System.Drawing.Color.Black;
            this.madeInPaint.BackgroundImage = global::air_hockey.Properties.Resources.madeinpaint;
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
            this.airHockeyTitle.Location = new System.Drawing.Point(34, 0);
            this.airHockeyTitle.Name = "airHockeyTitle";
            this.airHockeyTitle.Size = new System.Drawing.Size(100, 50);
            this.airHockeyTitle.TabIndex = 7;
            this.airHockeyTitle.TabStop = false;
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.Location = new System.Drawing.Point(306, 0);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(100, 50);
            this.p1ScoreLabel.TabIndex = 8;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.Location = new System.Drawing.Point(306, 650);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(100, 50);
            this.p2ScoreLabel.TabIndex = 9;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::air_hockey.Properties.Resources.air_hockey_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(440, 700);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.airHockeyTitle);
            this.Controls.Add(this.madeInPaint);
            this.Controls.Add(this.puck);
            this.Controls.Add(this.p2Striker);
            this.Controls.Add(this.p1Striker);
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
            ((System.ComponentModel.ISupportInitialize)(this.p1Striker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Striker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeInPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airHockeyTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox netBox2;
        private System.Windows.Forms.PictureBox netBox1;
        private System.Windows.Forms.PictureBox p1Striker;
        private System.Windows.Forms.PictureBox p2Striker;
        private System.Windows.Forms.PictureBox puck;
        private System.Windows.Forms.PictureBox madeInPaint;
        private System.Windows.Forms.PictureBox airHockeyTitle;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
    }
}

