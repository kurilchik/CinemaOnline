
namespace CinemaOnline.PL.Forms
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this._homePictureBox = new System.Windows.Forms.PictureBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._emailAddressTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._emailAddressLabel = new System.Windows.Forms.Label();
            this._balanceLabel = new System.Windows.Forms.Label();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._balanceTextBox = new System.Windows.Forms.TextBox();
            this._topUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _homePictureBox
            // 
            this._homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_homePictureBox.Image")));
            this._homePictureBox.Location = new System.Drawing.Point(12, 12);
            this._homePictureBox.Name = "_homePictureBox";
            this._homePictureBox.Size = new System.Drawing.Size(50, 50);
            this._homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._homePictureBox.TabIndex = 21;
            this._homePictureBox.TabStop = false;
            this._homePictureBox.Click += new System.EventHandler(this._homePictureBox_Click);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Enabled = false;
            this._nameTextBox.Location = new System.Drawing.Point(131, 96);
            this._nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.ReadOnly = true;
            this._nameTextBox.Size = new System.Drawing.Size(291, 27);
            this._nameTextBox.TabIndex = 27;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(12, 103);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(52, 20);
            this._nameLabel.TabIndex = 26;
            this._nameLabel.Text = "Name:";
            // 
            // _emailAddressTextBox
            // 
            this._emailAddressTextBox.Enabled = false;
            this._emailAddressTextBox.Location = new System.Drawing.Point(131, 169);
            this._emailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._emailAddressTextBox.Name = "_emailAddressTextBox";
            this._emailAddressTextBox.ReadOnly = true;
            this._emailAddressTextBox.Size = new System.Drawing.Size(291, 27);
            this._emailAddressTextBox.TabIndex = 24;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(12, 254);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(73, 20);
            this._passwordLabel.TabIndex = 23;
            this._passwordLabel.Text = "Password:";
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Location = new System.Drawing.Point(9, 176);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(104, 20);
            this._emailAddressLabel.TabIndex = 22;
            this._emailAddressLabel.Text = "Email address:";
            // 
            // _balanceLabel
            // 
            this._balanceLabel.AutoSize = true;
            this._balanceLabel.Location = new System.Drawing.Point(12, 330);
            this._balanceLabel.Name = "_balanceLabel";
            this._balanceLabel.Size = new System.Drawing.Size(64, 20);
            this._balanceLabel.TabIndex = 28;
            this._balanceLabel.Text = "Balance:";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Enabled = false;
            this._passwordTextBox.Location = new System.Drawing.Point(131, 247);
            this._passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.ReadOnly = true;
            this._passwordTextBox.Size = new System.Drawing.Size(291, 27);
            this._passwordTextBox.TabIndex = 31;
            // 
            // _balanceTextBox
            // 
            this._balanceTextBox.Enabled = false;
            this._balanceTextBox.Location = new System.Drawing.Point(131, 323);
            this._balanceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._balanceTextBox.Name = "_balanceTextBox";
            this._balanceTextBox.ReadOnly = true;
            this._balanceTextBox.Size = new System.Drawing.Size(291, 27);
            this._balanceTextBox.TabIndex = 32;
            // 
            // _topUpButton
            // 
            this._topUpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._topUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._topUpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._topUpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._topUpButton.Location = new System.Drawing.Point(0, 401);
            this._topUpButton.Name = "_topUpButton";
            this._topUpButton.Size = new System.Drawing.Size(445, 56);
            this._topUpButton.TabIndex = 33;
            this._topUpButton.Text = "TOP UP BALANCE";
            this._topUpButton.UseVisualStyleBackColor = false;
            this._topUpButton.Click += new System.EventHandler(this._topUpButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 457);
            this.Controls.Add(this._topUpButton);
            this.Controls.Add(this._balanceTextBox);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._balanceLabel);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._emailAddressTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailAddressLabel);
            this.Controls.Add(this._homePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.Text = "Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._homePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _homePictureBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _emailAddressTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.Label _balanceLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _balanceTextBox;
        private System.Windows.Forms.Button _topUpButton;
    }
}