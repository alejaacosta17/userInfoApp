namespace userInfoApp
{
    partial class OutPutListBox
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(66, 63);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(135, 60);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // AddUserButton
            // 
            this.AddUserButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddUserButton.Location = new System.Drawing.Point(69, 167);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(83, 46);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(135, 86);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(126, 20);
            this.UserIdTextBox.TabIndex = 4;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(66, 89);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(46, 13);
            this.UserIdLabel.TabIndex = 3;
            this.UserIdLabel.Text = "User ID:";
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(135, 112);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(126, 20);
            this.UserAgeTextBox.TabIndex = 6;
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.Location = new System.Drawing.Point(66, 115);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(54, 13);
            this.UserAgeLabel.TabIndex = 5;
            this.UserAgeLabel.Text = "User Age:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(135, 323);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(289, 47);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status Displayed here: ";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputList
            // 
            this.OutputList.FormattingEnabled = true;
            this.OutputList.Items.AddRange(new object[] {
            "hola",
            "como",
            "estas",
            "perro"});
            this.OutputList.Location = new System.Drawing.Point(342, 60);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(187, 186);
            this.OutputList.TabIndex = 8;
            this.OutputList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OutPutListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 427);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.UserAgeTextBox);
            this.Controls.Add(this.UserAgeLabel);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "OutPutListBox";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox UserAgeTextBox;
        private System.Windows.Forms.Label UserAgeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox OutputList;
    }
}

