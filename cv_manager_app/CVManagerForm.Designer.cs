namespace cv_manager_app
{
    partial class CVManagerForm
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
            this.modifyresume = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyresume
            // 
            this.modifyresume.Location = new System.Drawing.Point(137, 94);
            this.modifyresume.Name = "modifyresume";
            this.modifyresume.Size = new System.Drawing.Size(162, 53);
            this.modifyresume.TabIndex = 0;
            this.modifyresume.Text = "Add to Resume";
            this.modifyresume.UseVisualStyleBackColor = true;
            this.modifyresume.Click += new System.EventHandler(this.modifyResume_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CVManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 836);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modifyresume);
            this.Name = "CVManagerForm";
            this.Text = "CVManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modifyresume;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}