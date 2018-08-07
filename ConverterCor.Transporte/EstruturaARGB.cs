using System.ComponentModel;

namespace ConverterCor.Transporte
{
    public class EstruturaARGB : INotifyPropertyChanged
    {
        private byte a;
        private byte r;
        private byte g;
        private byte b;

        public event PropertyChangedEventHandler PropertyChanged;

        public byte A
        {
            get { return a; }
            set { a = value; OnPropertyChanged("A"); }
        }
        public byte R
        {
            get { return r; }
            set { r = value; OnPropertyChanged("R"); }
        }
        public byte G
        {
            get { return g; }
            set { g = value; OnPropertyChanged("G"); }
        }
        public byte B
        {
            get { return b; }
            set { b = value; OnPropertyChanged("B"); }
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
