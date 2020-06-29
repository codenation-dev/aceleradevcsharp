using System.Threading.Tasks;
using CodenationRestaurante.Api.ViewModel;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _repo;
        public UsuarioController(IUsuarioRepositorio repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] UsuarioViewModel usuario)
        {
            return await _repo.Incluir(usuario.Nome, usuario.Email, usuario.Senha);
        }

        [HttpPost("Login")]
        public async Task<IdentityUser> Login(LoginViewModel login)
        {
            return await _repo.Login(login.Email, login.Senha);
        }
    }
}
