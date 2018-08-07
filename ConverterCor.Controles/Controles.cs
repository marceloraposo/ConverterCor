using System.Windows.Media;

namespace ConverterCor.Controles
{
    public class Controles
    {
        /// <summary>
        /// Converter a cor ARGB em RGB
        /// </summary>
        /// <param name="colorArgb">Brush com as caracteristicas do campo</param>
        /// <returns></returns>
        private static Brush GetColorRGB(Brush colorArgb)
        {
            Color color = ConverterRGB(((Color)colorArgb.GetValue(SolidColorBrush.ColorProperty)));

            colorArgb.SetValue(SolidColorBrush.ColorProperty, color);

            return colorArgb;
        }

        /// <summary>
        /// Converter a cor recebida para RGB
        /// </summary>
        /// <param name="corARGB">Cor ARGB</param>
        /// <returns></returns>
        public static Color ConverterRGB(Color corARGB)
        {
            return Color.FromRgb(
                            (byte)((corARGB.R) * (corARGB.A / 255.0) + 255 - corARGB.A),
                            (byte)((corARGB.G) * (corARGB.A / 255.0) + 255 - corARGB.A),
                            (byte)((corARGB.B) * (corARGB.A / 255.0) + 255 - corARGB.A));

        }
    }
}
