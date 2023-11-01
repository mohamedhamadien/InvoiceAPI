using InoviceAPI.Services;
using InvoiceAPI.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private UintOfWork _unitOfWork;

        public ItemController(UintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemDtoUpdate>> GetAllAsync()
        {

            return   _unitOfWork.Item.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDtoUpdate>> GetByIdAsync(int id)
        {
            var item =   _unitOfWork.Item.GetByIdAsync(id);
            if (item != null)
            {

                return Ok(item);
            }

            return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> PostInvoice([FromForm] ItemDtoCreate item)
        {
            await _unitOfWork.Item.InsertAsync(item);

            return Ok(item);


        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromForm] ItemDtoUpdate item)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Item.UpdateAsync(item);

                return Ok(item);
            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _unitOfWork.Item.Delete(id);
            
            return NotFound();
        }

    }
}
