using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
namespace testcams
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice[] videoSource;
        private DateTime time;
        private string _counter;
        private int _tempCount = 0;
        private string pathToTempFolder = "C://Users/Public/Documents/3Dcreator/TempResult/";
        private string pathToSaveJpeg = "C://Users/Public/Documents/3Dcreator/";
        /////////////////////////////////////////////////////////////////////////
        public Form1() { InitializeComponent(); }
        /////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice[5];
            int i = 0;
            foreach (FilterInfo devices in videoDevices)
            {
                //
                if (devices.Name == "Webcam C170")
                {
                    videoSource[i++] = new VideoCaptureDevice(devices.MonikerString);
                }
            }
            /////////////////////////////////////////////////////////////////////////
            for (int y = 0; y <= 4; y++)
            {
                var vp = (VideoSourcePlayer)this.Controls["videoSourcePlayer" + (y + 1)];
                vp.VideoSource = videoSource[y];
                vp.Start();
            }
        }
        ////
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                var vp = (VideoSourcePlayer)this.Controls["videoSourcePlayer" + i];
                vp.Stop();
            }
            bigVideo.Stop();           
        }
        ////
        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {
            bigVideo.VideoSource = videoSource[0];
            bigVideo.Start();
        }
        ////
        private void videoSourcePlayer2_Click(object sender, EventArgs e)
        {
            bigVideo.VideoSource = videoSource[1];
            bigVideo.Start();
        }
        ////
        private void videoSourcePlayer3_Click_1(object sender, EventArgs e)
        {
            bigVideo.VideoSource = videoSource[2];
            bigVideo.Start();
        }
        ////
        private void videoSourcePlayer4_Click_1(object sender, EventArgs e)
        {
            bigVideo.VideoSource = videoSource[3];
            bigVideo.Start();
        }
        ////
        private void videoSourcePlayer5_Click_1(object sender, EventArgs e)
        {
            bigVideo.VideoSource = videoSource[4];
            bigVideo.Start();
        }
        ////        
        private void bigVideo_Click(object sender, EventArgs e)
        {
            time = System.DateTime.Now;
            _counter = " " + time.Day + time.Hour + " " + time.Minute + time.Millisecond;
            var vp = (VideoSourcePlayer)this.Controls["bigVideo"];
            vp.NewFrame += vp_NewFrame;
        }
        ////
        void vp_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                if (!System.IO.Directory.Exists(pathToSaveJpeg))
                {
                    System.IO.Directory.CreateDirectory(pathToSaveJpeg);
                }
                var filename = Path.ChangeExtension("New Image" + _counter, "jpeg");
                var capture = (VideoSourcePlayer)sender;
                capture.NewFrame -= vp_NewFrame;
                image.Save(Path.Combine(pathToSaveJpeg, filename), ImageFormat.Jpeg);
                //   image.Dispose();// uncoment if need stay image on bigVideo
                MessageBox.Show("Image Saved");
                _counter = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image is not Saved");
            }
        }
        //// // click action convert from bmp to stl format      
        private void button_capture_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    var vp = (VideoSourcePlayer)this.Controls["videoSourcePlayer" + i];
                    vp.NewFrame += SaveingImage;
                    Thread.Sleep(700);
                }
                _tempCount = 0;
                //// convert from bmp to stl format action
                try
                {
                    OpencvEngine ImageEngine = new OpencvEngine();
                    ImageEngine.CreateSTLFormat();
                }
                catch (Exception ex) { MessageBox.Show("Image To STL action is loss"); }
            }
            catch (Exception ex) { MessageBox.Show("SaveingImage action is loss"); }
        }
        /// // saving images to temporary folder     
        private void SaveingImage(object sender, ref Bitmap image)
        {
            var filename = Path.ChangeExtension("tmpImg" + _tempCount++, "jpeg");
            var capture = (VideoSourcePlayer)sender;
            ////
            try
            {
                System.IO.Directory.CreateDirectory(pathToTempFolder);
                capture.NewFrame -= SaveingImage;
                image.Save(Path.Combine(pathToTempFolder, filename), ImageFormat.Jpeg);
            }
            catch (Exception ex) { MessageBox.Show("SaveingImage action is loss"); }
        }
    }
}
