namespace cv_manager_app
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
            this.loginButton = new System.Windows.Forms.Button();
            this.GoToDashBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.Location = new System.Drawing.Point(373, 283);
            this.loginButton.Name = "loginButton";
            this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginButton.Size = new System.Drawing.Size(238, 68);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Dashboard";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // GoToDashBoard
            // 
            this.GoToDashBoard.AutoSize = true;
            this.GoToDashBoard.BackColor = System.Drawing.SystemColors.Control;
            this.GoToDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoToDashBoard.Location = new System.Drawing.Point(401, 368);
            this.GoToDashBoard.Name = "GoToDashBoard";
            this.GoToDashBoard.Size = new System.Drawing.Size(183, 18);
            this.GoToDashBoard.TabIndex = 1;
            this.GoToDashBoard.Text = "Click to go to your dashboard";
            this.GoToDashBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.GoToDashBoard);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label GoToDashBoard;
    }
}

