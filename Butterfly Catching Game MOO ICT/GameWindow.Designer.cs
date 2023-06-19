namespace Butterfly_Catching_Game_MOO_ICT
{
    partial class GameWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCaught = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-56, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(12, 497);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time Left: 00";
            // 
            // lblCaught
            // 
            this.lblCaught.AutoSize = true;
            this.lblCaught.BackColor = System.Drawing.Color.White;
            this.lblCaught.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaught.Location = new System.Drawing.Point(686, 497);
            this.lblCaught.Name = "lblCaught";
            this.lblCaught.Size = new System.Drawing.Size(97, 25);
            this.lblCaught.TabIndex = 2;
            this.lblCaught.Text = "Caught: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Butterfly_Catching_Game_MOO_ICT.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 531);
            this.Controls.Add(this.lblCaught);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "GameWindow";
            this.Text = "Game Window: Butterfly Catching Game MOO ICT";
            this.Click += new System.EventHandler(this.FormClickEvent);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTime;
        private Label lblCaught;
        private System.Windows.Forms.Timer GameTimer;
    }
}