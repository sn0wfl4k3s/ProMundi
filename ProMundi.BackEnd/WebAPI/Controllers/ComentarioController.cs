using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Base;
using Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;
using WebAPI.ViewModels.Comentario;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : CrudControllerBase<Comentario, ComentarioViewModelCadastro, ComentarioViewModel>
    {
        private readonly IRepositoryBase<Comentario> _comentarioRepository;
        private readonly IMapper _mapper;

        public ComentarioController(IRepositoryBase<Comentario> comentarioRepository, IMapper mapper) : base(comentarioRepository, mapper)
        {
            _comentarioRepository = comentarioRepository;
            _mapper = mapper;
        }
    }
}