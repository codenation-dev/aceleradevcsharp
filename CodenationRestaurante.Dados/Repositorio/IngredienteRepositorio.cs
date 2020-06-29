using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class IngredienteRepositorio : RepositorioBase<Ingrediente>, IIngredienteRepositorio
    {
        public IngredienteRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
