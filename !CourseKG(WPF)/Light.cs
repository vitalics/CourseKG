using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _CourseKG_WPF_
{
    class Light
    {
        #region Public Fields
        public Color FirstLineColor { get; private set; }
        /// <summary>
        /// Coefficient which encounters material, lies in range 0..1
        /// </summary>
        public int FirstLineDiffuseCoeff { get; private set; }
        /// <summary>
        /// Coefficient which encounters material, lies in range 0..1
        /// </summary>
        public int SecondLineDiffuseCoeff { get; private set; }
        public Color SecondLineColor { get; private set; }
        int SunBrightness { get; private set; }
        #endregion

        public Light(Color firstLineColor, Color secondLineColor, int firstLineDiffuseCoeff, int secondLineDiffuseCoeff, int sunBrightness)
        {
            FirstLineColor = firstLineColor;
            SecondLineColor = secondLineColor;
            FirstLineDiffuseCoeff = firstLineDiffuseCoeff;
            SecondLineDiffuseCoeff = secondLineDiffuseCoeff;
            SunBrightness = sunBrightness;
        }

        void EnlightRectangleFirstLine(Rectangle rect)
        {
            Color color = new Color();
            color.R = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.R);
            color.G = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.G);
            color.B = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.B);
            rect.Fill = new SolidColorBrush(color);
        }

        void EnlightRectangleSecondLine(Rectangle rect)
        {
            Color color = new Color();
            color.R = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.R);
            color.G = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.G);
            color.B = (byte)(SunBrightness * FirstLineDiffuseCoeff * FirstLineColor.B);
            rect.Fill = new SolidColorBrush(color);
        }
    }
}
