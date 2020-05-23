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
using WebAPI.ViewModels.Conteudo;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConteudoController : CrudControllerBase<Conteudo, ConteudoViewModelCadastro, ConteudoViewModel>
    {
        private readonly IRepositoryBase<Conteudo> _conteudoRepository;
        private readonly IMapper _mapper;

        public ConteudoController(IRepositoryBase<Conteudo> conteudoRepository, IMapper mapper) : base(conteudoRepository, mapper)
        {
            _conteudoRepository = conteudoRepository;
            _mapper = mapper;
        }
    }
}