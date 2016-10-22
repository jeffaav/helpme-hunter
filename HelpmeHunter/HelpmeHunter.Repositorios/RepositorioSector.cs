using HelpmeHunter.Modelo;

namespace HelpmeHunter.Repositorios
{
    public class RepositorioSector : RepositorioGenerico<Sector>
    {
        public RepositorioSector(HelpmeHunterEntities context) : base(context)
        {
        }
    }
}
