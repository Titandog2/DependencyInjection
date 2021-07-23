using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Notify : INotify
    {
        public void EnviarMensaje(string User, string Email)
        {
            Console.WriteLine(string.Format("Se ha enviado un correo al destinario: {0} \n Correo: {1}", User, Email));
        }
    }

    public interface INotify
    {
        void EnviarMensaje(string User, string Email);
    }
}
