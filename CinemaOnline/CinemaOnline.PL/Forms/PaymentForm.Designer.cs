
namespace CinemaOnline.PL.Forms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this._accountPictureBox = new System.Windows.Forms.PictureBox();
            this._homePictureBox = new System.Windows.Forms.PictureBox();
            this._filmPictureBox = new System.Windows.Forms.PictureBox();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._descriptionTextLabel = new System.Windows.Forms.Label();
            this._nameTextLabel = new System.Windows.Forms.Label();
            this._genreTextLabel = new System.Windows.Forms.Label();
            this._genreLabel = new System.Windows.Forms.Label();
            this._payButton = new System.Windows.Forms.Button();
            this._cinemaLabel = new System.Windows.Forms.Label();
            this._timeLabel = new System.Windows.Forms.Label();
            this._cinemaComboBox = new System.Windows.Forms.ComboBox();
            this._timeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._filmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _accountPictureBox
            // 
            this._accountPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._accountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_accountPictureBox.Image")));
            this._accountPictureBox.Location = new System.Drawing.Point(746, 12);
            this._accountPictureBox.Name = "_accountPictureBox";
            this._accountPictureBox.Size = new System.Drawing.Size(50, 50);
            this._accountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._accountPictureBox.TabIndex = 21;
            this._accountPictureBox.TabStop = false;
            this._accountPictureBox.Click += new System.EventHandler(this._accountTictureBox_Click);
            // 
            // _homePictureBox
            // 
            this._homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_homePictureBox.Image")));
            this._homePictureBox.Location = new System.Drawing.Point(12, 12);
            this._homePictureBox.Name = "_homePictureBox";
            this._homePictureBox.Size = new System.Drawing.Size(50, 50);
            this._homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._homePictureBox.TabIndex = 20;
            this._homePictureBox.TabStop = false;
            this._homePictureBox.Click += new System.EventHandler(this._homePictureBox_Click);
            // 
            // _filmPictureBox
            // 
            this._filmPictureBox.Location = new System.Drawing.Point(12, 68);
            this._filmPictureBox.Name = "_filmPictureBox";
            this._filmPictureBox.Size = new System.Drawing.Size(300, 430);
            this._filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._filmPictureBox.TabIndex = 22;
            this._filmPictureBox.TabStop = false;
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.AutoSize = true;
            this._descriptionLabel.Location = new System.Drawing.Point(339, 155);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(88, 20);
            this._descriptionLabel.TabIndex = 38;
            this._descriptionLabel.Text = "Description:";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(339, 74);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(52, 20);
            this._nameLabel.TabIndex = 36;
            this._nameLabel.Text = "Name:";
            // 
            // _descriptionTextLabel
            // 
            this._descriptionTextLabel.Location = new System.Drawing.Point(339, 185);
            this._descriptionTextLabel.Name = "_descriptionTextLabel";
            this._descriptionTextLabel.Size = new System.Drawing.Size(447, 197);
            this._descriptionTextLabel.TabIndex = 41;
            this._descriptionTextLabel.Text = "description";
            // 
            // _nameTextLabel
            // 
            this._nameTextLabel.AutoSize = true;
            this._nameTextLabel.Location = new System.Drawing.Point(397, 74);
            this._nameTextLabel.Name = "_nameTextLabel";
            this._nameTextLabel.Size = new System.Drawing.Size(46, 20);
            this._nameTextLabel.TabIndex = 42;
            this._nameTextLabel.Text = "name";
            // 
            // _genreTextLabel
            // 
            this._genreTextLabel.AutoSize = true;
            this._genreTextLabel.Location = new System.Drawing.Point(397, 113);
            this._genreTextLabel.Name = "_genreTextLabel";
            this._genreTextLabel.Size = new System.Drawing.Size(47, 20);
            this._genreTextLabel.TabIndex = 44;
            this._genreTextLabel.Text = "genre";
            // 
            // _genreLabel
            // 
            this._genreLabel.AutoSize = true;
            this._genreLabel.Location = new System.Drawing.Point(339, 113);
            this._genreLabel.Name = "_genreLabel";
            this._genreLabel.Size = new System.Drawing.Size(51, 20);
            this._genreLabel.TabIndex = 43;
            this._genreLabel.Text = "Genre:";
            // 
            // _payButton
            // 
            this._payButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._payButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._payButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._payButton.ForeColor = System.Drawing.Color.White;
            this._payButton.Location = new System.Drawing.Point(0, 520);
            this._payButton.Name = "_payButton";
            this._payButton.Size = new System.Drawing.Size(808, 51);
            this._payButton.TabIndex = 45;
            this._payButton.Text = "Pay";
            this._payButton.UseVisualStyleBackColor = false;
            this._payButton.Click += new System.EventHandler(this._payButton_Click);
            // 
            // _cinemaLabel
            // 
            this._cinemaLabel.AutoSize = true;
            this._cinemaLabel.Location = new System.Drawing.Point(339, 409);
            this._cinemaLabel.Name = "_cinemaLabel";
            this._cinemaLabel.Size = new System.Drawing.Size(62, 20);
            this._cinemaLabel.TabIndex = 46;
            this._cinemaLabel.Text = "Cinema:";
            // 
            // _timeLabel
            // 
            this._timeLabel.AutoSize = true;
            this._timeLabel.Location = new System.Drawing.Point(339, 460);
            this._timeLabel.Name = "_timeLabel";
            this._timeLabel.Size = new System.Drawing.Size(45, 20);
            this._timeLabel.TabIndex = 47;
            this._timeLabel.Text = "Time:";
            // 
            // _cinemaComboBox
            // 
            this._cinemaComboBox.FormattingEnabled = true;
            this._cinemaComboBox.Location = new System.Drawing.Point(425, 406);
            this._cinemaComboBox.Name = "_cinemaComboBox";
            this._cinemaComboBox.Size = new System.Drawing.Size(361, 28);
            this._cinemaComboBox.TabIndex = 48;
            // 
            // _timeComboBox
            // 
            this._timeComboBox.FormattingEnabled = true;
            this._timeComboBox.Location = new System.Drawing.Point(425, 457);
            this._timeComboBox.Name = "_timeComboBox";
            this._timeComboBox.Size = new System.Drawing.Size(361, 28);
            this._timeComboBox.TabIndex = 49;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this._timeComboBox);
            this.Controls.Add(this._cinemaComboBox);
            this.Controls.Add(this._timeLabel);
            this.Controls.Add(this._cinemaLabel);
            this.Controls.Add(this._payButton);
            this.Controls.Add(this._genreTextLabel);
            this.Controls.Add(this._genreLabel);
            this.Controls.Add(this._nameTextLabel);
            this.Controls.Add(this._descriptionTextLabel);
            this.Controls.Add(this._descriptionLabel);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._filmPictureBox);
            this.Controls.Add(this._accountPictureBox);
            this.Controls.Add(this._homePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._filmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _accountPictureBox;
        private System.Windows.Forms.PictureBox _homePictureBox;
        private System.Windows.Forms.PictureBox _filmPictureBox;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _descriptionTextLabel;
        private System.Windows.Forms.Label _nameTextLabel;
        private System.Windows.Forms.Label _genreTextLabel;
        private System.Windows.Forms.Label _genreLabel;
        private System.Windows.Forms.Button _payButton;
        private System.Windows.Forms.Label _cinemaLabel;
        private System.Windows.Forms.Label _timeLabel;
        private System.Windows.Forms.ComboBox _cinemaComboBox;
        private System.Windows.Forms.ComboBox _timeComboBox;
    }
}