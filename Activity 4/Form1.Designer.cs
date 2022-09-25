namespace Activity_4
{
    partial class activity4
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.userInputSeconds = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.userTotal = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the number of seconds below\r\n\r\n";
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(31, 92);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(64, 25);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter:";
            // 
            // userInputSeconds
            // 
            this.userInputSeconds.Location = new System.Drawing.Point(101, 98);
            this.userInputSeconds.Name = "userInputSeconds";
            this.userInputSeconds.Size = new System.Drawing.Size(100, 20);
            this.userInputSeconds.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(31, 162);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 25);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // userTotal
            // 
            this.userTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userTotal.Location = new System.Drawing.Point(99, 162);
            this.userTotal.Name = "userTotal";
            this.userTotal.Size = new System.Drawing.Size(100, 23);
            this.userTotal.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.AutoSize = true;
            this.convertButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertButton.Location = new System.Drawing.Point(243, 91);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(74, 33);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // activity4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 215);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.userTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.userInputSeconds);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.label1);
            this.Name = "activity4";
            this.Text = "Activity 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox userInputSeconds;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label userTotal;
        private System.Windows.Forms.Button convertButton;
    }
}

