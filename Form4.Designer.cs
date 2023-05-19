namespace Racing
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.cirload = new CircularProgressBar.CircularProgressBar();
            this.ready = new System.Windows.Forms.Label();
            this.timercir = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.cirload);
            this.panel1.Controls.Add(this.ready);
            this.panel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 625);
            this.panel1.TabIndex = 0;
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.send.Location = new System.Drawing.Point(221, 31);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(0, 51);
            this.send.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(21, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(194, 51);
            this.label.TabIndex = 5;
            this.label.Text = "Loading";
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.Cyan;
            this.progress.Location = new System.Drawing.Point(166, 396);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(66, 39);
            this.progress.TabIndex = 4;
            this.progress.Text = "0%";
            // 
            // cirload
            // 
            this.cirload.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cirload.AnimationFunction")));
            this.cirload.AnimationSpeed = 10;
            this.cirload.BackColor = System.Drawing.Color.Black;
            this.cirload.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cirload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirload.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirload.InnerMargin = 2;
            this.cirload.InnerWidth = -1;
            this.cirload.Location = new System.Drawing.Point(110, 310);
            this.cirload.MarqueeAnimationSpeed = 10;
            this.cirload.Name = "cirload";
            this.cirload.OuterColor = System.Drawing.Color.NavajoWhite;
            this.cirload.OuterMargin = -25;
            this.cirload.OuterWidth = 26;
            this.cirload.ProgressColor = System.Drawing.Color.Cyan;
            this.cirload.ProgressWidth = 15;
            this.cirload.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cirload.Size = new System.Drawing.Size(211, 215);
            this.cirload.StartAngle = 270;
            this.cirload.Step = 100;
            this.cirload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cirload.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cirload.SubscriptText = "";
            this.cirload.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cirload.SuperscriptText = "";
            this.cirload.TabIndex = 3;
            this.cirload.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cirload.Value = 50;
            // 
            // ready
            // 
            this.ready.AutoSize = true;
            this.ready.BackColor = System.Drawing.Color.Transparent;
            this.ready.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready.ForeColor = System.Drawing.Color.Red;
            this.ready.Location = new System.Drawing.Point(276, 114);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(157, 51);
            this.ready.TabIndex = 0;
            this.ready.Text = "Ready";
            // 
            // timercir
            // 
            this.timercir.Enabled = true;
            this.timercir.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 621);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = " Loading";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ready;
        private CircularProgressBar.CircularProgressBar cirload;
        private System.Windows.Forms.Timer timercir;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label send;
    }
}