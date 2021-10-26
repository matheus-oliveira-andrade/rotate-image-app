using System.Drawing;
using System.IO;

namespace RotateImageApp.Models
{
    public class ImageService
    {
        public static void GenerateSaveImages(string inputImage, string outputFolder, float[] angles)
        {
            Image imgInput = Image.FromFile(inputImage);

            FileInfo imgInfo = new FileInfo(inputImage);

            foreach (float angle in angles)
            {
                Image imgOutput = ImageRotate.Rotate(imgInput, angle);

                string imgOutputName = $"{Path.GetFileNameWithoutExtension(imgInfo.Name)}_{angle}{imgInfo.Extension}";                

                ImageUtils.Save($"{Path.Combine(outputFolder, imgOutputName)}", imgOutput);
            }
        }

    }
}
