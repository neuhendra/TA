namespace _11Maret
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
            this.videoControl1 = new CCT.NUI.Visual.VideoControl();
            this.buttonHandAndFinger = new System.Windows.Forms.Button();
            this.radioButtonKinectWONear = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // videoControl1
            // 
            this.videoControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.videoControl1.BackColor = System.Drawing.Color.Black;
            this.videoControl1.Location = new System.Drawing.Point(133, 12);
            this.videoControl1.Name = "videoControl1";
            this.videoControl1.Size = new System.Drawing.Size(640, 652);
            this.videoControl1.Stretch = false;
            this.videoControl1.TabIndex = 8;
            // 
            // buttonHandAndFinger
            // 
            this.buttonHandAndFinger.Location = new System.Drawing.Point(34, 31);
            this.buttonHandAndFinger.Name = "buttonHandAndFinger";
            this.buttonHandAndFinger.Size = new System.Drawing.Size(75, 23);
            this.buttonHandAndFinger.TabIndex = 7;
            this.buttonHandAndFinger.Text = "detection";
            this.buttonHandAndFinger.UseVisualStyleBackColor = true;
            this.buttonHandAndFinger.Click += new System.EventHandler(this.buttonHandAndFinger_Click);
            // 
            // radioButtonKinectWONear
            // 
            this.radioButtonKinectWONear.AutoSize = true;
            this.radioButtonKinectWONear.Location = new System.Drawing.Point(24, 74);
            this.radioButtonKinectWONear.Name = "radioButtonKinectWONear";
            this.radioButtonKinectWONear.Size = new System.Drawing.Size(81, 17);
            this.radioButtonKinectWONear.TabIndex = 14;
            this.radioButtonKinectWONear.Text = "KInect SDK";
            this.radioButtonKinectWONear.UseVisualStyleBackColor = true;
            this.radioButtonKinectWONear.CheckedChanged += new System.EventHandler(this.radioButtonKinectWONear_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 715);
            this.Controls.Add(this.radioButtonKinectWONear);
            this.Controls.Add(this.buttonHandAndFinger);
            this.Controls.Add(this.videoControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCT.NUI.Visual.VideoControl videoControl1;
        private System.Windows.Forms.Button buttonHandAndFinger;
        private System.Windows.Forms.RadioButton radioButtonKinectWONear;
    }
}

