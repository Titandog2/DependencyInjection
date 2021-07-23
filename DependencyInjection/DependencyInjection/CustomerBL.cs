using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class CustomerBL : ICustomerBL
    {
        public CustomerBL(ICustomer customer)
        {
            Customer = customer;
        }
        ICustomer Customer;

        public void ImprimirDatosDelCliente(string Nombre, string DNI, string Telefono)
        {
            Customer.DatosDelCliente(Nombre, DNI, Telefono);
        }
    }

    public interface ICustomerBL
    {
        void ImprimirDatosDelCliente(string Nombre, string DNI, string Telefono);
    }
}
