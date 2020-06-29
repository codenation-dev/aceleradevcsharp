using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class CardapioRepositorio : RepositorioBase<Cardapio>, ICardapioRepositorio
    {
        public CardapioRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
