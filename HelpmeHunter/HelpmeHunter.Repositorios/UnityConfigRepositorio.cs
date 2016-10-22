using Microsoft.Practices.Unity;

namespace HelpmeHunter.Repositorios
{
    public class UnityConfigRepositorio
    {
        public static void RegistrarRepositorios(IUnityContainer container)
        {
            container.RegisterType<RepositorioPais>();
            container.RegisterType<RepositorioSector>();
            container.RegisterType<RepositorioPuesto>();
        }
    }
}
