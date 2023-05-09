namespace BrickBreaker
{
    partial class HighScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.returnButton = new System.Windows.Forms.Button();
            this.highScoreLabelk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(532, 464);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // highScoreLabelk
            // 
            this.highScoreLabelk.AutoSize = true;
            this.highScoreLabelk.ForeColor = System.Drawing.Color.Coral;
            this.highScoreLabelk.Location = new System.Drawing.Point(343, 142);
            this.highScoreLabelk.Name = "highScoreLabelk";
            this.highScoreLabelk.Size = new System.Drawing.Size(10, 13);
            this.highScoreLabelk.TabIndex = 1;
            this.highScoreLabelk.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highScoreLabel.ForeColor = System.Drawing.Color.Coral;
            this.highScoreLabel.Location = new System.Drawing.Point(402, 58);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(428, 285);
            this.highScoreLabel.TabIndex = 3;
            this.highScoreLabel.Text = " ";
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highScoreLabelk);
            this.Controls.Add(this.returnButton);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(1386, 788);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label highScoreLabelk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highScoreLabel;
    }
}
