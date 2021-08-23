
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
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _accountPictureBox
            // 
            this._accountPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._accountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_accountPictureBox.Image")));
            this._accountPictureBox.Location = new System.Drawing.Point(997, 12);
            this._accountPictureBox.Name = "_accountPictureBox";
            this._accountPictureBox.Size = new System.Drawing.Size(50, 50);
            this._accountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._accountPictureBox.TabIndex = 21;
            this._accountPictureBox.TabStop = false;
            this._accountPictureBox.Click += new System.EventHandler(this._accountTictureBox_Click);
            // 
            // _filmsFlowLayoutPanel
            // 
            this._filmsFlowLayoutPanel.AutoScroll = true;
            this._filmsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._filmsFlowLayoutPanel.Location = new System.Drawing.Point(0, 126);
            this._filmsFlowLayoutPanel.Name = "_filmsFlowLayoutPanel";
            this._filmsFlowLayoutPanel.Size = new System.Drawing.Size(1059, 541);
            this._filmsFlowLayoutPanel.TabIndex = 22;
            this._filmsFlowLayoutPanel.WrapContents = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 667);
            this.Controls.Add(this._filmsFlowLayoutPanel);
            this.Controls.Add(this._accountPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreviewForm";
            this.Text = "Cinema Online";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._accountPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _accountPictureBox;
        private System.Windows.Forms.FlowLayoutPanel _filmsFlowLayoutPanel;
    }
}