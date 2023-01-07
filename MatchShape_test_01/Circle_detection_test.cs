using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MatchShape_test_01
{
    public partial class Circle_detection_test : Form
    {
        public Circle_detection_test()
        {
            InitializeComponent();
        }
        Mat Test_Mat = new Mat();
        Mat Copy_Mat = new Mat();
        Mat second_copy = new Mat();

        private void detection_circle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                Test_Mat = Cv2.ImRead(openFileDialog1.FileName);
                Circle_picture.Image = new Bitmap(openFileDialog1.FileName);
            }
            
        }

        public void DrawCircles()
        {
            Test_Mat.CopyTo(Copy_Mat);
            Copy_Mat.CopyTo(second_copy);
            Cv2.CvtColor(Copy_Mat, Copy_Mat, ColorConversionCodes.BGR2GRAY);
            CircleSegment[] Circles = Cv2.HoughCircles(Copy_Mat, HoughMethods.Gradient, dp_trackbar.Value, minDist_trackbar.Value, P1_trackbar.Value, P2_trackbar.Value, minRadius_trackbar.Value, maxRadius_trackbar.Value);
            Cv2.CvtColor(Copy_Mat, Copy_Mat, ColorConversionCodes.GRAY2BGR);
            for (int i = 0; i < Circles.Length; i++)
            {
                Cv2.Circle(second_copy, (int)Circles[i].Center.X, (int)Circles[i].Center.Y, (int)Circles[i].Radius, new Scalar(0, 128, 128, 255), 1);
            }
            
            Circle_picture.Image = BitmapConverter.ToBitmap(second_copy);
            
        }
        private void circle_detection_parameter_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
        private void minDist_trackbar_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
        private void P1_trackbar_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
        private void P2_trackbar_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
        private void minRadius_trackbar_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
        private void maxRadius_trackbar_Scroll(object sender, EventArgs e)
        {
            DrawCircles();
        }
    }
}
