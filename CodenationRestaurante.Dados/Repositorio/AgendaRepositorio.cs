using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class AgendaRepositorio : RepositorioBase<Agenda>, IAgendaRepositorio
    {
        public AgendaRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
