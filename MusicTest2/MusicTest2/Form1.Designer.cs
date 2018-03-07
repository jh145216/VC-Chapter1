namespace MusicTest2
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
            this.duelStateButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // duelStateButton
            // 
            this.duelStateButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.duelStateButton.Location = new System.Drawing.Point(57, 51);
            this.duelStateButton.Name = "duelStateButton";
            this.duelStateButton.Size = new System.Drawing.Size(207, 130);
            this.duelStateButton.TabIndex = 1;
            this.duelStateButton.Text = "Play";
            this.duelStateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duelStateButton.UseVisualStyleBackColor = true;
            this.duelStateButton.CheckedChanged += new System.EventHandler(this.duelStateButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 233);
            this.Controls.Add(this.duelStateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox duelStateButton;
    }
}

