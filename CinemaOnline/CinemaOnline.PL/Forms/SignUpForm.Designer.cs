
namespace CinemaOnline.PL.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._emailAddressTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._emailAddressLabel = new System.Windows.Forms.Label();
            this._singUpButton = new System.Windows.Forms.Button();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._notificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(135, 187);
            this._passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(291, 27);
            this._passwordTextBox.TabIndex = 10;
            // 
            // _emailAddressTextBox
            // 
            this._emailAddressTextBox.Location = new System.Drawing.Point(135, 109);
            this._emailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._emailAddressTextBox.Name = "_emailAddressTextBox";
            this._emailAddressTextBox.Size = new System.Drawing.Size(291, 27);
            this._emailAddressTextBox.TabIndex = 9;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(16, 194);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(83, 20);
            this._passwordLabel.TabIndex = 8;
            this._passwordLabel.Text = "Password: *";
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Location = new System.Drawing.Point(13, 116);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(114, 20);
            this._emailAddressLabel.TabIndex = 7;
            this._emailAddressLabel.Text = "Email address: *";
            // 
            // _singUpButton
            // 
            this._singUpButton.BackColor = System.Drawing.Color.LimeGreen;
            this._singUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._singUpButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._singUpButton.ForeColor = System.Drawing.Color.White;
            this._singUpButton.Location = new System.Drawing.Point(0, 318);
            this._singUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._singUpButton.Name = "_singUpButton";
            this._singUpButton.Size = new System.Drawing.Size(438, 67);
            this._singUpButton.TabIndex = 11;
            this._singUpButton.Text = "SIGN UP";
            this._singUpButton.UseVisualStyleBackColor = false;
            this._singUpButton.Click += new System.EventHandler(this._singUpButton_Click);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(135, 36);
            this._nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.PasswordChar = '*';
            this._nameTextBox.Size = new System.Drawing.Size(291, 27);
            this._nameTextBox.TabIndex = 13;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(16, 43);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(52, 20);
            this._nameLabel.TabIndex = 12;
            this._nameLabel.Text = "Name:";
            // 
            // _notificationLabel
            // 
            this._notificationLabel.AutoSize = true;
            this._notificationLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this._notificationLabel.Location = new System.Drawing.Point(16, 259);
            this._notificationLabel.Name = "_notificationLabel";
            this._notificationLabel.Size = new System.Drawing.Size(109, 20);
            this._notificationLabel.TabIndex = 14;
            this._notificationLabel.Text = "* required field";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 385);
            this.Controls.Add(this._notificationLabel);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._singUpButton);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._emailAddressTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _emailAddressTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.Button _singUpButton;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _notificationLabel;
    }
}