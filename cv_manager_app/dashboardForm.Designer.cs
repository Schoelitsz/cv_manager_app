namespace cv_manager_app
{
    partial class dashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SectionButton = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "last 3 messages";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1097, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "analytics";
            // 
            // SectionButton
            // 
            this.SectionButton.Location = new System.Drawing.Point(39, 51);
            this.SectionButton.Name = "SectionButton";
            this.SectionButton.Size = new System.Drawing.Size(151, 46);
            this.SectionButton.TabIndex = 3;
            this.SectionButton.Text = "Work on Sections Here";
            this.SectionButton.UseVisualStyleBackColor = true;
            this.SectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(39, 165);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(150, 55);
            this.Messages.TabIndex = 4;
            this.Messages.Text = "Check messages";
            this.Messages.UseVisualStyleBackColor = true;
            this.Messages.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.SectionButton);
            this.groupBox1.Controls.Add(this.Messages);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 864);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 871);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SectionButton;
        private System.Windows.Forms.Button Messages;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}