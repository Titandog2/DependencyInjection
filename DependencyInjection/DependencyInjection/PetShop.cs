using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class PetShop
    {
        public PetShop(IAnimals animal, ICustomerBL customer, INotificationBL notification)
        {
            Animal = animal;
            Customer = customer;
            Notification = notification;
        }

        readonly IAnimals Animal;
        readonly ICustomerBL Customer;
        readonly INotificationBL Notification;

        public void ComprarMascota(OrderInfo orderInfo)
        {
            Customer.ImprimirDatosDelCliente(orderInfo.Nombre, orderInfo.DNI, orderInfo.Telefono);
            Animal.DatosDelAnimal(orderInfo.Raza, orderInfo.Edad, orderInfo.Peso);
            Notification.EnviarNotificacion(orderInfo.User, orderInfo.Email);
        }
    }
}
