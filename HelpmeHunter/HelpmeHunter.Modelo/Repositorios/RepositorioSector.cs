using HelpmeHunter.Modelo.BD;

namespace HelpmeHunter.Modelo.Repositorios
{
    public class RepositorioSector : RepositorioGenerico<Sector>
    {
        public RepositorioSector(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
