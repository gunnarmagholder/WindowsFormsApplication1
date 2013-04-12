namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(264, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 73);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kill Me";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(82, 58);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "text der frage";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAnswer.Location = new System.Drawing.Point(85, 105);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(225, 20);
            this.tbAnswer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 455);
            this.ControlBox = false;
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictator";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
    }
}

