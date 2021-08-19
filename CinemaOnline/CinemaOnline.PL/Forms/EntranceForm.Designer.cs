
namespace CinemaOnline.PL.Forms
{
    partial class EntranceForm
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
            this._signInButton = new System.Windows.Forms.Button();
            this._signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _signInButton
            // 
            this._signInButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._signInButton.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._signInButton.Location = new System.Drawing.Point(0, 0);
            this._signInButton.Name = "_signInButton";
            this._signInButton.Size = new System.Drawing.Size(482, 219);
            this._signInButton.TabIndex = 0;
            this._signInButton.Text = "SIGN IN";
            this._signInButton.UseVisualStyleBackColor = true;
            this._signInButton.Click += new System.EventHandler(this._signInButton_Click);
            // 
            // _signUpButton
            // 
            this._signUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._signUpButton.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._signUpButton.Location = new System.Drawing.Point(0, 225);
            this._signUpButton.Name = "_signUpButton";
            this._signUpButton.Size = new System.Drawing.Size(482, 228);
            this._signUpButton.TabIndex = 1;
            this._signUpButton.Text = "SIGN UP";
            this._signUpButton.UseVisualStyleBackColor = true;
            this._signUpButton.Click += new System.EventHandler(this._signUpButton_Click);
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this._signUpButton);
            this.Controls.Add(this._signInButton);
            this.Name = "EntranceForm";
            this.Text = "Entrance - Cinema Online";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _signInButton;
        private System.Windows.Forms.Button _signUpButton;
    }
}