using HelpmeHunter.Modelo.BD;

namespace HelpmeHunter.Modelo.Repositorios
{
    public class RepositorioPais : RepositorioGenerico<Pais>
    {
        public RepositorioPais(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
