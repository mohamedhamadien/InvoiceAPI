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
    public class InvoiceController : ControllerBase
    {
        private UintOfWork _unitOfWork;

        public InvoiceController(UintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<InvoiceDtoUpdate>> GetAllAsync()
        {

            return   _unitOfWork.IInovcie.GetAllAsync();
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDtoUpdate>> GetByIdAsync(int id)
        {
            var invoice =   _unitOfWork.IInovcie.GetByIdAsync(id);
            if (invoice != null) { 
                
                return Ok(invoice);
            }

            return NotFound();
           
        }
       
        [HttpPost]
        public async Task<IActionResult> PostInvoice([FromForm] InvoiceDtoCreate invoice)
        {
           await _unitOfWork.IInovcie.InsertAsync(invoice);

            return Ok(invoice);


        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromForm] InvoiceDtoUpdate invoice)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.IInovcie.UpdateAsync(invoice);
             
                return Ok(invoice);
            }
            return NotFound();

        }
      
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            _unitOfWork.IInovcie.Delete(id);
            return NotFound();
        }
        

    }
}
