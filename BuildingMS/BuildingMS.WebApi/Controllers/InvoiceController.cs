using BuildingMS.Entity.Dto;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using BuildingMS.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ApiBaseController<IInvoiceService, Invoice, DtoInvoice>
    {
        private readonly IInvoiceService ınvoiceService;

        public InvoiceController(IInvoiceService ınvoiceService) : base(ınvoiceService)
        {
            this.ınvoiceService = ınvoiceService;

        }
    }
}
