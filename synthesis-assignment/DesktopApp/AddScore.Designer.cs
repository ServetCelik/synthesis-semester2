namespace DesktopApp
{
    partial class AddScore
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
            this.tbP1Score = new System.Windows.Forms.TextBox();
            this.tbP2Score = new System.Windows.Forms.TextBox();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnConfirmScore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbP1Score
            // 
            this.tbP1Score.Location = new System.Drawing.Point(169, 125);
            this.tbP1Score.Name = "tbP1Score";
            this.tbP1Score.Size = new System.Drawing.Size(194, 27);
            this.tbP1Score.TabIndex = 0;
            // 
            // tbP2Score
            // 
            this.tbP2Score.Location = new System.Drawing.Point(169, 183);
            this.tbP2Score.Name = "tbP2Score";
            this.tbP2Score.Size = new System.Drawing.Size(194, 27);
            this.tbP2Score.TabIndex = 1;
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Location = new System.Drawing.Point(1, 128);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(50, 20);
            this.lblP1Score.TabIndex = 2;
            this.lblP1Score.Text = "label1";
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Location = new System.Drawing.Point(1, 186);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(50, 20);
            this.lblP2Score.TabIndex = 3;
            this.lblP2Score.Text = "label2";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(160, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(212, 45);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Enter Scores";
            // 
            // btnConfirmScore
            // 
            this.btnConfirmScore.Location = new System.Drawing.Point(213, 279);
            this.btnConfirmScore.Name = "btnConfirmScore";
            this.btnConfirmScore.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmScore.TabIndex = 5;
            this.btnConfirmScore.Text = "Submit";
            this.btnConfirmScore.UseVisualStyleBackColor = true;
            this.btnConfirmScore.Click += new System.EventHandler(this.btnConfirmScore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(213, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirmScore);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.tbP2Score);
            this.Controls.Add(this.tbP1Score);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddScore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbP1Score;
        private TextBox tbP2Score;
        private Label lblP1Score;
        private Label lblP2Score;
        private Label lblHeading;
        private Button btnConfirmScore;
        private Button btnClose;
    }
}