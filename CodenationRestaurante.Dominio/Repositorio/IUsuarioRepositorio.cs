using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CodenationRestaurante.Dominio.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<bool> Incluir(string nome, string email, string senha);
        Task<IdentityUser> Login(string email, string senha);
    }
}
