using Microsoft.AspNetCore.Mvc;
using SectorOrange.API.Services.Interfaces;
using SectorOrange.API.Services.Models;
using System.Threading.Tasks;

namespace SectorOrange.API.Web.Controllers
{
    /// <summary>
    /// Base Rest API Controller that supports main Http Request operations with basic implementation of Rest Service methods
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BaseRestController<TService, TModel, TId> : ControllerBase where TService : IBaseRestService<TModel, TId>
                                                                            where TModel : IBaseEntity<TId>
    {
        private readonly TService _service;

        public BaseRestController(TService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(TId id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public virtual async Task Post(TModel model)
        {
            await _service.AddAsync(model);
        }

        [HttpPut]
        public virtual async Task Put(TModel model)
        {
            await _service.UpdateAsync(model);
        }

        [HttpDelete("{id}")]
        public virtual async Task Delete(TId id)
        {
            await _service.DeleteAsync(id);
        }
    }
}
