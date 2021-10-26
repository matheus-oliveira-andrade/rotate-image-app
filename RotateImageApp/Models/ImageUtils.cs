using System.Drawing;
using System.Drawing.Imaging;

namespace RotateImageApp.Models
{
    public class ImageUtils
    {
        public static void Save(string pathOutput, Image image)
        {
            image.Save(pathOutput, ImageFormat.Png);
        }

        public static string OnlyImageName(string imageName)
        {
            string[] nameParts = imageName.Split(".");            

            if (nameParts.Length > 1)
            {
                nameParts[nameParts.Length - 1] = string.Empty;

                return string.Join(".", nameParts);
            }

            return imageName;
        }
    }    
}
