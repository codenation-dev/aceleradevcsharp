using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class TipoPratoRepositorio : RepositorioBase<TipoPrato>, ITipoPratoRepositorio
    {
        public TipoPratoRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
