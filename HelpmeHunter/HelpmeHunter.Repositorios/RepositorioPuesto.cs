using HelpmeHunter.Modelo;

namespace HelpmeHunter.Repositorios
{
    public class RepositorioPuesto : RepositorioGenerico<Puesto>
    {
        public RepositorioPuesto(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
