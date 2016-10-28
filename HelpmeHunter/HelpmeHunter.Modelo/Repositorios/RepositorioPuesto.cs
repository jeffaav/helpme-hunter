using HelpmeHunter.Modelo.BD;

namespace HelpmeHunter.Modelo.Repositorios
{
    public class RepositorioPuesto : RepositorioGenerico<Puesto>
    {
        public RepositorioPuesto(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
