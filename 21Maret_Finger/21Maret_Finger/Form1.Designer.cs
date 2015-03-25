namespace _21Maret_Finger
{
    partial class MainForm
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
            this.videoControl = new CCT.NUI.Visual.VideoControl();
            this.buttonClustering = new System.Windows.Forms.Button();
            this.buttonConvexHull = new System.Windows.Forms.Button();
            this.buttonRGB = new System.Windows.Forms.Button();
            this.buttonDepth = new System.Windows.Forms.Button();
            this.buttonHandAndFinger = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonGestureRecognition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFingerCount = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoControl
            // 
            this.videoControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.videoControl.Location = new System.Drawing.Point(12, 12);
            this.videoControl.Name = "videoControl";
            this.videoControl.Size = new System.Drawing.Size(640, 480);
            this.videoControl.Stretch = false;
            this.videoControl.TabIndex = 0;
            // 
            // buttonClustering
            // 
            this.buttonClustering.Location = new System.Drawing.Point(674, 12);
            this.buttonClustering.Name = "buttonClustering";
            this.buttonClustering.Size = new System.Drawing.Size(161, 33);
            this.buttonClustering.TabIndex = 1;
            this.buttonClustering.Text = "Show Clustering";
            this.buttonClustering.UseVisualStyleBackColor = true;
            this.buttonClustering.Click += new System.EventHandler(this.buttonClustering_Click);
            // 
            // buttonConvexHull
            // 
            this.buttonConvexHull.Location = new System.Drawing.Point(674, 59);
            this.buttonConvexHull.Name = "buttonConvexHull";
            this.buttonConvexHull.Size = new System.Drawing.Size(161, 36);
            this.buttonConvexHull.TabIndex = 2;
            this.buttonConvexHull.Text = "Show Convex Hull and Contour";
            this.buttonConvexHull.UseVisualStyleBackColor = true;
            this.buttonConvexHull.Click += new System.EventHandler(this.buttonConvexHull_Click);
            // 
            // buttonRGB
            // 
            this.buttonRGB.Location = new System.Drawing.Point(674, 109);
            this.buttonRGB.Name = "buttonRGB";
            this.buttonRGB.Size = new System.Drawing.Size(161, 35);
            this.buttonRGB.TabIndex = 3;
            this.buttonRGB.Text = "Show RGB";
            this.buttonRGB.UseVisualStyleBackColor = true;
            this.buttonRGB.Click += new System.EventHandler(this.buttonRGB_Click);
            // 
            // buttonDepth
            // 
            this.buttonDepth.Location = new System.Drawing.Point(674, 159);
            this.buttonDepth.Name = "buttonDepth";
            this.buttonDepth.Size = new System.Drawing.Size(161, 34);
            this.buttonDepth.TabIndex = 4;
            this.buttonDepth.Text = "Show Depth";
            this.buttonDepth.UseVisualStyleBackColor = true;
            this.buttonDepth.Click += new System.EventHandler(this.buttonDepth_Click);
            // 
            // buttonHandAndFinger
            // 
            this.buttonHandAndFinger.Location = new System.Drawing.Point(674, 207);
            this.buttonHandAndFinger.Name = "buttonHandAndFinger";
            this.buttonHandAndFinger.Size = new System.Drawing.Size(161, 34);
            this.buttonHandAndFinger.TabIndex = 5;
            this.buttonHandAndFinger.Text = "Show Hand Tracking";
            this.buttonHandAndFinger.UseVisualStyleBackColor = true;
            this.buttonHandAndFinger.Click += new System.EventHandler(this.buttonHandAndFinger_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(674, 458);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 34);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(674, 411);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(161, 34);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonGestureRecognition
            // 
            this.buttonGestureRecognition.Location = new System.Drawing.Point(674, 257);
            this.buttonGestureRecognition.Name = "buttonGestureRecognition";
            this.buttonGestureRecognition.Size = new System.Drawing.Size(161, 34);
            this.buttonGestureRecognition.TabIndex = 8;
            this.buttonGestureRecognition.Text = "Show Gesture Recognition";
            this.buttonGestureRecognition.UseVisualStyleBackColor = true;
            this.buttonGestureRecognition.Click += new System.EventHandler(this.buttonGestureRecognition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Finger Open :";
            // 
            // labelFingerCount
            // 
            this.labelFingerCount.AutoSize = true;
            this.labelFingerCount.Font = new System.Drawing.Font("Humanst521 BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFingerCount.Location = new System.Drawing.Point(726, 323);
            this.labelFingerCount.Name = "labelFingerCount";
            this.labelFingerCount.Size = new System.Drawing.Size(65, 76);
            this.labelFingerCount.TabIndex = 10;
            this.labelFingerCount.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(829, 297);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 104);
            this.trackBar1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 509);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelFingerCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGestureRecognition);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHandAndFinger);
            this.Controls.Add(this.buttonDepth);
            this.Controls.Add(this.buttonRGB);
            this.Controls.Add(this.buttonConvexHull);
            this.Controls.Add(this.buttonClustering);
            this.Controls.Add(this.videoControl);
            this.Name = "MainForm";
            this.Text = "Hand Tracking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCT.NUI.Visual.VideoControl videoControl;
        private System.Windows.Forms.Button buttonClustering;
        private System.Windows.Forms.Button buttonConvexHull;
        private System.Windows.Forms.Button buttonRGB;
        private System.Windows.Forms.Button buttonDepth;
        private System.Windows.Forms.Button buttonHandAndFinger;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonGestureRecognition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFingerCount;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

