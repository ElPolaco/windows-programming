using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaMVVM.ModelWidoku
{
    using Model;
    using System.Windows.Input;

    public class ModelWidokuPierwszaAplikacjaMVMM : INotifyPropertyChanged
    {
        private ModelPierwszaAplikacjaMVVM model = PlikHelper.Wczytaj();  

        public double Wartość
        {
            get { return model.Wartość; }
            set { model.Wartość = value; onPropertyChanged(nameof(Wartość)); model.Zapisz(); }  
        }
        private ICommand resetuj = null;
        public ICommand Resetuj
        {
            get {
                if (resetuj == null) resetuj = new RelayCommand(
                    (object o) => 
                    {
                        model.Resetuj();
                        onPropertyChanged(nameof(Wartość)); 
                    },
                    (object o) =>
                    {
                        return model.Wartość > 0;
                    }
                    );
                return resetuj; 
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void onPropertyChanged(string nazwaWłasności)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(nazwaWłasności)); 
            }
        }
    }
}
