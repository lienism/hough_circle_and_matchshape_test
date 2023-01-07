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
    public partial class choose_picture_T : Form
    {
        public choose_picture_T()
        {
            InitializeComponent();
        }
        Mat Left_Mat = new Mat();
        Mat Right_Mat = new Mat();
        private void Left_choice_pictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != "")
            {
                Left_Mat = Cv2.ImRead(openFileDialog1.FileName);
                Left_choice_pictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void Right_choice_pictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "")
            {
                Right_Mat = Cv2.ImRead(openFileDialog2.FileName);
                Right_choice_pictureBox.Image = new Bitmap(openFileDialog2.FileName);
            }
        }

        private void Compare_button_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Point[][] Left_contour;
            OpenCvSharp.Point[][] Right_contour;
            HierarchyIndex[] Left_hi;
            HierarchyIndex[] Right_hi;
            int left_index = 0;
            int Right_index = 0;
            Cv2.CvtColor(Left_Mat, Left_Mat, ColorConversionCodes.BGR2GRAY);
            //Cv2.Threshold(Left_Mat, Left_Mat, 220, 255, ThresholdTypes.Binary);
            Cv2.Threshold(Left_Mat, Left_Mat, 0, 255, ThresholdTypes.Otsu|ThresholdTypes.Binary);
            Cv2.GaussianBlur(Left_Mat, Left_Mat, new OpenCvSharp.Size(7, 7), 2 , 2);
            Cv2.FindContours(Left_Mat, out Left_contour, out Left_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.CvtColor(Left_Mat, Left_Mat, ColorConversionCodes.GRAY2BGR);
            for (int i = 0; i < Left_contour.Length; i++)
            {
                if(Cv2.ContourArea(Left_contour[i]) > 3000)
                { 
                    Cv2.DrawContours(Left_Mat, Left_contour, i, new Scalar(255, 255, 100, 255), 5);
                    left_index = i;
                }
            }
            Left_choice_pictureBox.Image = BitmapConverter.ToBitmap(Left_Mat);

            Cv2.CvtColor(Right_Mat, Right_Mat, ColorConversionCodes.BGR2GRAY);
            //Cv2.Threshold(Right_Mat, Right_Mat, 220, 255, ThresholdTypes.Binary);
            Cv2.Threshold(Right_Mat, Right_Mat, 0, 255, ThresholdTypes.Otsu|ThresholdTypes.Binary);
            Cv2.FindContours(Right_Mat, out Right_contour, out Right_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.CvtColor(Right_Mat, Right_Mat, ColorConversionCodes.GRAY2BGR);
            for (int i = 0; i < Right_contour.Length; i++)
            {
                if (Cv2.ContourArea(Right_contour[i]) > 3000)
                {
                    Cv2.DrawContours(Right_Mat, Right_contour, i, new Scalar(255, 255, 100, 255), 5);
                    Right_index = i;
                }
            }
            Right_choice_pictureBox.Image = BitmapConverter.ToBitmap(Right_Mat);


            Cv2.CvtColor(Left_Mat, Left_Mat, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(Right_Mat, Right_Mat, ColorConversionCodes.BGR2GRAY);


            Result_value_label.Text = "" + Cv2.MatchShapes(Left_Mat, Right_Mat, ShapeMatchModes.I1);
            Contour_process_result_value_label.Text = "" + Cv2.MatchShapes(Left_contour[left_index], Right_contour[Right_index], ShapeMatchModes.I1);
        }

        private void choose_picture_T_Load(object sender, EventArgs e)
        {
            Circle_detection_test CD_form = new Circle_detection_test();
            CD_form.Show();
        }
    }
}
