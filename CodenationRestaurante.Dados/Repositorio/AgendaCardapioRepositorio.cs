using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class AgendaCardapioRepositorio : RepositorioBase<AgendaCardapio>, IAgendaCardapioRepositorio
    {
        public AgendaCardapioRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
