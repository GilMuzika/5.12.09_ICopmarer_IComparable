using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._12._09_ICopmarer_person
{
    static class Statics
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int generateRandomNumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }


        
        public static void drawBorder<T>(this T drawableObject, int borderWidth, Color bordercolor) where T : class
        {
            int width = 0; int height = 0;
            if (drawableObject is Image) { width = (drawableObject as Image).Width; height = (drawableObject as Image).Height; }
            if (drawableObject is Control) { width = (drawableObject as Control).Width; height = (drawableObject as Control).Height; }

            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphicsObj = Graphics.FromImage(bitmap);

            Pen myPen = new Pen(bordercolor, borderWidth);
            graphicsObj.DrawRectangle(myPen, 0, 0, width - 1, height - 1);

            if (drawableObject is Image) drawableObject = bitmap as T;
            else {
                drawableObject.GetType().GetProperty("BackgroundImage")?.SetValue(drawableObject, bitmap);
                drawableObject.GetType().GetProperty("Image")?.SetValue(drawableObject, bitmap);
            }
            graphicsObj.Dispose();
        }
       











        static public string defaultComparerModifier = null;



        






    }
}
