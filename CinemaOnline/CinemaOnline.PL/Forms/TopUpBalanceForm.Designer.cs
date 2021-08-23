﻿
namespace CinemaOnline.PL.Forms
{
    partial class TopUpBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopUpBalanceForm));
            this._notificationLabel = new System.Windows.Forms.Label();
            this._topUpButton = new System.Windows.Forms.Button();
            this._topUpTextBox = new System.Windows.Forms.TextBox();
            this._accountPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _notificationLabel
            // 
            this._notificationLabel.AutoSize = true;
            this._notificationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._notificationLabel.Location = new System.Drawing.Point(11, 96);
            this._notificationLabel.Name = "_notificationLabel";
            this._notificationLabel.Size = new System.Drawing.Size(134, 20);
            this._notificationLabel.TabIndex = 15;
            this._notificationLabel.Text = "Enter card number:";
            // 
            // _topUpButton
            // 
            this._topUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._topUpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._topUpButton.Location = new System.Drawing.Point(0, 147);
            this._topUpButton.Name = "_topUpButton";
            this._topUpButton.Size = new System.Drawing.Size(481, 57);
            this._topUpButton.TabIndex = 16;
            this._topUpButton.Text = "TOP UP";
            this._topUpButton.UseVisualStyleBackColor = true;
            this._topUpButton.Click += new System.EventHandler(this._topUpButton_Click);
            // 
            // _topUpTextBox
            // 
            this._topUpTextBox.Location = new System.Drawing.Point(161, 93);
            this._topUpTextBox.Name = "_topUpTextBox";
            this._topUpTextBox.Size = new System.Drawing.Size(293, 27);
            this._topUpTextBox.TabIndex = 17;
            // 
            // _accountPictureBox
            // 
            this._accountPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._accountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_accountPictureBox.Image")));
            this._accountPictureBox.Location = new System.Drawing.Point(419, 12);
            this._accountPictureBox.Name = "_accountPictureBox";
            this._accountPictureBox.Size = new System.Drawing.Size(50, 50);
            this._accountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._accountPictureBox.TabIndex = 19;
            this._accountPictureBox.TabStop = false;
            this._accountPictureBox.Click += new System.EventHandler(this._accountTictureBox_Click);
            // 
            // TopUpBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 204);
            this.Controls.Add(this._accountPictureBox);
            this.Controls.Add(this._topUpTextBox);
            this.Controls.Add(this._topUpButton);
            this.Controls.Add(this._notificationLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopUpBalanceForm";
            this.Text = "Top Up Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopUpBalanceForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _notificationLabel;
        private System.Windows.Forms.Button _topUpButton;
        private System.Windows.Forms.TextBox _topUpTextBox;
        private System.Windows.Forms.PictureBox _accountPictureBox;
    }
}