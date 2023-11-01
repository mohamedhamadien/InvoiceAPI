using InoviceAPI.Services;
using InvoiceAPI.DataAccess;
using InvoiceAPI.Models.Dtos;
using InvoiceAPI.Models.Entities;
using InvoiceAPI.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private UintOfWork _unitOfWork;

        public StoreController(UintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<StoreDtoUpdate>> GetAllAsync()
        {

            return   _unitOfWork.Store.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StoreDtoUpdate>> GetByIdAsync(int id)
        {
            var invoice =   _unitOfWork.Store.GetByIdAsync(id);
            if (invoice != null)
            {

                return Ok(invoice);
            }

            return NotFound();

        }

        [HttpGet("{storeid}")]
        public async Task<ActionResult<StoreDtoUpdate>> GetStoreByIdAsync(int id)
        {
            var invoice =   _unitOfWork.Store.GetByIdAsync(id);
            if (invoice != null)
            {

                return Ok(invoice);
            }

            return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> PostInvoice([FromForm] StoreDtoCreate invoice)
        {
            await _unitOfWork.Store.InsertAsync(invoice);

            return Ok(invoice);


        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromForm] StoreDtoUpdate invoice)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Store.UpdateAsync(invoice);

                return Ok(invoice);
            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _unitOfWork.Store.Delete(id);
            return NotFound();
        }

    }
}
