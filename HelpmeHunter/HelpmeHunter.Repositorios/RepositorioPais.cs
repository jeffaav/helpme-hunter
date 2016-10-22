using HelpmeHunter.Modelo;

namespace HelpmeHunter.Repositorios
{
    public class RepositorioPais : RepositorioGenerico<Pais>
    {
        public RepositorioPais(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
