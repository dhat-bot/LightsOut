namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.lightbulbPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lightbulbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gameNameLabel.Location = new System.Drawing.Point(96, 19);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(219, 38);
            this.gameNameLabel.TabIndex = 0;
            this.gameNameLabel.Text = "Lights Out!";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorLabel.ForeColor = System.Drawing.Color.Green;
            this.creatorLabel.Location = new System.Drawing.Point(99, 75);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(109, 19);
            this.creatorLabel.TabIndex = 1;
            this.creatorLabel.Text = "By Daniel Hattemer";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.instructionsLabel.Location = new System.Drawing.Point(24, 112);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(318, 18);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Turn all the lights out (black) to win the game!";
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(133, 148);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // lightbulbPictureBox
            // 
            this.lightbulbPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightbulbPictureBox.Image")));
            this.lightbulbPictureBox.Location = new System.Drawing.Point(12, 19);
            this.lightbulbPictureBox.Name = "lightbulbPictureBox";
            this.lightbulbPictureBox.Size = new System.Drawing.Size(69, 72);
            this.lightbulbPictureBox.TabIndex = 4;
            this.lightbulbPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 184);
            this.Controls.Add(this.lightbulbPictureBox);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.gameNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.lightbulbPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.PictureBox lightbulbPictureBox;
    }
}