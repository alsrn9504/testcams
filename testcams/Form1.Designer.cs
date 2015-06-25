namespace testcams
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.button_capture = new System.Windows.Forms.Button();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.bigVideo = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer5 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(9, 20);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(128, 128);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.Click += new System.EventHandler(this.videoSourcePlayer1_Click);
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(598, 20);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(128, 128);
            this.videoSourcePlayer2.TabIndex = 1;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.Click += new System.EventHandler(this.videoSourcePlayer2_Click);
            // 
            // button_capture
            // 
            this.button_capture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_capture.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_capture.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button_capture.Location = new System.Drawing.Point(9, 661);
            this.button_capture.Name = "button_capture";
            this.button_capture.Size = new System.Drawing.Size(717, 52);
            this.button_capture.TabIndex = 5;
            this.button_capture.Text = "To STL";
            this.button_capture.UseVisualStyleBackColor = false;
            this.button_capture.Click += new System.EventHandler(this.button_capture_Click);
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.videoSourcePlayer4.Location = new System.Drawing.Point(156, 20);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(128, 128);
            this.videoSourcePlayer4.TabIndex = 7;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            this.videoSourcePlayer4.Click += new System.EventHandler(this.videoSourcePlayer4_Click_1);
            // 
            // bigVideo
            // 
            this.bigVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigVideo.Location = new System.Drawing.Point(9, 150);
            this.bigVideo.Name = "bigVideo";
            this.bigVideo.Size = new System.Drawing.Size(717, 505);
            this.bigVideo.TabIndex = 6;
            this.bigVideo.Text = "videoSourcePlayer6";
            this.bigVideo.VideoSource = null;
            this.bigVideo.Click += new System.EventHandler(this.bigVideo_Click);
            // 
            // videoSourcePlayer5
            // 
            this.videoSourcePlayer5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.videoSourcePlayer5.Location = new System.Drawing.Point(301, 20);
            this.videoSourcePlayer5.Name = "videoSourcePlayer5";
            this.videoSourcePlayer5.Size = new System.Drawing.Size(128, 128);
            this.videoSourcePlayer5.TabIndex = 8;
            this.videoSourcePlayer5.Text = "videoSourcePlayer5";
            this.videoSourcePlayer5.VideoSource = null;
            this.videoSourcePlayer5.Click += new System.EventHandler(this.videoSourcePlayer5_Click_1);
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(452, 20);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(128, 128);
            this.videoSourcePlayer3.TabIndex = 9;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.Click += new System.EventHandler(this.videoSourcePlayer3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 716);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.videoSourcePlayer5);
            this.Controls.Add(this.videoSourcePlayer4);
            this.Controls.Add(this.bigVideo);
            this.Controls.Add(this.button_capture);
            this.Controls.Add(this.videoSourcePlayer2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "3D Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.Button button_capture;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private AForge.Controls.VideoSourcePlayer bigVideo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer5;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
    }
}

