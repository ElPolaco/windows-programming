using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaMVVM.Model
{
    public static class PlikHelper
    {
        private const string nazwaPliku = "ustawienia.txt";
        public static void Zapisz(this ModelPierwszaAplikacjaMVVM model)
        {
            string łańcuch = model.Wartość.ToString();
            File.WriteAllText(nazwaPliku,łańcuch);
        }
        public static ModelPierwszaAplikacjaMVVM Wczytaj()
        {
            try
            {
                string łańcuch = File.ReadAllText(nazwaPliku);
                double wartość = double.Parse(łańcuch);
                return new ModelPierwszaAplikacjaMVVM() { Wartość = wartość };
            }
            catch (Exception e)
            {
                return new ModelPierwszaAplikacjaMVVM() { Wartość = 0 };
            }
        }
    }
}
