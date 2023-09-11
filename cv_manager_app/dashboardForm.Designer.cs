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
            this.displayMessages = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cvButton = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.householdGroceries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayMessages
            // 
            this.displayMessages.AutoSize = true;
            this.displayMessages.Location = new System.Drawing.Point(393, 95);
            this.displayMessages.Name = "displayMessages";
            this.displayMessages.Size = new System.Drawing.Size(132, 16);
            this.displayMessages.TabIndex = 0;
            this.displayMessages.Text = "Messages and mails";
            this.displayMessages.Click += new System.EventHandler(this.displayMessages_Click);
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
            // cvButton
            // 
            this.cvButton.Location = new System.Drawing.Point(39, 51);
            this.cvButton.Name = "cvButton";
            this.cvButton.Size = new System.Drawing.Size(151, 46);
            this.cvButton.TabIndex = 3;
            this.cvButton.Text = "work on CV here";
            this.cvButton.UseVisualStyleBackColor = true;
            this.cvButton.Click += new System.EventHandler(this.cvButton_Click);
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
            this.groupBox1.Controls.Add(this.householdGroceries);
            this.groupBox1.Controls.Add(this.cvButton);
            this.groupBox1.Controls.Add(this.Messages);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 864);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // householdGroceries
            // 
            this.householdGroceries.Location = new System.Drawing.Point(39, 277);
            this.householdGroceries.Name = "householdGroceries";
            this.householdGroceries.Size = new System.Drawing.Size(150, 59);
            this.householdGroceries.TabIndex = 5;
            this.householdGroceries.Text = "Groceries!";
            this.householdGroceries.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Personal Dashboard";
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 871);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayMessages);
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cvButton;
        private System.Windows.Forms.Button Messages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button householdGroceries;
        private System.Windows.Forms.Label label1;
    }
}