namespace MatchShape_test_01
{
    partial class Circle_detection_test
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
            this.Circle_picture = new System.Windows.Forms.PictureBox();
            this.detection_circle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.result_label = new System.Windows.Forms.Label();
            this.Result_value_label = new System.Windows.Forms.Label();
            this.dp_trackbar = new System.Windows.Forms.TrackBar();
            this.parameter_dp = new System.Windows.Forms.Label();
            this.parameter_minDist = new System.Windows.Forms.Label();
            this.minDist_trackbar = new System.Windows.Forms.TrackBar();
            this.parameter_1 = new System.Windows.Forms.Label();
            this.P1_trackbar = new System.Windows.Forms.TrackBar();
            this.parameter_2 = new System.Windows.Forms.Label();
            this.P2_trackbar = new System.Windows.Forms.TrackBar();
            this.parameter_minRadius = new System.Windows.Forms.Label();
            this.minRadius_trackbar = new System.Windows.Forms.TrackBar();
            this.parameter_maxRadius = new System.Windows.Forms.Label();
            this.maxRadius_trackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Circle_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDist_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadius_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadius_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Circle_picture
            // 
            this.Circle_picture.Location = new System.Drawing.Point(239, 12);
            this.Circle_picture.Name = "Circle_picture";
            this.Circle_picture.Size = new System.Drawing.Size(303, 266);
            this.Circle_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle_picture.TabIndex = 0;
            this.Circle_picture.TabStop = false;
            // 
            // detection_circle
            // 
            this.detection_circle.Location = new System.Drawing.Point(326, 301);
            this.detection_circle.Name = "detection_circle";
            this.detection_circle.Size = new System.Drawing.Size(136, 23);
            this.detection_circle.TabIndex = 1;
            this.detection_circle.Text = "detection_circle";
            this.detection_circle.UseVisualStyleBackColor = true;
            this.detection_circle.Click += new System.EventHandler(this.detection_circle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(684, 458);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(48, 12);
            this.result_label.TabIndex = 3;
            this.result_label.Text = "Result : ";
            // 
            // Result_value_label
            // 
            this.Result_value_label.AutoSize = true;
            this.Result_value_label.Location = new System.Drawing.Point(753, 458);
            this.Result_value_label.Name = "Result_value_label";
            this.Result_value_label.Size = new System.Drawing.Size(35, 12);
            this.Result_value_label.TabIndex = 4;
            this.Result_value_label.Text = "label2";
            // 
            // dp_trackbar
            // 
            this.dp_trackbar.Location = new System.Drawing.Point(172, 330);
            this.dp_trackbar.Maximum = 200;
            this.dp_trackbar.Minimum = 1;
            this.dp_trackbar.Name = "dp_trackbar";
            this.dp_trackbar.Size = new System.Drawing.Size(490, 45);
            this.dp_trackbar.TabIndex = 5;
            this.dp_trackbar.Value = 1;
            this.dp_trackbar.Scroll += new System.EventHandler(this.circle_detection_parameter_Scroll);
            // 
            // parameter_dp
            // 
            this.parameter_dp.AutoSize = true;
            this.parameter_dp.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.parameter_dp.Location = new System.Drawing.Point(20, 330);
            this.parameter_dp.Name = "parameter_dp";
            this.parameter_dp.Size = new System.Drawing.Size(121, 20);
            this.parameter_dp.TabIndex = 6;
            this.parameter_dp.Text = "parameter_dp";
            // 
            // parameter_minDist
            // 
            this.parameter_minDist.AutoSize = true;
            this.parameter_minDist.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.parameter_minDist.Location = new System.Drawing.Point(3, 397);
            this.parameter_minDist.Name = "parameter_minDist";
            this.parameter_minDist.Size = new System.Drawing.Size(163, 20);
            this.parameter_minDist.TabIndex = 8;
            this.parameter_minDist.Text = "parameter_minDist";
            // 
            // minDist_trackbar
            // 
            this.minDist_trackbar.Location = new System.Drawing.Point(172, 397);
            this.minDist_trackbar.Maximum = 200;
            this.minDist_trackbar.Minimum = 1;
            this.minDist_trackbar.Name = "minDist_trackbar";
            this.minDist_trackbar.Size = new System.Drawing.Size(490, 45);
            this.minDist_trackbar.TabIndex = 7;
            this.minDist_trackbar.Value = 1;
            this.minDist_trackbar.Scroll += new System.EventHandler(this.minDist_trackbar_Scroll);
            // 
            // parameter_1
            // 
            this.parameter_1.AutoSize = true;
            this.parameter_1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.parameter_1.Location = new System.Drawing.Point(20, 458);
            this.parameter_1.Name = "parameter_1";
            this.parameter_1.Size = new System.Drawing.Size(111, 20);
            this.parameter_1.TabIndex = 10;
            this.parameter_1.Text = "parameter_1";
            // 
            // P1_trackbar
            // 
            this.P1_trackbar.Location = new System.Drawing.Point(172, 458);
            this.P1_trackbar.Maximum = 200;
            this.P1_trackbar.Minimum = 1;
            this.P1_trackbar.Name = "P1_trackbar";
            this.P1_trackbar.Size = new System.Drawing.Size(490, 45);
            this.P1_trackbar.TabIndex = 9;
            this.P1_trackbar.Value = 1;
            this.P1_trackbar.Scroll += new System.EventHandler(this.P1_trackbar_Scroll);
            // 
            // parameter_2
            // 
            this.parameter_2.AutoSize = true;
            this.parameter_2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.parameter_2.Location = new System.Drawing.Point(20, 509);
            this.parameter_2.Name = "parameter_2";
            this.parameter_2.Size = new System.Drawing.Size(111, 20);
            this.parameter_2.TabIndex = 12;
            this.parameter_2.Text = "parameter_2";
            // 
            // P2_trackbar
            // 
            this.P2_trackbar.Location = new System.Drawing.Point(172, 509);
            this.P2_trackbar.Maximum = 200;
            this.P2_trackbar.Minimum = 1;
            this.P2_trackbar.Name = "P2_trackbar";
            this.P2_trackbar.Size = new System.Drawing.Size(490, 45);
            this.P2_trackbar.TabIndex = 11;
            this.P2_trackbar.Value = 1;
            this.P2_trackbar.Scroll += new System.EventHandler(this.P2_trackbar_Scroll);
            // 
            // parameter_minRadius
            // 
            this.parameter_minRadius.AutoSize = true;
            this.parameter_minRadius.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.parameter_minRadius.Location = new System.Drawing.Point(12, 569);
            this.parameter_minRadius.Name = "parameter_minRadius";
            this.parameter_minRadius.Size = new System.Drawing.Size(150, 16);
            this.parameter_minRadius.TabIndex = 14;
            this.parameter_minRadius.Text = "parameter_minRadius";
            // 
            // minRadius_trackbar
            // 
            this.minRadius_trackbar.Location = new System.Drawing.Point(172, 569);
            this.minRadius_trackbar.Maximum = 200;
            this.minRadius_trackbar.Minimum = 1;
            this.minRadius_trackbar.Name = "minRadius_trackbar";
            this.minRadius_trackbar.Size = new System.Drawing.Size(490, 45);
            this.minRadius_trackbar.TabIndex = 13;
            this.minRadius_trackbar.Value = 1;
            this.minRadius_trackbar.Scroll += new System.EventHandler(this.minRadius_trackbar_Scroll);
            // 
            // parameter_maxRadius
            // 
            this.parameter_maxRadius.AutoSize = true;
            this.parameter_maxRadius.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.parameter_maxRadius.Location = new System.Drawing.Point(8, 631);
            this.parameter_maxRadius.Name = "parameter_maxRadius";
            this.parameter_maxRadius.Size = new System.Drawing.Size(154, 16);
            this.parameter_maxRadius.TabIndex = 16;
            this.parameter_maxRadius.Text = "parameter_maxRadius";
            // 
            // maxRadius_trackbar
            // 
            this.maxRadius_trackbar.Location = new System.Drawing.Point(172, 631);
            this.maxRadius_trackbar.Maximum = 200;
            this.maxRadius_trackbar.Minimum = 1;
            this.maxRadius_trackbar.Name = "maxRadius_trackbar";
            this.maxRadius_trackbar.Size = new System.Drawing.Size(490, 45);
            this.maxRadius_trackbar.TabIndex = 15;
            this.maxRadius_trackbar.Value = 1;
            this.maxRadius_trackbar.Scroll += new System.EventHandler(this.maxRadius_trackbar_Scroll);
            // 
            // Circle_detection_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 716);
            this.Controls.Add(this.parameter_maxRadius);
            this.Controls.Add(this.maxRadius_trackbar);
            this.Controls.Add(this.parameter_minRadius);
            this.Controls.Add(this.minRadius_trackbar);
            this.Controls.Add(this.parameter_2);
            this.Controls.Add(this.P2_trackbar);
            this.Controls.Add(this.parameter_1);
            this.Controls.Add(this.P1_trackbar);
            this.Controls.Add(this.parameter_minDist);
            this.Controls.Add(this.minDist_trackbar);
            this.Controls.Add(this.parameter_dp);
            this.Controls.Add(this.dp_trackbar);
            this.Controls.Add(this.Result_value_label);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.detection_circle);
            this.Controls.Add(this.Circle_picture);
            this.Name = "Circle_detection_test";
            this.Text = "Circle_detection_test";
            ((System.ComponentModel.ISupportInitialize)(this.Circle_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDist_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadius_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadius_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Circle_picture;
        private System.Windows.Forms.Button detection_circle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label Result_value_label;
        private System.Windows.Forms.TrackBar dp_trackbar;
        private System.Windows.Forms.Label parameter_dp;
        private System.Windows.Forms.Label parameter_minDist;
        private System.Windows.Forms.TrackBar minDist_trackbar;
        private System.Windows.Forms.Label parameter_1;
        private System.Windows.Forms.TrackBar P1_trackbar;
        private System.Windows.Forms.Label parameter_2;
        private System.Windows.Forms.TrackBar P2_trackbar;
        private System.Windows.Forms.Label parameter_minRadius;
        private System.Windows.Forms.TrackBar minRadius_trackbar;
        private System.Windows.Forms.Label parameter_maxRadius;
        private System.Windows.Forms.TrackBar maxRadius_trackbar;
    }
}