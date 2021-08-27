
namespace CinemaOnline.PL.Forms
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this._accountPictureBox = new System.Windows.Forms.PictureBox();
            this._filmsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._welcomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _accountPictureBox
            // 
            this._accountPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._accountPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._accountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_accountPictureBox.Image")));
            this._accountPictureBox.Location = new System.Drawing.Point(872, 9);
            this._accountPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._accountPictureBox.Name = "_accountPictureBox";
            this._accountPictureBox.Size = new System.Drawing.Size(44, 38);
            this._accountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._accountPictureBox.TabIndex = 21;
            this._accountPictureBox.TabStop = false;
            this._accountPictureBox.Click += new System.EventHandler(this._accountTictureBox_Click);
            // 
            // _filmsFlowLayoutPanel
            // 
            this._filmsFlowLayoutPanel.AutoScroll = true;
            this._filmsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._filmsFlowLayoutPanel.Location = new System.Drawing.Point(0, 93);
            this._filmsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._filmsFlowLayoutPanel.Name = "_filmsFlowLayoutPanel";
            this._filmsFlowLayoutPanel.Size = new System.Drawing.Size(927, 479);
            this._filmsFlowLayoutPanel.TabIndex = 22;
            this._filmsFlowLayoutPanel.WrapContents = false;
            // 
            // _welcomLabel
            // 
            this._welcomLabel.AutoSize = true;
            this._welcomLabel.Location = new System.Drawing.Point(39, 31);
            this._welcomLabel.Name = "_welcomLabel";
            this._welcomLabel.Size = new System.Drawing.Size(51, 15);
            this._welcomLabel.TabIndex = 23;
            this._welcomLabel.Text = "Welcom";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 572);
            this.Controls.Add(this._welcomLabel);
            this.Controls.Add(this._filmsFlowLayoutPanel);
            this.Controls.Add(this._accountPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Online";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _accountPictureBox;
        private System.Windows.Forms.FlowLayoutPanel _filmsFlowLayoutPanel;
        private System.Windows.Forms.Label _welcomLabel;
    }
}