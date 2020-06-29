using CodenationRestaurante.Dominio.Modelo;
using System.Collections.Generic;

namespace CodenationRestaurante.Dominio.Repositorio
{
    public interface IPratosIngredientesRepositorio : IRepositorioBase<PratosIngredientes>
    {
        List<PratosIngredientes> SelecionarCompleto();
    }
}
