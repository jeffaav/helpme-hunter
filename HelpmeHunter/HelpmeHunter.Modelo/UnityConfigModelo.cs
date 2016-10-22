using Microsoft.Practices.Unity;

namespace HelpmeHunter.Modelo
{
    public class UnityConfigModelo
    {
        public static void RegistrarModelo(IUnityContainer container)
        {
            container.RegisterType<HelpmeHunterEntities>(new PerRequestLifetimeManager());
        }
    }
}
