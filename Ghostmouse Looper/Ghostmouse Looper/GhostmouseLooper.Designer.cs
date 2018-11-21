namespace Ghostmouse_Looper
{
    partial class GhostmouseLooper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GhostmouseLooper));
            this.label1 = new System.Windows.Forms.Label();
            this.loopButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.ghostMouseKeyTextbox = new System.Windows.Forms.TextBox();
            this.loopLengthTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ghostmouseLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loopCountTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.remainingIterationsLabel = new System.Windows.Forms.Label();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.completionTimeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ghostmouse Looper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loopButton
            // 
            this.loopButton.BackColor = System.Drawing.Color.PaleGreen;
            this.loopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopButton.Location = new System.Drawing.Point(343, 83);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(93, 49);
            this.loopButton.TabIndex = 4;
            this.loopButton.Text = "Loop";
            this.loopButton.UseVisualStyleBackColor = false;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitButton.Location = new System.Drawing.Point(343, 143);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(198, 143);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(100, 31);
            this.timeButton.TabIndex = 3;
            this.timeButton.TabStop = false;
            this.timeButton.Text = "Measure Time";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // ghostMouseKeyTextbox
            // 
            this.ghostMouseKeyTextbox.Location = new System.Drawing.Point(9, 98);
            this.ghostMouseKeyTextbox.Name = "ghostMouseKeyTextbox";
            this.ghostMouseKeyTextbox.Size = new System.Drawing.Size(65, 20);
            this.ghostMouseKeyTextbox.TabIndex = 1;
            this.ghostMouseKeyTextbox.Text = "";
            this.ghostMouseKeyTextbox.TextChanged += new System.EventHandler(this.ghostMouseKeyTextbox_TextChanged);
            // 
            // loopLengthTextbox
            // 
            this.loopLengthTextbox.Location = new System.Drawing.Point(217, 98);
            this.loopLengthTextbox.Name = "loopLengthTextbox";
            this.loopLengthTextbox.Size = new System.Drawing.Size(62, 20);
            this.loopLengthTextbox.TabIndex = 3;
            this.loopLengthTextbox.TextChanged += new System.EventHandler(this.loopLengthTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requires a program called \"Ghostmouse\" or some similar equivalent. This program m" +
    "ust be open and ready to run, otherwise nothing will happen. This can be found h" +
    "ere:";
            // 
            // ghostmouseLink
            // 
            this.ghostmouseLink.AutoSize = true;
            this.ghostmouseLink.Location = new System.Drawing.Point(105, 242);
            this.ghostmouseLink.Name = "ghostmouseLink";
            this.ghostmouseLink.Size = new System.Drawing.Size(208, 13);
            this.ghostmouseLink.TabIndex = 8;
            this.ghostmouseLink.Text = "Ghostmouse - Action Recorder && Playback";
            this.ghostmouseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ghostmouseLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghostmouse Key Press";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(198, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loop Length";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(198, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "- - OR  - -";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "secs";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(98, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number Times to Loop";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loopCountTextbox
            // 
            this.loopCountTextbox.Location = new System.Drawing.Point(108, 98);
            this.loopCountTextbox.Name = "loopCountTextbox";
            this.loopCountTextbox.Size = new System.Drawing.Size(65, 20);
            this.loopCountTextbox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Remaining Iterations:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Remaining Time:";
            // 
            // remainingIterationsLabel
            // 
            this.remainingIterationsLabel.AutoSize = true;
            this.remainingIterationsLabel.Location = new System.Drawing.Point(119, 152);
            this.remainingIterationsLabel.Name = "remainingIterationsLabel";
            this.remainingIterationsLabel.Text = "";
            this.remainingIterationsLabel.Size = new System.Drawing.Size(0, 13);
            this.remainingIterationsLabel.TabIndex = 18;
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Location = new System.Drawing.Point(119, 167);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Text = "";
            this.remainingTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.remainingTimeLabel.TabIndex = 19;
            // 
            // completionTimeLabel
            // 
            this.completionTimeLabel.AutoSize = true;
            this.completionTimeLabel.Location = new System.Drawing.Point(119, 182);
            this.completionTimeLabel.Name = "completionTimeLabel";
            this.completionTimeLabel.Text = "";
            this.completionTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.completionTimeLabel.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Est. Comp. Time:";
            // 
            // GhostmouseLooper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.Controls.Add(this.completionTimeLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.remainingIterationsLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loopCountTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ghostmouseLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loopLengthTextbox);
            this.Controls.Add(this.ghostMouseKeyTextbox);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GhostmouseLooper";
            this.Load += new System.EventHandler(this.GhostmouseLooper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.TextBox ghostMouseKeyTextbox;
        private System.Windows.Forms.TextBox loopLengthTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ghostmouseLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox loopCountTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label remainingIterationsLabel;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Label completionTimeLabel;
        private System.Windows.Forms.Label label12;
    }
}

