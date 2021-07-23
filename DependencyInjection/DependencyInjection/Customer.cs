using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Customer : ICustomer
    {
        public void DatosDelCliente(string Nombre, string DNI, string Telefono)
        {
             Console.WriteLine(string.Format("Datos del cliente: {0} \n DNI: {1} \n Telefono: {2}", Nombre, DNI, Telefono));
        }
    }
    public interface ICustomer
    {
        void DatosDelCliente(string Nombre, string DNI, string Telefono);
    }
}
