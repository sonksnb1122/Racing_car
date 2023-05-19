namespace Racing
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.selectLv = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.hell = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectLv
            // 
            this.selectLv.AutoSize = true;
            this.selectLv.BackColor = System.Drawing.Color.Transparent;
            this.selectLv.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLv.Location = new System.Drawing.Point(78, 110);
            this.selectLv.Name = "selectLv";
            this.selectLv.Size = new System.Drawing.Size(257, 43);
            this.selectLv.TabIndex = 0;
            this.selectLv.Text = "Select Level";
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Transparent;
            this.easy.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(148, 206);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(115, 56);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click_1);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Transparent;
            this.hard.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(148, 284);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(115, 56);
            this.hard.TabIndex = 2;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // hell
            // 
            this.hell.BackColor = System.Drawing.Color.Transparent;
            this.hell.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hell.Location = new System.Drawing.Point(148, 363);
            this.hell.Name = "hell";
            this.hell.Size = new System.Drawing.Size(115, 56);
            this.hell.TabIndex = 3;
            this.hell.Text = "Hell";
            this.hell.UseVisualStyleBackColor = false;
            this.hell.Click += new System.EventHandler(this.hell_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.hell);
            this.panel1.Controls.Add(this.hard);
            this.panel1.Controls.Add(this.easy);
            this.panel1.Controls.Add(this.selectLv);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 629);
            this.panel1.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(425, 626);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = " Select Level";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectLv;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button hell;
        private System.Windows.Forms.Panel panel1;
    }
}