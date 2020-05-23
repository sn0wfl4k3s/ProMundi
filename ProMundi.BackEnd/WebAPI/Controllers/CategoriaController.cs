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
using WebAPI.ViewModels.Categoria;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : CrudControllerBase<Categoria, CategoriaViewModelCadastro, CategoriaViewModel>
    {
        private readonly IRepositoryBase<Categoria> _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaController(IRepositoryBase<Categoria> categoriaRepository, IMapper mapper) : base(categoriaRepository, mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }
    }
}