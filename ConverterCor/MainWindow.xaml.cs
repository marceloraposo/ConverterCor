using ConverterCor.Transporte;
using System.Windows;
using System.Windows.Media;

namespace ConverterCor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region atributos
        private EstruturaCor estruturaCor;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            this.EstruturaCor = new EstruturaCor();
            this.DataContext = this;
        }

        #region campos
        public EstruturaCor EstruturaCor
        {
            get { return estruturaCor; }
            set { estruturaCor = value; }
        }

        #endregion

        #region Metodos

        private void colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Color color, colorResult;
            if (colorPicker.SelectedColor.HasValue)
            {
                color = colorPicker.SelectedColor.Value;
                colorResult = Controles.Controles.ConverterRGB(color);
                this.EstruturaCor.EstruturaARGB.R = color.R;
                this.EstruturaCor.EstruturaARGB.G = color.G;
                this.EstruturaCor.EstruturaARGB.B = color.B;
                this.EstruturaCor.EstruturaARGB.A = color.A;

                this.EstruturaCor.EstruturaRGB.R = colorResult.R;
                this.EstruturaCor.EstruturaRGB.G = colorResult.G;
                this.EstruturaCor.EstruturaRGB.B = colorResult.B;
                this.EstruturaCor.Codigo = colorResult.ToString();
            }
        }

        private void setCorRGB()
        {
            Color color = Color.FromRgb(this.EstruturaCor.EstruturaRGB.R, this.EstruturaCor.EstruturaRGB.G, this.EstruturaCor.EstruturaRGB.B);
            colorPicker.SelectedColor = color;
        }

        private void setCorARGB()
        {
            Color color = Color.FromArgb(this.EstruturaCor.EstruturaARGB.A, this.EstruturaCor.EstruturaARGB.R, this.EstruturaCor.EstruturaARGB.G, this.EstruturaCor.EstruturaARGB.B);
            colorPicker.SelectedColor = color;
        }

        private void TextBoxCodigo_LostFocus(object sender, RoutedEventArgs e)
        {
            setCorCodigo();
        }

        private void setCorCodigo()
        {
            Color color = (Color)ColorConverter.ConvertFromString(this.EstruturaCor.Codigo);
            colorPicker.SelectedColor = color;
        }

        private void TextBoxRGB_LostFocus(object sender, RoutedEventArgs e)
        {
            setCorRGB();
        }

        private void TextBoxARGB_LostFocus(object sender, RoutedEventArgs e)
        {
            setCorARGB();
        }
        #endregion
    }
}
