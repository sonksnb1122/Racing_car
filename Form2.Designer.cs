namespace Racing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.startgame = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highestscore = new System.Windows.Forms.Button();
            this.guide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startgame
            // 
            this.startgame.BackColor = System.Drawing.Color.Transparent;
            this.startgame.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgame.ForeColor = System.Drawing.Color.Red;
            this.startgame.Location = new System.Drawing.Point(81, 129);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(277, 53);
            this.startgame.TabIndex = 0;
            this.startgame.Text = "Start Game";
            this.startgame.UseVisualStyleBackColor = false;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(81, 507);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(277, 51);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guide);
            this.panel1.Controls.Add(this.highestscore);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.startgame);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 625);
            this.panel1.TabIndex = 2;
            // 
            // highestscore
            // 
            this.highestscore.BackColor = System.Drawing.Color.Transparent;
            this.highestscore.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestscore.ForeColor = System.Drawing.Color.Orange;
            this.highestscore.Location = new System.Drawing.Point(81, 246);
            this.highestscore.Name = "highestscore";
            this.highestscore.Size = new System.Drawing.Size(277, 53);
            this.highestscore.TabIndex = 2;
            this.highestscore.Text = "Higest Score";
            this.highestscore.UseVisualStyleBackColor = false;
            this.highestscore.Click += new System.EventHandler(this.highestscore_Click);
            // 
            // guide
            // 
            this.guide.BackColor = System.Drawing.Color.Transparent;
            this.guide.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guide.ForeColor = System.Drawing.Color.Lime;
            this.guide.Location = new System.Drawing.Point(81, 375);
            this.guide.Name = "guide";
            this.guide.Size = new System.Drawing.Size(277, 54);
            this.guide.TabIndex = 3;
            this.guide.Text = "Guide";
            this.guide.UseVisualStyleBackColor = false;
            this.guide.Click += new System.EventHandler(this.guide_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 621);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = " Racing";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button highestscore;
        private System.Windows.Forms.Button guide;
    }
}