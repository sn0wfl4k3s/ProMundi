using AutoMapper;
using Domain.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Base
{
    public class CrudControllerBase<T, TViewModelCadastro, TViewModel> :
        ControllerBase
        where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;
        private readonly IMapper _mapper;

        public CrudControllerBase(IRepositoryBase<T> repositoryBase, IMapper mapper)
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            var objectToGet = await _repositoryBase.GetAllAsync();
            return Ok(_mapper.Map<List<TViewModel>>(objectToGet));
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public virtual IActionResult GetById(int id)
        {
            var objectToGet = _repositoryBase.GetById(id);

            return Ok(_mapper.Map<TViewModel>(objectToGet));
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] TViewModelCadastro model)
        {
            var objectToCreate = _mapper.Map<TViewModelCadastro, T>(model);

            await _repositoryBase.AddAsync(objectToCreate);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromBody] TViewModelCadastro model, int id)
        {

            dynamic objectToUpdate = _mapper.Map<TViewModelCadastro, T>(model);
            objectToUpdate.Id = id;
            await _repositoryBase.Update(objectToUpdate);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            //if (id == null)
            //    return BadRequest();

            await _repositoryBase.Delete(id);

            return NoContent();
        }
    }
}