using InoviceAPI.Services;
using InvoiceAPI.Models.Dtos;
using InvoiceAPI.Models.Entities;
using InvoiceAPI.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private UintOfWork _unitOfWork;

        public UnitController(UintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public    IEnumerable<UnitDtoUpdate> GetAllAsync()
        {

            return   _unitOfWork.Unit.GetAllAsync();
        }

        [HttpGet("{id}")]
        public    ActionResult<UnitDtoUpdate> GetByIdAsync(int id)
        {
            var invoice =   _unitOfWork.Unit.GetByIdAsync(id);
          

                return Ok(invoice);
            

            return NotFound();

        }

        [HttpPost]
        public    IActionResult PostInvoice([FromForm] UnitDtoCreate invoice)
        {
              _unitOfWork.Unit.InsertAsync(invoice);

            return Ok(invoice);


        }

        [HttpPut]
        public    IActionResult UpdateAsync([FromForm] UnitDtoUpdate invoice)
        {
            if (ModelState.IsValid)
            {
                  _unitOfWork.Unit.UpdateAsync(invoice);

                return Ok(invoice);
            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public    IActionResult  DeleteAsync(int id)
        {
            _unitOfWork.Unit.Delete(id);
            return NotFound();
        }

    }
}
