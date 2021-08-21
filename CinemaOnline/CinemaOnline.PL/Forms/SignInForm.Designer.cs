
namespace CinemaOnline.PL.Forms
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this._emailAddressLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._informationalLabel = new System.Windows.Forms.Label();
            this._singInButton = new System.Windows.Forms.Button();
            this._emailAddressTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._signUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Location = new System.Drawing.Point(9, 43);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(104, 20);
            this._emailAddressLabel.TabIndex = 0;
            this._emailAddressLabel.Text = "Email address:";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(12, 128);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(73, 20);
            this._passwordLabel.TabIndex = 1;
            this._passwordLabel.Text = "Password:";
            // 
            // _informationalLabel
            // 
            this._informationalLabel.AutoSize = true;
            this._informationalLabel.Location = new System.Drawing.Point(140, 202);
            this._informationalLabel.Name = "_informationalLabel";
            this._informationalLabel.Size = new System.Drawing.Size(222, 20);
            this._informationalLabel.TabIndex = 2;
            this._informationalLabel.Text = "if you don\'t have an account yet.";
            // 
            // _singInButton
            // 
            this._singInButton.BackColor = System.Drawing.Color.LimeGreen;
            this._singInButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._singInButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._singInButton.ForeColor = System.Drawing.Color.White;
            this._singInButton.Location = new System.Drawing.Point(0, 258);
            this._singInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._singInButton.Name = "_singInButton";
            this._singInButton.Size = new System.Drawing.Size(434, 67);
            this._singInButton.TabIndex = 3;
            this._singInButton.Text = "SIGN IN";
            this._singInButton.UseVisualStyleBackColor = false;
            this._singInButton.Click += new System.EventHandler(this._singInButton_Click);
            // 
            // _emailAddressTextBox
            // 
            this._emailAddressTextBox.Location = new System.Drawing.Point(122, 40);
            this._emailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._emailAddressTextBox.Name = "_emailAddressTextBox";
            this._emailAddressTextBox.Size = new System.Drawing.Size(291, 27);
            this._emailAddressTextBox.TabIndex = 5;
            this._emailAddressTextBox.Leave += new System.EventHandler(this._emailAddressTextBox_Leave);
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(122, 125);
            this._passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(291, 27);
            this._passwordTextBox.TabIndex = 6;
            this._passwordTextBox.Leave += new System.EventHandler(this._passwordTextBox_Leave);
            // 
            // _signUpLabel
            // 
            this._signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._signUpLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this._signUpLabel.ForeColor = System.Drawing.Color.Navy;
            this._signUpLabel.Location = new System.Drawing.Point(82, 202);
            this._signUpLabel.Name = "_signUpLabel";
            this._signUpLabel.Size = new System.Drawing.Size(63, 20);
            this._signUpLabel.TabIndex = 7;
            this._signUpLabel.Text = "Sign up ";
            this._signUpLabel.Click += new System.EventHandler(this._signUpLabel_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 325);
            this.Controls.Add(this._signUpLabel);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._emailAddressTextBox);
            this.Controls.Add(this._singInButton);
            this.Controls.Add(this._informationalLabel);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _informationalLabel;
        private System.Windows.Forms.Button _singInButton;
        private System.Windows.Forms.TextBox _emailAddressTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _signUpLabel;
    }
}