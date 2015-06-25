using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Imaging.Filters;



namespace testcams
{
    class OpencvEngine
    {
        private string TEMP_FILE_PATH = "C://Users/Public/Documents/3Dcreator/TempResult/"; // temporary folder
        private string SAVE_FILE_PATH = "C://Users/Public/Documents/3Dcreator/3DObjects/";// save .stl file folder
        Image[] tempImages;
        Image[] filteredImages;
        Image imgSTL;
        public void CreateSTLFormat()
        {
            try
            {
                if (GetImageToWork("tmpImg", ".jpeg"))// getting image from file
                { 
                    ImageToGrayScale();    // converter to Grayscale 
                    ThresholdAction(); // converting to threshold
                    ObjectPanoramaToSTL(); // object panorama to .stl file 
                    SaveRenderingImageToFile();// saving stl object to file
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("I think that the Pad moves?\nPlease try agayn without moving a Pad.");
            }
        }      
        // ///////////////////////////////////ImageToGrayScale
        private void ImageToGrayScale()// create grayscale filter (BT709)
        {
            filteredImages = new Image[5];
            for (int i = 0; i < tempImages.Length; i++)
            {
                Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                filteredImages[i] = filter.Apply((Bitmap)tempImages[i]);// apply the filter                
            }
            SetImageToTempFolder("GreyScale", filteredImages);
        }
        // ///////////////////////////// ThresholdAction
        private void ThresholdAction()
        {
            tempImages = new Image[5];
            // create filter
            Threshold filter = new Threshold(100);
            for (int i = 0; i < tempImages.Length;i++) {
                filter.ApplyInPlace((Bitmap)filteredImages[i]);
                tempImages[i] = filteredImages[i];
            }
                // apply the filter

            SetImageToTempFolder("ThresholdAction", tempImages);
        }
        // ///////////////////////////// ColorFilteringAction
        private void ColorFilteringAction()
        {/*
            filteredImages = new Image[5];
            // create filter
            ColorFiltering filter = new ColorFiltering();
            // set color ranges to keep
            filter.Red = new IntRange(0, 246);
            filter.Green = new IntRange(3, 238);
            filter.Blue = new IntRange(96, 238);            
           
            for (int i = 0; i < tempImages.Length; i++)
            {
                filteredImages[i] = filter.Apply((Bitmap)tempImages[i]);// apply the filter                
            }
            SetImageToTempFolder("ColorFiltering");*/
        }
       
        // //////////////////////////////ObjectPanoramaToSTL
        private void ObjectPanoramaToSTL()
        {
            // create instance of blob counter
            AForge.Imaging.BlobCounter blobCounter = new AForge.Imaging.BlobCounter();            
            // process input image
            blobCounter.ProcessImage((Bitmap)tempImages[3]);
            // get information about detected objects
            AForge.Imaging.Blob[] blobs = blobCounter.GetObjectsInformation();

            // apply the filter
            // filter.ApplyInPlace((Bitmap)filteredImages[3]);
            imgSTL = filteredImages[3];
        }
        ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////
        // ////////////////////////////  SaveRenderingImageToFile
        private void SaveRenderingImageToFile()
        {
            try
            {
                if (!System.IO.Directory.Exists(SAVE_FILE_PATH))
                {
                    System.IO.Directory.CreateDirectory(SAVE_FILE_PATH);
                }
                ////
                imgSTL.Save(SAVE_FILE_PATH + "new_stl.jpeg", ImageFormat.Jpeg);
            }
            catch (Exception ex) { MessageBox.Show("Convertation to STL is Loss try Again"); }
        }        
        /////////////////////////////////     GetImageToWork
        private bool GetImageToWork(string imageName, string imageType)
        {
            bool _actionResult = false;
            tempImages = new Image[5];
            try
            {
                for (int i = 0; i < this.tempImages.Length; i++)
                {
                    tempImages[i] = Image.FromFile(this.TEMP_FILE_PATH + imageName + i + imageType);
                }
                _actionResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  exception get img to work");
            }
            return _actionResult;
        }
        // ///////////////////////////////  SetImageToTempFolder
        private bool SetImageToTempFolder(string filterName, Image[] images)
        {
            bool _actionResult = false;
            try
            {
                if (!System.IO.Directory.Exists(this.TEMP_FILE_PATH))
                {
                    System.IO.Directory.CreateDirectory(this.TEMP_FILE_PATH);
                }
                for (int i = 0; i < images.Length; i++)
                {
                    var filename = Path.ChangeExtension(filterName + i, "bmp");
                    images[i].Save(Path.Combine(this.TEMP_FILE_PATH, filename), ImageFormat.Bmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image is not Saved");
            }
            return _actionResult;
        }
    }
}
/*
 *  // MergeFullImages();      // merging all images to 1      
                    // ColorFilteringAction();      // Gray Scale To RGB bitmap
        //////////////////////////////////MergeFullImages
        private void MergeFullImages()
        {
            // that we know at max wegth about object on Pad
            // create filter
            Merge filter = new Merge((Bitmap)tempImages[0]);
            // apply the filter
            Bitmap resultImage = filter.Apply((Bitmap)tempImages[2]);
            // temp 
            Bitmap temResultImage = resultImage;
            // 3
            filter = new Merge(temResultImage);
            resultImage = filter.Apply((Bitmap)tempImages[1]);
            temResultImage = resultImage;
            //  4
            filter = new Merge(temResultImage);
            resultImage = filter.Apply((Bitmap)tempImages[3]);
            temResultImage = resultImage;
            //  5
            filter = new Merge(temResultImage);
            resultImage = filter.Apply((Bitmap)tempImages[4]);
            // out image 
            filteredImages[0] = resultImage;
            SetImageToTempFolder("Merge");
        }*/