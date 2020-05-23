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
using WebAPI.ViewModels.Tema;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemaController : CrudControllerBase<Tema, TemaViewModelCadastro, TemaViewModel>
    {
        private readonly IRepositoryBase<Tema> _temaRepository;
        private readonly IMapper _mapper;

        public TemaController(IRepositoryBase<Tema> temaRepository, IMapper mapper) : base(temaRepository, mapper)
        {
            _temaRepository = temaRepository;
            _mapper = mapper;
        }
    }
}