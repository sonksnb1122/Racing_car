namespace Racing
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listViewScore = new System.Windows.Forms.ListView();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewScore
            // 
            this.listViewScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.PlayerName,
            this.Score,
            this.Time});
            this.listViewScore.FullRowSelect = true;
            this.listViewScore.GridLines = true;
            this.listViewScore.HideSelection = false;
            this.listViewScore.Location = new System.Drawing.Point(0, -1);
            this.listViewScore.Name = "listViewScore";
            this.listViewScore.Size = new System.Drawing.Size(424, 579);
            this.listViewScore.TabIndex = 0;
            this.listViewScore.UseCompatibleStateImageBehavior = false;
            this.listViewScore.View = System.Windows.Forms.View.Details;
            // 
            // N
            // 
            this.N.Text = "N";
            this.N.Width = 25;
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Player Name";
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerName.Width = 129;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score.Width = 65;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 119;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(68, 584);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(283, 44);
            this.back.TabIndex = 1;
            this.back.Text = "Back To Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 626);
            this.Controls.Add(this.back);
            this.Controls.Add(this.listViewScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = " Highest Score";
            this.ResumeLayout(false);

        }
        
        #endregion

        private System.Windows.Forms.ListView listViewScore;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button back;
    }
}