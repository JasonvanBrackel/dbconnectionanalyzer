namespace Apprenda.ClientServices.SqlServerConnectionAnalyzer
{
    partial class SqlServerConnectionAnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerConnectionAnalyzerForm));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.ConnectionStringTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(17, 13);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(17, 39);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(21, 158);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(53, 23);
            this.TestButton.TabIndex = 6;
            this.TestButton.Text = "&Run";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.UsernameTextBox.Location = new System.Drawing.Point(112, 10);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(326, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordMaskedTextBox
            // 
            this.PasswordMaskedTextBox.Location = new System.Drawing.Point(113, 36);
            this.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            this.PasswordMaskedTextBox.Size = new System.Drawing.Size(325, 20);
            this.PasswordMaskedTextBox.TabIndex = 2;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(20, 187);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(972, 421);
            this.ResultsTextBox.TabIndex = 7;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.DatabaseTextBox.Location = new System.Drawing.Point(113, 88);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(326, 20);
            this.DatabaseTextBox.TabIndex = 4;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(18, 91);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(53, 13);
            this.DatabaseLabel.TabIndex = 5;
            this.DatabaseLabel.Text = "Database";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ServerTextBox.Location = new System.Drawing.Point(113, 62);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(326, 20);
            this.ServerTextBox.TabIndex = 3;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(18, 65);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerLabel.TabIndex = 7;
            this.ServerLabel.Text = "Server";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Location = new System.Drawing.Point(269, 111);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(18, 13);
            this.OrLabel.TabIndex = 47;
            this.OrLabel.Text = "Or";
            this.OrLabel.UseMnemonic = false;
            // 
            // ConnectionStringTextBox
            // 
            this.ConnectionStringTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ConnectionStringTextBox.Location = new System.Drawing.Point(113, 127);
            this.ConnectionStringTextBox.Name = "ConnectionStringTextBox";
            this.ConnectionStringTextBox.Size = new System.Drawing.Size(871, 20);
            this.ConnectionStringTextBox.TabIndex = 5;
            this.ConnectionStringTextBox.TextChanged += new System.EventHandler(this.ConnectionStringTextBox_TextChanged);
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.AutoSize = true;
            this.ConnectionStringLabel.Location = new System.Drawing.Point(18, 130);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(91, 13);
            this.ConnectionStringLabel.TabIndex = 49;
            this.ConnectionStringLabel.Text = "Connection String";
            // 
            // SqlServerConnectionAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 620);
            this.Controls.Add(this.ConnectionStringTextBox);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.PasswordMaskedTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlServerConnectionAnalyzerForm";
            this.Text = "Sql Server Connection Analyzer";
            this.Load += new System.EventHandler(this.SqlServerConnectionAnalyzerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordMaskedTextBox;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.TextBox ConnectionStringTextBox;
        private System.Windows.Forms.Label ConnectionStringLabel;
    }
}

