using AutoMapper;
using Domain.Base;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;
using WebAPI.ViewModels.Usuario;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : CrudControllerBase<Usuario, UsuarioViewModelCadastro, UsuarioViewModel>
    {
        private readonly IRepositoryBase<Usuario> _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioController(IRepositoryBase<Usuario> usuarioRepository, IMapper mapper) : base(usuarioRepository, mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
    }
}
    