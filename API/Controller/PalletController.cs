using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalletController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PalletController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pallets = await _unitOfWork.PalletRepository.GetAll();

            return Ok(pallets);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var pallets = await _unitOfWork.PalletRepository.GetById(id);

            return Ok(pallets);
        }


    }
}
