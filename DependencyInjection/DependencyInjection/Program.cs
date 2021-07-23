using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        public static IContainer Container;

        static void Main(string[] args)
        {
            OrderInfo info = new OrderInfo();

            Console.WriteLine("Bienvenidos al Sistema de Compras de Mascotas SCM");
            Console.WriteLine("Por favor digite su nombre");
            info.Nombre = Console.ReadLine();
            Console.WriteLine($"Hola {info.Nombre}");
            Console.WriteLine("Ingresa tu Número de identificación");
            info.DNI = Console.ReadLine();
            Console.WriteLine("Ingresa tu Número de telefono");
            info.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa la especie de la mascota");
            info.Raza = Console.ReadLine();
            Console.WriteLine("Ingresa la Edad de la mascota seleccionada");
            info.Edad = Console.ReadLine();
            Console.WriteLine("Ingresa el peso de la mascota seleccionada");
            info.Peso = Console.ReadLine();
            Console.WriteLine("Ingresa tu usuario");
            info.User = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo electrónico");
            info.Email = Console.ReadLine();
            Console.WriteLine();


            ContainerBuilder build = new ContainerBuilder();

            build.RegisterType<Notify>().As<INotify>();
            build.RegisterType<Customer>().As<ICustomer>();
            build.RegisterType<Animals>().As<IAnimals>();
            build.RegisterType<PetShop>();

            build.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                                .Where(t => t.Name.EndsWith("BL"))
                                .As(t => t.GetInterfaces().FirstOrDefault(
                                    i => i.Name == "I" + t.Name));

            Container = build.Build();

            DependencyInjection.PetShop petShopBL = Container.Resolve<DependencyInjection.PetShop>();
            petShopBL.ComprarMascota(info);


            Console.WriteLine();
            Console.WriteLine("Gracias por su compra.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
