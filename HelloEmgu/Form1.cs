using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloEmgu
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int Hmin = 0;
        private int Hmax = 255;
        private int Smin = 0;
        private int Smax = 255;
        private int Vmin = 0;
        private int Vmax = 255;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
        }

        private void DisplayWebcam()
        {
            while(_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                int newHeight = (frame.Size.Height * emguPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(emguPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);
                emguPictureBox.Image = frame.ToBitmap();


                //red
                Mat hsvFrame = new Mat();
                CvInvoke.CvtColor(frame, hsvFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                Mat[] hsvChannels = hsvFrame.Split();

                Mat hueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[0], new ScalarArray(Hmin), new ScalarArray(Hmax), hueFilter);
                Invoke(new Action(() => { hFilter.Image = hueFilter.ToBitmap(); }));

                Mat saturationFilter = new Mat();
                CvInvoke.InRange(hsvChannels[1], new ScalarArray(Smin), new ScalarArray(Smax), saturationFilter);
                Invoke(new Action(() => { sFilter.Image = saturationFilter.ToBitmap(); }));

                Mat valueFilter = new Mat();
                CvInvoke.InRange(hsvChannels[2], new ScalarArray(Vmin), new ScalarArray(Vmax), valueFilter);
                Invoke(new Action(() => { vFilter.Image = valueFilter.ToBitmap(); }));

                Mat mergedRed = new Mat();
                CvInvoke.BitwiseAnd(hueFilter, saturationFilter, mergedRed);
                CvInvoke.BitwiseAnd(mergedRed, valueFilter, mergedRed);
                Invoke(new Action(() => { redImage.Image = mergedRed.ToBitmap(); }));
                //red

               //binary 
                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, 150, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                Invoke(new Action(() => { whiteImage.Image = binaryFrame.ToBitmap(); }));
                //binary
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }

        private void hMax_Scroll(object sender, EventArgs e)
        {
            Hmax = hMax.Value;
        }

        private void hMin_Scroll(object sender, EventArgs e)
        {
            Hmin = hMin.Value;
        }

        private void sMax_Scroll(object sender, EventArgs e)
        {
            Smax = sMax.Value;
        }

        private void sMin_Scroll(object sender, EventArgs e)
        {
            Smin = sMin.Value;
        }

        private void vMax_Scroll(object sender, EventArgs e)
        {
            Vmax = vMax.Value;
        }

        private void vMin_Scroll(object sender, EventArgs e)
        {
            Vmin = vMin.Value;
        }
    }
}
