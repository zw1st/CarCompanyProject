using Unity.Lifetime;
using Unity;
using PolinaPolechkaProject.Entities;
using PolinaPolechkaProject.Interfaces;
using PolinaPolechkaProject.Interfaces.Implementations;
using System.Numerics;

namespace PolinaPolechkaProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormMain>());
        }
        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            

            container.RegisterType<IOperations<Owner>, OwnerImplementation>(new TransientLifetimeManager());
            container.RegisterType<IOperations<Factory>, FactoryImplementation>(new TransientLifetimeManager());
            container.RegisterType<IOperations<Car>, CarImplementation>(new TransientLifetimeManager());
            container.RegisterType<IOperations<CarShop>, CarShopImplementation>(new TransientLifetimeManager());
            container.RegisterType<IOperations<Brand>, BrandImplementation>();

            container.RegisterType<IConnectionString, ConnectionString>();

            return container;
        }
    }
}