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
using System.IO;

namespace testcams
{
    public partial class Form2 : Form
    {
        private string SAVE_FILE_PATH = "C://Users/Public/Documents/3Dcreator/3DObjects/";
        private string pathToTempFolder = "C://Users/Public/Documents/3Dcreator/TempResult/";
        // /////////////////////////////////////////////////////////
        public Form2() { InitializeComponent(); }
        // /////////////////////////////////////////////////////////
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = this.SAVE_FILE_PATH + "new_stl.jpeg";// test !!!             
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.IO.Directory.Exists(pathToTempFolder))
            {
                Directory.Delete(pathToTempFolder, true);// deleting temporary folder
            }
        }
    }
}
