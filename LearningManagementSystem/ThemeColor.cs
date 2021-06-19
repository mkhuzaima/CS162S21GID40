using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    class ThemeColor
    {
        public static Color ChangeColorBrightness(Color color, double CorrectionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //if correctionfactior is negative then the color darkens
            if (CorrectionFactor < 0)
            {
                CorrectionFactor += 1;
                red *= CorrectionFactor;
                green *= CorrectionFactor;
                blue *= CorrectionFactor;
            }
            //if correctionfactior is positive then the color brightens
            else
            {
                red = (255 - red) * CorrectionFactor + red;
                green = (255 - green) * CorrectionFactor + green;
                blue = (255 - blue) * CorrectionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte) green, (byte) blue);
        }
    }
}
