using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Animals : IAnimals
    {
        public void DatosDelAnimal(string Raza, string Edad, string Peso)
        {
           Console.WriteLine(string.Format("Datos del Animal: {0} \n Edad: {1} \n Peso: {2}", Raza, Edad, Peso));
        }
    }

    public interface IAnimals
    {
        void DatosDelAnimal(string Raza, string Edad, string Peso);
    }
}
