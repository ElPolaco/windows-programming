using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Zadanie3.ModelWidoku
{
    using Model;
    using System.Windows.Input;

    public class EdycjaTekstu : ObservedObject
    {
         private readonly Tekst model=new Tekst();
        public string Napis
        {
            get => model.Łańcuch;
            set {
                model.Łańcuch = value;
                onPropertyChanged(nameof(Napis));
            }
        }
        private ICommand czyść = null;
        public ICommand Czyść
        {
            get
            {
                if (czyść == null) czyść = new RelayCommand((object p) => {  model.Czyść(); onPropertyChanged(nameof(Napis)); });
                return czyść;
            }
        }

    }
}
