using HelpmeHunter.Modelo.BD;
using HelpmeHunter.Modelo.Repositorios;
using Microsoft.Practices.Unity;

namespace HelpmeHunter.Modelo
{
    public class UnityConfigModelo
    {
        public static void RegistrarModelo(IUnityContainer container)
        {
            container.RegisterType<HelpmeHunterEntities>(new PerRequestLifetimeManager());

            container.RegisterType<RepositorioPais>();
            container.RegisterType<RepositorioSector>();
            container.RegisterType<RepositorioPuesto>();
        }
    }
}
