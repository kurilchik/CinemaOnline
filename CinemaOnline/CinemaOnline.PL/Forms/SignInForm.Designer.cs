
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
            this._orLabel = new System.Windows.Forms.Label();
            this._singInButton = new System.Windows.Forms.Button();
            this._singUpButton = new System.Windows.Forms.Button();
            this._emailAddressTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Location = new System.Drawing.Point(13, 53);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(82, 15);
            this._emailAddressLabel.TabIndex = 0;
            this._emailAddressLabel.Text = "Email address:";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(13, 149);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(60, 15);
            this._passwordLabel.TabIndex = 1;
            this._passwordLabel.Text = "Password:";
            // 
            // _orLabel
            // 
            this._orLabel.AutoSize = true;
            this._orLabel.Location = new System.Drawing.Point(177, 277);
            this._orLabel.Name = "_orLabel";
            this._orLabel.Size = new System.Drawing.Size(23, 15);
            this._orLabel.TabIndex = 2;
            this._orLabel.Text = "OR";
            // 
            // _singInButton
            // 
            this._singInButton.BackColor = System.Drawing.Color.LimeGreen;
            this._singInButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._singInButton.ForeColor = System.Drawing.Color.White;
            this._singInButton.Location = new System.Drawing.Point(42, 224);
            this._singInButton.Name = "_singInButton";
            this._singInButton.Size = new System.Drawing.Size(300, 50);
            this._singInButton.TabIndex = 3;
            this._singInButton.Text = "SIGN IN";
            this._singInButton.UseVisualStyleBackColor = false;
            // 
            // _singUpButton
            // 
            this._singUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._singUpButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._singUpButton.ForeColor = System.Drawing.Color.White;
            this._singUpButton.Location = new System.Drawing.Point(42, 295);
            this._singUpButton.Name = "_singUpButton";
            this._singUpButton.Size = new System.Drawing.Size(300, 50);
            this._singUpButton.TabIndex = 4;
            this._singUpButton.Text = "SIGN UP";
            this._singUpButton.UseVisualStyleBackColor = false;
            // 
            // _emailAddressTextBox
            // 
            this._emailAddressTextBox.Location = new System.Drawing.Point(101, 50);
            this._emailAddressTextBox.Name = "_emailAddressTextBox";
            this._emailAddressTextBox.Size = new System.Drawing.Size(255, 23);
            this._emailAddressTextBox.TabIndex = 5;
            this._emailAddressTextBox.Leave += new System.EventHandler(this._emailAddressTextBox_Leave);
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(101, 146);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(255, 23);
            this._passwordTextBox.TabIndex = 6;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._emailAddressTextBox);
            this.Controls.Add(this._singUpButton);
            this.Controls.Add(this._singInButton);
            this.Controls.Add(this._orLabel);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In - Cinema Online";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _orLabel;
        private System.Windows.Forms.Button _singInButton;
        private System.Windows.Forms.Button _singUpButton;
        private System.Windows.Forms.TextBox _emailAddressTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
    }
}