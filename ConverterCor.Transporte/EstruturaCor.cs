using System.ComponentModel;

namespace ConverterCor.Transporte
{
    public class EstruturaCor : INotifyPropertyChanged
    {
        private EstruturaARGB estruturaARGB;
        private EstruturaRGB estruturaRGB;
        private string codigo;

        public event PropertyChangedEventHandler PropertyChanged;

        public EstruturaCor()
        {
            EstruturaARGB = new EstruturaARGB();
            EstruturaRGB = new EstruturaRGB();
        }

        public EstruturaARGB EstruturaARGB
        {
            get { return estruturaARGB; }
            set { estruturaARGB = value; }
        }
        public EstruturaRGB EstruturaRGB
        {
            get { return estruturaRGB; }
            set { estruturaRGB = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; OnPropertyChanged("Codigo"); }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
