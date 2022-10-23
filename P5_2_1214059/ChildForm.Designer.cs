namespace P5_2_1214059
{
    partial class ChildForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DispayButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputLabel.Location = new System.Drawing.Point(0, 16);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(292, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(37, 88);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DispayButton
            // 
            this.DispayButton.Location = new System.Drawing.Point(181, 88);
            this.DispayButton.Name = "DispayButton";
            this.DispayButton.Size = new System.Drawing.Size(75, 23);
            this.DispayButton.TabIndex = 2;
            this.DispayButton.Text = "&Display";
            this.DispayButton.UseVisualStyleBackColor = true;
            this.DispayButton.Click += new System.EventHandler(this.DispayButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(46, 152);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputGroupBox.TabIndex = 3;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output";
            // 
            // TimeOption
            // 
            this.TimeOption.Location = new System.Drawing.Point(16, 53);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Dispay Current &Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // DateOption
            // 
            this.DateOption.Location = new System.Drawing.Point(16, 27);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(168, 24);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Dispay Current D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.CheckedChanged += new System.EventHandler(this.DateOption_CheckedChanged);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 280);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.DispayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DispayButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
    }
}